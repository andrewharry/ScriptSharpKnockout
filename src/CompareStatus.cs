using System.Runtime.CompilerServices;

namespace KnockoutApi
{
    [Imported, IgnoreNamespace, NamedValues]
    public enum CompareStatus
    {
        [ScriptName("added")] Added = 0,
        [ScriptName("deleted")] Deleted = 1,
        [ScriptName("retained")] Retained = 2
    }
}
