using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseOrderSystem.Responses;

namespace PurchaseOrderSystem.Controllers
{
	/// <summary>
	/// ヘルスチェック用コントローラ
	/// </summary>
	public class HealthCheckController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			return Json(new HealthCheckResponse());
		}
	}
}
