﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace peluqueria.Models;

public partial class DetalleVentaServicio
{
    public int IdDetalleServicio { get; set; }

    public int? IdVenta { get; set; }

    public int? IdServicio { get; set; }

    public decimal MontoServicio { get; set; }

    public virtual Servicio IdServicioNavigation { get; set; }

    public virtual Venta IdVentaNavigation { get; set; }
}