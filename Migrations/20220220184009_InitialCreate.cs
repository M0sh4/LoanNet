using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanNet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
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
                    table.PrimaryKey("PK_usuario", x => x.nId);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
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
                    table.PrimaryKey("PK_cliente", x => x.cDni);
                    table.ForeignKey(
                        name: "FK_cliente_usuario_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "usuario",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "empresa",
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
                    table.PrimaryKey("PK_empresa", x => x.cRuc);
                    table.ForeignKey(
                        name: "FK_empresa_usuario_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "usuario",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "documento",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false),
                    cNombre = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documento", x => new { x.cDni, x.cRuc });
                    table.ForeignKey(
                        name: "FK_documento_cliente_cDni",
                        column: x => x.cDni,
                        principalTable: "cliente",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_documento_empresa_cRuc",
                        column: x => x.cRuc,
                        principalTable: "empresa",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
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
                    table.PrimaryKey("PK_empleado", x => x.cDni);
                    table.ForeignKey(
                        name: "FK_empleado_empresa_cRuc",
                        column: x => x.cRuc,
                        principalTable: "empresa",
                        principalColumn: "cRuc");
                    table.ForeignKey(
                        name: "FK_empleado_usuario_nIdUsu",
                        column: x => x.nIdUsu,
                        principalTable: "usuario",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "lista_negra",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false),
                    cRazon = table.Column<string>(nullable: true),
                    dtFechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lista_negra", x => new { x.cRuc, x.cDni });
                    table.ForeignKey(
                        name: "FK_lista_negra_cliente_cDni",
                        column: x => x.cDni,
                        principalTable: "cliente",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lista_negra_empresa_cRuc",
                        column: x => x.cRuc,
                        principalTable: "empresa",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recomendado",
                columns: table => new
                {
                    cDni = table.Column<string>(nullable: false),
                    cDniRec = table.Column<string>(nullable: false),
                    cRuc = table.Column<string>(nullable: false),
                    nId = table.Column<int>(nullable: false),
                    dtFechaReg = table.Column<DateTime>(nullable: false),
                    bEstado = table.Column<bool>(nullable: false),
                    clientecDni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recomendado", x => new { x.cDniRec, x.cDni, x.cRuc });
                    table.ForeignKey(
                        name: "FK_recomendado_cliente_cDni",
                        column: x => x.cDni,
                        principalTable: "cliente",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recomendado_empresa_cRuc",
                        column: x => x.cRuc,
                        principalTable: "empresa",
                        principalColumn: "cRuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recomendado_cliente_clientecDni",
                        column: x => x.clientecDni,
                        principalTable: "cliente",
                        principalColumn: "cDni",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tipo_prestamo",
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
                    table.PrimaryKey("PK_tipo_prestamo", x => x.nId);
                    table.ForeignKey(
                        name: "FK_tipo_prestamo_empresa_cRuc",
                        column: x => x.cRuc,
                        principalTable: "empresa",
                        principalColumn: "cRuc");
                });

            migrationBuilder.CreateTable(
                name: "prestamo",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cDni = table.Column<string>(nullable: true),
                    cRuc = table.Column<string>(nullable: true),
                    nMonto = table.Column<double>(nullable: false),
                    dtFechaIni = table.Column<DateTime>(nullable: false),
                    dtFechaFin = table.Column<DateTime>(nullable: false),
                    cEstado = table.Column<bool>(nullable: false),
                    nIdTipoPrestamo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamo", x => x.nId);
                    table.ForeignKey(
                        name: "FK_prestamo_cliente_cDni",
                        column: x => x.cDni,
                        principalTable: "cliente",
                        principalColumn: "cDni");
                    table.ForeignKey(
                        name: "FK_prestamo_tipo_prestamo_nIdTipoPrestamo",
                        column: x => x.nIdTipoPrestamo,
                        principalTable: "tipo_prestamo",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateTable(
                name: "pago",
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
                    table.PrimaryKey("PK_pago", x => x.nId);
                    table.ForeignKey(
                        name: "FK_pago_prestamo_nIdPrestamo",
                        column: x => x.nIdPrestamo,
                        principalTable: "prestamo",
                        principalColumn: "nId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_nIdUsu",
                table: "cliente",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_documento_cRuc",
                table: "documento",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_cRuc",
                table: "empleado",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_nIdUsu",
                table: "empleado",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_nIdUsu",
                table: "empresa",
                column: "nIdUsu");

            migrationBuilder.CreateIndex(
                name: "IX_lista_negra_cDni",
                table: "lista_negra",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_pago_nIdPrestamo",
                table: "pago",
                column: "nIdPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_cDni",
                table: "prestamo",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_nIdTipoPrestamo",
                table: "prestamo",
                column: "nIdTipoPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_recomendado_cDni",
                table: "recomendado",
                column: "cDni");

            migrationBuilder.CreateIndex(
                name: "IX_recomendado_cRuc",
                table: "recomendado",
                column: "cRuc");

            migrationBuilder.CreateIndex(
                name: "IX_recomendado_clientecDni",
                table: "recomendado",
                column: "clientecDni");

            migrationBuilder.CreateIndex(
                name: "IX_tipo_prestamo_cRuc",
                table: "tipo_prestamo",
                column: "cRuc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documento");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "lista_negra");

            migrationBuilder.DropTable(
                name: "pago");

            migrationBuilder.DropTable(
                name: "recomendado");

            migrationBuilder.DropTable(
                name: "prestamo");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "tipo_prestamo");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
