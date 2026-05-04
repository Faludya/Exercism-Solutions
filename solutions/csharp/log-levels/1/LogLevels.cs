static class LogLine
{
    public static string Message(string logLine) => logLine.Split(": ").Last().Trim();

    public static string LogLevel(string logLine) => logLine.Split(']').First().Remove(0, 1).ToLower();

    public static string Reformat(string logLine)
    {
        var error = logLine.Split(']').First().Remove(0, 1).ToLower();
        var message = logLine.Split(": ").Last().Trim();

        return $"{message} ({error})";
    }
}
