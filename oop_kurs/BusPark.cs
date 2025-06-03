using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace oop_kurs
{
	public class BusPark
	{
		private string carNumber;
		private string driver;
		private string routeNumber;
		private int capacity;
		private int releaseYear;
		public static List<BusPark> busList = new List<BusPark>();
		public static List<BusPark> originalBusList = new List<BusPark>();

		public BusPark()
		{
			carNumber = "";
			driver = "";
			routeNumber = "";
			capacity = 0;
			releaseYear = 0;
		}

		public BusPark(string carNumber, string driver, string routeNumber, int capacity, int releaseYear)
		{
			this.carNumber = carNumber;
			this.driver = driver;
			this.routeNumber = routeNumber;
			this.capacity = capacity;
			this.releaseYear = releaseYear;
		}

		~BusPark() {}

		public string CarNumber
		{
			get => carNumber;
			set => carNumber = value;
		}

		public string Driver
		{
			get => driver;
			set => driver = value;
		}

		public string RouteNumber
		{
			get => routeNumber;
			set => routeNumber = value;
		}

		public int Capacity
		{
			get => capacity;
			set => capacity = value;
		}

		public int ReleaseYear
		{
			get => releaseYear;
			set => releaseYear = value;
		}

	}
}
