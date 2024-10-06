﻿namespace OnlineStore.Data.Entities;

public partial class Shipping
{
    public int ShippingId { get; set; }

    public int OrderId { get; set; }

    public string CarrierName { get; set; } = null!;

    public string TrackingNumber { get; set; } = null!;

    public short ShippingStatus { get; set; }

    public DateTime EstimatedDeliveryDate { get; set; }

    public DateTime? ActualDeliveryDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}
