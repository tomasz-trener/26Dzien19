using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class addInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.021981759007m, new DateTime(2023, 5, 18, 15, 49, 5, 490, DateTimeKind.Local).AddTicks(6066), "Gorgeous Wooden Chair" },
                    { 2, "7", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, new DateTime(2023, 11, 28, 12, 27, 39, 126, DateTimeKind.Local).AddTicks(7945), "Handcrafted Steel Shoes" },
                    { 3, "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 198.083692779804m, new DateTime(2023, 3, 19, 7, 21, 22, 399, DateTimeKind.Local).AddTicks(9928), "Handmade Granite Table" },
                    { 4, "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.643399712929m, new DateTime(2023, 10, 18, 19, 34, 52, 759, DateTimeKind.Local).AddTicks(1290), "Handmade Wooden Table" },
                    { 5, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 359.887736376788m, new DateTime(2023, 4, 20, 20, 53, 4, 488, DateTimeKind.Local).AddTicks(7458), "Intelligent Steel Salad" },
                    { 6, "8", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 181.360829243139m, new DateTime(2023, 11, 2, 8, 40, 37, 598, DateTimeKind.Local).AddTicks(4728), "Handcrafted Rubber Bike" },
                    { 7, "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 938.297015022625m, new DateTime(2023, 6, 3, 7, 52, 50, 8, DateTimeKind.Local).AddTicks(4763), "Unbranded Steel Car" },
                    { 8, "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, new DateTime(2023, 8, 26, 23, 7, 17, 696, DateTimeKind.Local).AddTicks(7010), "Tasty Plastic Cheese" },
                    { 9, "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 249.172251003875m, new DateTime(2023, 2, 15, 15, 6, 33, 153, DateTimeKind.Local).AddTicks(4468), "Handcrafted Fresh Sausages" },
                    { 10, "1", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 905.322284099796m, new DateTime(2023, 12, 8, 6, 48, 42, 614, DateTimeKind.Local).AddTicks(7110), "Fantastic Frozen Gloves" },
                    { 11, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 842.480734222792m, new DateTime(2023, 10, 7, 0, 2, 46, 756, DateTimeKind.Local).AddTicks(4259), "Generic Steel Ball" },
                    { 12, "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.928430071533m, new DateTime(2023, 10, 15, 4, 34, 43, 530, DateTimeKind.Local).AddTicks(2950), "Ergonomic Rubber Car" },
                    { 13, "6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 706.948686653259m, new DateTime(2023, 9, 14, 9, 48, 12, 449, DateTimeKind.Local).AddTicks(8913), "Generic Steel Pizza" },
                    { 14, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.262494314584m, new DateTime(2023, 3, 10, 23, 0, 50, 937, DateTimeKind.Local).AddTicks(5209), "Small Metal Sausages" },
                    { 15, "2", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 378.222576259273m, new DateTime(2023, 9, 29, 16, 6, 43, 967, DateTimeKind.Local).AddTicks(2360), "Fantastic Soft Pants" },
                    { 16, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, new DateTime(2023, 1, 17, 8, 1, 32, 434, DateTimeKind.Local).AddTicks(1200), "Gorgeous Frozen Towels" },
                    { 17, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 126.128098112125m, new DateTime(2023, 8, 26, 22, 23, 4, 12, DateTimeKind.Local).AddTicks(670), "Tasty Steel Cheese" },
                    { 18, "8", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.970371435383m, new DateTime(2023, 8, 24, 0, 5, 45, 371, DateTimeKind.Local).AddTicks(3707), "Gorgeous Granite Cheese" },
                    { 19, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 913.003066283186m, new DateTime(2023, 1, 17, 11, 23, 44, 950, DateTimeKind.Local).AddTicks(7041), "Sleek Rubber Chicken" },
                    { 20, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 940.814879371698m, new DateTime(2023, 6, 10, 12, 54, 29, 433, DateTimeKind.Local).AddTicks(270), "Intelligent Wooden Salad" },
                    { 21, "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 479.41424090062m, new DateTime(2023, 8, 19, 0, 17, 23, 621, DateTimeKind.Local).AddTicks(2672), "Handcrafted Wooden Sausages" },
                    { 22, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 320.499838554068m, new DateTime(2023, 3, 31, 19, 44, 45, 891, DateTimeKind.Local).AddTicks(378), "Sleek Granite Car" },
                    { 23, "6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.915239043029m, new DateTime(2023, 7, 31, 13, 34, 53, 209, DateTimeKind.Local).AddTicks(3928), "Small Wooden Car" },
                    { 24, "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, new DateTime(2023, 9, 1, 6, 11, 12, 438, DateTimeKind.Local).AddTicks(7082), "Sleek Steel Shirt" },
                    { 25, "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.238750720974m, new DateTime(2023, 9, 17, 7, 40, 4, 2, DateTimeKind.Local).AddTicks(3518), "Incredible Frozen Mouse" },
                    { 26, "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 150.818741621831m, new DateTime(2023, 7, 13, 1, 16, 24, 125, DateTimeKind.Local).AddTicks(8769), "Incredible Wooden Chair" },
                    { 27, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.773541800572m, new DateTime(2023, 4, 3, 13, 20, 0, 122, DateTimeKind.Local).AddTicks(326), "Gorgeous Plastic Chips" },
                    { 28, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 688.245783060904m, new DateTime(2023, 6, 26, 15, 45, 55, 233, DateTimeKind.Local).AddTicks(5566), "Incredible Fresh Bacon" },
                    { 29, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 553.558320945389m, new DateTime(2023, 9, 19, 2, 16, 49, 226, DateTimeKind.Local).AddTicks(6859), "Incredible Soft Computer" },
                    { 30, "4", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 663.536718269594m, new DateTime(2023, 1, 14, 3, 12, 12, 442, DateTimeKind.Local).AddTicks(8632), "Handcrafted Rubber Bike" },
                    { 31, "2", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 922.479030014704m, new DateTime(2023, 12, 10, 1, 38, 1, 639, DateTimeKind.Local).AddTicks(6774), "Handcrafted Concrete Tuna" },
                    { 32, "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, new DateTime(2023, 9, 19, 21, 25, 27, 578, DateTimeKind.Local).AddTicks(7193), "Gorgeous Wooden Fish" },
                    { 33, "7", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 955.272407213818m, new DateTime(2023, 6, 27, 21, 54, 28, 829, DateTimeKind.Local).AddTicks(3063), "Handcrafted Frozen Keyboard" },
                    { 34, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 151.982358236323m, new DateTime(2023, 1, 24, 15, 10, 16, 668, DateTimeKind.Local).AddTicks(646), "Intelligent Plastic Chair" },
                    { 35, "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.299358334532m, new DateTime(2023, 2, 11, 20, 2, 34, 663, DateTimeKind.Local).AddTicks(336), "Unbranded Wooden Pizza" },
                    { 36, "4", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 57.7988712865854m, new DateTime(2023, 3, 3, 14, 36, 32, 196, DateTimeKind.Local).AddTicks(2122), "Gorgeous Rubber Bacon" },
                    { 37, "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 883.980300599234m, new DateTime(2023, 5, 30, 6, 9, 45, 592, DateTimeKind.Local).AddTicks(272), "Handcrafted Rubber Shirt" },
                    { 38, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 822.452619476455m, new DateTime(2023, 3, 11, 4, 11, 25, 911, DateTimeKind.Local).AddTicks(1635), "Rustic Granite Shoes" },
                    { 39, "7", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 22.2432652671092m, new DateTime(2023, 6, 5, 11, 49, 40, 470, DateTimeKind.Local).AddTicks(6773), "Sleek Granite Chair" },
                    { 40, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, new DateTime(2023, 8, 23, 8, 35, 57, 94, DateTimeKind.Local).AddTicks(4529), "Incredible Rubber Soap" },
                    { 41, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 533.504530191656m, new DateTime(2023, 10, 5, 15, 41, 19, 242, DateTimeKind.Local).AddTicks(6590), "Awesome Soft Fish" },
                    { 42, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 265.709933652407m, new DateTime(2023, 9, 27, 2, 52, 18, 672, DateTimeKind.Local).AddTicks(1892), "Intelligent Cotton Tuna" },
                    { 43, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 294.402654204239m, new DateTime(2023, 3, 21, 18, 38, 32, 228, DateTimeKind.Local).AddTicks(861), "Refined Soft Bike" },
                    { 44, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 741.648888164036m, new DateTime(2023, 3, 25, 16, 18, 57, 386, DateTimeKind.Local).AddTicks(8479), "Handmade Cotton Bacon" },
                    { 45, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.239833488706m, new DateTime(2023, 3, 3, 12, 25, 20, 456, DateTimeKind.Local).AddTicks(9989), "Small Soft Tuna" },
                    { 46, "1", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 305.894089151124m, new DateTime(2023, 7, 6, 17, 7, 32, 16, DateTimeKind.Local).AddTicks(3486), "Practical Frozen Computer" },
                    { 47, "4", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 778.911179241683m, new DateTime(2023, 3, 11, 12, 7, 6, 318, DateTimeKind.Local).AddTicks(6617), "Rustic Wooden Mouse" },
                    { 48, "2", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 318.709401070936m, new DateTime(2023, 4, 23, 8, 59, 23, 744, DateTimeKind.Local).AddTicks(6287), "Handcrafted Metal Mouse" },
                    { 49, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 463.195345650052m, new DateTime(2023, 6, 6, 13, 41, 27, 346, DateTimeKind.Local).AddTicks(5486), "Handcrafted Rubber Salad" },
                    { 50, "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 717.609017980569m, new DateTime(2023, 10, 24, 2, 50, 26, 526, DateTimeKind.Local).AddTicks(4157), "Incredible Plastic Shoes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
