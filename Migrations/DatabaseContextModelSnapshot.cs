using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

using MyWebApiApp.Domains;

namespace MyWebApiApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("MyWebApiApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });
        }
    }
}
