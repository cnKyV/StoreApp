namespace DataApprover.Core.Global.ExtensionMethod;

public static class IntegerExtensions
{
    public static bool IsZeroOrNull(this int? variable)
    {
        if (variable == null)
            return false;

        if (variable.Value == 0)
            return false;

        return true;
    }
    
}