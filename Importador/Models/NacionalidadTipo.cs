﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CS_Padron_Importador.Models;

public partial class NacionalidadTipo
{
    public byte IdNacionalidadTipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
}