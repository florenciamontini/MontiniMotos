using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MontiniMotos.Migrations
{
    /// <inheritdoc />
    public partial class primermigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr_categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido_cli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni_cli = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_emp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido_emp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni_emp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeCompras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_repuesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cant_disponible = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repuestos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_venta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cant_repuesto_a_pedir = table.Column<int>(type: "int", nullable: false),
                    Montototal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Or_compraId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudPedidos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudPedidos_OrdenDeCompras_Or_compraId",
                        column: x => x.Or_compraId,
                        principalTable: "OrdenDeCompras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudPedidos_Proveedors_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineaOrdenDeCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio_del_momento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RepuestoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    OrdenDeCompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineaOrdenDeCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineaOrdenDeCompras_OrdenDeCompras_OrdenDeCompraId",
                        column: x => x.OrdenDeCompraId,
                        principalTable: "OrdenDeCompras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LineaOrdenDeCompras_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineaVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio_del_momento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RepuestoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineaVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineaVentas_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineaVentas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineaSolicitudPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio_del_momento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    RepuestoId = table.Column<int>(type: "int", nullable: false),
                    SolicitudPedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineaSolicitudPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineaSolicitudPedidos_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineaSolicitudPedidos_SolicitudPedidos_SolicitudPedidoId",
                        column: x => x.SolicitudPedidoId,
                        principalTable: "SolicitudPedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineaOrdenDeCompras_OrdenDeCompraId",
                table: "LineaOrdenDeCompras",
                column: "OrdenDeCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaOrdenDeCompras_RepuestoId",
                table: "LineaOrdenDeCompras",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaSolicitudPedidos_RepuestoId",
                table: "LineaSolicitudPedidos",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaSolicitudPedidos_SolicitudPedidoId",
                table: "LineaSolicitudPedidos",
                column: "SolicitudPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaVentas_RepuestoId",
                table: "LineaVentas",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaVentas_VentaId",
                table: "LineaVentas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_CategoriaId",
                table: "Repuestos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPedidos_EmpleadoId",
                table: "SolicitudPedidos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPedidos_Or_compraId",
                table: "SolicitudPedidos",
                column: "Or_compraId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPedidos_ProveedorId",
                table: "SolicitudPedidos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineaOrdenDeCompras");

            migrationBuilder.DropTable(
                name: "LineaSolicitudPedidos");

            migrationBuilder.DropTable(
                name: "LineaVentas");

            migrationBuilder.DropTable(
                name: "SolicitudPedidos");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "OrdenDeCompras");

            migrationBuilder.DropTable(
                name: "Proveedors");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
