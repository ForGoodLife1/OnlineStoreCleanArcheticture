﻿namespace OnlineStore.Data.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}