using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Query
	{
		public string Fileds { get; set; }
		public string Tables { get; set; }
		public string Condition { get; set; }
		public string GroupBy { get; set; }
		public Query(string fileds, string tables, string condition="", string groupby = "")
		{
			Fileds = fileds;
			Tables = tables;
			Condition = condition;
			GroupBy = groupby;
		}
	}
}
