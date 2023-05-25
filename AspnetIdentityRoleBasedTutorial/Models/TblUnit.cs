using System;
using System.Collections.Generic;

namespace OnlineShoppingProject.Models;

public partial class TblUnit
{
    public int UnitId { get; set; }

    public string UnitName { get; set; } = null!;

    public string? Description { get; set; }

    public short Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<TblProduct> TblProducts { get; } = new List<TblProduct>();

    public virtual TblUser? UpdatedByNavigation { get; set; }
}
