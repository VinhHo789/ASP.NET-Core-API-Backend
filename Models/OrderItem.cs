﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Do_an_mon_hoc.Models;

public partial class OrderItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public double? Price { get; set; }

    public override string ToString()
    {
        return Product.Name + ": " + Quantity;
    }

    public int? Quantity { get; set; }

    public double? Total { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public byte? IsDeleted { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}