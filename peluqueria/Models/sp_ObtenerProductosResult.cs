﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace peluqueria.Models
{
    public partial class sp_ObtenerProductosResult
    {
        public string descripcion { get; set; }
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        [Column("precio", TypeName = "decimal(10,2)")]
        public decimal precio { get; set; }
        public int stock { get; set; }
    }
}
