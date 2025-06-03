namespace oop_kurs
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			groupBox2 = new GroupBox();
			deleteObjectButton = new Button();
			changeObjectButton = new Button();
			createObjectButton = new Button();
			groupBox1 = new GroupBox();
			numericUpDown1 = new NumericUpDown();
			dateTimePicker1 = new DateTimePicker();
			textBox1 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(deleteObjectButton);
			groupBox2.Controls.Add(changeObjectButton);
			groupBox2.Controls.Add(createObjectButton);
			groupBox2.Location = new Point(391, 13);
			groupBox2.Margin = new Padding(3, 4, 3, 4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 4, 3, 4);
			groupBox2.Size = new Size(292, 179);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Действия";
			// 
			// deleteObjectButton
			// 
			deleteObjectButton.BackColor = SystemColors.ScrollBar;
			deleteObjectButton.FlatStyle = FlatStyle.Popup;
			deleteObjectButton.Location = new Point(49, 80);
			deleteObjectButton.Margin = new Padding(3, 4, 3, 4);
			deleteObjectButton.Name = "deleteObjectButton";
			deleteObjectButton.Size = new Size(193, 34);
			deleteObjectButton.TabIndex = 2;
			deleteObjectButton.Text = "Удалить";
			deleteObjectButton.UseVisualStyleBackColor = false;
			deleteObjectButton.Click += deleteObjectButton_Click;
			// 
			// changeObjectButton
			// 
			changeObjectButton.BackColor = SystemColors.ScrollBar;
			changeObjectButton.FlatStyle = FlatStyle.Popup;
			changeObjectButton.Location = new Point(49, 132);
			changeObjectButton.Margin = new Padding(3, 4, 3, 4);
			changeObjectButton.Name = "changeObjectButton";
			changeObjectButton.Size = new Size(193, 34);
			changeObjectButton.TabIndex = 1;
			changeObjectButton.Text = "Изменить";
			changeObjectButton.UseVisualStyleBackColor = false;
			changeObjectButton.Click += changeObjectButton_Click;
			// 
			// createObjectButton
			// 
			createObjectButton.BackColor = SystemColors.ScrollBar;
			createObjectButton.FlatStyle = FlatStyle.Popup;
			createObjectButton.Location = new Point(49, 30);
			createObjectButton.Margin = new Padding(3, 4, 3, 4);
			createObjectButton.Name = "createObjectButton";
			createObjectButton.Size = new Size(193, 34);
			createObjectButton.TabIndex = 0;
			createObjectButton.Text = "Добавить";
			createObjectButton.UseVisualStyleBackColor = false;
			createObjectButton.Click += createObjectButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(dateTimePicker1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(14, 13);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(371, 179);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Данные о водителе";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(169, 35);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(185, 31);
			numericUpDown1.TabIndex = 7;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(169, 131);
			dateTimePicker1.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
			dateTimePicker1.MinDate = new DateTime(1925, 1, 1, 0, 0, 0, 0);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(185, 31);
			dateTimePicker1.TabIndex = 6;
			dateTimePicker1.Value = new DateTime(1980, 1, 1, 0, 0, 0, 0);
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(169, 83);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(185, 31);
			textBox1.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(9, 137);
			label5.Name = "label5";
			label5.Size = new Size(146, 25);
			label5.TabIndex = 4;
			label5.Text = "Дата рождения: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(9, 85);
			label4.Name = "label4";
			label4.Size = new Size(61, 25);
			label4.TabIndex = 3;
			label4.Text = "ФИО: ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 35);
			label1.Name = "label1";
			label1.Size = new Size(36, 25);
			label1.TabIndex = 0;
			label1.Text = "id: ";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
			dataGridView1.Location = new Point(14, 199);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(669, 240);
			dataGridView1.TabIndex = 4;
			// 
			// Column1
			// 
			Column1.HeaderText = "id";
			Column1.MinimumWidth = 8;
			Column1.Name = "Column1";
			Column1.Width = 150;
			// 
			// Column2
			// 
			Column2.HeaderText = "ФИО";
			Column2.MinimumWidth = 8;
			Column2.Name = "Column2";
			Column2.Width = 150;
			// 
			// Column3
			// 
			Column3.HeaderText = "Дата рождения";
			Column3.MinimumWidth = 8;
			Column3.Name = "Column3";
			Column3.Width = 150;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(697, 448);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form2";
			Text = "Водители";
			groupBox2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox2;
		private Button deleteObjectButton;
		private Button changeObjectButton;
		private Button createObjectButton;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private Label label1;
		private DateTimePicker dateTimePicker1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
	}
}