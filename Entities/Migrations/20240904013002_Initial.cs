using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateOfBirthday = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Age", "DateOfBirthday", "Name", "Role" },
                values: new object[,]
                {
                    { new Guid("22e10821-5664-4f24-b794-4f164724de97"), 225, new DateOnly(1995, 1, 1), "Name04be66ad-4faa-4877-8957-8c56b0836f13", "Role63c33a36-8eaa-4d06-ac37-afd658ddf6b5" },
                    { new Guid("2d8a2e84-4e86-43e4-91db-6ba0f2a1e5b4"), 245, new DateOnly(1995, 1, 1), "Namece58ff93-37d3-4661-8c3f-630ce86e4b55", "Roleaf2342bd-8234-46b3-afde-1aac12cd74a1" },
                    { new Guid("3bab3bdd-3496-403f-864a-dbc7886d24ca"), 26, new DateOnly(1995, 1, 1), "Name9fc565a7-e663-46d4-ab3e-681411f5d74a", "Role3e73ade1-64c4-4174-8b69-da60385cb544" },
                    { new Guid("745e31b1-a3aa-4f87-8e0e-159275535544"), 212, new DateOnly(1995, 1, 1), "Name92bf259c-ee16-4edd-8bbf-bf221e641b00", "Rolee4898578-0e1b-41e0-be7d-882a94c00ae8" },
                    { new Guid("7c7b016b-faf7-4282-83a9-594b544e5c47"), 46, new DateOnly(1995, 1, 1), "Namee1fce561-12ac-4d3c-b8f1-9505b50a6519", "Rolee6b0da10-fa79-43f8-b315-3497b522e9b0" },
                    { new Guid("c541731f-24e5-4fd4-af00-6bb2313a4c1d"), 238, new DateOnly(1995, 1, 1), "Name47c2c23b-0341-48b7-b7a8-1fddfc0f839a", "Rolecdf4fa8f-e7f6-4417-8842-c2f2f460749a" },
                    { new Guid("ca5f19c6-fe04-4d49-bf14-93bd1cd53bec"), 236, new DateOnly(1995, 1, 1), "Named6d28a6b-5aa4-4859-9da2-1279756cd077", "Role6f225e4f-9e55-4e1c-8a70-fda96ec6563d" },
                    { new Guid("cfe26d88-c78a-47f8-a36c-e7ba9c6cfeef"), 19, new DateOnly(1995, 1, 1), "Name230b805b-9073-4413-9f37-aaab7be06c5d", "Role1d896e68-a7a8-4d97-a1cd-5567ff552330" },
                    { new Guid("e6d0fd26-283e-4add-b033-d4059657e4af"), 252, new DateOnly(1995, 1, 1), "Name50707721-bb15-4805-bfc7-4326dd708ada", "Role391ac8ca-c15f-4d99-a577-7ab146644fe2" },
                    { new Guid("fb55bf63-28b6-4d1e-8394-3ca614ca97d9"), 148, new DateOnly(1995, 1, 1), "Name7bb08537-f87e-4f13-9a01-1dc4ac3d5d32", "Rolea18306f8-0820-42bb-91f8-11cd379bbd02" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
