using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace FirstMobileApp
{
    public class MobileConfig
    {
        public static void MobileMode()
        {

            DisplayModeProvider.Instance.Modes.Insert(0,
            new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            DisplayModeProvider.Instance.Modes.Insert(1,
               new DefaultDisplayMode("iPad")
               {
                   ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf("iPad", StringComparison.OrdinalIgnoreCase) >= 0)
               });
        }
    }
}