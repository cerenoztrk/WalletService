using System;
using System.Collections.Generic;

namespace WalletService.Models;

public partial class VUserInvoice
{
    public int InvoiceId { get; set; }

    public string? Bank { get; set; }

    public string? InvoiceType { get; set; }
    public int? Quantity { get; set; }
    public int? Unit { get; set; }
    public int? Total { get; set; }
}
