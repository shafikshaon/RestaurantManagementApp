using System.Collections.Generic;
using RMS_Server_.Models;

namespace RMS_Server_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RMS_Server_.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RMS_Server_.Models.ApplicationDbContext context)
        {
            var CocaCola = new FoodItem() { Name = "CocaCola", Price = 30 };
            var ChickenFry = new FoodItem() { Name = "Chicken Fry", Price = 80 };
            var FriedRice = new FoodItem() { Name = "Fried Rice", Price = 120 };
            var IndiaFriedRice = new FoodItem() { Name = "Indian Fried Rice", Price = 150 };
            var FriedRiceWithCurry = new FoodItem() { Name = "Fried Rice with Vegetable Curry", Price = 170 };
            var ChikenFryWithSausages = new FoodItem() { Name = "Chikcen Fry with Sausages", Price = 120 };
            var BeefBurer = new FoodItem() { Name = "Beef Burger", Price = 80 };
            var SpecialBlocksBurger = new FoodItem() { Name = "Special Block's Burger", Price = 140 };



            context.FoodItems.AddOrUpdate(
                p => p.Id,
                CocaCola,
                ChickenFry,
                FriedRice,
                IndiaFriedRice,
                FriedRiceWithCurry,
                ChikenFryWithSausages,
                BeefBurer,
                SpecialBlocksBurger
                );

            context.SetMenus.AddOrUpdate(
                p => p.Id,
                new SetMenu
                {
                    Name = "Set Menu A",
                    Price = 199,
                    SetMenuItems = new List<SetMenuItem>()
                    {
                        new SetMenuItem()
                        {
                            FoodItem = FriedRice,
                            Quantity = 1
                        },
                        new SetMenuItem()
                        {
                            FoodItem = ChickenFry,
                            Quantity = 1
                        },
                        new SetMenuItem()
                        {
                            FoodItem = CocaCola,
                            Quantity = 1
                        }
                    }
                },
                new SetMenu()
                {
                    Name = "Set Menu B",
                    Price = 299,
                    SetMenuItems = new List<SetMenuItem>()
                    {
                        new SetMenuItem {FoodItem = FriedRiceWithCurry,Quantity = 1},
                        new SetMenuItem {FoodItem = ChikenFryWithSausages,Quantity = 1},
                        new SetMenuItem {FoodItem = CocaCola,Quantity = 1}
                    }
                },


                 new SetMenu()
                 {
                     Name = "Set Menu C",
                     Price = 350,
                     SetMenuItems = new List<SetMenuItem>()
                    {
                        new SetMenuItem {FoodItem = IndiaFriedRice,Quantity = 1},
                        new SetMenuItem {FoodItem = ChickenFry,Quantity = 1},
                        new SetMenuItem {FoodItem = CocaCola,Quantity = 1}
                    }
                 },

                  new SetMenu()
                  {
                      Name = "Set Menu D",
                      Price = 160,
                      SetMenuItems = new List<SetMenuItem>()
                    {
                        new SetMenuItem {FoodItem = BeefBurer,Quantity = 1},
                        new SetMenuItem {FoodItem = CocaCola,Quantity = 1},
                    }
                  },
                   new SetMenu()
                   {
                       Name = "Set Menu E",
                       Price = 350,
                       SetMenuItems = new List<SetMenuItem>()
                       {
                           new SetMenuItem {FoodItem = SpecialBlocksBurger,Quantity = 1},
                           new SetMenuItem {FoodItem = CocaCola,Quantity = 1},
                       }
                   }
                );
        }
    }
}
