using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kurs
{
	public class Driver
	{
		private int _id;
		private string _FIO;
		private string _BDate;
		public static List<Driver> Drivers = new List<Driver>();
		public Driver() 
		{
			_id = 0;
			_FIO = "";
			_BDate = "";
		}

		public Driver(int id, string fIO, string bDate)
		{
			_id = id;
			_FIO = fIO;
			_BDate = bDate;
		}

		~Driver() { }

		public int ID 
		{
			get => _id;
			set => _id = value;
		}

		public string FIO
		{
			get => _FIO;
			set => _FIO = value;
		}

		public string BDate
		{
			get => _BDate;
			set => _BDate = value;
		}
	}
}
