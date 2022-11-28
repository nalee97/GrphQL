using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrphQL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Superpowers_Superheroes_SuperheroId",
                table: "Superpowers");

            migrationBuilder.DropIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1a3594c4-ac3b-4d4c-85ae-2c86109fac68"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("56c5eeea-287d-42d0-8404-61137a643711"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("60c6f297-0a35-4358-aa6b-5c4abc6cb482"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("60d03812-4128-410b-8803-1b3fc0d54d28"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6ee3a676-c88c-4cff-8e89-8a5cf5cd099b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("754fa8b7-9e69-4879-a52c-4d464e33b5be"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("837f746c-c167-4ab7-a8fd-2468ea39ed7a"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("276fb2b3-1104-4741-afb6-731be91b2aa5"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("28a91e73-1467-4f09-90c2-0cfdf4164c6e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("2a5726e2-42d6-4e1f-807f-9d2908fab478"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("5619479b-58b3-40f1-b42d-a31e117a5d4c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("75ce3a56-9fee-4415-a858-7b390b2104c0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("96754b9a-900a-4ece-8b47-05bfa2568540"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("beeda4f9-966f-47b5-a126-d70c67f3acce"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("3ea5c3c4-418f-46c2-abf8-270943230217"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("553f3b30-5549-4224-a2ca-6c2811ef2180"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("fb64fff8-d3f9-4f16-a529-6251e91bc22d"));

            migrationBuilder.DropColumn(
                name: "SuperheroId",
                table: "Superpowers");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("530ec32e-af9c-4556-9976-123222ddf3c9"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("7085d33c-278e-486c-b9a4-095dc9117c7c"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("87bd6133-7049-483f-9c5c-dfe9fa8d402c"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("bf255aab-aae6-4af3-b765-31148f49b531"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("c704d721-5994-4c19-9a59-649233d46ab6"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("dbccb75c-5f11-4a37-ab6e-bef4ae2f7389"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("fe07d4a7-7b53-401e-a668-0fdd9d5ec37c"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("c47611f7-0021-4de8-8802-7e88bf1ec95b"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" },
                    { new Guid("dff2eb19-f95a-4f8f-9d25-09645e0f23a8"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("e8f9b5fa-5300-445a-b4ef-4e7d673b6ab6"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower" },
                values: new object[,]
                {
                    { new Guid("6c752d3e-6c90-47ef-8238-7bbf1ac4947c"), "Sublime fighting skills.", "Fighting" },
                    { new Guid("79018d12-6237-4833-b872-2654f02da51e"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power." },
                    { new Guid("7bb91578-29ba-4ef1-b921-8321534d679c"), "She knows how to infiltrate the enemy.", "Infiltration" },
                    { new Guid("845b1b86-da9e-4d16-a7e0-e5e8b5d35d94"), "She's good at spying at people.", "Espionage" },
                    { new Guid("f520b9d7-a14f-40cb-adcf-734304054017"), "The knowledge of how to undermine others.", "Subterfuge" },
                    { new Guid("fd59c53c-b995-4a63-93d8-feaf16950e07"), "He got a lot of money", "Wealth." },
                    { new Guid("ff5af3ae-dabc-470a-b235-3fdf7e46798e"), "He's always a step ahead.", "Intellect." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("530ec32e-af9c-4556-9976-123222ddf3c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7085d33c-278e-486c-b9a4-095dc9117c7c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("87bd6133-7049-483f-9c5c-dfe9fa8d402c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bf255aab-aae6-4af3-b765-31148f49b531"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c704d721-5994-4c19-9a59-649233d46ab6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dbccb75c-5f11-4a37-ab6e-bef4ae2f7389"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe07d4a7-7b53-401e-a668-0fdd9d5ec37c"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("c47611f7-0021-4de8-8802-7e88bf1ec95b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("dff2eb19-f95a-4f8f-9d25-09645e0f23a8"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("e8f9b5fa-5300-445a-b4ef-4e7d673b6ab6"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("6c752d3e-6c90-47ef-8238-7bbf1ac4947c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("79018d12-6237-4833-b872-2654f02da51e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7bb91578-29ba-4ef1-b921-8321534d679c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("845b1b86-da9e-4d16-a7e0-e5e8b5d35d94"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f520b9d7-a14f-40cb-adcf-734304054017"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fd59c53c-b995-4a63-93d8-feaf16950e07"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ff5af3ae-dabc-470a-b235-3fdf7e46798e"));

            migrationBuilder.AddColumn<Guid>(
                name: "SuperheroId",
                table: "Superpowers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1a3594c4-ac3b-4d4c-85ae-2c86109fac68"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("56c5eeea-287d-42d0-8404-61137a643711"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("60c6f297-0a35-4358-aa6b-5c4abc6cb482"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("60d03812-4128-410b-8803-1b3fc0d54d28"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("6ee3a676-c88c-4cff-8e89-8a5cf5cd099b"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("754fa8b7-9e69-4879-a52c-4d464e33b5be"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("837f746c-c167-4ab7-a8fd-2468ea39ed7a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("3ea5c3c4-418f-46c2-abf8-270943230217"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("553f3b30-5549-4224-a2ca-6c2811ef2180"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("fb64fff8-d3f9-4f16-a529-6251e91bc22d"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("276fb2b3-1104-4741-afb6-731be91b2aa5"), "Sublime fighting skills.", "Fighting", new Guid("3ea5c3c4-418f-46c2-abf8-270943230217") },
                    { new Guid("28a91e73-1467-4f09-90c2-0cfdf4164c6e"), "He got a lot of money", "Wealth.", new Guid("3ea5c3c4-418f-46c2-abf8-270943230217") },
                    { new Guid("2a5726e2-42d6-4e1f-807f-9d2908fab478"), "He's always a step ahead.", "Intellect.", new Guid("3ea5c3c4-418f-46c2-abf8-270943230217") },
                    { new Guid("5619479b-58b3-40f1-b42d-a31e117a5d4c"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("553f3b30-5549-4224-a2ca-6c2811ef2180") },
                    { new Guid("75ce3a56-9fee-4415-a858-7b390b2104c0"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("553f3b30-5549-4224-a2ca-6c2811ef2180") },
                    { new Guid("96754b9a-900a-4ece-8b47-05bfa2568540"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("fb64fff8-d3f9-4f16-a529-6251e91bc22d") },
                    { new Guid("beeda4f9-966f-47b5-a126-d70c67f3acce"), "She's good at spying at people.", "Espionage", new Guid("553f3b30-5549-4224-a2ca-6c2811ef2180") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Superpowers_Superheroes_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
