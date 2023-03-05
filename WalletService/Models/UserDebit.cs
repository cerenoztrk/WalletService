using System;
using System.Collections.Generic;

namespace WalletService.Models;

public partial class UserDebit
{
    public int DebitsId { get; set; }

    public decimal? DebtAmount { get; set; }

    public DateTime? Date { get; set; }

    public string? BankName { get; set; }
}
