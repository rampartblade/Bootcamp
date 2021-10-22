using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace OnlineDebitApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCardDetails",
                columns: table => new
                {
                    paymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    cardOwnerName = table.Column<string>(type: "text", nullable: true),
                    cardNumber = table.Column<string>(type: "text", nullable: true),
                    expirationDate = table.Column<string>(type: "text", nullable: true),
                    securityCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardDetails", x => x.paymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCardDetails");
        }
    }
}
