using System;
using System.Collections.Generic;

namespace WalletService.Models;

public partial class UserInvoice
{
    public int InvoiceId { get; set; }

    public decimal? TotalInvoice { get; set; }

    public string? InvoiceName { get; set; }
}
