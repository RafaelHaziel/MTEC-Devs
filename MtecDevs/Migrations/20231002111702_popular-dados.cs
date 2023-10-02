using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "063758ad-444c-4f4b-8b57-f99534b7667d", "3b787c36-5f4e-4a8b-a801-8d683c8bb066", "Administrador", "ADMINISTRADOR" },
                    { "8f480f57-c55d-4f6d-9311-b0b195183c88", "ff139ec2-1d27-4b43-826b-b80004711330", "Usuário", "USUÁRIO" },
                    { "a9deb3d3-69ad-42f3-9737-3c6c75c28387", "03d41ece-9895-476b-ad5e-8d4500d7b43f", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "011c31ef-7e4b-4b82-8689-7a4d76cc9ede", 0, "ec0cc852-4d11-4e93-b299-eacf77e5a85d", "hazieldefato@gamil.com", true, false, null, "HAZIELDEFATO@GMAIL.COM", "HAZIEL&TITO", "AQAAAAEAACcQAAAAEPy5Zl23vcGVFMxuZidQF4E4Os/CjgHbw2ucZF64vvFJOncOcpGxVFb4Rn8QmsOiFw==", "1", true, "b4823ee6-a547-4af9-9991-2aaf6fef9871", false, "Haziel&Tito" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "FullStack" },
                    { (byte)2, "FrontEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "063758ad-444c-4f4b-8b57-f99534b7667d", "011c31ef-7e4b-4b82-8689-7a4d76cc9ede" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "011c31ef-7e4b-4b82-8689-7a4d76cc9ede", new DateTime(1111, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.jpg", "Haziel e Tito", (byte)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f480f57-c55d-4f6d-9311-b0b195183c88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9deb3d3-69ad-42f3-9737-3c6c75c28387");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "063758ad-444c-4f4b-8b57-f99534b7667d", "011c31ef-7e4b-4b82-8689-7a4d76cc9ede" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "011c31ef-7e4b-4b82-8689-7a4d76cc9ede");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "063758ad-444c-4f4b-8b57-f99534b7667d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "011c31ef-7e4b-4b82-8689-7a4d76cc9ede");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)5);
        }
    }
}
