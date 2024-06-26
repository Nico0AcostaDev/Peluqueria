﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using peluqueria.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace peluqueria.Models
{
    public partial class PeluqueriaContext
    {
        private IPeluqueriaContextProcedures _procedures;

        public virtual IPeluqueriaContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new PeluqueriaContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IPeluqueriaContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sp_obtener_clientesResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_obtener_empleadosResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_ObtenerProductosResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_ObtenerServiciosResult>().HasNoKey().ToView(null);
        }
    }

    public partial class PeluqueriaContextProcedures : IPeluqueriaContextProcedures
    {
        private readonly PeluqueriaContext _context;

        public PeluqueriaContextProcedures(PeluqueriaContext context)
        {
            _context = context;
        }

        public virtual async Task<int> sp_insertar_ventaAsync(int? id_cliente, int? id_empleado, decimal? total, OutputParameter<int?> id_venta, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterid_venta = new SqlParameter
            {
                ParameterName = "id_venta",
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = id_venta?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "id_cliente",
                    Value = id_cliente ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "id_empleado",
                    Value = id_empleado ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "total",
                    Precision = 10,
                    Scale = 2,
                    Value = total ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Decimal,
                },
                parameterid_venta,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_insertar_venta] @id_cliente, @id_empleado, @total, @id_venta OUTPUT", sqlParameters, cancellationToken);

            id_venta.SetValue(parameterid_venta.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_insertar_venta_productoAsync(int? id_venta, int? id_producto, int? cantidad_prod, decimal? total_producto, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "id_venta",
                    Value = id_venta ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "id_producto",
                    Value = id_producto ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "cantidad_prod",
                    Value = cantidad_prod ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "total_producto",
                    Precision = 10,
                    Scale = 2,
                    Value = total_producto ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Decimal,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_insertar_venta_producto] @id_venta, @id_producto, @cantidad_prod, @total_producto", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_insertar_venta_servicioAsync(int? id_venta, int? id_servicio, int? cantidad_serv, decimal? total_servicio, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "id_venta",
                    Value = id_venta ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "id_servicio",
                    Value = id_servicio ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "cantidad_serv",
                    Value = cantidad_serv ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "total_servicio",
                    Precision = 10,
                    Scale = 2,
                    Value = total_servicio ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Decimal,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_insertar_venta_servicio] @id_venta, @id_servicio, @cantidad_serv, @total_servicio", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_obtener_clientesResult>> sp_obtener_clientesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_obtener_clientesResult>("EXEC @returnValue = [dbo].[sp_obtener_clientes]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_obtener_empleadosResult>> sp_obtener_empleadosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_obtener_empleadosResult>("EXEC @returnValue = [dbo].[sp_obtener_empleados]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_ObtenerProductosResult>> sp_ObtenerProductosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_ObtenerProductosResult>("EXEC @returnValue = [dbo].[sp_ObtenerProductos]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_ObtenerServiciosResult>> sp_ObtenerServiciosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_ObtenerServiciosResult>("EXEC @returnValue = [dbo].[sp_ObtenerServicios]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_ValidarUsuarioAsync(string nombre_usuario, string contraseña, OutputParameter<int?> existe, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterexiste = new SqlParameter
            {
                ParameterName = "existe",
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = existe?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "nombre_usuario",
                    Size = 50,
                    Value = nombre_usuario ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "contraseña",
                    Size = 50,
                    Value = contraseña ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterexiste,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_ValidarUsuario] @nombre_usuario, @contraseña, @existe OUTPUT", sqlParameters, cancellationToken);

            existe.SetValue(parameterexiste.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
