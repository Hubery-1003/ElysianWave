using System;
using System.Collections.Generic;

namespace ElysianWave.Models;

public partial class UserInfomation
{
    public int UserId { get; set; }

    public string? UserNickName { get; set; }

    public string? UserAccount { get; set; }

    public string? UserPassword { get; set; }
}
