using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Address { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<TblBuyNow> TblBuyNowCreatedByNavigations { get; } = new List<TblBuyNow>();

    public virtual ICollection<TblBuyNow> TblBuyNowUpdatedByNavigations { get; } = new List<TblBuyNow>();

    public virtual ICollection<TblCart> TblCartCreatedByNavigations { get; } = new List<TblCart>();

    public virtual ICollection<TblCart> TblCartUpdatedByNavigations { get; } = new List<TblCart>();

    public virtual ICollection<TblInventory> TblInventoryCreatedByNavigations { get; } = new List<TblInventory>();

    public virtual ICollection<TblInventory> TblInventoryUpdatedByNavigations { get; } = new List<TblInventory>();

    public virtual ICollection<TblProduct> TblProductCreatedByNavigations { get; } = new List<TblProduct>();

    public virtual ICollection<TblProduct> TblProductUpdatedByNavigations { get; } = new List<TblProduct>();

    public virtual ICollection<TblPurchase> TblPurchaseCreatedByNavigations { get; } = new List<TblPurchase>();

    public virtual ICollection<TblPurchase> TblPurchaseUpdatedByNavigations { get; } = new List<TblPurchase>();

    public virtual ICollection<TblUnit> TblUnitCreatedByNavigations { get; } = new List<TblUnit>();

    public virtual ICollection<TblUnit> TblUnitUpdatedByNavigations { get; } = new List<TblUnit>();

    public virtual ICollection<TblWishList> TblWishListCreatedByNavigations { get; } = new List<TblWishList>();

    public virtual ICollection<TblWishList> TblWishListUpdatedByNavigations { get; } = new List<TblWishList>();
}
