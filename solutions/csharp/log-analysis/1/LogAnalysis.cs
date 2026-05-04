public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter){
        return str.Split(delimiter).Last();
    }
    public static string SubstringBetween(this string str, string left, string right){
        var leftDel = str.IndexOf(left) + left.Length;
        var rightDel = str.IndexOf(right);
        return str.Substring(leftDel, rightDel - leftDel);
    }
    public static string Message(this string str){
        return str.Split("]: ").Last();
    }
    public static string LogLevel(this string str){
        var leftDel = str.IndexOf('[') + 1;
        var rightDel = str.IndexOf(']');
        return str.Substring(leftDel, rightDel - leftDel);
    }
}