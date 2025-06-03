using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_kurs
{
	public partial class Form2 : Form
	{
		private Form1 mainForm;
		public event Action OnDriverCreate;
		public event Action<string> OnDriversChanged;
		public Form2(Form1 form1)
		{
			InitializeComponent();
			mainForm = form1;
			ShowObjectsOnDataGridView();
		}

		private void createObjectButton_Click(object sender, EventArgs e)
		{
			if (numericUpDown1.Value == 0 || string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				int id = (int) numericUpDown1.Value;
				string fio = textBox1.Text;
				string bDate = dateTimePicker1.Value.ToShortDateString();
				foreach (Driver exitingDriver in Driver.Drivers)
				{
					if (exitingDriver.ID == id)
					{
						throw new Exception("Водитель с индексом " + id + " уже есть!");
					}
				}
				Driver newDriver = new Driver(id, fio, bDate);
				Driver.Drivers.Add(newDriver);
				OnDriverCreate?.Invoke();
				ShowObjectsOnDataGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при добавлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteObjectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Введите id водителя для удаления", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				int deleteId = (int) numericUpDown1.Value;
				bool isDeleted = false;

				for (int i = 0; i < Driver.Drivers.Count; i++)
				{
					if (Driver.Drivers[i].ID == deleteId)
					{
						Driver.Drivers.RemoveAt(i);
						isDeleted = true;
						break;
					}
				}

				if (isDeleted)
				{
					OnDriversChanged?.Invoke("Отсутствует");
					ShowObjectsOnDataGridView();
					MessageBox.Show($"Водитель с id {deleteId} удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					numericUpDown1.Value = numericUpDown1.Minimum;
					textBox1.Text = "";
					dateTimePicker1.Value = dateTimePicker1.MinDate;
				}
				else
				{
					MessageBox.Show($"Водитель с id {deleteId} не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void changeObjectButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)numericUpDown1.Value;
				string fio = textBox1.Text;
				string bDate = dateTimePicker1.Value.ToShortDateString();
				Driver newDriver = new Driver(id, fio, bDate);
				Driver driverToUpdate = null;
				foreach (Driver driver in Driver.Drivers)
				{
					if (driver.ID == id)
					{
						driverToUpdate = newDriver;
						break;
					}
				}

				if (driverToUpdate != null)
				{
					driverToUpdate.FIO = fio;
					driverToUpdate.BDate = bDate;
					ShowObjectsOnDataGridView();
					OnDriversChanged?.Invoke(newDriver.ID + ". " + newDriver.FIO);
					MessageBox.Show($"Обновлены данные водителя с id: {id}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show($"Не найден водитель с id: {id}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при изменении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ShowObjectsOnDataGridView()
		{
			dataGridView1.Rows.Clear();
			try
			{
				foreach (Driver driver in Driver.Drivers)
				{
					dataGridView1.Rows.Add(
						driver.ID,
						driver.FIO,
						driver.BDate
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
