using BLL.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace UnitTest.Services
{
    class FakeRestaurantService : IRestaurantService
    {
        public List<Ingredient> IngredientsDB = new List<Ingredient>()
        {
             new Ingredient(1,"persil",15),
            new Ingredient(2,"ail",15),
            new Ingredient(3,"gingembre",3)
        }; 
    
    

        public Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            return Task.FromResult(ingredient);
        }

        public Task<Menu> CreateMenu(Menu Menus)
        {
            throw new NotImplementedException();
        }

        public Task<Repas> CreateRepas(Repas Repas)
        {
            throw new NotImplementedException();
        }

        public Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
        {
            List<Ingredient> data = null;
            if (pageRequest.Page * pageRequest.PageSize < IngredientsDB.Count)
            {
                int firstIndex = (pageRequest.Page * pageRequest.PageSize);
                int lastIndex = ((pageRequest.Page * pageRequest.PageSize) + pageRequest.PageSize);
                Math.Clamp(lastIndex, 0, IngredientsDB.Count);

                data = IngredientsDB.GetRange(firstIndex, lastIndex - firstIndex);

            }
           return Task.FromResult(new PageResponse<Ingredient>()
           {
                Page = pageRequest.Page,
                PageSize = pageRequest.PageSize,
                TotalRecords = IngredientsDB.Count,
                Data = data
           });
        }

        public Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<Repas>> GetAllRepas(PageRequest pageRequest, Filter filter)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetIngredientById(int id)
        {
            return Task.FromResult(IngredientsDB.Find(b => b.IdIngr == id));
        }

        public Task<Menu> GetMenuById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Repas> GetRepasById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeRepas> GetTypeRepasById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> ModifyIngredient(Ingredient ingredient)
        {
            if (ingredient.IdIngr == null)
                return null;
            var _Ingredient = IngredientsDB.Find(b => b.IdIngr == ingredient.IdIngr);
            _Ingredient.NomIngr = ingredient.NomIngr;
            _Ingredient.PrixIngr = ingredient.PrixIngr;

            return Task.FromResult(_Ingredient);
        }

        public Task<Menu> ModifyMenu(Menu Menus)
        {
            throw new NotImplementedException();
        }

        public Task<Repas> ModifyRepas(Repas Repas)
        {
            throw new NotImplementedException();
        }

        public Task<TypeRepas> ModifyTypeRepas(TypeRepas tRepas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveIngredientById(int id)
        {
            int i = IngredientsDB.RemoveAll(b => b.IdIngr == id);
            return Task.FromResult( i > 0);
        }

        public Task<bool> RemoveMenuById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRepasById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveTypeRepasById(int id)
        {
            throw new NotImplementedException();
        }
    }
}