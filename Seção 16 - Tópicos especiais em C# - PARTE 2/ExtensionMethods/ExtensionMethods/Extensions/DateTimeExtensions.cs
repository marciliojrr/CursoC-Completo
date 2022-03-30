using System;
using System.Globalization;

namespace ExtensionMethods.Extensions // Podemos mudar o namespace para 'System', assim nao precisamos importar no programa principal
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            }
            else
            {
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
            }
        }
    }
}
