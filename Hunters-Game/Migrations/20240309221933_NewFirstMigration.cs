using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class NewFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academy_Districts_DistrictAcademyId",
                table: "Academy");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Academy_AcademyId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Department_DepartmentId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Academy_AcademyResponsibleId",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Academy",
                table: "Academy");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Academy",
                newName: "Academies");

            migrationBuilder.RenameIndex(
                name: "IX_Academy_DistrictAcademyId",
                table: "Academies",
                newName: "IX_Academies_DistrictAcademyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Academies",
                table: "Academies",
                column: "AcademyId");

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "CreatureId", "DangerRatio", "Desctription", "Name", "TerritoryId" },
                values: new object[,]
                {
                    { 4, null, 0, "Одна из областей Изомара.", "Платор", 2 },
                    { 5, null, 0, "Одна из областей Вусла.", "Гилнорт", 3 },
                    { 6, null, 0, "Одна из областей Сириба", "Накра", 4 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "HuntersCount", "Name" },
                values: new object[] { 3, "Сюда попадают охотники после бакалавриата в академии, а также те, кто пока не попал в другие департаменты. Занимаются помощью другим департаментам в случае необходимости.", 0, "Департамент резерва" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "AreaId", "CreatureId", "DangerRatio", "Desctription", "Name" },
                values: new object[,]
                {
                    { 5, 4, null, 0, "Город области Платор в Изомаре, полный талантливых и творческих людей. Отсюда вышло множество звёзд и артистов.", "Финея" },
                    { 6, 5, null, 0, "Город области Гилнорт в Вусле, где климат достаточно разнообразен. Зимой там чрезвычайно холодно, а летом население терпит сильнейшую жару. Из-за этого у его жителей хорошая акклиматизация и сильный иммунитет.", "Рона" },
                    { 7, 6, null, 0, "Город области Накра в Сирибе, где население терпит сильнейшие морозы, банды мародёров, гигантов и вампиров.", "Сноуден" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictId", "AcademyResponsibleId", "CityId", "CreatureId", "DangerRatio", "Desctription", "Name" },
                values: new object[,]
                {
                    { 9, 1, 5, null, 0, "Северная часть города Финея", "Северная Финея" },
                    { 10, 1, 5, null, 0, "Южная часть города Финея", "Южная Финея" },
                    { 11, 1, 6, null, 0, "Северная часть города Рона", "Северная Рона" },
                    { 12, 1, 6, null, 0, "Южная часть города Рона", "Южная Рона" },
                    { 13, 1, 7, null, 0, "Северная часть города Сноуден", "Северный Сноуден" },
                    { 14, 1, 7, null, 0, "Южная часть города Сноуден", "Южный Сноуден" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Districts_DistrictAcademyId",
                table: "Academies",
                column: "DistrictAcademyId",
                principalTable: "Districts",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Academies_AcademyId",
                table: "Characters",
                column: "AcademyId",
                principalTable: "Academies",
                principalColumn: "AcademyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Departments_DepartmentId",
                table: "Characters",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Academies_AcademyResponsibleId",
                table: "Districts",
                column: "AcademyResponsibleId",
                principalTable: "Academies",
                principalColumn: "AcademyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academies_Districts_DistrictAcademyId",
                table: "Academies");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Academies_AcademyId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Departments_DepartmentId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Academies_AcademyResponsibleId",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Academies",
                table: "Academies");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Academies",
                newName: "Academy");

            migrationBuilder.RenameIndex(
                name: "IX_Academies_DistrictAcademyId",
                table: "Academy",
                newName: "IX_Academy_DistrictAcademyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Academy",
                table: "Academy",
                column: "AcademyId");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                column: "DangerRatio",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Academy_Districts_DistrictAcademyId",
                table: "Academy",
                column: "DistrictAcademyId",
                principalTable: "Districts",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Academy_AcademyId",
                table: "Characters",
                column: "AcademyId",
                principalTable: "Academy",
                principalColumn: "AcademyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Department_DepartmentId",
                table: "Characters",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Academy_AcademyResponsibleId",
                table: "Districts",
                column: "AcademyResponsibleId",
                principalTable: "Academy",
                principalColumn: "AcademyId");
        }
    }
}
