using System;
using System.Text.RegularExpressions;
using HugoSMS.WinForm.App.Models;
using NLog;

namespace HugoSMS.WinForm.App.Helpers
{
    public class COMMONS
    {
        // NLog 정적 인스턴스 생성
        public static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        public static bool IS_SCAN = false;

        public static User LOGGED_IN_USER;

        /// <summary>
        /// 숫자만 사용하는지 확인하는 메서드
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool IsDigitsOnly(string param)
        {
            foreach (var item in param)
            {
                if (item < '0' || item > '9')
                    return false;
            }

            return true;
        }

        /// <summary>
        /// 이메일주소 검증 메서드
        /// </summary>
        /// <param name="trim"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string param)
        {
            return !Regex.IsMatch(param,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
        }
    }
}
