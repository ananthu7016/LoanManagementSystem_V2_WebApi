using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LoanManagementSystem_V2_WebApi.Model;

public partial class LoanCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    [JsonIgnore]
    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
