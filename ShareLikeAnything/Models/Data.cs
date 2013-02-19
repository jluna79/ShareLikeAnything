﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareLikeAnything.Models
{
	public class Data
	{
		public string Id { get; set; }
		public string Text { get; set; }
		public string Url { get; set; }
		public string ContentType { get; set; }
		public int TimesView { get; set; }
		public DateTime CreatedDate { get; set; }

		public Data()
		{
			TimesView = 5;
		}
	}
}