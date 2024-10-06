namespace OnlineStore.Data.Entities;

public partial class Order
{
    public Order()
    {
        OrderItems = new HashSet<OrderItem>();
        Payments = new HashSet<Payment>();
        Shippings = new HashSet<Shipping>();
    }
    public int OrderId { get; set; }


    public int CustomerId2 { get; set; }
    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public short Status { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();
}
