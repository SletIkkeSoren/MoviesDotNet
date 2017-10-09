using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Movies.Migrations
{
    public partial class hej : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cast_CastId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CastId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CastId",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Cast",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Cast",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActorAge = table.Column<int>(type: "int", nullable: false),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cast_ActorId",
                table: "Cast",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cast_MovieId",
                table: "Cast",
                column: "MovieId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Actor_ActorId",
                table: "Cast",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Actor_ActorId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Cast_ActorId",
                table: "Cast");

            migrationBuilder.DropIndex(
                name: "IX_Cast_MovieId",
                table: "Cast");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Cast");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Cast");

            migrationBuilder.AddColumn<int>(
                name: "CastId",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CastId",
                table: "Movie",
                column: "CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cast_CastId",
                table: "Movie",
                column: "CastId",
                principalTable: "Cast",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
