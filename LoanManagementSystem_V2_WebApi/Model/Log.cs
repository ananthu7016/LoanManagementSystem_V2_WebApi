using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LoanManagementSystem_V2_WebApi.Model;

public partial class Log
{
    public int LogId { get; set; }

    public int? EventId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? LogDescription { get; set; }

    [JsonIgnore]
    public virtual Event? Event { get; set; }
}
