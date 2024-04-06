﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Do_an_mon_hoc.Models;

public partial class Order
{
    public int Id { get; set; }

    public string Address { get; set; }

    public double? Total { get; set; }

    public string Note { get; set; }

    public string Status { get; set; }

    public string PaymentMethod { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual User User { get; set; }
}