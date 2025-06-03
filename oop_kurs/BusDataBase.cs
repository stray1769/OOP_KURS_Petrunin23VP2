using oop_kurs;
using System.Text.Encodings.Web;
using System.Text.Json;

public class BusDatabase
{
	public List<BusPark> Buses { get; set; }
	public List<Driver> Drivers { get; set; }
	public List<RouteNumber> RouteNumbers { get; set; }

	public string _currentFilePath;

	public BusDatabase()
	{
		Buses = new List<BusPark>();
		Drivers = new List<Driver>();
		RouteNumbers = new List<RouteNumber>();
	}
	public BusDatabase(List<BusPark> buses)
	{
		Buses = buses;
	}
	public List<BusPark> GetBuses()
	{
		return Buses;
	}
	public void Save(string filePath)
	{
		var options = new JsonSerializerOptions
		{
			WriteIndented = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};

		string json = JsonSerializer.Serialize(this, options);
		File.WriteAllText(filePath, json);
	}

	public static BusDatabase Load(string filePath)
	{
		string json = File.ReadAllText(filePath);
		return JsonSerializer.Deserialize<BusDatabase>(json);
	}
}
