using OnlineStore.Data.Commons;

namespace OnlineStore.Data.Entities;

public partial class Customer : GeneralLocalizableEntity
{
    public Customer()
    {
        Orders=new HashSet<Order>();
        Reviews=new HashSet<Review>();
    }
    public int CustomerId { get; set; }

    public string NameAr { get; set; } = null!;
    public string NameEn { get; set; } = null!;


    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
