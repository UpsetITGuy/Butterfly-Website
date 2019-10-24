using Microsoft.EntityFrameworkCore.Migrations;

namespace ButterflyWebsite.Data.Migrations
{
    public partial class collections2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "Collections");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Accuracy",
                table: "Collections",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
