using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Localization
{
    /// <summary>
    /// 本地化帮助类
    /// </summary>
    public static class CultureHelper
    {
        /// <summary>
        /// 获取所有的<see cref="CultureInfo"/>对象
        /// </summary>
        public static CultureInfo[] AllCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

        /// <summary>
        /// 判断当前文化的文字否是从右到左
        /// </summary>
        public static bool IsRtl => CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;

        public static bool UsingLunarCalendar = CultureInfo.CurrentUICulture.DateTimeFormat.Calendar.AlgorithmType == CalendarAlgorithmType.LunarCalendar;

        public static CultureInfo GetCultureInfoByChecking(string name)
        {
            try
            {
                return CultureInfo.GetCultureInfo(name);
            }
            catch (CultureNotFoundException)
            {
                return CultureInfo.CurrentCulture;
            }
        }
    }
}
