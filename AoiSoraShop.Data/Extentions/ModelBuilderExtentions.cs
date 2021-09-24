using AoiSoraShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AoiSoraShop.Data.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of AoiSoraShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of AoiSoraShop" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { 
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null, 
                    SortOrder = 1,
                    Status = Enum.Status.Active,
                    CategoryName = "Áo nam",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enum.Status.Active,
                    CategoryName = "Áo nữ",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 1000000, 
                    Price = 200000, 
                    Stock = 0,
                    ViewCount = 0,
                    ProductName = "Áo sơ mi trắng",
                    SeoAlias = "ao-so-mi-trang",
                    SeoDecription = "Áo sơ mi trắng",
                    SeoTitle = "Áo sơ mi trắng",
                    Details = "Áo sơ mi trắng",
                    Description = "Áo sơ mi trắng"
                },
                new Product()
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 1000000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                    ProductName = "Áo thun trắng",
                    SeoAlias = "ao-thun-trang",
                    SeoDecription = "Áo thun trắng",
                    SeoTitle = "Áo thun trắng",
                    Details = "Áo thun trắng",
                    Description = "Áo thun trắng"
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId =1},
                new ProductInCategory() { ProductId = 2, CategoryId = 1 }
                );

            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "vanduy9491@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Duy",
                LastName = "Tran",
                Dob = new DateTime(1991, 01, 31)
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}
