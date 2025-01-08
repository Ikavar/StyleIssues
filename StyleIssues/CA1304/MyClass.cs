using System.Globalization;

namespace StyleIssues.CA1304
{
    public static class MyClass
    {
        public static string MyMethod(string str) =>
#pragma warning disable CA1062 // Validate arguments of public methods
            $"K-{str.ToUpper(CultureInfo.CurrentCulture)}";
#pragma warning restore CA1062 // Validate arguments of public methods

    }
}
