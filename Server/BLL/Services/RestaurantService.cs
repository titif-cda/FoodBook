using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{/// <summary>
/// Service RestaurantService
/// </summary>
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _db;
        private readonly ILogger<RestaurantService> _logger;

        public RestaurantService(IUnitOfWork unitOfWork, ILogger<RestaurantService> logger)
        {
            _logger = logger;
            _db = unitOfWork;
        }


        #region Ingredients
        public async Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredient = _db.GetRepository<IIngredientRepository>();
            Ingredient newIngredient = await _ingredient.InsertAsync(ingredient);
            _db.Commit();

            return newIngredient;
        }
        public async Task<bool> RemoveIngredientById(int id)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();
            try
            {
                var count = await _ingredients.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _logger.LogWarning(e.Message);
                _db.Rollback();
                return false;
            }
        }

        public async Task<Ingredient> ModifyIngredient(Ingredient ingredient)
        {
            _db.BeginTransaction();
            IIngredientRepository _Ingredients = _db.GetRepository<IIngredientRepository>();
            try
            {
                await _Ingredients.UpdateAsync(ingredient);
                _db.Commit();
                return ingredient;
            }
            catch (Exception e)
            {
                _logger.LogWarning(e.Message);
                _db.Rollback();
                return null;
            }
        }

        public async Task<Ingredient> GetIngredientById(int id)
        {
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();

            return await _ingredients.GetAsync(id);
        }


        public async Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
        {
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();

            var ingredients = await _ingredients.GetAllAsync(pageRequest);

            return ingredients;
        }
        #endregion

        #region TypeRepas
        public async Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas)
        {
            _db.BeginTransaction();
            ITypeRepasRepository _trepas = _db.GetRepository<ITypeRepasRepository>();
            TypeRepas newTRepas = await _trepas.InsertAsync(tRepas);
            _db.Commit();

            return newTRepas;
        }

        public async Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest)
        {

            ITypeRepasRepository _tRepass = _db.GetRepository<ITypeRepasRepository>();

            var Type = (await _tRepass.GetAllAsync(pageRequest));

            return Type;
        }

        public async Task<TypeRepas> GetTypeRepasById(int id)
        {
            ITypeRepasRepository _tRepas = _db.GetRepository<ITypeRepasRepository>();

            return await _tRepas.GetAsync(id);
        }

        public async Task<TypeRepas> ModifyTypeRepas(TypeRepas tRepas)
        {
            _db.BeginTransaction();
            ITypeRepasRepository _tRepas = _db.GetRepository<ITypeRepasRepository>();
            try
            {
                await _tRepas.UpdateAsync(tRepas);
                _db.Commit();
                return tRepas;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }

        public async Task<bool> RemoveTypeRepasById(int id)
        {
            _db.BeginTransaction();
            ITypeRepasRepository _tRepass = _db.GetRepository<ITypeRepasRepository>();
            try
            {
                var count = await _tRepass.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }

        #endregion
        #region Met

        public async Task<Met> CreateMet(Met met)
        {
            IMetsRepository _metRepo = _db.GetRepository<IMetsRepository>();
            IMetsIngredientsRepository _metIngredientsRepo = _db.GetRepository<IMetsIngredientsRepository>();
            
            _db.BeginTransaction();
            Met newRepas = await _metRepo.InsertAsync(met);

            for(int i = 0; i < met.ListDesIngredients.Count; i++)
            {
                var metsIngredient = met.ListDesIngredients[i];
                metsIngredient.IdMet = newRepas.Id;
                await _metIngredientsRepo.InsertAsync(metsIngredient);
            };
            _db.Commit();

            return newRepas;
        }
        public async Task<Met> ModifyMet(Met met)
        {
            _db.BeginTransaction();
            IMetsRepository _met = _db.GetRepository<IMetsRepository>();
            IMetsIngredientsRepository _metIngredientsRepo = _db.GetRepository<IMetsIngredientsRepository>();
            try
            {
                //Remove old List Ingredients
                await _metIngredientsRepo.DeleteMetIngredientFromMetIdAsync(met.Id);

                //Update met
                await _met.UpdateAsync(met);

                //Add new List Ingredients
                for (int i = 0; i < met.ListDesIngredients.Count; i++)
                {
                    var metsIngredient = met.ListDesIngredients[i];
                    metsIngredient.IdMet = met.Id;
                    await _metIngredientsRepo.InsertAsync(metsIngredient);
                };
                _db.Commit();
                return met;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        public async Task<PageResponse<Met>> GetAllMet(FilterMetPaged filterMetPaged)
        {
            IMetsRepository _met = _db.GetRepository<IMetsRepository>();

            var Type = (await _met.GetAllAsync(filterMetPaged));

            return Type;
        }

        public async Task<Met> GetMetById(int id)
        {
            IMetsRepository _met = _db.GetRepository<IMetsRepository>();

            return await _met.GetAsync(id);
        }

        

        public async Task<Met> GetIngredientParMetById(int id)
        {
            IMetsRepository _met = _db.GetRepository<IMetsRepository>();

            return await _met.GetIngredientForMetAsync(id);
        }

       

        public async Task<bool> RemoveMetById(int id)
        {
            _db.BeginTransaction();
            IMetsRepository _met = _db.GetRepository<IMetsRepository>();
            try
            {
                var count = await _met.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }

        #endregion
        #region Service
        /// <summary>
        /// Crée un nouveau service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public async Task<Service> CreateService(Service service)
        {

            _db.BeginTransaction();
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            
            var serviceExist = await _service.GetServiceByDateAndService(service.Date.GetValueOrDefault().Date, service.Midi);
            if (serviceExist.Date.GetValueOrDefault().Date == service.Date.GetValueOrDefault().Date && serviceExist.Midi == service.Midi)
            {
                Service newService = await _service.InsertAsync(service);
                return newService;

            }
            else
            {
                return null;
                
            }
            _db.Commit();

            return service;
        }
        
        /// <summary>
        /// Récupère tous les services
        /// </summary>
        /// <param name="pageRequest"></param>
        /// <returns></returns>
        public async Task<PageResponse<Service>> GetAllService(PageRequest pageRequest)
        {
            IServiceRepository _serviceRepo = _db.GetRepository<IServiceRepository>();

            var service = (await _serviceRepo.GetAllAsync(pageRequest));

            return service;
        }
       
        /// <summary>
        /// Recupère un service via son ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Service> GetServiceById(int id)
        {
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            return await _service.GetAsync(id);
        }

        public async Task<Service> GetMetForServiceAsync(int id)
        {
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            return await _service.GetMetForServiceAsync(id);
        }


        public async Task<Service> GetServiceByDateAndService(DateTime date, bool midi)
        {
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            return await _service.GetServiceByDateAndService(date,midi);
        }
       
        
        public async Task<Service> ModifyService(Service service)
        {
            _db.BeginTransaction();
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();
            try
            {
                var ok = await _service.UpdateAsync(service);
                _db.Commit();
                if (ok)
                    return service;
                else return null;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }

        public async Task<Service> ModifyAllService(Service service)
        {
            _db.BeginTransaction();
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            Service newService = await _service.UpdateAllAsync(service);
            _db.Commit();
            return newService;
            
        }
        /// <summary>
        /// Suppression du service par l'identifiant
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns></returns>
        public async Task<bool> RemoveServiceById(int id)
        {
            _db.BeginTransaction();
            IServiceRepository _menu = _db.GetRepository<IServiceRepository>();
            try
            {
                var count = await _menu.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }


        #endregion
        #region MetsIngredients
        /// <summary>
        /// Cree une liste de d'ingredients liés aux plats
        /// </summary>
        /// <param name="ListeIngredients"></param>
        /// <returns></returns>
        public async Task<MetsIngredients> CreateListeIngredients(MetsIngredients ListeIngredients)
        {

            _db.BeginTransaction();
            IMetsIngredientsRepository _metsIngredients = _db.GetRepository<IMetsIngredientsRepository>();
            MetsIngredients newListMetsIngredients = await _metsIngredients.InsertAsync(ListeIngredients);
            _db.Commit();

            return newListMetsIngredients;
        }

        /// <summary>
        /// Récupère la  liste de tous les ingredients liés aux plats
        /// </summary>
        /// <param name="pageRequest"></param>
        /// <returns></returns>
        public async Task<PageResponse<MetsIngredients>> GetAllListeIngredients(PageRequest pageRequest)
        {
            IMetsIngredientsRepository _metsIngredientsRepo = _db.GetRepository<IMetsIngredientsRepository>();

            var metsIngredientsRepo = (await _metsIngredientsRepo.GetAllAsync(pageRequest));

            return metsIngredientsRepo;
        }

        /// <summary>
        /// Récupère la  liste de tous les ingredients liés aux plats
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<MetsIngredients> GetAllListeIngredientsById(int id)
        {
            IMetsIngredientsRepository _metsIngredients = _db.GetRepository<IMetsIngredientsRepository>();

            return await _metsIngredients.GetAsync(id);
        }

        /// <summary>
        /// modifie la  liste de tous les ingredients liés aux plats
        /// </summary>
        /// <param name="ListeIngredients"></param>
        /// <returns></returns>
        public async Task<MetsIngredients> ModifyAllListeIngredients(MetsIngredients ListeIngredients)
        {
            _db.BeginTransaction();
            IMetsIngredientsRepository _metsIngredients = _db.GetRepository<IMetsIngredientsRepository>();
            try
            {
                var ok = await _metsIngredients.UpdateAsync(ListeIngredients);
                _db.Commit();
                if (ok)
                    return ListeIngredients;
                else return null;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        /// <summary>
        /// supprime un  liste de tous les ingredients liés aux plats via un Id
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns></returns>
        public async Task<bool> RemovAllListeIngredientsById(int id)
        {
            _db.BeginTransaction();
            IMetsIngredientsRepository _metsIngredients = _db.GetRepository<IMetsIngredientsRepository>();
            try
            {
                var count = await _metsIngredients.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }

       
        #endregion
    }
}
