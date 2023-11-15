using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Media_System.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "Posts",
                type: "time(3)",
                precision: 3,
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(7)",
                oldPrecision: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "Posts",
                type: "time(7)",
                precision: 7,
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(3)",
                oldPrecision: 3);
        }
    }
}
