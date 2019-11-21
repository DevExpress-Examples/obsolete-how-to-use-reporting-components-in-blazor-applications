﻿using Microsoft.AspNetCore.Mvc;
using DevExpress.Compatibility.System.Web;
using DevExpress.XtraReports.Web.ReportDesigner;

namespace BlazorReporting.Server.Controllers
{
    [Route("api/[controller]")]
    public class ReportingController : Controller
    {
        public ReportingController() { }
        [Route("[action]", Name = "getReportDesignerModel")]
        public object GetReportDesignerModel(string reportUrl)
        {
            string modelJsonScript = new ReportDesignerClientSideModelGenerator(HttpContext.RequestServices)
                .GetJsonModelScript(reportUrl, null, "/DXXRD", "/DXXRDV", "/DXQB");
            return new JavaScriptSerializer().Deserialize<object>(modelJsonScript);

        }
    }
}