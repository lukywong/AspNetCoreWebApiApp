using System;

using Xunit;

using MyWebApiApp.Domains;
using MyWebApiApp.Models;

namespace MyWebApiApp.Test
{
    public class ProductsCrudTest
    {
        [Fact]
        public void CreateTest()
        {
            using (var db = new DatabaseContext())
            {
                // arrange
                var shirt = new Product()
                {
                    Name = "T-shirt",
                    Description = "T-shirt new arrival",
                    CreatedAt = DateTime.Parse("Jan 27, 2016"),
                    CreatedBy = "Luky Wong"
                };

                // act
                db.Products.Add(shirt);
                var count = db.SaveChanges();

                // assert
                Assert.Equal(1, count);
            }
        }
    }
}
