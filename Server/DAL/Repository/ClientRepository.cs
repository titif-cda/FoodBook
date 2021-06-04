using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.UOW;
using Dapper;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class ClientRepository : IClientRepository
    {
        private readonly DbSession _session;
        public ClientRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Client where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            var stmt = @"select * from Client";
            return await _session.Connection.QueryAsync<Client>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Client>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Client 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Client";

            IEnumerable<Client> clientTask = await _session.Connection.QueryAsync<Client>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Client>(pageRequest.Page, pageRequest.PageSize, countTask, clientTask.ToList());
        }

        public async Task<Client> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Client where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Client>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Client> InsertAsync(Client entity)
        {
            string mdpHash;
            string pwd = entity.Password;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                mdpHash = GetHash(sha256Hash, pwd);
            }

            var stmt = @"insert into Client( Nom , Prenom, Tel, Email, Login, Password , Role)  output INSERTED.Id
            values (@Nom, @Prenom, @Tel, @Email, @Login, @Password,@Role)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, new
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Tel = entity.Tel,
                Email = entity.Email,
                Login = entity.Login,
                Password = mdpHash,
                Role = "Client"
            },
                      _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Client entity)
        {
            string mdpHash;
            string pwd = entity.Password;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                mdpHash = GetHash(sha256Hash, pwd);
            }
            var stmt = @"UPDATE Client SET Nom = @Nom, Prenom = @Prenom, Tel = @Tel, Email = @Email, Login = @Login, Password = @Password WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, new
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Tel = entity.Tel,
                Email = entity.Email,
                Login = entity.Login,
                Password = mdpHash,
                Id = entity.Id

            }, _session.Transaction);
            return nbModifiedLines > 0;
        }

        public Task<Client> GetClientByUsernameAndPassword(string login, string password)
        {
            //TODO réécrire la requete avec un nom au lieu du Username
            var stmt = @"select * from Client
                         Where Login = @Login AND Password = @Password";

            return _session.Connection.QueryFirstOrDefaultAsync<Client>(stmt, new { Login = login, Password = password }, _session.Transaction);
        }

       
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
