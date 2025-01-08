namespace StyleIssues.CA1507
{
    public static class MyClass
    {
        public static string MyMethod(string str)
        {
            ArgumentNullException.ThrowIfNull(str);

            return "test" + str;
        }
    }
}
