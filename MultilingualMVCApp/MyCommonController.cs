using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultilingualMVCApp
{
    public class MyCommonController:Controller
    { 
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            else
            {
                var userLanguage = Request.UserLanguages;
                var userLang = userLanguage != null ? userLanguage[0] : "";
                if (userLang != "")
                {
                    lang = userLang;
                }
                else
                {
                    lang = LangTrans.GetDefaultLanguage(); // Using LangTrans class we get default language
                }
            }

            new LangTrans().SetLanguage(lang); // Using LangTrans class, We set language selection with property and function 

            return base.BeginExecuteCore(callback, state);
        }
    }
}