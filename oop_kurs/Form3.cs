using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_kurs
{
	public partial class Form3 : Form
	{
		private Form1 mainForm;
		public event Action OnRouteCreate;
		public event Action<string> OnRouteChanged;
		public Form3(Form1 form1)
		{
			InitializeComponent();
			mainForm = form1;
			ShowObjectsOnDataGridView();
		}

		private void createObjectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
				|| string.IsNullOrEmpty(textBox3.Text))
			{
				MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				string routenumber = textBox1.Text;
				string start = textBox2.Text;
				string end = textBox3.Text;
				foreach (RouteNumber exitingRoute in RouteNumber.RouteNumbers)
				{
					if (exitingRoute.routeNumber == routenumber)
					{
						throw new Exception("Маршрут с номером " + routenumber + " уже есть!");
					}
				}
				RouteNumber newRoute = new RouteNumber(routenumber, start, end);
				RouteNumber.RouteNumbers.Add(newRoute);
				OnRouteCreate?.Invoke();
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
				MessageBox.Show("Введите номер маршрута для удаления", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				string deleteRouteNumber = textBox1.Text;
				bool isDeleted = false;

				for (int i = 0; i < RouteNumber.RouteNumbers.Count; i++)
				{
					if (RouteNumber.RouteNumbers[i].routeNumber == deleteRouteNumber)
					{
						RouteNumber.RouteNumbers.RemoveAt(i);
						isDeleted = true;
						break;
					}
				}

				if (isDeleted)
				{
					OnRouteChanged?.Invoke("Отсутствует");
					ShowObjectsOnDataGridView();
					MessageBox.Show($"Маршрут с номером {deleteRouteNumber} удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					textBox2.Text = "";
					textBox3.Text = "";
				}
				else
				{
					MessageBox.Show($"Маршрут с номером {deleteRouteNumber} не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				string routenumber = textBox1.Text;
				string start = textBox2.Text;
				string end = textBox3.Text;
				RouteNumber newRouteNumber = new RouteNumber(routenumber, start, end);
				RouteNumber routeNumberToUpdate = null;
				foreach (RouteNumber routeNumber in RouteNumber.RouteNumbers)
				{
					if (routeNumber.routeNumber == routenumber)
					{
						routeNumberToUpdate = newRouteNumber;
						break;
					}
				}

				if (routeNumberToUpdate != null)
				{
					routeNumberToUpdate.Start = start;
					routeNumberToUpdate.End = end;
					ShowObjectsOnDataGridView();
					MessageBox.Show($"Обновлены для маршрута с номером: {routenumber}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show($"Не найден маршрут с номером: {routenumber}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				foreach (RouteNumber routenumber in RouteNumber.RouteNumbers)
				{
					dataGridView1.Rows.Add(
						routenumber.routeNumber,
						routenumber.Start,
						routenumber.End
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
