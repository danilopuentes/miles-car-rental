﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesCarRentalApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAvailabilityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityHour",
                table: "Availabilities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "AvailabilityHour",
                table: "Availabilities",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
