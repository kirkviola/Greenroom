using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Greenroom.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateFieldsForAssignmentAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Assignments",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(2023, 6, 30, 11, 28, 37, 456, DateTimeKind.Local).AddTicks(526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Assignments",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(2023, 6, 30, 11, 28, 37, 456, DateTimeKind.Local).AddTicks(92),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Assignments",
                type: "datetime2",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssignmentResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 30, 11, 28, 37, 456, DateTimeKind.Local).AddTicks(2225));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssignmentResponses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Assignments",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true,
                oldDefaultValue: new DateTime(2023, 6, 30, 11, 28, 37, 456, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Assignments",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true,
                oldDefaultValue: new DateTime(2023, 6, 30, 11, 28, 37, 456, DateTimeKind.Local).AddTicks(92));
        }
    }
}
