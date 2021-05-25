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
{
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
        #region Repas

        public async Task<Met> CreateRepas(Met met)
        {
            _db.BeginTransaction();
            IMetRepository _met = _db.GetRepository<IMetRepository>();
            Met newRepas = await _met.InsertAsync(met);
            _db.Commit();

            return newRepas;
        }

        public async Task<PageResponse<Met>> GetAllRepas(PageRequest pageRequest, Filter filter)
        {
            IMetRepository _met = _db.GetRepository<IMetRepository>();

            var Type = (await _met.GetAllAsync(pageRequest, filter));

            return Type;
        }

        public async Task<Met> GetMetById(int id)
        {
            IMetRepository _met = _db.GetRepository<IMetRepository>();

            return await _met.GetAsync(id);
        }

        public async Task<Met> ModifyMet(Met met)
        {
            _db.BeginTransaction();
            IMetRepository _met = _db.GetRepository<IMetRepository>();
            try
            {
                await _met.UpdateAsync(met);
                _db.Commit();
                return met;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }

        public async Task<bool> RemoveMetsById(int id)
        {
            _db.BeginTransaction();
            IMetRepository _met = _db.GetRepository<IMetRepository>();
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
        #region Repas
        public async Task<Service> CreateMet(Service service)
        {

            _db.BeginTransaction();
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();
            Service newService = await _service.InsertAsync(service);
            _db.Commit();

            return newService;
        }

        public async Task<PageResponse<Service>> GetAllMet(PageRequest pageRequest)
        {
            IServiceRepository _serviceRepo = _db.GetRepository<IServiceRepository>();

            var service = (await _serviceRepo.GetAllAsync(pageRequest));

            return service;
        }

        public async Task<Service> GetServiceById(int id)
        {
            IServiceRepository _service = _db.GetRepository<IServiceRepository>();

            return await _service.GetAsync(id);
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


    }
}
