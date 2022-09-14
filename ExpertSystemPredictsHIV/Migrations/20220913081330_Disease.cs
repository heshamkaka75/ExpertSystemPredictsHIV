using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpertSystemPredictsHIV.Migrations
{
    public partial class Disease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BloodPressure",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constant",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cough",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Diabetes",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Diarrhea",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fever",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Headache",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HeartDisease",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KidneyDisease",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Musclepain",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NightSweats",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RashOrBlisters",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SexualIntercourse",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SharingNeedles",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkinRash",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SorePainfulMouthUlcers",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StomachDisease",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SwollenLymphNodes",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Transfusion",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UlcerationInTheMouthOrGenitals",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightLoss",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WhiteSpotsOnTongue",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodPressure",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Constant",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Cough",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Diabetes",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Diarrhea",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Fever",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Headache",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HeartDisease",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "KidneyDisease",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Musclepain",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NightSweats",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RashOrBlisters",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SexualIntercourse",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SharingNeedles",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SkinRash",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SorePainfulMouthUlcers",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "StomachDisease",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SwollenLymphNodes",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Transfusion",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UlcerationInTheMouthOrGenitals",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "WeightLoss",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "WhiteSpotsOnTongue",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
