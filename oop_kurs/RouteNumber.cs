using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kurs
{
	public class RouteNumber
	{
		private string _routenumber;
		private string _start;
		private string _end;
		public static List<RouteNumber> RouteNumbers = new List<RouteNumber>();
		public RouteNumber()
		{
			_routenumber = "";
			_start = "";
			_end = "";
		}

		public RouteNumber(string routenumber, string start, string end)
		{
			_routenumber = routenumber;
			_start = start;
			_end = end;
		}

		~RouteNumber() { }

		public string routeNumber
		{
			get => _routenumber;
			set => _routenumber = value;
		}

		public string Start
		{
			get => _start;
			set => _start = value;
		}

		public string End
		{
			get => _end;
			set => _end = value;
		}
	}
}
