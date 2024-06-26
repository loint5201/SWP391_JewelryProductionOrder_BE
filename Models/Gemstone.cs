﻿using System;
using System.Collections.Generic;

namespace BE.Models;

public partial class Gemstone
{
    public int GemstoneId { get; set; }

    public string? GemstoneName { get; set; }

    public decimal? GemstoneCost { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<JewelryGemstone> JewelryGemstones { get; set; } = new List<JewelryGemstone>();
}
