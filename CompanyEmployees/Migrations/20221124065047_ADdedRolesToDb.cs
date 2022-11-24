using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class ADdedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cb37218d-4722-4f7f-ad78-bc7bc44a7073", "8f4f5711-f68d-4ef0-8653-dd1c2bfb54fe", "Administrator", "ADMINISTRATOR" },
                    { "d6c34ceb-b762-434b-87c1-07b523b06b71", "dd196517-d843-47d6-a7d4-b136f0ad0c30", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb37218d-4722-4f7f-ad78-bc7bc44a7073");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6c34ceb-b762-434b-87c1-07b523b06b71");
        }
    }
}
