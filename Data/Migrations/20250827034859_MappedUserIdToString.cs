using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace askfm.Data.Migrations
{
    /// <inheritdoc />
    public partial class MappedUserIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followings_AspNetUsers_UserId1",
                table: "Followings");

            migrationBuilder.DropIndex(
                name: "IX_Followings_UserId1",
                table: "Followings");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Followings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Followings",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "FollowingUserId",
                table: "Followings",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Followings_UserId",
                table: "Followings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Followings_AspNetUsers_UserId",
                table: "Followings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followings_AspNetUsers_UserId",
                table: "Followings");

            migrationBuilder.DropIndex(
                name: "IX_Followings_UserId",
                table: "Followings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Followings",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "FollowingUserId",
                table: "Followings",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Followings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Followings_UserId1",
                table: "Followings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Followings_AspNetUsers_UserId1",
                table: "Followings",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
