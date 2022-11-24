using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrphQL.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0ce2b1fd-6e24-4e2e-a7a2-0d598341c258"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("2d17334c-054e-4451-b12a-809c249246c3"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("6efb4165-9451-4c3e-80d9-0282a77ffa00"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("9677a4ed-66b8-4ab7-afce-e657cd472a65"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("b1e4fcb6-c0a3-49b6-87dd-346dbd3f3472"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("d2a9ef3a-72ae-4354-a5d4-a9ad1e6142c3"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("f2aeaaab-ec1a-487b-ac94-45bd323f7fd4"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("667ffa57-5b82-4636-a522-1d70e0a4e43d"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("6ff0b876-96fb-4bc0-8839-91de30bf1c53"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("f7768ca5-1ebc-4810-b768-30a7f13b6c1b"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0f0ff7b3-b7d5-4444-867b-6996c2b8cdc2"), "He got a lot of money", "Wealth.", new Guid("6ff0b876-96fb-4bc0-8839-91de30bf1c53") },
                    { new Guid("1f01066f-a2fc-43e2-af92-e4e6fdc768ee"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("667ffa57-5b82-4636-a522-1d70e0a4e43d") },
                    { new Guid("44040c93-ae7e-41ce-9363-3f2731e47625"), "She's good at spying at people.", "Espionage", new Guid("667ffa57-5b82-4636-a522-1d70e0a4e43d") },
                    { new Guid("62303d4d-8825-4ba4-b28d-355db5d13751"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("f7768ca5-1ebc-4810-b768-30a7f13b6c1b") },
                    { new Guid("738b5650-aadd-46f5-af61-ce936389038b"), "Sublime fighting skills.", "Fighting", new Guid("6ff0b876-96fb-4bc0-8839-91de30bf1c53") },
                    { new Guid("7ad6aa25-63a9-4b5e-b4ed-bfbbb03c5bae"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("667ffa57-5b82-4636-a522-1d70e0a4e43d") },
                    { new Guid("9e787e51-85e1-4340-8cd5-a06b0f704424"), "He's always a step ahead.", "Intellect.", new Guid("6ff0b876-96fb-4bc0-8839-91de30bf1c53") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0ce2b1fd-6e24-4e2e-a7a2-0d598341c258"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2d17334c-054e-4451-b12a-809c249246c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6efb4165-9451-4c3e-80d9-0282a77ffa00"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9677a4ed-66b8-4ab7-afce-e657cd472a65"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1e4fcb6-c0a3-49b6-87dd-346dbd3f3472"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d2a9ef3a-72ae-4354-a5d4-a9ad1e6142c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f2aeaaab-ec1a-487b-ac94-45bd323f7fd4"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0f0ff7b3-b7d5-4444-867b-6996c2b8cdc2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("1f01066f-a2fc-43e2-af92-e4e6fdc768ee"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("44040c93-ae7e-41ce-9363-3f2731e47625"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("62303d4d-8825-4ba4-b28d-355db5d13751"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("738b5650-aadd-46f5-af61-ce936389038b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7ad6aa25-63a9-4b5e-b4ed-bfbbb03c5bae"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9e787e51-85e1-4340-8cd5-a06b0f704424"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("667ffa57-5b82-4636-a522-1d70e0a4e43d"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("6ff0b876-96fb-4bc0-8839-91de30bf1c53"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("f7768ca5-1ebc-4810-b768-30a7f13b6c1b"));

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
    }
}
