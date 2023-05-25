using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblWishList
{
    public int WishListId { get; set; }

    public int? ProductId { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblProduct? Product { get; set; }

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
