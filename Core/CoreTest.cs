namespace Core;

public class CoreTest
{
    public static string Run(string? name)
    {
        return name != null
            ? $"Hello, {name}"
            : "Please pass a name on the query string";
    }
}