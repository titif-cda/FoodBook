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

        public List<Service> MenuDb = new List<Service>()
                {
                    new Service()
                    {
                        Date = DateTime.Now,
                        Id = 1,
                        ListPlats = new List<Met>()
                        {
                            new Met
                            {
                                Id = 1,
                                Description = "DescRepas1",
                                IdType = 1,
                                Libelle = "LibelleRepas1"
                            },
                            new Met
                            {
                                Id = 2,
                                Description = "DescRepas2",
                                IdType = 2,
                                Libelle = "LibelleRepas2"
                            },
                            new Met
                            {
                                Id = 3,
                                Description = "DescRepas3",
                                IdType = 3,
                                Libelle = "LibelleRepas3"
                            }
                        }
                    },
                    new Service()
                    {
                        Date = DateTime.Now.AddDays(1),
                        Id = 5,
                        ListPlats = new List<Met>()
                        {
                            new Met
                            {
                                Id = 4,
                                Description = "DescRepas4",
                                IdType = 1,
                                Libelle = "LibelleRepas4"
                            },
                            new Met
                            {
                                Id = 5,
                                Description = "DescRepas5",
                                IdType = 2,
                                Libelle = "LibelleRepas5"
                            },
                            new Met
                            {
                                Id = 6,
                                Description = "DescRepas6",
                                IdType = 3,
                                Libelle = "LibelleRepas6"
                            }
                        }
                    }
                };




        public Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            if (ingredient.Nom == null)
            {
                return Task.FromResult<Ingredient>(null);
            }
            return Task.FromResult(ingredient);
        }

        public Task<Service> CreateService(Service service)
        {
            if (service.Id == 0)
            {
                return Task.FromResult<Service>(null);
            }
            return Task.FromResult(service);
        }

        public Task<Met> CreateMet(Met met)
        {
            if (met.Libelle == null)
            {
                return Task.FromResult<Met>(null);
            }
            return Task.FromResult(met);
        }

        public Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas)
        {
            if (tRepas.Libelle == null)
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

        public Task<PageResponse<Service>> GetAllService(PageRequest pageRequest)
        {
            List<Service> data = null;
            if (pageRequest.Page * pageRequest.PageSize < MenuDb.Count)
            {
                int firstIndex = (pageRequest.Page * pageRequest.PageSize);
                int lastIndex = ((pageRequest.Page * pageRequest.PageSize) + pageRequest.PageSize);
                Math.Clamp(lastIndex, 0, MenuDb.Count);

                data = MenuDb.GetRange(firstIndex, lastIndex - firstIndex);

            }
            return Task.FromResult(new PageResponse<Service>()
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

        public Task<PageResponse<Met>> GetAllMet(PageRequest pageRequest, Filter filter)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetIngredientById(int id)
        {
            return Task.FromResult(IngredientsDB.Find(b => b.Id == id));
        }

        public Task<Service> GetServiceById(int id)
        {
            return Task.FromResult(MenuDb.Find(b => b.Id == id));
        }

        public Task<Met> GetMetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeRepas> GetTypeRepasById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> ModifyIngredient(Ingredient ingredient)
        {
            if (ingredient.Id == null)
                return null;
            var _Ingredient = IngredientsDB.Find(b => b.Id == ingredient.Id);
            if (_Ingredient == null)
            {
                return Task.FromResult<Ingredient>(null);
            }
            _Ingredient.Nom = ingredient.Nom;
            _Ingredient.Prix = ingredient.Prix;

            return Task.FromResult(_Ingredient);
        }

        public Task<Service> ModifyService(Service menus)
        {

            if (menus.Id == 0)
                return null;
            var _Menu = MenuDb.Find(b => b.Id == menus.Id);
            if (_Menu == null)
            {
                return Task.FromResult<Service>(null);
            }
            _Menu.Id = menus.Id;
            _Menu.Date = menus.Date;

            return Task.FromResult(_Menu);
        }

        public Task<Met> ModifyMet(Met Repas)
        {
            throw new NotImplementedException();
        }

        public Task<TypeRepas> ModifyTypeRepas(TypeRepas tRepas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveIngredientById(int id)
        {
            int i = IngredientsDB.RemoveAll(b => b.Id == id);
            return Task.FromResult( i > 0);
        }

        public Task<bool> RemoveServiceById(int id)
        {
            int i = MenuDb.RemoveAll(b => b.Id == id);
            return Task.FromResult(i > 0);
        }

        public Task<bool> RemoveMetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveTypeRepasById(int id)
        {
            throw new NotImplementedException();
        }
    }
}