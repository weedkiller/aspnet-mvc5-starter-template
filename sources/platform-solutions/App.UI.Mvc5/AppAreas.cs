﻿namespace App.UI.Mvc5
{
	public enum Area : int
	{
		Root,
		Dash,
		Features,
		HtmlElements,
		Management,
		Users
	}

	public class AppAreas
	{
		public static string GetAreaName(Area area)
		{
			if (area == Area.Root)
			{
				return string.Empty;
			}

			return area.ToString();
		}
	}
}