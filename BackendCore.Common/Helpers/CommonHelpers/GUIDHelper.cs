using System;

namespace BackendCore.Common.Helpers.CommonHelpers
{
    public class GUIDHelper
    {
        public static string GetUniqueId(string Prefix)
        {
            var random = new Random();
            var result = Prefix + DateTime.Now.ToString("yyyyMMddHHmmss") + random.Next(1, 1000);
            return result;
        }
    }
}
