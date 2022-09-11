﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace report_project.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reportTitle1",
                table: "reports",
                newName: "reportTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reportTitle",
                table: "reports",
                newName: "reportTitle1");
        }
    }
}
