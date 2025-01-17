﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    partial class CompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirthday")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = new Guid("fb55bf63-28b6-4d1e-8394-3ca614ca97d9"),
                            Age = 148,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name7bb08537-f87e-4f13-9a01-1dc4ac3d5d32",
                            Role = "Rolea18306f8-0820-42bb-91f8-11cd379bbd02"
                        },
                        new
                        {
                            ID = new Guid("3bab3bdd-3496-403f-864a-dbc7886d24ca"),
                            Age = 26,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name9fc565a7-e663-46d4-ab3e-681411f5d74a",
                            Role = "Role3e73ade1-64c4-4174-8b69-da60385cb544"
                        },
                        new
                        {
                            ID = new Guid("745e31b1-a3aa-4f87-8e0e-159275535544"),
                            Age = 212,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name92bf259c-ee16-4edd-8bbf-bf221e641b00",
                            Role = "Rolee4898578-0e1b-41e0-be7d-882a94c00ae8"
                        },
                        new
                        {
                            ID = new Guid("c541731f-24e5-4fd4-af00-6bb2313a4c1d"),
                            Age = 238,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name47c2c23b-0341-48b7-b7a8-1fddfc0f839a",
                            Role = "Rolecdf4fa8f-e7f6-4417-8842-c2f2f460749a"
                        },
                        new
                        {
                            ID = new Guid("7c7b016b-faf7-4282-83a9-594b544e5c47"),
                            Age = 46,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Namee1fce561-12ac-4d3c-b8f1-9505b50a6519",
                            Role = "Rolee6b0da10-fa79-43f8-b315-3497b522e9b0"
                        },
                        new
                        {
                            ID = new Guid("e6d0fd26-283e-4add-b033-d4059657e4af"),
                            Age = 252,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name50707721-bb15-4805-bfc7-4326dd708ada",
                            Role = "Role391ac8ca-c15f-4d99-a577-7ab146644fe2"
                        },
                        new
                        {
                            ID = new Guid("2d8a2e84-4e86-43e4-91db-6ba0f2a1e5b4"),
                            Age = 245,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Namece58ff93-37d3-4661-8c3f-630ce86e4b55",
                            Role = "Roleaf2342bd-8234-46b3-afde-1aac12cd74a1"
                        },
                        new
                        {
                            ID = new Guid("ca5f19c6-fe04-4d49-bf14-93bd1cd53bec"),
                            Age = 236,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Named6d28a6b-5aa4-4859-9da2-1279756cd077",
                            Role = "Role6f225e4f-9e55-4e1c-8a70-fda96ec6563d"
                        },
                        new
                        {
                            ID = new Guid("22e10821-5664-4f24-b794-4f164724de97"),
                            Age = 225,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name04be66ad-4faa-4877-8957-8c56b0836f13",
                            Role = "Role63c33a36-8eaa-4d06-ac37-afd658ddf6b5"
                        },
                        new
                        {
                            ID = new Guid("cfe26d88-c78a-47f8-a36c-e7ba9c6cfeef"),
                            Age = 19,
                            DateOfBirthday = new DateOnly(1995, 1, 1),
                            Name = "Name230b805b-9073-4413-9f37-aaab7be06c5d",
                            Role = "Role1d896e68-a7a8-4d97-a1cd-5567ff552330"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
