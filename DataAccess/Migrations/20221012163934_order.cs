using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445123-a24d-4543-a6c6-9443d048c222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395d9a20-4ce1-4c40-9381-1cc235cb02bc", "AQAAAAEAACcQAAAAEHRN5fiEZlfYIN/2B4ray7sM/OwPgksYeEYjmJX4S0G4mOmy4b53c7ZP/ixRkygD/g==", "9bae316a-9c37-4942-a87e-7357bf0412b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048c111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbb9d24c-c540-43ca-b216-ca2a57b94757", "AQAAAAEAACcQAAAAEHt5hGtYqxkx3OYpCJ/ueR/eROEpxZ0VisHiFiqZcmh1Hwi+khUOZN5uP3rx2IK/bw==", "6dd52ca5-e51b-4e43-bd81-4a51b9c6d9b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445123-a24d-4543-a6c6-9443d048c222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d71419e-94b6-4a48-b1a3-2171a1804d83", "AQAAAAEAACcQAAAAEHvFoNoEtoguGCya3fpD7Z1TLAvE8L/Y8yc9cETHIajiQqEe2Gz7g491mA4T28wUxA==", "fb3faadf-36c9-4e82-b074-5be59e7f6c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048c111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b2ad579-2bf2-42be-8977-2e8233a6261d", "AQAAAAEAACcQAAAAED79aW6jKgEbZsxfzs7lNLL1Awj7cy+znUXvF0fdvfrJzaiVTcPZLEmiywfWbK7Ojg==", "57c1dfe1-f059-4db2-93f1-3c5e8359eb2d" });
        }
    }
}
