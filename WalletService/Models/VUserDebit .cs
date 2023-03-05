using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace WalletService.Models;

public partial class VUserDebit
{

    public decimal? Amount { get; set; }

    public DateTime? Date { get; set; }

    public string? Bank { get; set; }
}
