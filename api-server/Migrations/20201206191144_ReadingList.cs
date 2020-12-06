using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_server.Migrations
{
    public partial class ReadingList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TagsAttributed",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Articles",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.CreateTable(
                name: "ReadingLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticlesInReadingLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PreviousArticleId = table.Column<int>(type: "int", nullable: true),
                    NextArticleId = table.Column<int>(type: "int", nullable: true),
                    ReadingListId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesInReadingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticlesInReadingLists_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesInReadingLists_ReadingLists_ReadingListId",
                        column: x => x.ReadingListId,
                        principalTable: "ReadingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "ReadingLists",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title ReadingList 01", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title ReadingList 02", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title ReadingList 03", null }
                });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 123, 121, 210, 147, 193, 62, 192, 189, 233, 42, 214, 141, 22, 11, 108, 159, 123, 47, 251, 61, 62, 215, 81, 186, 156, 56, 138, 106, 78, 0, 195, 24, 248, 110, 104, 15, 80, 138, 230, 89, 192, 239, 208, 102, 203, 136, 202, 13, 9, 155, 183, 79, 3, 10, 156, 189, 171, 176, 49, 15, 88, 46, 253, 36 }, new byte[] { 107, 247, 37, 139, 52, 55, 240, 175, 44, 56, 67, 170, 9, 149, 236, 29, 48, 29, 225, 185, 62, 40, 203, 52, 129, 149, 142, 5, 20, 162, 241, 183, 42, 81, 32, 230, 119, 9, 126, 67, 59, 82, 224, 39, 7, 233, 4, 51, 93, 94, 16, 150, 191, 221, 175, 113, 235, 89, 77, 134, 237, 214, 104, 159, 235, 174, 209, 124, 23, 190, 109, 95, 210, 138, 154, 143, 187, 31, 178, 149, 3, 56, 94, 149, 70, 111, 161, 49, 56, 181, 152, 94, 187, 112, 197, 32, 172, 32, 119, 207, 236, 219, 76, 56, 163, 35, 237, 50, 236, 81, 107, 202, 214, 99, 151, 99, 253, 168, 38, 238, 14, 157, 41, 156, 98, 253, 112, 41 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 171, 208, 56, 2, 213, 245, 59, 42, 71, 71, 33, 82, 188, 24, 152, 74, 118, 250, 190, 60, 167, 0, 33, 77, 155, 175, 82, 194, 26, 233, 78, 115, 22, 32, 203, 7, 106, 235, 100, 44, 144, 76, 26, 12, 228, 174, 90, 11, 140, 160, 86, 243, 253, 157, 122, 194, 127, 222, 253, 78, 76, 101, 138, 61 }, new byte[] { 85, 44, 252, 14, 175, 222, 37, 211, 129, 154, 230, 87, 138, 69, 214, 172, 79, 250, 70, 198, 223, 24, 253, 194, 175, 175, 145, 87, 15, 207, 27, 185, 243, 14, 232, 203, 7, 153, 212, 148, 132, 139, 128, 57, 179, 45, 40, 194, 215, 136, 90, 31, 194, 177, 152, 185, 188, 242, 114, 57, 159, 149, 205, 92, 73, 124, 149, 98, 222, 165, 132, 110, 94, 194, 3, 72, 132, 220, 41, 161, 82, 255, 185, 184, 67, 251, 101, 27, 160, 19, 108, 186, 217, 218, 167, 1, 104, 8, 7, 254, 181, 223, 46, 105, 206, 166, 168, 28, 172, 209, 63, 191, 13, 50, 139, 155, 168, 108, 101, 47, 23, 85, 73, 152, 228, 180, 137, 168 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 125, 102, 88, 163, 65, 159, 100, 186, 36, 207, 219, 187, 249, 52, 55, 238, 161, 222, 183, 77, 88, 176, 61, 224, 19, 69, 103, 42, 184, 205, 166, 116, 98, 232, 130, 95, 52, 250, 226, 23, 73, 175, 18, 13, 244, 89, 196, 150, 246, 8, 127, 136, 90, 70, 6, 174, 35, 129, 80, 167, 128, 225, 252, 30 }, new byte[] { 231, 11, 220, 49, 203, 193, 24, 20, 143, 241, 105, 49, 72, 45, 235, 114, 210, 237, 131, 146, 184, 168, 125, 37, 52, 40, 188, 101, 99, 155, 28, 140, 238, 200, 161, 186, 124, 129, 229, 173, 38, 104, 23, 159, 123, 27, 101, 193, 191, 241, 94, 115, 4, 176, 25, 129, 49, 244, 77, 157, 108, 84, 15, 189, 114, 26, 44, 108, 73, 77, 70, 221, 163, 222, 149, 5, 135, 243, 80, 237, 57, 180, 9, 209, 90, 253, 169, 232, 209, 55, 233, 89, 184, 235, 59, 107, 77, 132, 160, 237, 188, 20, 65, 192, 160, 27, 71, 93, 186, 250, 67, 249, 73, 73, 110, 80, 39, 51, 136, 77, 202, 220, 62, 30, 88, 242, 223, 179 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 212, 196, 19, 40, 182, 38, 49, 212, 131, 212, 30, 191, 87, 26, 252, 190, 71, 84, 11, 129, 90, 172, 68, 130, 1, 140, 60, 148, 150, 30, 62, 155, 217, 20, 84, 195, 64, 78, 222, 236, 66, 53, 82, 199, 4, 134, 116, 91, 228, 35, 106, 243, 90, 221, 86, 249, 64, 42, 60, 133, 75, 118, 197, 68 }, new byte[] { 195, 160, 191, 205, 154, 252, 55, 95, 214, 2, 249, 220, 44, 91, 186, 228, 253, 231, 227, 226, 60, 182, 167, 177, 161, 176, 242, 231, 61, 190, 81, 86, 180, 139, 133, 92, 201, 140, 13, 128, 192, 189, 14, 216, 92, 148, 208, 137, 23, 204, 67, 183, 89, 63, 210, 209, 189, 119, 221, 136, 222, 162, 128, 58, 203, 138, 169, 245, 11, 248, 127, 227, 25, 8, 231, 106, 189, 179, 166, 114, 5, 170, 237, 215, 78, 39, 44, 238, 139, 108, 95, 117, 154, 245, 163, 103, 76, 101, 198, 186, 252, 232, 232, 236, 113, 72, 139, 16, 90, 58, 115, 63, 89, 146, 3, 75, 158, 217, 210, 105, 118, 113, 130, 37, 241, 96, 148, 35 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 69, 204, 232, 201, 181, 45, 236, 19, 217, 176, 79, 198, 82, 63, 192, 15, 130, 111, 53, 62, 164, 222, 72, 65, 188, 196, 190, 214, 167, 246, 212, 103, 253, 157, 204, 79, 67, 69, 208, 206, 103, 246, 142, 64, 52, 155, 168, 97, 243, 210, 125, 94, 117, 244, 64, 56, 112, 242, 130, 72, 208, 99, 147, 95 }, new byte[] { 59, 190, 133, 43, 226, 209, 73, 51, 253, 139, 142, 190, 210, 25, 240, 240, 64, 105, 204, 122, 36, 205, 41, 234, 12, 203, 91, 97, 30, 176, 11, 38, 188, 76, 127, 202, 37, 161, 122, 44, 229, 70, 66, 160, 166, 165, 78, 230, 32, 214, 69, 217, 204, 166, 126, 228, 45, 96, 12, 68, 42, 114, 218, 190, 44, 241, 140, 145, 80, 116, 181, 86, 55, 93, 73, 218, 203, 96, 149, 126, 223, 77, 35, 183, 12, 98, 235, 207, 156, 19, 81, 217, 188, 251, 196, 12, 203, 239, 157, 194, 166, 20, 37, 167, 126, 239, 198, 185, 230, 250, 155, 100, 151, 85, 53, 105, 39, 202, 14, 88, 44, 36, 106, 233, 63, 195, 158, 101 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 20, 255, 123, 42, 110, 192, 137, 0, 72, 183, 45, 188, 218, 140, 7, 95, 110, 157, 61, 165, 7, 106, 102, 106, 181, 120, 202, 173, 45, 140, 178, 70, 40, 97, 64, 106, 74, 206, 116, 216, 189, 90, 57, 211, 233, 113, 88, 73, 133, 23, 97, 70, 135, 122, 51, 107, 110, 26, 123, 221, 110, 253, 21, 254 }, new byte[] { 225, 147, 191, 111, 46, 7, 204, 229, 75, 27, 192, 78, 148, 102, 112, 48, 189, 50, 99, 202, 162, 187, 35, 101, 76, 172, 243, 55, 182, 37, 131, 135, 159, 29, 159, 91, 30, 137, 202, 125, 57, 116, 114, 235, 218, 120, 27, 8, 236, 231, 160, 146, 191, 157, 47, 131, 87, 113, 205, 185, 229, 238, 182, 105, 25, 157, 65, 241, 61, 217, 203, 184, 201, 212, 110, 138, 252, 1, 244, 111, 41, 196, 139, 56, 245, 191, 29, 253, 177, 211, 119, 25, 210, 62, 65, 186, 10, 171, 32, 230, 17, 95, 212, 152, 26, 86, 81, 43, 136, 31, 17, 152, 218, 193, 73, 14, 16, 50, 184, 186, 7, 104, 101, 21, 241, 22, 190, 126 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 82, 168, 118, 231, 154, 152, 102, 231, 120, 223, 99, 83, 59, 161, 26, 177, 123, 72, 57, 205, 30, 49, 119, 41, 27, 164, 197, 247, 5, 146, 206, 105, 183, 71, 46, 34, 22, 81, 253, 218, 84, 32, 249, 162, 69, 171, 238, 52, 64, 32, 3, 204, 255, 195, 125, 58, 222, 84, 120, 28, 91, 83, 35, 117 }, new byte[] { 124, 73, 245, 3, 100, 29, 45, 110, 106, 110, 132, 214, 182, 75, 116, 25, 55, 155, 94, 102, 13, 232, 41, 96, 68, 105, 124, 212, 243, 73, 113, 115, 253, 234, 40, 30, 143, 226, 161, 6, 56, 234, 207, 41, 106, 131, 53, 253, 95, 130, 109, 193, 185, 80, 23, 45, 151, 224, 20, 107, 135, 172, 110, 236, 117, 166, 233, 123, 62, 33, 131, 254, 54, 135, 27, 178, 47, 214, 75, 0, 135, 11, 61, 58, 192, 197, 65, 35, 183, 223, 108, 74, 27, 213, 155, 216, 159, 201, 134, 202, 50, 44, 60, 92, 58, 195, 71, 3, 103, 195, 129, 102, 81, 12, 132, 233, 29, 103, 21, 6, 161, 119, 248, 207, 139, 39, 191, 84 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 154, 177, 61, 9, 174, 194, 11, 78, 71, 247, 219, 205, 90, 72, 11, 233, 179, 75, 30, 29, 82, 237, 16, 190, 112, 115, 164, 149, 105, 174, 25, 185, 207, 167, 214, 243, 222, 194, 223, 124, 155, 54, 179, 14, 115, 137, 167, 44, 238, 101, 103, 141, 229, 216, 71, 57, 182, 28, 150, 175, 80, 95, 107, 138 }, new byte[] { 24, 248, 219, 58, 84, 63, 64, 82, 42, 21, 44, 179, 211, 64, 90, 26, 151, 217, 246, 201, 59, 56, 87, 7, 226, 115, 64, 145, 56, 30, 216, 127, 225, 84, 97, 109, 5, 118, 228, 212, 60, 223, 76, 127, 46, 171, 235, 226, 190, 213, 101, 53, 96, 88, 126, 180, 192, 51, 104, 123, 215, 95, 201, 9, 69, 97, 130, 216, 236, 162, 134, 3, 105, 73, 150, 69, 174, 74, 250, 50, 125, 172, 231, 26, 131, 113, 205, 191, 67, 217, 172, 153, 26, 13, 182, 41, 48, 33, 151, 219, 214, 233, 146, 178, 254, 7, 104, 251, 89, 7, 62, 222, 190, 189, 108, 197, 2, 163, 130, 89, 213, 150, 67, 72, 244, 49, 113, 17 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 111, 238, 122, 99, 177, 26, 30, 235, 254, 38, 88, 175, 73, 157, 75, 241, 113, 193, 155, 221, 190, 11, 105, 185, 229, 124, 17, 208, 108, 32, 179, 188, 139, 88, 154, 51, 119, 132, 28, 105, 7, 100, 141, 110, 212, 176, 146, 148, 193, 130, 0, 253, 14, 114, 231, 144, 170, 231, 186, 234, 76, 183, 99, 20 }, new byte[] { 130, 67, 61, 204, 0, 171, 27, 78, 33, 69, 104, 135, 12, 206, 227, 147, 70, 103, 109, 176, 65, 66, 25, 150, 246, 225, 85, 72, 127, 164, 85, 100, 180, 26, 132, 217, 94, 45, 227, 29, 4, 38, 207, 80, 234, 134, 0, 109, 210, 22, 228, 188, 210, 9, 223, 175, 119, 152, 249, 100, 192, 103, 230, 198, 182, 49, 41, 162, 155, 34, 149, 113, 225, 98, 206, 158, 143, 163, 224, 191, 158, 6, 55, 169, 104, 120, 52, 112, 65, 164, 39, 22, 54, 173, 107, 177, 190, 167, 84, 205, 253, 125, 80, 238, 133, 38, 30, 66, 223, 178, 20, 21, 97, 53, 84, 179, 162, 221, 174, 202, 243, 199, 219, 24, 30, 224, 84, 85 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 251, 25, 159, 185, 11, 60, 164, 137, 232, 248, 240, 5, 92, 67, 231, 174, 212, 37, 119, 212, 18, 158, 247, 77, 151, 176, 14, 49, 213, 39, 175, 164, 197, 141, 192, 24, 215, 34, 150, 224, 193, 217, 231, 152, 30, 202, 55, 130, 133, 235, 71, 2, 28, 178, 83, 74, 131, 188, 170, 48, 230, 169, 76, 226 }, new byte[] { 242, 134, 197, 128, 168, 239, 232, 97, 99, 11, 2, 95, 205, 13, 255, 136, 144, 77, 48, 177, 123, 5, 201, 197, 37, 206, 25, 228, 190, 0, 249, 139, 108, 95, 198, 145, 238, 117, 233, 87, 252, 173, 211, 125, 214, 104, 105, 61, 79, 110, 77, 62, 142, 128, 187, 181, 218, 244, 50, 165, 191, 156, 107, 65, 28, 228, 27, 72, 23, 142, 74, 184, 173, 121, 238, 26, 145, 159, 183, 238, 91, 87, 87, 9, 230, 68, 15, 245, 230, 162, 111, 231, 197, 240, 217, 80, 152, 195, 198, 202, 112, 82, 121, 244, 202, 114, 88, 149, 129, 90, 248, 251, 48, 207, 213, 105, 251, 176, 35, 196, 155, 194, 1, 81, 52, 212, 211, 56 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 59, 236, 181, 231, 250, 25, 210, 57, 147, 47, 215, 175, 20, 121, 219, 7, 42, 160, 237, 222, 178, 68, 150, 22, 246, 250, 44, 215, 66, 210, 45, 93, 118, 67, 143, 2, 9, 41, 178, 164, 45, 229, 205, 6, 48, 96, 101, 129, 176, 123, 207, 103, 239, 251, 197, 23, 177, 146, 132, 48, 48, 144, 81, 94 }, new byte[] { 190, 67, 121, 200, 116, 250, 139, 60, 86, 66, 179, 14, 174, 247, 106, 214, 239, 163, 110, 90, 62, 95, 215, 162, 150, 0, 109, 41, 132, 177, 92, 103, 179, 64, 97, 72, 220, 223, 69, 41, 151, 161, 225, 35, 51, 203, 86, 217, 51, 139, 160, 97, 129, 82, 243, 201, 135, 213, 173, 205, 35, 2, 22, 52, 52, 212, 179, 117, 244, 98, 44, 94, 25, 247, 239, 192, 239, 89, 106, 108, 202, 242, 216, 213, 54, 210, 194, 226, 36, 180, 191, 59, 80, 184, 246, 116, 240, 146, 3, 154, 60, 224, 23, 167, 218, 27, 71, 246, 241, 4, 126, 83, 117, 168, 154, 21, 193, 150, 168, 69, 231, 122, 223, 38, 160, 118, 38, 93 }, null });

            migrationBuilder.InsertData(
                table: "ArticlesInReadingLists",
                columns: new[] { "Id", "ArticleId", "CreatedAt", "NextArticleId", "PreviousArticleId", "ReadingListId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, null },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, null },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, null },
                    { 4, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, 2, null },
                    { 5, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2, null },
                    { 6, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, 3, null },
                    { 7, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 11, 3, null },
                    { 8, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 12, 3, null },
                    { 9, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 13, 3, null },
                    { 10, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesInReadingLists_ArticleId",
                table: "ArticlesInReadingLists",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesInReadingLists_ReadingListId",
                table: "ArticlesInReadingLists",
                column: "ReadingListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingLists_Name",
                table: "ReadingLists",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesInReadingLists");

            migrationBuilder.DropTable(
                name: "ReadingLists");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TagsAttributed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Articles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(2690), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3300), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3330), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3350), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3360), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3370), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3370), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3380), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3390), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3400), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3400), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3410), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3420), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3430), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 794, DateTimeKind.Local).AddTicks(8190), new DateTime(2020, 8, 24, 10, 43, 2, 804, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(440), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(480), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(490), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(500), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(510), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(520), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(520), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(530), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(540), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(550), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(560), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(560), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(570), new DateTime(2020, 8, 24, 10, 43, 2, 805, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5770), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5880), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5880), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5890), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5900), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5910), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5910), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5920), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5930), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5940), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5940), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5950), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5960), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5960), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5970), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5980), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5980), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5990), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6000), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6000), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6010), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6020), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6020), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6030), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6030), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6040), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6050), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "TagsAttributed",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6050), new DateTime(2020, 8, 24, 10, 43, 2, 811, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7840), new byte[] { 238, 123, 87, 113, 69, 57, 182, 218, 48, 223, 26, 18, 1, 39, 192, 186, 244, 119, 54, 207, 240, 142, 54, 203, 140, 166, 206, 93, 136, 64, 68, 196, 2, 232, 251, 247, 145, 174, 99, 53, 154, 230, 209, 244, 126, 66, 145, 50, 81, 228, 187, 21, 48, 160, 170, 206, 234, 220, 241, 119, 76, 244, 192, 9 }, new byte[] { 25, 179, 197, 218, 83, 54, 12, 84, 55, 105, 141, 147, 177, 190, 164, 225, 117, 170, 218, 133, 105, 165, 114, 81, 11, 131, 190, 24, 34, 19, 36, 222, 85, 151, 60, 77, 230, 245, 145, 136, 131, 196, 141, 252, 124, 29, 224, 148, 150, 105, 215, 14, 86, 48, 84, 59, 115, 129, 22, 150, 225, 157, 248, 78, 86, 1, 186, 97, 154, 93, 153, 237, 91, 133, 15, 135, 84, 196, 39, 44, 97, 82, 244, 16, 64, 64, 177, 168, 195, 155, 128, 178, 78, 110, 240, 106, 250, 44, 175, 76, 83, 141, 195, 108, 176, 227, 225, 1, 15, 247, 32, 193, 70, 125, 20, 186, 200, 99, 163, 233, 142, 201, 8, 13, 92, 91, 225, 21 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7960), new byte[] { 126, 124, 215, 161, 132, 65, 73, 234, 50, 125, 110, 208, 253, 248, 64, 96, 148, 119, 98, 186, 35, 246, 185, 50, 4, 180, 147, 212, 151, 240, 8, 130, 21, 208, 60, 222, 127, 115, 204, 129, 255, 220, 251, 114, 29, 8, 119, 34, 114, 193, 231, 157, 41, 108, 127, 27, 53, 157, 117, 188, 166, 119, 61, 134 }, new byte[] { 177, 32, 10, 66, 215, 247, 183, 93, 50, 202, 210, 120, 244, 241, 119, 67, 229, 133, 228, 228, 176, 66, 51, 121, 246, 247, 138, 24, 224, 85, 62, 97, 215, 78, 39, 203, 112, 199, 144, 140, 209, 127, 212, 202, 13, 123, 114, 61, 35, 108, 171, 192, 0, 206, 252, 60, 51, 183, 115, 218, 104, 196, 16, 145, 168, 253, 147, 17, 248, 223, 30, 130, 133, 36, 226, 155, 39, 175, 5, 84, 86, 87, 238, 154, 248, 170, 236, 227, 165, 8, 180, 126, 192, 174, 236, 226, 221, 57, 60, 201, 220, 213, 58, 146, 235, 167, 70, 134, 38, 219, 105, 150, 139, 111, 205, 156, 47, 82, 174, 119, 54, 30, 188, 200, 247, 138, 80, 250 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7970), new byte[] { 61, 19, 69, 134, 135, 35, 72, 84, 164, 176, 73, 2, 117, 217, 52, 62, 82, 179, 164, 36, 220, 150, 18, 78, 170, 42, 72, 154, 101, 56, 48, 188, 160, 233, 107, 31, 139, 152, 64, 187, 133, 125, 148, 107, 88, 218, 234, 165, 1, 9, 170, 75, 29, 3, 122, 31, 142, 27, 138, 32, 84, 191, 114, 203 }, new byte[] { 35, 0, 204, 118, 140, 69, 208, 198, 43, 186, 177, 25, 173, 36, 74, 47, 168, 126, 125, 195, 148, 61, 123, 141, 233, 141, 27, 239, 172, 187, 178, 203, 110, 20, 217, 238, 198, 204, 18, 204, 200, 63, 83, 27, 140, 168, 226, 227, 219, 113, 54, 194, 83, 36, 199, 163, 11, 6, 165, 217, 228, 108, 229, 166, 226, 1, 226, 180, 155, 215, 16, 4, 6, 165, 26, 100, 80, 147, 244, 235, 105, 112, 214, 190, 139, 228, 6, 53, 55, 19, 96, 128, 213, 8, 98, 168, 34, 49, 108, 212, 37, 83, 84, 76, 172, 158, 59, 237, 202, 191, 246, 231, 85, 239, 1, 1, 71, 113, 241, 85, 57, 190, 152, 87, 253, 98, 71, 176 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8060), new byte[] { 139, 54, 108, 136, 251, 123, 46, 135, 78, 5, 9, 22, 208, 209, 147, 152, 116, 49, 220, 82, 248, 49, 96, 82, 207, 72, 95, 161, 73, 237, 20, 175, 168, 209, 15, 154, 37, 159, 26, 24, 112, 26, 233, 187, 100, 184, 3, 119, 139, 215, 66, 181, 3, 133, 163, 17, 94, 143, 104, 225, 3, 111, 46, 90 }, new byte[] { 71, 78, 12, 102, 98, 208, 202, 19, 56, 34, 7, 118, 202, 75, 0, 70, 254, 119, 208, 87, 199, 47, 52, 86, 74, 250, 145, 5, 56, 174, 65, 234, 248, 8, 93, 190, 175, 153, 149, 75, 196, 253, 200, 104, 164, 210, 27, 144, 77, 8, 183, 121, 135, 115, 82, 99, 109, 175, 46, 241, 93, 121, 32, 173, 75, 136, 68, 130, 92, 135, 169, 54, 199, 18, 82, 42, 65, 197, 146, 146, 62, 104, 244, 107, 167, 57, 92, 10, 29, 138, 101, 244, 115, 1, 56, 112, 204, 139, 128, 57, 198, 246, 110, 56, 127, 44, 204, 210, 199, 181, 20, 58, 32, 250, 79, 209, 197, 203, 161, 136, 132, 188, 18, 122, 249, 205, 157, 111 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8060), new byte[] { 32, 152, 210, 185, 21, 186, 23, 24, 249, 94, 110, 102, 132, 190, 172, 19, 31, 202, 195, 170, 94, 151, 96, 100, 59, 131, 85, 66, 157, 230, 226, 157, 43, 124, 20, 93, 127, 164, 73, 10, 233, 94, 246, 46, 61, 175, 1, 42, 167, 205, 114, 35, 22, 6, 53, 218, 46, 222, 58, 2, 74, 25, 125, 69 }, new byte[] { 48, 86, 188, 47, 189, 232, 223, 13, 161, 182, 101, 49, 96, 201, 75, 215, 113, 4, 90, 227, 87, 42, 222, 68, 104, 103, 21, 104, 180, 207, 70, 162, 128, 27, 238, 250, 83, 113, 12, 114, 205, 28, 19, 34, 193, 34, 223, 246, 254, 222, 202, 100, 178, 206, 34, 17, 216, 0, 111, 134, 25, 152, 179, 227, 88, 249, 159, 31, 195, 132, 15, 239, 139, 100, 99, 230, 180, 172, 197, 254, 224, 218, 143, 251, 141, 147, 232, 227, 229, 164, 9, 168, 127, 198, 133, 246, 72, 131, 144, 58, 114, 113, 191, 31, 91, 145, 184, 28, 230, 92, 136, 85, 56, 45, 68, 224, 201, 64, 13, 120, 92, 78, 19, 94, 194, 196, 60, 127 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8080), new byte[] { 47, 197, 111, 192, 108, 149, 148, 154, 61, 98, 93, 132, 113, 31, 41, 46, 112, 54, 193, 254, 26, 53, 109, 160, 92, 10, 236, 102, 144, 209, 16, 94, 215, 245, 36, 51, 174, 196, 244, 55, 60, 138, 196, 104, 205, 85, 62, 77, 3, 12, 228, 62, 117, 17, 8, 38, 134, 150, 121, 125, 235, 207, 160, 196 }, new byte[] { 57, 63, 11, 245, 250, 164, 86, 8, 132, 140, 53, 224, 66, 52, 196, 76, 172, 121, 99, 81, 16, 15, 149, 222, 153, 48, 176, 11, 146, 169, 155, 113, 245, 97, 216, 100, 234, 247, 118, 91, 210, 150, 235, 91, 113, 154, 147, 172, 175, 148, 235, 69, 234, 199, 57, 170, 15, 79, 84, 188, 130, 37, 86, 220, 58, 190, 234, 51, 246, 170, 153, 192, 172, 215, 10, 172, 89, 120, 142, 239, 90, 67, 13, 113, 174, 92, 133, 161, 5, 173, 159, 19, 5, 122, 234, 170, 30, 97, 38, 79, 177, 121, 200, 50, 83, 92, 13, 253, 245, 164, 59, 126, 188, 217, 99, 250, 73, 31, 249, 231, 226, 42, 9, 67, 89, 39, 56, 244 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8080), new byte[] { 236, 182, 199, 239, 40, 101, 14, 231, 180, 144, 91, 53, 202, 4, 161, 28, 235, 222, 141, 133, 132, 130, 106, 80, 99, 101, 117, 255, 228, 132, 59, 247, 195, 172, 87, 127, 10, 211, 79, 166, 164, 101, 77, 97, 251, 217, 76, 161, 215, 118, 37, 162, 185, 59, 173, 99, 104, 146, 72, 185, 89, 78, 37, 84 }, new byte[] { 157, 194, 113, 95, 212, 53, 42, 166, 111, 56, 58, 179, 215, 153, 83, 40, 55, 255, 126, 120, 120, 156, 152, 248, 190, 115, 188, 147, 23, 169, 108, 210, 22, 92, 19, 173, 117, 199, 131, 241, 128, 230, 158, 244, 81, 111, 201, 248, 90, 162, 151, 207, 241, 104, 122, 170, 55, 97, 192, 133, 112, 212, 99, 172, 121, 176, 172, 229, 32, 10, 92, 231, 243, 82, 185, 130, 236, 132, 164, 226, 200, 247, 149, 41, 128, 103, 94, 169, 45, 90, 151, 158, 41, 90, 7, 1, 151, 191, 233, 197, 194, 238, 123, 171, 88, 34, 199, 236, 144, 156, 213, 192, 130, 26, 42, 96, 9, 91, 148, 162, 135, 4, 187, 141, 239, 85, 179, 63 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8090), new byte[] { 198, 43, 196, 241, 234, 156, 233, 42, 12, 87, 48, 197, 103, 81, 126, 59, 134, 166, 69, 178, 241, 213, 106, 92, 108, 100, 164, 95, 169, 144, 163, 137, 210, 214, 214, 9, 162, 77, 74, 230, 192, 156, 192, 28, 17, 163, 179, 242, 246, 166, 41, 97, 225, 41, 79, 216, 13, 113, 24, 7, 43, 155, 77, 142 }, new byte[] { 38, 183, 63, 136, 231, 41, 10, 53, 113, 41, 240, 163, 166, 183, 201, 68, 213, 162, 120, 130, 21, 197, 105, 112, 28, 213, 100, 163, 211, 152, 195, 113, 52, 12, 62, 255, 211, 124, 211, 222, 178, 118, 45, 150, 145, 109, 239, 171, 152, 71, 56, 27, 0, 170, 154, 36, 165, 187, 83, 100, 6, 28, 76, 110, 51, 116, 144, 163, 201, 52, 168, 238, 103, 143, 190, 211, 237, 170, 77, 0, 63, 180, 176, 222, 124, 14, 153, 107, 140, 170, 126, 25, 246, 131, 51, 196, 21, 62, 239, 4, 81, 42, 228, 169, 33, 219, 40, 226, 248, 19, 12, 167, 190, 148, 155, 134, 109, 94, 25, 98, 86, 186, 182, 98, 181, 22, 147, 179 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8100), new byte[] { 178, 204, 78, 19, 136, 12, 216, 167, 242, 13, 127, 46, 3, 20, 157, 20, 118, 86, 170, 161, 184, 149, 245, 25, 91, 238, 43, 5, 205, 165, 170, 2, 200, 219, 108, 175, 49, 130, 103, 210, 50, 135, 213, 82, 118, 196, 217, 183, 39, 41, 197, 131, 48, 38, 136, 50, 233, 232, 206, 242, 202, 219, 204, 55 }, new byte[] { 182, 205, 239, 162, 250, 241, 128, 198, 13, 165, 121, 107, 247, 35, 207, 120, 41, 35, 145, 114, 253, 73, 129, 166, 231, 125, 96, 236, 206, 105, 96, 160, 161, 54, 57, 192, 55, 59, 143, 125, 209, 247, 245, 119, 1, 248, 79, 77, 222, 7, 28, 3, 90, 171, 147, 66, 38, 45, 167, 208, 181, 242, 53, 35, 179, 241, 225, 136, 124, 113, 253, 214, 241, 15, 238, 121, 65, 177, 137, 78, 185, 203, 156, 232, 231, 98, 222, 14, 113, 48, 192, 209, 211, 123, 138, 132, 190, 161, 162, 61, 236, 145, 169, 166, 206, 59, 167, 197, 119, 216, 205, 119, 28, 232, 95, 74, 22, 11, 238, 207, 248, 217, 236, 105, 138, 101, 26, 137 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8110), new byte[] { 56, 156, 144, 180, 140, 23, 223, 220, 39, 162, 224, 85, 177, 245, 98, 214, 28, 121, 75, 168, 81, 114, 182, 77, 200, 223, 38, 60, 3, 219, 231, 250, 3, 183, 137, 136, 184, 49, 149, 233, 136, 66, 81, 254, 236, 162, 232, 57, 157, 242, 173, 209, 181, 242, 98, 0, 61, 174, 35, 243, 249, 102, 191, 32 }, new byte[] { 232, 254, 81, 104, 88, 147, 205, 112, 246, 158, 170, 136, 74, 213, 124, 32, 40, 182, 242, 115, 22, 120, 128, 96, 67, 50, 110, 14, 61, 45, 3, 164, 210, 77, 111, 50, 203, 67, 16, 142, 223, 157, 230, 46, 207, 222, 112, 40, 254, 31, 101, 243, 126, 235, 54, 81, 103, 244, 16, 103, 34, 198, 65, 223, 135, 211, 61, 30, 77, 95, 58, 43, 206, 79, 21, 73, 92, 226, 213, 215, 243, 249, 40, 19, 1, 84, 18, 119, 11, 239, 23, 141, 184, 109, 250, 197, 10, 133, 191, 81, 225, 109, 80, 104, 70, 234, 2, 182, 220, 254, 35, 198, 233, 131, 71, 28, 83, 34, 21, 165, 33, 93, 90, 86, 70, 193, 98, 2 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8110), new byte[] { 5, 32, 231, 29, 126, 204, 7, 146, 61, 6, 20, 181, 95, 69, 187, 63, 165, 251, 198, 59, 19, 181, 163, 11, 187, 169, 44, 231, 169, 72, 182, 233, 100, 29, 46, 212, 146, 173, 156, 199, 86, 128, 23, 186, 180, 136, 169, 214, 20, 27, 139, 143, 87, 247, 46, 32, 219, 188, 80, 189, 111, 147, 236, 179 }, new byte[] { 36, 25, 41, 101, 186, 11, 42, 137, 191, 129, 209, 212, 13, 244, 176, 249, 220, 165, 51, 36, 254, 58, 233, 253, 122, 185, 90, 142, 240, 223, 24, 151, 1, 26, 170, 88, 204, 141, 133, 187, 183, 208, 107, 225, 198, 15, 234, 100, 17, 192, 86, 34, 140, 118, 69, 163, 62, 201, 46, 48, 235, 60, 110, 185, 209, 81, 28, 59, 244, 239, 93, 240, 39, 118, 124, 133, 129, 48, 142, 77, 1, 133, 187, 147, 25, 111, 175, 161, 125, 1, 244, 143, 216, 83, 94, 109, 82, 100, 111, 170, 155, 144, 44, 95, 32, 105, 39, 102, 22, 186, 6, 177, 77, 116, 158, 136, 235, 81, 19, 164, 251, 30, 159, 27, 105, 3, 122, 28 }, new DateTime(2020, 8, 24, 10, 43, 2, 806, DateTimeKind.Local).AddTicks(8120) });
        }
    }
}
