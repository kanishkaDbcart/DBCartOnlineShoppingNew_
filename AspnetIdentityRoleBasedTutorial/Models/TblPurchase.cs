using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblPurchase
{
    public int PurchaseId { get; set; }

    public int BuyNowId { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual TblBuyNow BuyNow { get; set; } = null!;

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
