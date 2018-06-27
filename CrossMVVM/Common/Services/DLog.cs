using System;
using System.Diagnostics;

namespace Common.Services
{
    public static class DLog
    {
        public static void Error(string error)
        {
            Debug.WriteLine(FormatedString(error, "❌"));
        }

        public static void Info(string info)
        {
            Debug.WriteLine(FormatedString(info, "💧"));
        }

        public static void Success(string success)
        {
            Debug.WriteLine(FormatedString(success, "✅"));
        }

        public static string FormatedString(string message, string symbol)
        {
            var formatedString = 
                $"\n<==================================================\n" +
                $"{symbol} - {DateTime.Now.ToString()}" +
                $"\n==================================================\n" +
                $"{message}" +
                $"\n==================================================>\n";
            return formatedString;
        }
    }
}
