﻿using App.UI.Mvc5.Infrastructure;
using App.UI.Mvc5.Models;
using Serilog;
using System.Web.Mvc;

namespace App.UI.Mvc5.Controllers
{
	[RoutePrefix("")]
	[TrackMenuItem("root.landing")]
	public class HomeController : __BaseController
	{
		private ILogger _logger = null;

		public HomeController(ILogger logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[Route(Name = "HomeIndexGet")]
		public ActionResult Index()
		{
			var model = new EmptyViewModel();

			_logger.Information("Testing this thing with user {user} at {time}", User, System.DateTime.Now);

			model = null;

			return View(model);
		}
	}
}