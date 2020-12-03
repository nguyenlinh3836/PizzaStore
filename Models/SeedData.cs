using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace PizzaStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "#1 MARGHERITA",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Category = "Pizza",
                    },
                    new Product
                    {
                        Name = "#2 HAWAIIAN",
                        Description = "Jămbông, dứa, xốt cà chua và phomát",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Hawaiian.jpg",
                        Category = "Pizza",
                    },
                    new Product
                    {
                        Name = "#3 TROPICANA SEAFOOD",
                        Description = "Tôm, cá, cua thanh, ngao, dứa, xốt ớt chua ngọt và phomát.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Tropicana-Seafood.jpg",
                        Category = "Pizza",
                    },
                    new Product
                    {
                        Name = "#4 BBQ BEEFY",
                        Description = "Thịt ba chỉ bò và heo nướng, hành tây, cà chua với xốt BBQ, khoai tây sợi và...",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-BBQ-Beefy.jpg",
                        Category = "Pizza",

                    },
                    new Product
                    {
                        Name = "GARLIC BREAD",
                        Description = "Bánh mỳ bơ tỏi.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Garlic-Bread.jpg",
                        Category = "Starters",

                    },
                    new Product
                    {
                        Name = "GARLIC CHEESE LOAF",
                        Description = "Bánh mỳ bơ tỏi nhồi phô mai nướng.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Garlic-Cheese-Loaf.jpg",
                        Category = "Starters",

                    },
                    new Product
                    {
                        Name = "SOUP OF THE DAY",
                        Description = "Xin hỏi nhân viên phục vụ về món súp đặc biệt trong ngày.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Soup-Of-The-Day.jpg",
                        Category = "Starters",

                    },
                    new Product
                    {
                        Name = "AMERICAN FRIES",
                        Description = "Khoai tây Mỹ chiên giòn dùng kèm với xốt tương cà & mayonnaise.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-American-Fries.jpg",
                        Category = "Starters",
                    },
                    new Product
                    {
                        Name = "CAESAR SALAD",
                        Description = "Salát Ceasar với xà lách thái nhỏ, bánh mỳ nướng, thịt ba chỉ xông khói, trứng chần, trộn...",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Caesar-Salad.jpg",
                        Category = "Salads",
                    },
                    new Product
                    {
                        Name = "GREEN GARDEN SALAD",
                        Description = "Salát với xà lách, cà chua, dưa chuột, hành tây, trộn xốt dầu dấm đặc biệt của Al...",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Green-Garden-Salad.jpg",
                        Category = "Salads",
                    },
                    new Product
                    {
                        Name = "BEEF SALAD",
                        Description = "Salát với thịt bò nhập khẩu tẩm xốt ớt cay nướng, khoai tây bi, ớt Đà Lạt ...",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Beef-Salad.jpg",
                        Category = "Salads",
                    },
                    new Product
                    {
                        Name = "RUSSIAN SALAD",
                        Description = "Salát Nga với cà rốt, khoai tây, đậu hạt, ngô hạt, jămbông, củ cải đỏ, cần tây, trộn...",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Russian-Salad.jpg",
                        Category = "Salads",
                    }

                );
                context.SaveChanges();
            }

            if (!context.Sizes.Any())
            {
                context.Sizes.AddRange(
                    new Size
                    {
                        Price = 150000,
                        Name = "S",
                        ProductId = 1
                    },
                    new Size
                    {
                        Price = 220000,
                        Name = "L",
                        ProductId = 1
                    },
                    new Size
                    {
                        Price = 260000,
                        Name = "XL",
                        ProductId = 1
                    },


                    new Size
                    {
                        Price = 150000,
                        Name = "S",
                        ProductId = 2
                    },
                    new Size
                    {
                        Price = 220000,
                        Name = "L",
                        ProductId = 2
                    },
                    new Size
                    {
                        Price = 260000,
                        Name = "XL",
                        ProductId = 2
                    },


                    new Size
                    {
                        Price = 150000,
                        Name = "S",
                        ProductId = 3
                    },
                    new Size
                    {
                        Price = 220000,
                        Name = "L",
                        ProductId = 3
                    },
                    new Size
                    {
                        Price = 260000,
                        Name = "XL",
                        ProductId = 3
                    },


                    new Size
                    {
                        Price = 150000,
                        Name = "S",
                        ProductId = 4
                    },
                    new Size
                    {
                        Price = 230000,
                        Name = "L",
                        ProductId = 4
                    },
                    new Size
                    {
                        Price = 260000,
                        Name = "XL",
                        ProductId = 4
                    },

                    new Size
                    {
                        Price = 70000,
                        Name = "",
                        ProductId = 5
                    },

                    new Size
                    {
                        Price = 80000,
                        Name = "",
                        ProductId = 6
                    },

                    new Size
                    {
                        Price = 80000,
                        Name = "",
                        ProductId = 7
                    },

                    new Size
                    {
                        Price = 90000,
                        Name = "",
                        ProductId = 8
                    },

                    new Size
                    {
                        Price = 140000,
                        Name = "",
                        ProductId = 9
                    },

                    new Size
                    {
                        Price = 110000,
                        Name = "",
                        ProductId = 10
                    },

                    new Size
                    {
                        Price = 140000,
                        Name = "",
                        ProductId = 11
                    },

                    new Size
                    {
                        Price = 130000,
                        Name = "",
                        ProductId = 12
                    }

                );
                context.SaveChanges();
            }


        }
    }
}