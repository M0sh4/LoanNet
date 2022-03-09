using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanNet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cUsuario = table.Column<string>(nullable: true),
                    cContrasena = table.Column<string>(nullable: true),
                    cTipoUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.nId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cDni = table.Column<string>(maxLength: 8, nullable: false),
                    nIdUsu = table.Column<int>(nullable: false),
                    cNombres = table.Column<string>(nullable: true),
                    cApellidos = table.Column<string>(nullable: true),
                    cTelefono = table.Column<string>(maxLength: 9, nullable: true),
                    cDireccion = table.Column<string>(nullable: true),
                    cCorreo = table.Column<string>(nullable: true),
                    cFoto = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cDni);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "Usuarios",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    cRuc = table.Column<string>(maxLength: 11, nullable: false),
                    nIdUsu = table.Column<int>(nullable: false),
                    cNombre = table.Column<string>(nullable: true),
                    cRazonSocial = table.Column<string>(nullable: true),
                    cTelefono = table.Column<string>(maxLength: 9, nullable: true),
                    cFoto = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.cRuc);
                    table.ForeignKey(
                        name: "FK_Empresas_Usuarios_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "Usuarios",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cNombre = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => new { x.cDni, x.cRuc });
                    table.ForeignKey(
                        name: "FK_Documentos_Clientes_cDni",
                        column: x => x.cDni,
                        principalTable: "Clientes",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documentos_Empresas_cRuc",
                        column: x => x.cRuc,
                        principalTable: "Empresas",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    cDni = table.Column<string>(maxLength: 8, nullable: false),
                    nIdUsu = table.Column<int>(nullable: false),
                    cNombre = table.Column<string>(nullable: true),
                    cApellidos = table.Column<string>(nullable: true),
                    cRuc = table.Column<string>(nullable: true),
                    cFoto = table.Column<string>(nullable: true),
                    cTelefono = table.Column<string>(maxLength: 9, nullable: true),
                    bEstado = table.Column<bool>(nullable: false),
                    dtFechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.cDni);
                    table.ForeignKey(
                        name: "FK_Empleados_Empresas_cRuc",
                        column: x => x.cRuc,
                        principalTable: "Empresas",
                        principalColumn: "cRuc");
                    table.ForeignKey(
                        name: "FK_Empleados_Usuarios_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "Usuarios",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "Listas_Negras",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cRazon = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listas_Negras", x => new { x.cRuc, x.cDni });
                    table.ForeignKey(
                        name: "FK_Listas_Negras_Clientes_cDni",
                        column: x => x.cDni,
                        principalTable: "Clientes",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listas_Negras_Empresas_cRuc",
                        column: x => x.cRuc,
                        principalTable: "Empresas",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recomendados",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cDniRec = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dtFechaReg = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false),
                    clientecDni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendados", x => new { x.cDniRec, x.cDni, x.cRuc });
                    table.ForeignKey(
                        name: "FK_Recomendados_Clientes_cDni",
                        column: x => x.cDni,
                        principalTable: "Clientes",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recomendados_Empresas_cRuc",
                        column: x => x.cRuc,
                        principalTable: "Empresas",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recomendados_Clientes_clientecDni",
                        column: x => x.clientecDni,
                        principalTable: "Clientes",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Prestamos",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nPorcentaje = table.Column<int>(nullable: false),
                    cRuc = table.Column<string>(nullable: true),
                    cNombre = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Prestamos", x => x.nId);
                    table.ForeignKey(
                        name: "FK_Tipos_Prestamos_Empresas_cRuc",
                        column: x => x.cRuc,
                        principalTable: "Empresas",
                        principalColumn: "cRuc");
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cDni = table.Column<string>(nullable: true),
                    cRuc = table.Column<string>(nullable: true),
                    nMonto = table.Column<double>(nullable: false),
                    dtFechaIni = table.Column<DateTime>(nullable: false),
                    dtFechaFin = table.Column<DateTime>(nullable: false),
                    cEstado = table.Column<string>(maxLength: 1, nullable: true),
                    nIdTipoPrestamo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.nId);
                    table.ForeignKey(
                        name: "FK_Prestamos_Clientes_cDni",
                        column: x => x.cDni,
                        principalTable: "Clientes",
                        principalColumn: "cDni");
                    table.ForeignKey(
                        name: "FK_Prestamos_Tipos_Prestamos_nIdTipoPrestamo",
                        column: x => x.nIdTipoPrestamo,
                        principalTable: "Tipos_Prestamos",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nIdPrestamo = table.Column<int>(nullable: false),
                    nMonto = table.Column<double>(nullable: false),
                    dtFecha = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.nId);
                    table.ForeignKey(
                        name: "FK_Pagos_Prestamos_nIdPrestamo",
                        column: x => x.nIdPrestamo,
                        principalTable: "Prestamos",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_nIdUsu",
                table: "Clientes",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_cRuc",
                table: "Documentos",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_cRuc",
                table: "Empleados",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_nIdUsu",
                table: "Empleados",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_nIdUsu",
                table: "Empresas",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_Listas_Negras_cDni",
                table: "Listas_Negras",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_nIdPrestamo",
                table: "Pagos",
                column: "nIdPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_cDni",
                table: "Prestamos",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_nIdTipoPrestamo",
                table: "Prestamos",
                column: "nIdTipoPrestamo");

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
                name: "IX_Tipos_Prestamos_cRuc",
                table: "Tipos_Prestamos",
                column: "cRuc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Listas_Negras");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Recomendados");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Tipos_Prestamos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
