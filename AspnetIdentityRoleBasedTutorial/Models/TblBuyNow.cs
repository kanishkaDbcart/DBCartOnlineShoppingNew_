using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblBuyNow
{
    public int BuyNowId { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int PayementTypes { get; set; }

    public decimal Quantity { get; set; }

    public decimal Rate { get; set; }

    public decimal TotalAmount { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ICollection<TblPurchase> TblPurchases { get; } = new List<TblPurchase>();

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
