﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LoanManagementSystem_V2_WebApi.Model;

public partial class Loan
{
    public int LoanId { get; set; }

    public string? LoanName { get; set; }

    public string? LoanDescription { get; set; }

    public int? CategoryId { get; set; }

    public decimal? LoanMinimumAmount { get; set; }

    public decimal? LoanMaximumAmount { get; set; }

    public decimal? LoanIntrestRate { get; set; }

    public decimal? LatePaymentPenalty { get; set; }

    public decimal? ProcessingFee { get; set; }

    public decimal? TaxPercentage { get; set; }

    public int? RepaymentFrequency { get; set; }

    public int? GracePeriod { get; set; }

    public bool? EmployementStatusRequired { get; set; }

    public bool? CollateralRequired { get; set; }

    public int? LoanTerm { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? LoanStatus { get; set; }

    [JsonIgnore]
    public virtual LoanCategory? Category { get; set; }

    [JsonIgnore]
    public virtual ICollection<LoanDeatil> LoanDeatils { get; set; } = new List<LoanDeatil>();

    [JsonIgnore]
    public virtual ICollection<LoanRequest> LoanRequests { get; set; } = new List<LoanRequest>();
}
