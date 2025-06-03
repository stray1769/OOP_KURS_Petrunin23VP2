using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace oop_kurs
{
	public partial class Form1 : Form
	{
		private BusDatabase _database;

		public Form1()
		{
			InitializeComponent();
			comboBox1.Items.AddRange(new string[] { "Госномер", "Водитель", "Номер маршрута", "Вместимость", "Год выпуска" });
			comboBox1.SelectedIndex = 0;

			_database = new BusDatabase();
			UpdateMenuItems();
		}

		private void UpdateMenuItems()
		{
			saveToolStripMenuItem.Enabled = _database != null && !(BusPark.busList.Count == 0);
			deleteAllToolStripMenuItem.Enabled = !(BusPark.busList.Count == 0);
		}
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Проверяем, есть ли данные для сохранения
			if (BusPark.busList.Count > 0 || Driver.Drivers.Count > 0 || RouteNumber.RouteNumbers.Count > 0)
			{
				using (SaveFileDialog saveDialog = new SaveFileDialog())
				{
					saveDialog.Filter = "База данных автобусов (*.busdb)|*.busdb";
					saveDialog.DefaultExt = "busdb";
					saveDialog.Title = "Сохранить текущую базу данных";

					if (saveDialog.ShowDialog() == DialogResult.OK)
					{
						try
						{
							// Создаем временную базу со всеми текущими данными
							var tempDb = new BusDatabase
							{
								Buses = new List<BusPark>(BusPark.busList),
								Drivers = new List<Driver>(Driver.Drivers),
								RouteNumbers = new List<RouteNumber>(RouteNumber.RouteNumbers)
							};

							// Сохраняем все данные
							tempDb.Save(saveDialog.FileName);

							MessageBox.Show("Все данные успешно сохранены:\n" +
										  $"- Автобусов: {BusPark.busList.Count}\n" +
										  $"- Водителей: {Driver.Drivers.Count}\n" +
										  $"- Маршрутов: {RouteNumber.RouteNumbers.Count}",
										  "Сохранение завершено",
										  MessageBoxButtons.OK,
										  MessageBoxIcon.Information);
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
										  "Ошибка",
										  MessageBoxButtons.OK,
										  MessageBoxIcon.Error);
							return;
						}
						UpdateAllUI();
					}
					else
					{
						return; // Пользователь отменил сохранение
					}
				}
			}
			else
			{
				MessageBox.Show($"Добавьте элементы!",
										  "Ошибка",
										  MessageBoxButtons.OK,
										  MessageBoxIcon.Error);
			}
		}

		private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Вы уверены, что хотите удалить все данные?",
									   "Подтверждение удаления",
									   MessageBoxButtons.YesNo,
									   MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				// Очищаем все данные
				BusPark.busList.Clear();
				BusPark.originalBusList.Clear();
				Driver.Drivers.Clear();
				RouteNumber.RouteNumbers.Clear();

				// Обновляем интерфейс
				comboBox2.Items.Clear();
				comboBox3.Items.Clear();
				UpdateAllUI();

				// Сбрасываем базу данных
				_database = new BusDatabase();
				_database._currentFilePath = null;

				MessageBox.Show("Все данные удалены", "Информация",
							   MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openDialog = new OpenFileDialog())
			{
				openDialog.Filter = "База данных автобусов (*.busdb)|*.busdb";
				openDialog.Title = "Открыть базу данных";

				if (openDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Загружаем все данные из файла
						var loadedDb = BusDatabase.Load(openDialog.FileName);

						// Обновляем статические списки
						BusPark.busList = new List<BusPark>(loadedDb.Buses);
						Driver.Drivers = new List<Driver>(loadedDb.Drivers);
						RouteNumber.RouteNumbers = new List<RouteNumber>(loadedDb.RouteNumbers);

						BusPark.originalBusList = new List<BusPark>(BusPark.busList);
						_database._currentFilePath = openDialog.FileName;

						// Обновляем интерфейс
						UpdateAllUI();

						MessageBox.Show($"Успешно загружено:\n" +
									  $"- Автобусов: {BusPark.busList.Count}\n" +
									  $"- Водителей: {Driver.Drivers.Count}\n" +
									  $"- Маршрутов: {RouteNumber.RouteNumbers.Count}",
									  "Загрузка завершена",
									  MessageBoxButtons.OK,
									  MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка загрузки: {ex.Message}",
									  "Ошибка",
									  MessageBoxButtons.OK,
									  MessageBoxIcon.Error);
					}
				}
			}
		}
		private void UpdateAllUI()
		{
			// Обновляем основную таблицу
			ShowObjectsOnDataGridView();

			// Обновляем комбобоксы
			UpdateDriversComboBox();
			UpdateRoutesComboBox();

			// Обновляем меню
			UpdateMenuItems();
		}

		private void UpdateDriversComboBox()
		{
			comboBox2.Items.Clear();
			foreach (Driver driver in Driver.Drivers)
			{
				comboBox2.Items.Add(driver.ID + ". " + driver.FIO);
			}
		}

		private void UpdateRoutesComboBox()
		{
			comboBox3.Items.Clear();
			foreach (RouteNumber route in RouteNumber.RouteNumbers)
			{
				comboBox3.Items.Add(route.routeNumber);
			}
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

			// 2. Проверка существования файла шрифта
			if (!File.Exists(fontPath))
			{
				MessageBox.Show("Шрифт Arial не найден! Используется стандартный шрифт.");
				fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
			}

			// 3. Создаем базовый шрифт с поддержкой кириллицы
			BaseFont baseFont;
			try
			{
				baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
			}
			catch
			{
				// Если не удалось загрузить шрифт, используем встроенный
				baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
			}

			// 4. Создаем основной шрифт для документа
			iTextSharp.text.Font mainFont = new iTextSharp.text.Font(baseFont, 10);
			iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);

			using (SaveFileDialog saveDialog = new SaveFileDialog())
			{
				saveDialog.Filter = "PDF файлы (*.pdf)|*.pdf";
				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Создаем документ
						iTextSharp.text.Document document = new iTextSharp.text.Document();
						PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
						document.Open();

						// Добавляем заголовок
						Paragraph title = new Paragraph("Отчет по автобусам", headerFont);
						title.Alignment = Element.ALIGN_CENTER;
						document.Add(title);

						// Создаем таблицу
						PdfPTable table = new PdfPTable(5);
						table.WidthPercentage = 100;

						// Заголовки таблицы
						AddCell(table, "Госномер", mainFont);
						AddCell(table, "Водитель", mainFont);
						AddCell(table, "Маршрут", mainFont);
						AddCell(table, "Вместимость", mainFont);
						AddCell(table, "Год выпуска", mainFont);

						// Данные
						foreach (var bus in BusPark.busList)
						{
							AddCell(table, bus.CarNumber, mainFont);
							AddCell(table, bus.Driver, mainFont);
							AddCell(table, bus.RouteNumber, mainFont);
							AddCell(table, bus.Capacity.ToString(), mainFont);
							AddCell(table, bus.ReleaseYear.ToString(), mainFont);
						}

						document.Add(table);
						document.Close();

						MessageBox.Show("PDF успешно создан!");
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка: {ex.Message}");
					}
				}
			}
		}
		private void AddCell(PdfPTable table, string text, iTextSharp.text.Font font)
		{
			PdfPCell cell = new PdfPCell(new Phrase(text, font));
			cell.Padding = 5;
			cell.BorderWidth = 0.5f;
			table.AddCell(cell);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
			{
				MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				string carnumber = textBox1.Text;
				string driver = comboBox2.SelectedItem.ToString();
				string routenumber = comboBox3.SelectedItem.ToString();
				int capacity = Convert.ToInt32(numericUpDown1.Value);
				int realeseyear = Convert.ToInt32(numericUpDown2.Value);

				foreach (BusPark exitingBus in BusPark.busList)
				{
					if (exitingBus.CarNumber == carnumber)
					{
						throw new Exception("Автобус с номером " + carnumber + " уже есть!");
					}
				}

				BusPark newBusPark = new BusPark(carnumber, driver, routenumber, capacity, realeseyear);
				BusPark.busList.Add(newBusPark);
				BusPark.originalBusList = new List<BusPark>(BusPark.busList);
				UpdateAllUI();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при добавлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string carnumber = textBox1.Text;
				string driver = comboBox2.SelectedItem.ToString();
				string routenumber = comboBox3.SelectedItem.ToString();
				int capacity = Convert.ToInt32(numericUpDown1.Value);
				int realeseyear = Convert.ToInt32(numericUpDown2.Value);

				BusPark busToUpdate = null;
				foreach (BusPark bus in BusPark.busList)
				{
					if (bus.CarNumber == carnumber)
					{
						busToUpdate = bus;
						break;
					}
				}

				if (busToUpdate != null)
				{
					busToUpdate.Driver = driver;
					busToUpdate.RouteNumber = routenumber;
					busToUpdate.Capacity = capacity;
					busToUpdate.ReleaseYear = realeseyear;

					UpdateAllUI();
					BusPark.originalBusList = new List<BusPark>(BusPark.busList);

					MessageBox.Show($"Обновлены данные автобуса с номером: {carnumber}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show($"Не найден автобус с номером: {carnumber}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при изменении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Введите госномер автобуса для удаления", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				string carNumberToDelete = textBox1.Text;
				bool isDeleted = false;

				for (int i = 0; i < BusPark.busList.Count; i++)
				{
					if (BusPark.busList[i].CarNumber == carNumberToDelete)
					{
						BusPark.busList.RemoveAt(i);
						isDeleted = true;
						break;
					}
				}

				if (isDeleted)
				{
					BusPark.originalBusList = new List<BusPark>(BusPark.busList);
					UpdateAllUI();

					MessageBox.Show($"Автобус с номером {carNumberToDelete} удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					comboBox2.SelectedItem = -1;
					comboBox2.Text = "";
					comboBox3.SelectedItem = -1;
					comboBox3.Text = "";
					numericUpDown1.Value = numericUpDown1.Minimum;
					numericUpDown2.Value = numericUpDown2.Maximum;
				}
				else
				{
					MessageBox.Show($"Автобус с номером {carNumberToDelete} не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void button6_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox5.Text))
			{
				MessageBox.Show("Введите значение для фильтрации", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Выберите категорию для фильтрации", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				string filterCategory = comboBox1.SelectedItem.ToString();
				string filterValue = textBox5.Text.ToLower();

				var filteredList = BusPark.originalBusList.Where(bus =>
				{
					switch (filterCategory)
					{
						case "Госномер":
							return bus.CarNumber.ToLower().Contains(filterValue);
						case "Водитель":
							return bus.Driver.ToLower().Contains(filterValue);
						case "Номер маршрута":
							return bus.RouteNumber.ToLower().Contains(filterValue);
						case "Вместимость":
							return bus.Capacity.ToString().Contains(filterValue);
						case "Год выпуска":
							return bus.ReleaseYear.ToString().Contains(filterValue);
						default:
							return false;
					}
				}).ToList();

				BusPark.busList = filteredList;
				UpdateAllUI();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при фильтрации: " + ex.Message,
							  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{
			BusPark.busList = new List<BusPark>(BusPark.originalBusList);
			UpdateAllUI();
			textBox5.Text = "";
		}

		private void ShowObjectsOnDataGridView()
		{
			dataGridView1.Rows.Clear();
			try
			{
				foreach (BusPark bus in BusPark.busList)
				{
					dataGridView1.Rows.Add(
						bus.CarNumber,
						bus.Driver,
						bus.RouteNumber,
						bus.Capacity,
						bus.ReleaseYear
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			Task.Delay(300).ContinueWith(_ =>
			{
				this.Invoke((MethodInvoker)delegate
				{
					PerformSearch();
				});
			});
		}

		private void PerformSearch()
		{
			string searchText = textBox4.Text.Trim().ToLower();

			if (string.IsNullOrEmpty(searchText))
			{
				UpdateAllUI();
				return;
			}

			try
			{
				var searchResults = BusPark.busList.Where(bus =>
					bus.CarNumber.ToLower().Contains(searchText) ||
					bus.Driver.ToLower().Contains(searchText) ||
					bus.RouteNumber.ToLower().Contains(searchText) ||
					bus.Capacity.ToString().Contains(searchText) ||
					bus.ReleaseYear.ToString().Contains(searchText))
					.ToList();

				dataGridView1.Rows.Clear();
				foreach (var bus in searchResults)
				{
					dataGridView1.Rows.Add(
						bus.CarNumber,
						bus.Driver,
						bus.RouteNumber,
						bus.Capacity,
						bus.ReleaseYear
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка",
							  MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void Form2_DriverCreate()
		{
			comboBox2.Items.Clear();
			foreach (Driver driver in Driver.Drivers)
			{
				comboBox2.Items.Add(driver.ID + ". " + driver.FIO);
			}
		}
		public void Form2_DriversChanged(string changeDriver)
		{
			comboBox2.Items.Clear();
			foreach (Driver driver in Driver.Drivers)
			{
				comboBox2.Items.Add(driver.ID + ". " + driver.FIO);
			}
			foreach (BusPark bus in BusPark.busList)
			{
				bool check = true;
				foreach (Driver driver in Driver.Drivers)
				{
					if (bus.Driver == (driver.ID + ". " + driver.FIO))
					{
						check = false;
						break;
					}
				}
				if (check)
				{
					bus.Driver = changeDriver;
				}

			}
			UpdateAllUI();
		}

		private void добавитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(this);
			form2.OnDriversChanged += Form2_DriversChanged;
			form2.OnDriverCreate += Form2_DriverCreate;
			form2.Show();
			form2.FormClosed += (s, args) =>
			{
				добавитьВодителяToolStripMenuItem.Enabled = true;
			};
			добавитьВодителяToolStripMenuItem.Enabled = false;
		}

		private void добавитьМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3(this);
			form3.OnRouteChanged += Form3_RouteChanged;
			form3.OnRouteCreate += Form3_RouteCreate;
			form3.Show();
			form3.FormClosed += (s, args) =>
			{
				добавитьМаршрутToolStripMenuItem.Enabled = true;
			};
			добавитьМаршрутToolStripMenuItem.Enabled = false;
		}

		private void Form3_RouteCreate()
		{
			comboBox3.Items.Clear();
			foreach (RouteNumber routeNumber in RouteNumber.RouteNumbers)
			{
				comboBox3.Items.Add(routeNumber.routeNumber);
			}
		}

		private void Form3_RouteChanged(string changeRoute)
		{
			comboBox3.Items.Clear();
			foreach (RouteNumber routeNumber in RouteNumber.RouteNumbers)
			{
				comboBox3.Items.Add(routeNumber.routeNumber);
			}
			foreach (BusPark bus in BusPark.busList)
			{
				bool check = true;
				foreach (RouteNumber routeNumber in RouteNumber.RouteNumbers)
				{
					if (bus.RouteNumber == routeNumber.routeNumber)
					{
						check = false;
						break;
					}
				}
				if (check)
				{
					bus.RouteNumber = changeRoute;
				}

			}
			UpdateAllUI();
		}
	}
}