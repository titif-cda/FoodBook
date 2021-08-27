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

        public List<Met> MetDB = new List<Met>()
        {
            new Met(){
                Id = 1,
                Libelle = "Soupe à l'oignon ",
                Description = " Soupe à l'oignon",
                TypeRepas = new TypeRepas() {
                                    Id = 1,
                                    Libelle ="Entree"
                                },
            },
            new Met()
            {
                Id = 1,
                Libelle = "pizza 4 fromage ",
                Description = " descriptif1",
                TypeRepas = new TypeRepas() {
                                    Id = 2,
                                    Libelle ="Plat"
                                },
            },
            new Met(){
                Id = 3,
                Libelle = "boule de glace ",
                Description = " descriptif2",
                TypeRepas = new TypeRepas() {
                                    Id = 1,
                                    Libelle ="Entree"
                                },
            },
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
                                TypeRepas = new TypeRepas() {
                                    Id = 1,
                                    Libelle ="Entree"
                                },
                                Libelle = "LibelleRepas1"
                            },
                            new Met
                            {
                                Id = 2,
                                Description = "DescRepas2",
                               TypeRepas = new TypeRepas() {
                                    Id = 2,
                                    Libelle ="Plat"
                                },
                                Libelle = "LibelleRepas2"
                            },
                            new Met
                            {
                                Id = 3,
                                Description = "DescRepas3",
                                TypeRepas = new TypeRepas() {
                                    Id = 3,
                                    Libelle ="Dessert"
                                },
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
                                TypeRepas = new TypeRepas() {
                                    Id = 1,
                                    Libelle ="Entree"
                                },
                                Libelle = "LibelleRepas4"
                            },
                            new Met
                            {
                                Id = 5,
                                Description = "DescRepas5",
                                TypeRepas = new TypeRepas() {
                                    Id = 2,
                                    Libelle ="Plat"
                                },
                                Libelle = "LibelleRepas5"
                            },
                            new Met
                            {
                                Id = 6,
                                Description = "DescRepas6",
                                TypeRepas = new TypeRepas() {
                                    Id = 3,
                                    Libelle ="Dessert"
                                },
                                Libelle = "LibelleRepas6"
                            }
                        }
                    }
                };
        public List<TypeRepas> TypeDB = new List<TypeRepas>()
        {
             new TypeRepas(){
                Id = 1,
                Libelle = "Entree",
            },
             new TypeRepas(){
                Id = 2,
                Libelle = "Plat",
            },
             new TypeRepas(){
                Id = 2,
                Libelle = "Dessert",
            }
        };

        public Task<Service> GetServiceById(int id)
        {
            return Task.FromResult(MenuDb.Find(b => b.Id == id));
        }

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
                int firstIndex = (pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault());
                int lastIndex = ((pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault()) + pageRequest.PageSize.GetValueOrDefault());
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
                int firstIndex = (pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault());
                int lastIndex = ((pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault()) + pageRequest.PageSize.GetValueOrDefault());
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

        }

        public Task<PageResponse<Met>> GetAllMet(PageRequest pageRequest, FilterMetPaged filter)
        {
            List<Met> data = null;
            if (pageRequest.Page * pageRequest.PageSize < MenuDb.Count)
            {
                int firstIndex = (pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault());
                int lastIndex = ((pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault()) + pageRequest.PageSize.GetValueOrDefault());
                Math.Clamp(lastIndex, 0, MenuDb.Count);

                data = MetDB.GetRange(firstIndex, lastIndex - firstIndex);

            }
            return Task.FromResult(new PageResponse<Met>()
            {
                Page = pageRequest.Page,
                PageSize = pageRequest.PageSize,
                TotalRecords = MenuDb.Count,
                Data = data
            });
        }

        public Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest)
        {
            List<TypeRepas> data = null;
            if (pageRequest.Page * pageRequest.PageSize < MenuDb.Count)
            {
                int firstIndex = (pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault());
                int lastIndex = ((pageRequest.Page.GetValueOrDefault() * pageRequest.PageSize.GetValueOrDefault()) + pageRequest.PageSize.GetValueOrDefault());
                Math.Clamp(lastIndex, 0, MenuDb.Count);

                data = TypeDB.GetRange(firstIndex, lastIndex - firstIndex);

            }
            return Task.FromResult(new PageResponse<TypeRepas>()
            {
                Page = pageRequest.Page,
                PageSize = pageRequest.PageSize,
                TotalRecords = MenuDb.Count,
                Data = data
            });
        }

        public Task<Ingredient> GetIngredientById(int id)
        {
            return Task.FromResult(IngredientsDB.Find(b => b.Id == id));
        }

      

        public Task<Met> GetMetById(int id)
        {
            return Task.FromResult(MetDB.Find(b => b.Id == id));
        }

        public Task<TypeRepas> GetTypeRepasById(int id)
        {
            return Task.FromResult(TypeDB.Find(b => b.Id == id));
            
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
            _Menu.Midi = menus.Midi;
            _Menu.ListPlats = menus.ListPlats;

            return Task.FromResult(_Menu);
        }

        public Task<Met> ModifyMet(Met Repas)
        {
            if (Repas.Id == 0)
                return null;
            var _Met = MetDB.Find(b => b.Id == Repas.Id);
            if (_Met == null)
            {
                return Task.FromResult<Met>(null);
            }
            _Met.Id = Repas.Id;
            _Met.Libelle = Repas.Libelle;
            _Met.Description = Repas.Description;
            _Met.TypeRepas = Repas.TypeRepas;
            _Met.ListDesIngredients = Repas.ListDesIngredients;
            return Task.FromResult(_Met);
        }

        public Task<TypeRepas> ModifyTypeRepas(TypeRepas tRepas)
        {
            if (tRepas.Id == 0)
                return null;
            var _TRepas = TypeDB.Find(b => b.Id == tRepas.Id);
            if (_TRepas == null)
            {
                return Task.FromResult<TypeRepas>(null);
            }
            _TRepas.Id = tRepas.Id;
            _TRepas.Libelle = tRepas.Libelle;
            return Task.FromResult(_TRepas);
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
            int i = MetDB.RemoveAll(b => b.Id == id);
            return Task.FromResult(i > 0);
        }

        public Task<bool> RemoveTypeRepasById(int id)
        {
            int i = TypeDB.RemoveAll(b => b.Id == id);
            return Task.FromResult(i > 0);
        }

        public Task<PageResponse<Met>> GetAllMet(FilterMetPaged filterMetPaged)
        {
            throw new NotImplementedException();
        }

        public Task<Met> GetIngredientParMetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetMetForServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetServiceByDateAndService(DateTime date, bool midi)
        {
            throw new NotImplementedException();
        }

        public Task<Service> ModifyAllService(Service service)
        {
            if (service.Id == 0)
                return null;
            var _Service = MenuDb.Find(b => b.Id == service.Id);
            if (_Service == null)
            {
                return Task.FromResult<Service>(null);
            }
            _Service.Id = service.Id;
            _Service.Date = service.Date;
            _Service.Midi = service.Midi;
            _Service.ListPlats = service.ListPlats;

            return Task.FromResult(_Service);
        }

        public Task<MetsIngredients> CreateListeIngredients(MetsIngredients ListeIngredients)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<MetsIngredients>> GetAllListeIngredients(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<MetsIngredients> GetAllListeIngredientsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MetsIngredients> ModifyAllListeIngredients(MetsIngredients ListeIngredients)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemovAllListeIngredientsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}