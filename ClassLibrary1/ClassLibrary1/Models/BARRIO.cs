﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models;

public partial class BARRIO
{
    public int id_barrio { get; set; }

    public string descripcion { get; set; }

    public int? id_localidad { get; set; }

    public virtual ICollection<DIRECCIONE> DIRECCIONEs { get; set; } = new List<DIRECCIONE>();

    public virtual LOCALIDADE id_localidadNavigation { get; set; }
}