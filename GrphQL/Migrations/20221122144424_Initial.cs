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
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3551e641-b698-4f81-b9e1-ece3d94bd649"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("36d49dc5-501d-434c-aefb-607d2cb24486"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("63df450f-7511-4ec1-b485-5be3e0fabb57"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8f55948a-4b1c-4938-aee3-9590678d904f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d525021d-fac8-42db-b324-02fd1453f0a2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ea382601-6675-44f0-88cb-a0b523d386fb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fdac483c-e8e5-4e75-8574-2361f024a1e7"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("26433a69-7a3b-433a-9f35-5ce40347fd91"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("39ec092c-0b73-41c6-9c04-c2ae827a1ad4"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("741388ed-b0eb-4ba7-b892-fdb8d9b54ac7"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7cb68a63-e7aa-40eb-a7ce-47d267a44a18"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("86cc456a-c5a9-407d-b416-94955ea6ecea"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("8fcdfef8-aaa2-45e4-9f73-db92207e5564"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f9708e81-7b9d-4919-b38a-a4db3a2fdcb1"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b"));

            migrationBuilder.DropColumn(
                name: "SuperheroId",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4a285f37-b635-47f5-91e0-a8f3aec91d20"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("59a82ebd-1a0c-40a9-8683-0b6ae424b4f5"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("62feb4e7-5b17-4e32-b6ae-9c7c25429c2d"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("76347f5f-7d2f-4206-80fe-4f475ce0b5e6"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("82c1ab43-0eb1-41bb-8542-7863e85c9f04"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("8899b6e0-1e7e-4aef-8a32-e94deafc5300"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("db803a41-4a0a-486c-93d5-d8df343d6a51"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("58c257b1-71d0-462b-9482-0249295de532"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("864cf9cb-fac1-411c-aa5b-f2e8cc8a6948"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("9ed7b100-2c87-47f5-928b-11f769b5cfa4"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("15c6a834-9dcb-453c-821b-472e76fde415"), "She's good at spying at people.", "Espionage", new Guid("864cf9cb-fac1-411c-aa5b-f2e8cc8a6948") },
                    { new Guid("4b89b1cb-8a21-44cf-84bf-9c2386f169a0"), "Sublime fighting skills.", "Fighting", new Guid("58c257b1-71d0-462b-9482-0249295de532") },
                    { new Guid("619b3f4d-23aa-47aa-a522-4031c3b1867d"), "He's always a step ahead.", "Intellect.", new Guid("58c257b1-71d0-462b-9482-0249295de532") },
                    { new Guid("9f2bd32c-c0ce-4e07-8f01-31e8d0f96f63"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("864cf9cb-fac1-411c-aa5b-f2e8cc8a6948") },
                    { new Guid("ad43182d-8696-41ef-8581-c6ebd9fc87c8"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("9ed7b100-2c87-47f5-928b-11f769b5cfa4") },
                    { new Guid("c1377d1a-aa88-47c5-85b2-c7d909c0ddf1"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("864cf9cb-fac1-411c-aa5b-f2e8cc8a6948") },
                    { new Guid("d4855eaf-5ae6-4b10-b546-770bc78d12cb"), "He got a lot of money", "Wealth.", new Guid("58c257b1-71d0-462b-9482-0249295de532") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4a285f37-b635-47f5-91e0-a8f3aec91d20"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("59a82ebd-1a0c-40a9-8683-0b6ae424b4f5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("62feb4e7-5b17-4e32-b6ae-9c7c25429c2d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("76347f5f-7d2f-4206-80fe-4f475ce0b5e6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("82c1ab43-0eb1-41bb-8542-7863e85c9f04"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8899b6e0-1e7e-4aef-8a32-e94deafc5300"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db803a41-4a0a-486c-93d5-d8df343d6a51"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("15c6a834-9dcb-453c-821b-472e76fde415"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("4b89b1cb-8a21-44cf-84bf-9c2386f169a0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("619b3f4d-23aa-47aa-a522-4031c3b1867d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9f2bd32c-c0ce-4e07-8f01-31e8d0f96f63"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ad43182d-8696-41ef-8581-c6ebd9fc87c8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c1377d1a-aa88-47c5-85b2-c7d909c0ddf1"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d4855eaf-5ae6-4b10-b546-770bc78d12cb"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("58c257b1-71d0-462b-9482-0249295de532"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("864cf9cb-fac1-411c-aa5b-f2e8cc8a6948"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9ed7b100-2c87-47f5-928b-11f769b5cfa4"));

            migrationBuilder.AddColumn<Guid>(
                name: "SuperheroId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" },
                    { new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("3551e641-b698-4f81-b9e1-ece3d94bd649"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b"), "The Dark Knight" },
                    { new Guid("36d49dc5-501d-434c-aefb-607d2cb24486"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b"), "Batman Begins" },
                    { new Guid("63df450f-7511-4ec1-b485-5be3e0fabb57"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c"), "Black Widow" },
                    { new Guid("8f55948a-4b1c-4938-aee3-9590678d904f"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("d525021d-fac8-42db-b324-02fd1453f0a2"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("ea382601-6675-44f0-88cb-a0b523d386fb"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("fdac483c-e8e5-4e75-8574-2361f024a1e7"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b"), "The Dark Knight Rises" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("26433a69-7a3b-433a-9f35-5ce40347fd91"), "Sublime fighting skills.", "Fighting", new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b") },
                    { new Guid("39ec092c-0b73-41c6-9c04-c2ae827a1ad4"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c") },
                    { new Guid("741388ed-b0eb-4ba7-b892-fdb8d9b54ac7"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c") },
                    { new Guid("7cb68a63-e7aa-40eb-a7ce-47d267a44a18"), "He's always a step ahead.", "Intellect.", new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b") },
                    { new Guid("86cc456a-c5a9-407d-b416-94955ea6ecea"), "She's good at spying at people.", "Espionage", new Guid("0758c15b-4bd7-4ae7-be30-801782dd609c") },
                    { new Guid("8fcdfef8-aaa2-45e4-9f73-db92207e5564"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("2a6c5ad2-51f5-45dc-8fcd-be04d62a01e2") },
                    { new Guid("f9708e81-7b9d-4919-b38a-a4db3a2fdcb1"), "He got a lot of money", "Wealth.", new Guid("4efa1a24-21b6-4a87-bd62-8a5c3407936b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
