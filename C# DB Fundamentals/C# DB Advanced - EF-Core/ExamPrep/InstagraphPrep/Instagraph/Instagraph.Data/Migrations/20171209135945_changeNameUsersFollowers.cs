using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Instagraph.Data.Migrations
{
    public partial class changeNameUsersFollowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowers_Users_FollowerId",
                table: "UserFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowers_Users_UserId",
                table: "UserFollowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFollowers",
                table: "UserFollowers");

            migrationBuilder.RenameTable(
                name: "UserFollowers",
                newName: "UsersFollowers");

            migrationBuilder.RenameIndex(
                name: "IX_UserFollowers_FollowerId",
                table: "UsersFollowers",
                newName: "IX_UsersFollowers_FollowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersFollowers",
                table: "UsersFollowers",
                columns: new[] { "UserId", "FollowerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_Users_FollowerId",
                table: "UsersFollowers",
                column: "FollowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_Users_UserId",
                table: "UsersFollowers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_Users_FollowerId",
                table: "UsersFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_Users_UserId",
                table: "UsersFollowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersFollowers",
                table: "UsersFollowers");

            migrationBuilder.RenameTable(
                name: "UsersFollowers",
                newName: "UserFollowers");

            migrationBuilder.RenameIndex(
                name: "IX_UsersFollowers_FollowerId",
                table: "UserFollowers",
                newName: "IX_UserFollowers_FollowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFollowers",
                table: "UserFollowers",
                columns: new[] { "UserId", "FollowerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowers_Users_FollowerId",
                table: "UserFollowers",
                column: "FollowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowers_Users_UserId",
                table: "UserFollowers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
