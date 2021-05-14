using ADT.Html.Control;
using Microsoft.AspNetCore.Html;
using System;

namespace ADT.Html
{
    public class UI
    {
        private static KOViewModelControl _KOViewModelControl = new KOViewModelControl();


        /// <summary>
        /// 创建 KO 实体
        /// </summary>
        /// <returns></returns>
        public static HtmlString CreateKOViewModel(params object[] Models)
        {
            return new HtmlString(_KOViewModelControl.ScriptStr(Models).ToString());
        }
    }
}
