public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var parts = phoneNumber.Split('-');
        var result = (IsNewYork: parts[0] == "212", IsFake: parts[1] == "555", LocalNumber: phoneNumber.Substring(phoneNumber.Length - 4, 4));
        return result;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
