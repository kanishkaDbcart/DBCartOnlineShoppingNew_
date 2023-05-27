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

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<TblProduct> TblProducts { get; } = new List<TblProduct>();

    public virtual AspNetUser? UpdatedByNavigation { get; set; }
}
