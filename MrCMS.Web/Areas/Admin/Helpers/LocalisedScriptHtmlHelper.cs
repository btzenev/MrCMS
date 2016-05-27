﻿using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using MrCMS.Web.Areas.Admin.Services;
using MrCMS.Website;

namespace MrCMS.Web.Areas.Admin.Helpers
{
    public static class LocalisedScriptHtmlHelper
    {
        public static IHtmlString RenderLocalisedScripts(this HtmlHelper helper)
        {
            var localisedScripts = helper.GetAll<ILocalisedScripts>();
            var scriptList = localisedScripts.SelectMany(scripts => scripts.Files).ToArray();
            return Scripts.Render(scriptList); //MvcHtmlString.Create(string.Join(string.Empty, scriptList));
        }
    }
}