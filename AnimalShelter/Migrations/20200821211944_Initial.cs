using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Color", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Domestic Shorthair", "Black", "Female", "Frankie" },
                    { 10, 5, "Domestic Shorthair", "Black", "Male", "Jiji" },
                    { 9, 4, "Siamese", "Orange", "Male", "Hank" },
                    { 8, 17, "Domestic Shorthair", "Black", "Female", "Gypsy" },
                    { 7, 14, "Domestic Shorthair", "White", "Male", "George" },
                    { 11, 8, "Ragdoll", "Flame Point", "Female", "Sassy" },
                    { 5, 7, "Domestic Shorthair", "Grey", "Female", "Toots" },
                    { 4, 5, "Domestic Shorthair", "Tabby", "Male", "Bubsy" },
                    { 3, 5, "Domestic Longhair", "Tabby", "Female", "Snugglepuss" },
                    { 2, 3, "Domestic Mediumhair", "Black", "Male", "Jasper" },
                    { 6, 5, "Bombay", "Calico", "Female", "Scout" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Color", "Gender", "Name" },
                values: new object[,]
                {
                    { 9, 12, "Golden Retriever", "Gold", "Male", "Shadow" },
                    { 1, 8, "Puggle", "Black", "Female", "Violet" },
                    { 2, 3, "Terrier Mix", "Grey", "Female", "Ella" },
                    { 3, 10, "Terrier Mix", "Brown", "Male", "Huckleberry" },
                    { 4, 7, "Chesapeake Bay Retriever", "Brown", "Male", "Rye" },
                    { 5, 1, "Great Dane", "White", "Male", "Roger" },
                    { 6, 6, "Wolfhound", "Tawny", "Female", "Fido" },
                    { 7, 3, "Jack Russell Terrier", "Spotted", "Male", "Russell" },
                    { 8, 1, "Boxer", "Pink", "Male", "Chance" },
                    { 10, 2, "Chesapeake Bay Retriever", "Brown", "Male", "Jake" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
