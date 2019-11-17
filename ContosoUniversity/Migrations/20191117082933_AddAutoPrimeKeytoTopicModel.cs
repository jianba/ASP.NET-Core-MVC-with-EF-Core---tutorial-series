using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class AddAutoPrimeKeytoTopicModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Topic_TopicId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_TopicId",
                table: "Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Post_TopicId",
                table: "Post",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Topic_TopicId",
                table: "Post",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
