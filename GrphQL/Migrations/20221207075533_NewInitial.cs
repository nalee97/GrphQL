using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrphQL.Migrations
{
    /// <inheritdoc />
    public partial class NewInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("295a9982-ed8c-48f0-833c-60aedebb8867"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("46a858c5-d6a0-4721-8a38-48980b7a4245"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4c9c28dd-9b0c-4d72-98c7-acf9db4dabfa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("579dd8d8-ac82-4c2c-af49-938e11d39e9d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a56fc1a-1fae-4827-95ce-88b1c3373add"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7ba47100-0fa4-4805-b395-c753bf587676"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a7b25415-98d1-4bc2-98b0-ff7440dc5c63"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("26ef2e1d-e65d-4432-a3f2-5a59bd993456"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9c0b176d-72f9-412c-828e-040c44734c89"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("ca14c867-cbe2-4c59-b681-eee93bf75b95"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("021e7292-f206-4ce9-8e40-8032638cf333"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("091683d3-cd73-4f2f-90e0-ea90460180c2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("136fe378-e9ca-4f3b-9f9d-d73331c73771"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3b3ff6da-4946-43dc-bf4c-108e619c8f4b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("74fd5a68-358c-4016-93a7-9b540631f3b4"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("803556fa-93f1-4037-abc8-be9dcb0433ca"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cb1214b3-bf81-47d8-ae8d-c991b8f96a39"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("2da39650-695f-4671-862b-be8e07e34426"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("38b93dce-462a-4400-a7c2-67f1058f191b"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("57826eb4-2604-4e49-8fa9-2f410a9dd402"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("65608795-b419-4720-918c-a7edd7dc66dd"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("7b18ce1e-3ae7-455e-b98f-64ac139fac30"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("a30b2410-f396-4ef5-aa42-07900bf0b09d"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("fcf8fa46-c075-4a7f-a5c8-65ef5f78fdb5"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("3188d9ad-cee9-4592-af26-b478d12f0a02"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("473e10b2-54d8-4319-b66a-f4ef16e11bd4"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("492d51f5-1611-41a6-a7aa-9afc1561ebc2"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower" },
                values: new object[,]
                {
                    { new Guid("20a71dbd-f8cf-4660-9cc5-f77558275be9"), "The knowledge of how to undermine others.", "Subterfuge" },
                    { new Guid("24b2f79e-bfbf-4672-b765-afce594863d7"), "She's good at spying at people.", "Espionage" },
                    { new Guid("2ed4f87b-a06c-49d7-9b89-37c22dcc0e13"), "Sublime fighting skills.", "Fighting" },
                    { new Guid("487b0da5-a8f6-4beb-adce-c4eb9bc95ec7"), "He got a lot of money", "Wealth." },
                    { new Guid("8032e1fc-c747-45b9-b80f-a1a462ed757b"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power." },
                    { new Guid("cc0e23b1-2f8b-417c-8125-a329f8536654"), "She knows how to infiltrate the enemy.", "Infiltration" },
                    { new Guid("cd351665-5941-4ab1-a448-ecec24ad8729"), "He's always a step ahead.", "Intellect." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2da39650-695f-4671-862b-be8e07e34426"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("38b93dce-462a-4400-a7c2-67f1058f191b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("57826eb4-2604-4e49-8fa9-2f410a9dd402"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65608795-b419-4720-918c-a7edd7dc66dd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7b18ce1e-3ae7-455e-b98f-64ac139fac30"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a30b2410-f396-4ef5-aa42-07900bf0b09d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fcf8fa46-c075-4a7f-a5c8-65ef5f78fdb5"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("3188d9ad-cee9-4592-af26-b478d12f0a02"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("473e10b2-54d8-4319-b66a-f4ef16e11bd4"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("492d51f5-1611-41a6-a7aa-9afc1561ebc2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("20a71dbd-f8cf-4660-9cc5-f77558275be9"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("24b2f79e-bfbf-4672-b765-afce594863d7"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("2ed4f87b-a06c-49d7-9b89-37c22dcc0e13"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("487b0da5-a8f6-4beb-adce-c4eb9bc95ec7"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("8032e1fc-c747-45b9-b80f-a1a462ed757b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cc0e23b1-2f8b-417c-8125-a329f8536654"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cd351665-5941-4ab1-a448-ecec24ad8729"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("295a9982-ed8c-48f0-833c-60aedebb8867"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" },
                    { new Guid("46a858c5-d6a0-4721-8a38-48980b7a4245"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("4c9c28dd-9b0c-4d72-98c7-acf9db4dabfa"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("579dd8d8-ac82-4c2c-af49-938e11d39e9d"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" },
                    { new Guid("7a56fc1a-1fae-4827-95ce-88b1c3373add"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" },
                    { new Guid("7ba47100-0fa4-4805-b395-c753bf587676"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("a7b25415-98d1-4bc2-98b0-ff7440dc5c63"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("26ef2e1d-e65d-4432-a3f2-5a59bd993456"), "Luke Skywalker is a fictional character and the main protagonist of the original film trilogy of the Star Wars franchise created by George Lucas. He is portrayed by Mark Hamill in the original trilogy and by Hayden Christensen in the prequel trilogy.", "5'11", "Luke Skywalker" },
                    { new Guid("9c0b176d-72f9-412c-828e-040c44734c89"), "Batman is a superhero who appears in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and first appeared in Detective Comics #27 (May 1939). Originally", "6'2", "Batman" },
                    { new Guid("ca14c867-cbe2-4c59-b681-eee93bf75b95"), "Superman is a fictional superhero appearing in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, high school students living in Cleveland, Ohio, in 1933.", "6'3", "Superman" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower" },
                values: new object[,]
                {
                    { new Guid("021e7292-f206-4ce9-8e40-8032638cf333"), "She knows how to infiltrate the enemy.", "Infiltration" },
                    { new Guid("091683d3-cd73-4f2f-90e0-ea90460180c2"), "He got a lot of money", "Wealth." },
                    { new Guid("136fe378-e9ca-4f3b-9f9d-d73331c73771"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power." },
                    { new Guid("3b3ff6da-4946-43dc-bf4c-108e619c8f4b"), "Sublime fighting skills.", "Fighting" },
                    { new Guid("74fd5a68-358c-4016-93a7-9b540631f3b4"), "She's good at spying at people.", "Espionage" },
                    { new Guid("803556fa-93f1-4037-abc8-be9dcb0433ca"), "The knowledge of how to undermine others.", "Subterfuge" },
                    { new Guid("cb1214b3-bf81-47d8-ae8d-c991b8f96a39"), "He's always a step ahead.", "Intellect." }
                });
        }
    }
}
