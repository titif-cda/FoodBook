using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace BLL.Services
{
    class AccountService : IAccountService
    {
        private readonly IConfiguration _configuration;

        public AccountService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<LoginResponse> Login(string login, string password)
        {
            var clientRepository = _unitofwork.GetRepository<IClientRepository>();
            var client = await clientRepository.GetClientByUsernameAndPassword(login, password);

            if (client != null)
            {
                var loginResponse = new LoginResponse()
                {
                    Username = login,
                    AccessToken = GenerateJwtToken(client)
                };

                return loginResponse;
            }
            else
            {
                return null;
            }
        }

}

        private string GenerateJwtToken(Client client, List<string> roles)
        {
            //Add User Infos
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, client.Login),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, client.Login)
            };

            //Add roles
            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, client.Role));
            });

            //Signin Key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Expiration time
            var expires = DateTime.Now.AddSeconds(Convert.ToDouble(_configuration["JwtExpireSec"]));

            //Create JWT Token Object
            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );
            //Serializes a JwtSecurityToken into a JWT in compact Serialization Format.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
