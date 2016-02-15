using System.Collections.Generic;

namespace X.FUIdemo
{
	public class SomeViewModel
	{
		public string SomeLabel { get; set; }
		public List<SomeItem> SomeItems { get; set; }
	}
	public class SomeItem
	{
		public string ItemName { get; set; }
		public string ImageUrl { get; set; }
		public List<string> Details { get; set; }
	}
}
