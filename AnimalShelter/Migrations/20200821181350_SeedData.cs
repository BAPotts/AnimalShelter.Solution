using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Domestic Shorthair", "Female", "Frankie", "Cat" },
                    { 18, 1, "Boxer", "Male", "Chance", "Dog" },
                    { 17, 5, "Domestic Shorthair", "Male", "Jiji", "Cat" },
                    { 16, 4, "Siamese", "Male", "Hank", "Cat" },
                    { 15, 17, "Domestic Shorthair", "Female", "Gypsy", "Cat" },
                    { 14, 3, "Jack Russell Terrier", "Male", "Russell", "Dog" },
                    { 13, 14, "Domestic Shorthair", "Male", "George", "Cat" },
                    { 12, 6, "Wolfhound", "Female", "Fido", "Dog" },
                    { 11, 1, "Great Dane", "Male", "Roger", "Dog" },
                    { 10, 5, "Bombay", "Female", "Scout", "Cat" },
                    { 9, 7, "Chesapeake Bay Retriever", "Male", "Rye", "Dog" },
                    { 8, 7, "Domestic Shorthair", "Female", "Toots", "Cat" },
                    { 7, 5, "Domestic Shorthair", "Male", "Bubsy", "Cat" },
                    { 6, 10, "Terrier Mix", "Male", "Huckleberry", "Dog" },
                    { 5, 3, "Terrier Mix", "Female", "Ella", "Dog" },
                    { 4, 5, "Domestic Longhair", "Female", "Snugglepuss", "Cat" },
                    { 3, 8, "Puggle", "Female", "Violet", "Dog" },
                    { 2, 3, "Domestic Mediumhair", "Male", "Jasper", "Cat" },
                    { 19, 8, "Ragdoll", "Female", "Sassy", "Cat" },
                    { 20, 12, "Golden Retriever", "Male", "Shadow", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);
        }
    }
}
