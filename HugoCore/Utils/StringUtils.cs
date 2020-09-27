namespace HugoCore.Utils
{
    public static class StringUtils
    {
        public static bool IsAnyNullOrEmpty(params string[] strs)
        {
            foreach (var item in strs)
            {
                if (string.IsNullOrEmpty(item)) return true;
            }

            return false;
        }
    }
}
