using System.Diagnostics.Contracts;

namespace ACM.ContractApp;

public class Customer
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}

public class Contract
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public string Description { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal MonthlyAmount { get; set; }
    
}