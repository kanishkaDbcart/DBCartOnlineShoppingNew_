using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblAddress
{
    public int AddressId { get; set; }

    public int ProductId { get; set; }

    public string? DeliverAddress { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PinCode { get; set; } = null!;

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ICollection<TblBuyNow> TblBuyNows { get; } = new List<TblBuyNow>();

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
