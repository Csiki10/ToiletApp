﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToiletApp.Migrations
{
    public partial class pics3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab7dd8e-c5d9-4c97-9558-43c6bc7ba421");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ab7dd8e-c5d9-4c97-9558-43c6bc7ba421", 0, "d69680a1-d874-428a-9412-724594955981", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI123", "AQAAAAEAACcQAAAAECrtkoLE0xepxylv92+GJqW2CUZsQJ2X3Wjh+n5R7s2FcShpOnZIgjBynC32m63Qzw==", null, false, "d68fcff4-d58f-45d7-86a2-95371084509a", false, "csiki123" });
        }
    }
}
