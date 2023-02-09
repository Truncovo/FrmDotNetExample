﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;


namespace FrmDotNetExample.Helpers
{
    public static class CshtmlHelper
    {
        private static HttpServerUtility _server;
        private static string _html;
        private static readonly Dictionary<string, string> Templates = new Dictionary<string, string>();
        public static void Init(HttpServerUtility server)
        {

            _html = File.ReadAllText(server.MapPath("~/static/frm/index.html"));
            
        }


        public static HtmlString RenderReactPage()
        {
            return new HtmlString(_html);
            
        }

        public static string PublicUrl
        {
            get
            {
               return "/Static/PDFViewerUI";
            }
        }


        private static string GetSolutionDir()
        {
            return Path.GetDirectoryName(Path.GetDirectoryName(_server.MapPath("~")));
        }
    }

}