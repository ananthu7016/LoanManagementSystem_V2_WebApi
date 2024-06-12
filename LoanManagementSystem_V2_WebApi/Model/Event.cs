using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LoanManagementSystem_V2_WebApi.Model;

public partial class Event
{
    public int EventId { get; set; }

    public string? EventName { get; set; }

    [JsonIgnore]
    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
