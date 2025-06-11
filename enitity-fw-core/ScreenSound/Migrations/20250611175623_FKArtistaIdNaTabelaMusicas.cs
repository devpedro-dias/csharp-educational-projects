﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class FKArtistaIdNaTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 2 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 3 WHERE Id = 3");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 4 WHERE Id = 4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = NULL WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
