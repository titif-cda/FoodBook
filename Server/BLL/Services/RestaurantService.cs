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
    internal class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _db;
        private readonly ILogger<RestaurantService> _logger;

        public RestaurantService(IUnitOfWork unitOfWork, ILogger<RestaurantService> logger)
        {
           // _logger = logger;
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

        public async Task<Repas> CreateRepas(Repas Repas)
        {
            _db.BeginTransaction();
            IRepasRepository _repas = _db.GetRepository<IRepasRepository>();
            Repas newRepas = await _repas.InsertAsync(Repas);
            _db.Commit();

            return newRepas;
        }

        public async Task<PageResponse<Repas>> GetAllRepas(PageRequest pageRequest, Filter filter)
        {
            IRepasRepository _repas = _db.GetRepository<IRepasRepository>();

            var Type = (await _repas.GetAllAsync(pageRequest, filter));

            return Type;
        }

        public async Task<Repas> GetRepasById(int id)
        {
            IRepasRepository _repas = _db.GetRepository<IRepasRepository>();

            return await _repas.GetAsync(id);
        }

        public async Task<Repas> ModifyRepas(Repas Repas)
        {
            _db.BeginTransaction();
            IRepasRepository _repas = _db.GetRepository<IRepasRepository>();
            try
            {
                await _repas.UpdateAsync(Repas);
                _db.Commit();
                return Repas;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }

        public async Task<bool> RemoveRepasById(int id)
        {
            _db.BeginTransaction();
            IRepasRepository _repas = _db.GetRepository<IRepasRepository>();
            try
            {
                var count = await _repas.DeleteAsync(id);
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
        public async Task<Menu> CreateMenu(Menu Menus)
        {

            _db.BeginTransaction();
            IMenuRepository _menu = _db.GetRepository<IMenuRepository>();
            Menu newMenus = await _menu.InsertAsync(Menus);
            _db.Commit();

            return newMenus;
        }

        public async Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest)
        {
            IMenuRepository _menu = _db.GetRepository<IMenuRepository>();

            var Type = (await _menu.GetAllAsync(pageRequest));

            return Type;
        }

        public async Task<Menu> GetMenuById(int id)
        {
            IMenuRepository _menu = _db.GetRepository<IMenuRepository>();

            return await _menu.GetAsync(id);
        }

        public async Task<Menu> ModifyMenu(Menu Menus)
        {
            _db.BeginTransaction();
            IMenuRepository _menu = _db.GetRepository<IMenuRepository>();
            try
            {
                await _menu.UpdateAsync(Menus);
                _db.Commit();
                return Menus;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }

        public async Task<bool> RemoveMenuById(int id)
        {
            _db.BeginTransaction();
            IMenuRepository _menu = _db.GetRepository<IMenuRepository>();
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
