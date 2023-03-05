using System;
using System.Collections.Generic;

namespace WalletService.Models;

public partial class UserWallet
{
    public int BalanceId { get; set; }

    public decimal? Balance { get; set; }

    public string? Bank { get; set; }

    public DateTime? Date { get; set; }
}
