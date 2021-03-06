﻿using System.Web.Mvc;

namespace App.UI.Mvc5.Areas.Features.Controllers
{
	[RoutePrefix("landing")]
	public class _LandingController : __AreaBaseController
	{
		[HttpGet]
		[Route(Name = "FeaturesLandingIndexGet")]
		public ActionResult Index() => RedirectToAction("Index", "FormsAndValidation");
	}
}
