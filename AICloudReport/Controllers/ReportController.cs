using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AICloudReport.Models.Report;
using AICloudReport.Services;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc;

namespace AICloudReport.Controllers
{
	public class ReportController : Controller
	{
		public readonly IViewRenderService _viewRenderService;

		public IJsReportMVCService JsReportMVCService { get; }

		public ReportController(IViewRenderService viewRenderService, IJsReportMVCService jsReportMVCService)
		{
			_viewRenderService = viewRenderService;
			JsReportMVCService = jsReportMVCService;
		}

		[MiddlewareFilter(typeof(JsReportPipeline))]
		public IActionResult SendQuote([FromBody]SendQuote sendQuoteModel)
		{
			HttpContext.JsReportFeature()
				.Recipe(Recipe.PhantomPdf)
				.Configure((r) => r.Template.Phantom = new Phantom { Format = PhantomFormat.A4, Margin = "0cm" });
			return View(sendQuoteModel);
		}
	}
}
