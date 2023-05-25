using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblCart
{
    public int CartId { get; set; }

    public int? ProductId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Rate { get; set; }

    public short Status { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblProduct? Product { get; set; }

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
