﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Do_an_mon_hoc.Models;

public partial class CartItem
{
    public int Id { get; set; }

    public int? Quantity { get; set; }

    public double? Total { get; set; }

    public int? CartId { get; set; }

    public int? ProductId { get; set; }

    public virtual Cart Cart { get; set; }

    public virtual Product Product { get; set; }
}