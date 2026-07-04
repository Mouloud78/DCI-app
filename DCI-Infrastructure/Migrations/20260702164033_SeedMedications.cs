using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCI_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedMedications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Form", "Name", "Strength" },
                values: new object[,]
                {
                    { 1, "Comprimé", "Paracétamol", "500 mg" },
                    { 2, "Gélule", "Amoxicilline", "1 g" },
                    { 3, "Comprimé", "Ibuprofène", "400 mg" },
                    { 4, "Comprimé", "Metformine", "850 mg" },
                    { 5, "Gélule", "Oméprazole", "20 mg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
