﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Do_an_mon_hoc.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Thumbnail { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}