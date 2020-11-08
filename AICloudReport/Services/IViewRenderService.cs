using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AICloudReport.Services
{
	public interface IViewRenderService
	{		Task<string> RenderViewToStringAsync(string viewName, object model);
	}
}
