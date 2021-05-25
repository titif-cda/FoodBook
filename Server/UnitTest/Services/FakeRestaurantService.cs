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

        public List<Menu> MenuDb = new List<Menu>()
                {
                    new Menu()
                    {
                        DateMenu = DateTime.Now,
                        IdMenu = 1,
                        ListPlats = new List<Repas>()
                        {
                            new Repas
                            {
                                IdRepas = 1,
                                DescRepas = "DescRepas1",
                                IdTypeRepas = 1,
                                LibelleRepas = "LibelleRepas1"
                            },
                            new Repas
                            {
                                IdRepas = 2,
                                DescRepas = "DescRepas2",
                                IdTypeRepas = 2,
                                LibelleRepas = "LibelleRepas2"
                            },
                            new Repas
                            {
                                IdRepas = 3,
                                DescRepas = "DescRepas3",
                                IdTypeRepas = 3,
                                LibelleRepas = "LibelleRepas3"
                            }
                        }
                    },
                    new Menu()
                    {
                        DateMenu = DateTime.Now.AddDays(1),
                        IdMenu = 5,
                        ListPlats = new List<Repas>()
                        {
                            new Repas
                            {
                                IdRepas = 4,
                                DescRepas = "DescRepas4",
                                IdTypeRepas = 1,
                                LibelleRepas = "LibelleRepas4"
                            },
                            new Repas
                            {
                                IdRepas = 5,
                                DescRepas = "DescRepas5",
                                IdTypeRepas = 2,
                                LibelleRepas = "LibelleRepas5"
                            },
                            new Repas
                            {
                                IdRepas = 6,
                                DescRepas = "DescRepas6",
                                IdTypeRepas = 3,
                                LibelleRepas = "LibelleRepas6"
                            }
                        }
                    }
                };




        public Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            if (ingredient.NomIngr == null)
            {
                return Task.FromResult<Ingredient>(null);
            }
            return Task.FromResult(ingredient);
        }

        public Task<Menu> CreateMenu(Menu Menus)
        {
            if (Menus.NomMenu== null)
            {
                return Task.FromResult<Menu>(null);
            }
            return Task.FromResult(Menus);
        }

        public Task<Repas> CreateRepas(Repas Repas)
        {
            if (Repas.LibelleRepas == null)
            {
                return Task.FromResult<Repas>(null);
            }
            return Task.FromResult(Repas);
        }

        public Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas)
        {
            if (tRepas.LibelleTypeRepas == null)
            {
                return Task.FromResult<TypeRepas>(null);
            }
            return Task.FromResult(tRepas);
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
            List<Menu> data = null;
            if (pageRequest.Page * pageRequest.PageSize < MenuDb.Count)
            {
                int firstIndex = (pageRequest.Page * pageRequest.PageSize);
                int lastIndex = ((pageRequest.Page * pageRequest.PageSize) + pageRequest.PageSize);
                Math.Clamp(lastIndex, 0, MenuDb.Count);

                data = MenuDb.GetRange(firstIndex, lastIndex - firstIndex);

            }
            return Task.FromResult(new PageResponse<Menu>()
            {
                Page = pageRequest.Page,
                PageSize = pageRequest.PageSize,
                TotalRecords = MenuDb.Count,
                Data = data
            });

            //return Task.FromResult(new PageResponse<Menu>()
            //{
            //    Data = new List<Menu>()
            //    {
            //        new Menu()
            //        {
            //            DateMenu = DateTime.Now,
            //            IdMenu = 1,
            //            ListPlats = new List<Repas>()
            //            {
            //                new Repas
            //                {
            //                    IdRepas = 1,
            //                    DescRepas = "DescRepas1",
            //                    IdTypeRepas = 1,
            //                    LibelleRepas = "LibelleRepas1"
            //                },
            //                new Repas
            //                {
            //                    IdRepas = 2,
            //                    DescRepas = "DescRepas2",
            //                    IdTypeRepas = 2,
            //                    LibelleRepas = "LibelleRepas2"
            //                },
            //                new Repas
            //                {
            //                    IdRepas = 3,
            //                    DescRepas = "DescRepas3",
            //                    IdTypeRepas = 3,
            //                    LibelleRepas = "LibelleRepas3"
            //                }
            //            }
            //        },
            //        new Menu()
            //        {
            //            DateMenu = DateTime.Now.AddDays(1),
            //            IdMenu = 1,
            //            ListPlats = new List<Repas>()
            //            {
            //                new Repas
            //                {
            //                    IdRepas = 4,
            //                    DescRepas = "DescRepas4",
            //                    IdTypeRepas = 1,
            //                    LibelleRepas = "LibelleRepas4"
            //                },
            //                new Repas
            //                {
            //                    IdRepas = 5,
            //                    DescRepas = "DescRepas5",
            //                    IdTypeRepas = 2,
            //                    LibelleRepas = "LibelleRepas5"
            //                },
            //                new Repas
            //                {
            //                    IdRepas = 6,
            //                    DescRepas = "DescRepas6",
            //                    IdTypeRepas = 3,
            //                    LibelleRepas = "LibelleRepas6"
            //                }
            //            }
            //        }
            //    },
            //    Page = pageRequest.Page,
            //    PageSize = pageRequest.PageSize,
            //    TotalRecords = pageRequest.PageSize * 10,
            //});
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
            return Task.FromResult(MenuDb.Find(b => b.IdMenu == id));
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
            if (_Ingredient == null)
            {
                return Task.FromResult<Ingredient>(null);
            }
            _Ingredient.NomIngr = ingredient.NomIngr;
            _Ingredient.PrixIngr = ingredient.PrixIngr;

            return Task.FromResult(_Ingredient);
        }

        public Task<Menu> ModifyMenu(Menu menus)
        {

            if (menus.IdMenu == null)
                return null;
            var _Menu = MenuDb.Find(b => b.IdMenu == menus.IdMenu);
            if (_Menu == null)
            {
                return Task.FromResult<Menu>(null);
            }
            _Menu.NomMenu = menus.NomMenu;
            _Menu.DateMenu = menus.DateMenu;

            return Task.FromResult(_Menu);
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

        public Task<bool> RemoveServiceById(int id)
        {
            int i = MenuDb.RemoveAll(b => b.IdMenu == id);
            return Task.FromResult(i > 0);
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