using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanNet.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_usuario_nIdUsu",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_documento_cliente_cDni",
                table: "documento");

            migrationBuilder.DropForeignKey(
                name: "FK_documento_empresa_cRuc",
                table: "documento");

            migrationBuilder.DropForeignKey(
                name: "FK_empleado_empresa_cRuc",
                table: "empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_empleado_usuario_nIdUsu",
                table: "empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_usuario_nIdUsu",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_lista_negra_cliente_cDni",
                table: "lista_negra");

            migrationBuilder.DropForeignKey(
                name: "FK_lista_negra_empresa_cRuc",
                table: "lista_negra");

            migrationBuilder.DropForeignKey(
                name: "FK_pago_prestamo_nIdPrestamo",
                table: "pago");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamo_cliente_cDni",
                table: "prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamo_tipo_prestamo_nIdTipoPrestamo",
                table: "prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_recomendado_cliente_cDni",
                table: "recomendado");

            migrationBuilder.DropForeignKey(
                name: "FK_recomendado_empresa_cRuc",
                table: "recomendado");

            migrationBuilder.DropForeignKey(
                name: "FK_recomendado_cliente_clientecDni",
                table: "recomendado");

            migrationBuilder.DropForeignKey(
                name: "FK_tipo_prestamo_empresa_cRuc",
                table: "tipo_prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipo_prestamo",
                table: "tipo_prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recomendado",
                table: "recomendado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prestamo",
                table: "prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pago",
                table: "pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lista_negra",
                table: "lista_negra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresa",
                table: "empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empleado",
                table: "empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_documento",
                table: "documento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "tipo_prestamo",
                newName: "Tipos_Prestamos");

            migrationBuilder.RenameTable(
                name: "recomendado",
                newName: "Recomendados");

            migrationBuilder.RenameTable(
                name: "prestamo",
                newName: "Prestamos");

            migrationBuilder.RenameTable(
                name: "pago",
                newName: "Pagos");

            migrationBuilder.RenameTable(
                name: "lista_negra",
                newName: "Listas_Negras");

            migrationBuilder.RenameTable(
                name: "empresa",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "documento",
                newName: "Documentos");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_tipo_prestamo_cRuc",
                table: "Tipos_Prestamos",
                newName: "IX_Tipos_Prestamos_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_recomendado_clientecDni",
                table: "Recomendados",
                newName: "IX_Recomendados_clientecDni");

            migrationBuilder.RenameIndex(
                name: "IX_recomendado_cRuc",
                table: "Recomendados",
                newName: "IX_Recomendados_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_recomendado_cDni",
                table: "Recomendados",
                newName: "IX_Recomendados_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_prestamo_nIdTipoPrestamo",
                table: "Prestamos",
                newName: "IX_Prestamos_nIdTipoPrestamo");

            migrationBuilder.RenameIndex(
                name: "IX_prestamo_cDni",
                table: "Prestamos",
                newName: "IX_Prestamos_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_pago_nIdPrestamo",
                table: "Pagos",
                newName: "IX_Pagos_nIdPrestamo");

            migrationBuilder.RenameIndex(
                name: "IX_lista_negra_cDni",
                table: "Listas_Negras",
                newName: "IX_Listas_Negras_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_empresa_nIdUsu",
                table: "Empresas",
                newName: "IX_Empresas_nIdUsu");

            migrationBuilder.RenameIndex(
                name: "IX_empleado_nIdUsu",
                table: "Empleados",
                newName: "IX_Empleados_nIdUsu");

            migrationBuilder.RenameIndex(
                name: "IX_empleado_cRuc",
                table: "Empleados",
                newName: "IX_Empleados_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_documento_cRuc",
                table: "Documentos",
                newName: "IX_Documentos_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_nIdUsu",
                table: "Clientes",
                newName: "IX_Clientes_nIdUsu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_Prestamos",
                table: "Tipos_Prestamos",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados",
                columns: new[] { "cDniRec", "cDni", "cRuc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras",
                columns: new[] { "cRuc", "cDni" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "cRuc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "cDni");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos",
                columns: new[] { "cDni", "cRuc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_nIdUsu",
                table: "Clientes",
                column: "nIdUsu",
                principalTable: "Usuarios",
                principalColumn: "nId");

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
                name: "FK_Empleados_Empresas_cRuc",
                table: "Empleados",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Usuarios_nIdUsu",
                table: "Empleados",
                column: "nIdUsu",
                principalTable: "Usuarios",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Usuarios_nIdUsu",
                table: "Empresas",
                column: "nIdUsu",
                principalTable: "Usuarios",
                principalColumn: "nId");

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
                name: "FK_Pagos_Prestamos_nIdPrestamo",
                table: "Pagos",
                column: "nIdPrestamo",
                principalTable: "Prestamos",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Clientes_cDni",
                table: "Prestamos",
                column: "cDni",
                principalTable: "Clientes",
                principalColumn: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Tipos_Prestamos_nIdTipoPrestamo",
                table: "Prestamos",
                column: "nIdTipoPrestamo",
                principalTable: "Tipos_Prestamos",
                principalColumn: "nId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Prestamos_Empresas_cRuc",
                table: "Tipos_Prestamos",
                column: "cRuc",
                principalTable: "Empresas",
                principalColumn: "cRuc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_nIdUsu",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Clientes_cDni",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Empresas_cRuc",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Empresas_cRuc",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Usuarios_nIdUsu",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Usuarios_nIdUsu",
                table: "Empresas");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Clientes_cDni",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Negras_Empresas_cRuc",
                table: "Listas_Negras");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Prestamos_nIdPrestamo",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Clientes_cDni",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Tipos_Prestamos_nIdTipoPrestamo",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_cDni",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Empresas_cRuc",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendados_Clientes_clientecDni",
                table: "Recomendados");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Prestamos_Empresas_cRuc",
                table: "Tipos_Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_Prestamos",
                table: "Tipos_Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendados",
                table: "Recomendados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listas_Negras",
                table: "Listas_Negras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "Tipos_Prestamos",
                newName: "tipo_prestamo");

            migrationBuilder.RenameTable(
                name: "Recomendados",
                newName: "recomendado");

            migrationBuilder.RenameTable(
                name: "Prestamos",
                newName: "prestamo");

            migrationBuilder.RenameTable(
                name: "Pagos",
                newName: "pago");

            migrationBuilder.RenameTable(
                name: "Listas_Negras",
                newName: "lista_negra");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "empresa");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "empleado");

            migrationBuilder.RenameTable(
                name: "Documentos",
                newName: "documento");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Prestamos_cRuc",
                table: "tipo_prestamo",
                newName: "IX_tipo_prestamo_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendados_clientecDni",
                table: "recomendado",
                newName: "IX_recomendado_clientecDni");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendados_cRuc",
                table: "recomendado",
                newName: "IX_recomendado_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendados_cDni",
                table: "recomendado",
                newName: "IX_recomendado_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamos_nIdTipoPrestamo",
                table: "prestamo",
                newName: "IX_prestamo_nIdTipoPrestamo");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamos_cDni",
                table: "prestamo",
                newName: "IX_prestamo_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_nIdPrestamo",
                table: "pago",
                newName: "IX_pago_nIdPrestamo");

            migrationBuilder.RenameIndex(
                name: "IX_Listas_Negras_cDni",
                table: "lista_negra",
                newName: "IX_lista_negra_cDni");

            migrationBuilder.RenameIndex(
                name: "IX_Empresas_nIdUsu",
                table: "empresa",
                newName: "IX_empresa_nIdUsu");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_nIdUsu",
                table: "empleado",
                newName: "IX_empleado_nIdUsu");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_cRuc",
                table: "empleado",
                newName: "IX_empleado_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_Documentos_cRuc",
                table: "documento",
                newName: "IX_documento_cRuc");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_nIdUsu",
                table: "cliente",
                newName: "IX_cliente_nIdUsu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipo_prestamo",
                table: "tipo_prestamo",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recomendado",
                table: "recomendado",
                columns: new[] { "cDniRec", "cDni", "cRuc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_prestamo",
                table: "prestamo",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pago",
                table: "pago",
                column: "nId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lista_negra",
                table: "lista_negra",
                columns: new[] { "cRuc", "cDni" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresa",
                table: "empresa",
                column: "cRuc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empleado",
                table: "empleado",
                column: "cDni");

            migrationBuilder.AddPrimaryKey(
                name: "PK_documento",
                table: "documento",
                columns: new[] { "cDni", "cRuc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_usuario_nIdUsu",
                table: "cliente",
                column: "nIdUsu",
                principalTable: "usuario",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_documento_cliente_cDni",
                table: "documento",
                column: "cDni",
                principalTable: "cliente",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_documento_empresa_cRuc",
                table: "documento",
                column: "cRuc",
                principalTable: "empresa",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empleado_empresa_cRuc",
                table: "empleado",
                column: "cRuc",
                principalTable: "empresa",
                principalColumn: "cRuc");

            migrationBuilder.AddForeignKey(
                name: "FK_empleado_usuario_nIdUsu",
                table: "empleado",
                column: "nIdUsu",
                principalTable: "usuario",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_usuario_nIdUsu",
                table: "empresa",
                column: "nIdUsu",
                principalTable: "usuario",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_lista_negra_cliente_cDni",
                table: "lista_negra",
                column: "cDni",
                principalTable: "cliente",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lista_negra_empresa_cRuc",
                table: "lista_negra",
                column: "cRuc",
                principalTable: "empresa",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pago_prestamo_nIdPrestamo",
                table: "pago",
                column: "nIdPrestamo",
                principalTable: "prestamo",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamo_cliente_cDni",
                table: "prestamo",
                column: "cDni",
                principalTable: "cliente",
                principalColumn: "cDni");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamo_tipo_prestamo_nIdTipoPrestamo",
                table: "prestamo",
                column: "nIdTipoPrestamo",
                principalTable: "tipo_prestamo",
                principalColumn: "nId");

            migrationBuilder.AddForeignKey(
                name: "FK_recomendado_cliente_cDni",
                table: "recomendado",
                column: "cDni",
                principalTable: "cliente",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recomendado_empresa_cRuc",
                table: "recomendado",
                column: "cRuc",
                principalTable: "empresa",
                principalColumn: "cRuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recomendado_cliente_clientecDni",
                table: "recomendado",
                column: "clientecDni",
                principalTable: "cliente",
                principalColumn: "cDni",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tipo_prestamo_empresa_cRuc",
                table: "tipo_prestamo",
                column: "cRuc",
                principalTable: "empresa",
                principalColumn: "cRuc");
        }
    }
}
