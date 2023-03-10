using System;
using System.Collections.Generic;

namespace WalletService.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
