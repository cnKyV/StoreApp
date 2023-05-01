using System.ComponentModel;

namespace DataApprover.Core.Global.Enums;

public enum AuthorizationLevel
{
    [Description("User")]
    User = 0,
    [Description("Manager")]
    Manager = 1,
    [Description("Admin")]
    Admin = 2
}