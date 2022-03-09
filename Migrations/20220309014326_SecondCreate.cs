using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanNet.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Clientes_cDni",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Empresas_cRuc",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Clientes_cDni",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Empresas_cRuc",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_cDni",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Empresas_cRuc",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_clientecDni",
                table: "Recomendados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados");

            migrationBuilder.DropIndex(
                name: "IX_Recomendados_cDni",
                table: "Recomendados");

            migrationBuilder.DropIndex(
                name: "IX_Recomendados_cRuc",
                table: "Recomendados");

            migrationBuilder.DropIndex(
                name: "IX_Recomendados_clientecDni",
                table: "Recomendados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras");

            migrationBuilder.DropIndex(
                name: "IX_Listas_Negras_cDni",
                table: "Listas_Negras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "clientecDni",
                table: "Recomendados");

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Recomendados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(11)");

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Recomendados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(8)");

            migrationBuilder.AlterColumn<string>(
                name: "cDniRec",
                table: "Recomendados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(450)");

            migrationBuilder.AddColumn<string>(
                name: "recomendados",
                table: "Recomendados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "recomendadosREC",
                table: "Recomendados",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Listas_Negras",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(8)");

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Listas_Negras",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(11)");

            migrationBuilder.AddColumn<string>(
                name: "listasNegras",
                table: "Listas_Negras",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Documentos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(11)");

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Documentos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(8)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos",
                column: "nId");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendados_recomendados",
                table: "Recomendados",
                column: "recomendados");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendados_recomendadosREC",
                table: "Recomendados",
                column: "recomendadosREC");

            migrationBuilder.CreateIndex(
                name: "IX_Listas_Negras_listasNegras",
                table: "Listas_Negras",
                column: "listasNegras");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_cDni",
                table: "Documentos",
                column: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Clientes_cDni",
                table: "Documentos",
                column: "cDni",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Empresas_cRuc",
                table: "Documentos",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Negras_Clientes_listasNegras",
                table: "Listas_Negras",
                column: "listasNegras",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Negras_Empresas_listasNegras",
                table: "Listas_Negras",
                column: "listasNegras",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Clientes_recomendados",
                table: "Recomendados",
                column: "recomendados",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Empresas_recomendados",
                table: "Recomendados",
                column: "recomendados",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Clientes_recomendadosREC",
                table: "Recomendados",
                column: "recomendadosREC",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Clientes_cDni",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Empresas_cRuc",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Clientes_listasNegras",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Empresas_listasNegras",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_recomendados",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Empresas_recomendados",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_recomendadosREC",
                table: "Recomendados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados");

            migrationBuilder.DropIndex(
                name: "IX_Recomendados_recomendados",
                table: "Recomendados");

            migrationBuilder.DropIndex(
                name: "IX_Recomendados_recomendadosREC",
                table: "Recomendados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras");

            migrationBuilder.DropIndex(
                name: "IX_Listas_Negras_listasNegras",
                table: "Listas_Negras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_cDni",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "recomendados",
                table: "Recomendados");

            migrationBuilder.DropColumn(
                name: "recomendadosREC",
                table: "Recomendados");

            migrationBuilder.DropColumn(
                name: "listasNegras",
                table: "Listas_Negras");

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Recomendados",
                type: "NVARCHAR2(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cDniRec",
                table: "Recomendados",
                type: "NVARCHAR2(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Recomendados",
                type: "NVARCHAR2(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clientecDni",
                table: "Recomendados",
                type: "NVARCHAR2(8)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Listas_Negras",
                type: "NVARCHAR2(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Listas_Negras",
                type: "NVARCHAR2(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cRuc",
                table: "Documentos",
                type: "NVARCHAR2(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cDni",
                table: "Documentos",
                type: "NVARCHAR2(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados",
                columns: new[] { "cDniRec", "cDni", "cRuc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras",
                columns: new[] { "cRuc", "cDni" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos",
                columns: new[] { "cDni", "cRuc" });

            migrationBuilder.CreateIndex(
                name: "IX_Recomendados_cDni",
                table: "Recomendados",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendados_cRuc",
                table: "Recomendados",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendados_clientecDni",
                table: "Recomendados",
                column: "clientecDni");

            migrationBuilder.CreateIndex(
                name: "IX_Listas_Negras_cDni",
                table: "Listas_Negras",
                column: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Clientes_cDni",
                table: "Documentos",
                column: "cDni",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Empresas_cRuc",
                table: "Documentos",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Negras_Clientes_cDni",
                table: "Listas_Negras",
                column: "cDni",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Negras_Empresas_cRuc",
                table: "Listas_Negras",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Clientes_cDni",
                table: "Recomendados",
                column: "cDni",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Empresas_cRuc",
                table: "Recomendados",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendados_Clientes_clientecDni",
                table: "Recomendados",
                column: "clientecDni",
                principalTable: "Clientes",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
