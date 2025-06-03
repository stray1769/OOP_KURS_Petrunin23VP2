namespace oop_kurs
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			groupBox1 = new GroupBox();
			comboBox3 = new ComboBox();
			comboBox2 = new ComboBox();
			numericUpDown2 = new NumericUpDown();
			numericUpDown1 = new NumericUpDown();
			textBox1 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			deleteObjectButton = new Button();
			changeObjectButton = new Button();
			createObjectButton = new Button();
			cancelButton = new Button();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			groupBox3 = new GroupBox();
			textBox5 = new TextBox();
			filtredDataGridViewButton = new Button();
			comboBox1 = new ComboBox();
			textBox4 = new TextBox();
			groupBox4 = new GroupBox();
			menuStrip1 = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			deleteAllToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			добавитьВодителяToolStripMenuItem = new ToolStripMenuItem();
			добавитьМаршрутToolStripMenuItem = new ToolStripMenuItem();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(comboBox3);
			groupBox1.Controls.Add(comboBox2);
			groupBox1.Controls.Add(numericUpDown2);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(20, 52);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(421, 287);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Данные об автобусе";
			// 
			// comboBox3
			// 
			comboBox3.BackColor = SystemColors.Window;
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(186, 131);
			comboBox3.Margin = new Padding(3, 4, 3, 4);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(185, 33);
			comboBox3.TabIndex = 12;
			// 
			// comboBox2
			// 
			comboBox2.BackColor = SystemColors.Window;
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(186, 81);
			comboBox2.Margin = new Padding(3, 4, 3, 4);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(185, 33);
			comboBox2.TabIndex = 11;
			// 
			// numericUpDown2
			// 
			numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
			numericUpDown2.Location = new Point(186, 232);
			numericUpDown2.Margin = new Padding(3, 4, 3, 4);
			numericUpDown2.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(133, 31);
			numericUpDown2.TabIndex = 0;
			numericUpDown2.Value = new decimal(new int[] { 2025, 0, 0, 0 });
			// 
			// numericUpDown1
			// 
			numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
			numericUpDown1.Location = new Point(186, 182);
			numericUpDown1.Margin = new Padding(3, 4, 3, 4);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(184, 31);
			numericUpDown1.TabIndex = 8;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(186, 32);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(185, 31);
			textBox1.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(9, 134);
			label5.Name = "label5";
			label5.Size = new Size(166, 25);
			label5.TabIndex = 4;
			label5.Text = "Номер маршрута: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(9, 84);
			label4.Name = "label4";
			label4.Size = new Size(96, 25);
			label4.TabIndex = 3;
			label4.Text = "Водитель: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(9, 184);
			label3.Name = "label3";
			label3.Size = new Size(126, 25);
			label3.TabIndex = 2;
			label3.Text = "Вместимость: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(9, 234);
			label2.Name = "label2";
			label2.Size = new Size(123, 25);
			label2.TabIndex = 1;
			label2.Text = "Год выпуска: ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 34);
			label1.Name = "label1";
			label1.Size = new Size(102, 25);
			label1.TabIndex = 0;
			label1.Text = "Госномер: ";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(deleteObjectButton);
			groupBox2.Controls.Add(changeObjectButton);
			groupBox2.Controls.Add(createObjectButton);
			groupBox2.Location = new Point(447, 52);
			groupBox2.Margin = new Padding(3, 4, 3, 4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 4, 3, 4);
			groupBox2.Size = new Size(292, 287);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Действия";
			// 
			// deleteObjectButton
			// 
			deleteObjectButton.BackColor = SystemColors.ScrollBar;
			deleteObjectButton.FlatStyle = FlatStyle.Popup;
			deleteObjectButton.Location = new Point(49, 102);
			deleteObjectButton.Margin = new Padding(3, 4, 3, 4);
			deleteObjectButton.Name = "deleteObjectButton";
			deleteObjectButton.Size = new Size(193, 48);
			deleteObjectButton.TabIndex = 2;
			deleteObjectButton.Text = "Удалить";
			deleteObjectButton.UseVisualStyleBackColor = false;
			deleteObjectButton.Click += button3_Click;
			// 
			// changeObjectButton
			// 
			changeObjectButton.BackColor = SystemColors.ScrollBar;
			changeObjectButton.FlatStyle = FlatStyle.Popup;
			changeObjectButton.Location = new Point(49, 165);
			changeObjectButton.Margin = new Padding(3, 4, 3, 4);
			changeObjectButton.Name = "changeObjectButton";
			changeObjectButton.Size = new Size(193, 48);
			changeObjectButton.TabIndex = 1;
			changeObjectButton.Text = "Изменить";
			changeObjectButton.UseVisualStyleBackColor = false;
			changeObjectButton.Click += button2_Click;
			// 
			// createObjectButton
			// 
			createObjectButton.BackColor = SystemColors.ScrollBar;
			createObjectButton.FlatStyle = FlatStyle.Popup;
			createObjectButton.Location = new Point(49, 40);
			createObjectButton.Margin = new Padding(3, 4, 3, 4);
			createObjectButton.Name = "createObjectButton";
			createObjectButton.Size = new Size(193, 48);
			createObjectButton.TabIndex = 0;
			createObjectButton.Text = "Добавить";
			createObjectButton.UseVisualStyleBackColor = false;
			createObjectButton.Click += button1_Click;
			// 
			// cancelButton
			// 
			cancelButton.BackColor = SystemColors.ScrollBar;
			cancelButton.FlatStyle = FlatStyle.Popup;
			cancelButton.Location = new Point(36, 212);
			cancelButton.Margin = new Padding(3, 4, 3, 4);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(193, 48);
			cancelButton.TabIndex = 4;
			cancelButton.Text = "Сбросить";
			cancelButton.UseVisualStyleBackColor = false;
			cancelButton.Click += button5_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
			dataGridView1.Location = new Point(20, 461);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 28;
			dataGridView1.Size = new Size(992, 264);
			dataGridView1.TabIndex = 5;
			// 
			// Column1
			// 
			Column1.HeaderText = "Госномер";
			Column1.MinimumWidth = 8;
			Column1.Name = "Column1";
			Column1.Width = 150;
			// 
			// Column2
			// 
			Column2.HeaderText = "Водитель";
			Column2.MinimumWidth = 8;
			Column2.Name = "Column2";
			Column2.Width = 150;
			// 
			// Column3
			// 
			Column3.HeaderText = "Номер маршрута";
			Column3.MinimumWidth = 8;
			Column3.Name = "Column3";
			Column3.Width = 150;
			// 
			// Column4
			// 
			Column4.HeaderText = "Вместимость";
			Column4.MinimumWidth = 8;
			Column4.Name = "Column4";
			Column4.Width = 150;
			// 
			// Column5
			// 
			Column5.HeaderText = "Год выпуска";
			Column5.MinimumWidth = 8;
			Column5.Name = "Column5";
			Column5.Width = 150;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(textBox5);
			groupBox3.Controls.Add(filtredDataGridViewButton);
			groupBox3.Controls.Add(comboBox1);
			groupBox3.Controls.Add(cancelButton);
			groupBox3.Location = new Point(745, 52);
			groupBox3.Margin = new Padding(3, 4, 3, 4);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(3, 4, 3, 4);
			groupBox3.Size = new Size(280, 287);
			groupBox3.TabIndex = 6;
			groupBox3.TabStop = false;
			groupBox3.Text = "Фильтрация";
			// 
			// textBox5
			// 
			textBox5.BorderStyle = BorderStyle.FixedSingle;
			textBox5.Location = new Point(36, 91);
			textBox5.Margin = new Padding(3, 4, 3, 4);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(193, 31);
			textBox5.TabIndex = 9;
			// 
			// filtredDataGridViewButton
			// 
			filtredDataGridViewButton.BackColor = SystemColors.ScrollBar;
			filtredDataGridViewButton.FlatStyle = FlatStyle.Popup;
			filtredDataGridViewButton.Location = new Point(36, 142);
			filtredDataGridViewButton.Margin = new Padding(3, 4, 3, 4);
			filtredDataGridViewButton.Name = "filtredDataGridViewButton";
			filtredDataGridViewButton.Size = new Size(193, 48);
			filtredDataGridViewButton.TabIndex = 7;
			filtredDataGridViewButton.Text = "Фильтровать";
			filtredDataGridViewButton.UseVisualStyleBackColor = false;
			filtredDataGridViewButton.Click += button6_Click;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = SystemColors.Window;
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(36, 40);
			comboBox1.Margin = new Padding(3, 4, 3, 4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(193, 33);
			comboBox1.TabIndex = 10;
			// 
			// textBox4
			// 
			textBox4.BorderStyle = BorderStyle.FixedSingle;
			textBox4.Location = new Point(24, 45);
			textBox4.Margin = new Padding(3, 4, 3, 4);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(429, 31);
			textBox4.TabIndex = 9;
			textBox4.TextChanged += textBox4_TextChanged;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(textBox4);
			groupBox4.Location = new Point(20, 346);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(481, 105);
			groupBox4.TabIndex = 12;
			groupBox4.TabStop = false;
			groupBox4.Text = "Поиск";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, добавитьВодителяToolStripMenuItem, добавитьМаршрутToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1134, 33);
			menuStrip1.TabIndex = 13;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, deleteAllToolStripMenuItem, saveToolStripMenuItem });
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(129, 29);
			toolStripMenuItem1.Text = "База данных";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(306, 34);
			openToolStripMenuItem.Text = "Открыть";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new Size(306, 34);
			newToolStripMenuItem.Text = "Создать базу данных";
			newToolStripMenuItem.Click += newToolStripMenuItem_Click;
			// 
			// deleteAllToolStripMenuItem
			// 
			deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
			deleteAllToolStripMenuItem.Size = new Size(306, 34);
			deleteAllToolStripMenuItem.Text = "Удалить базу данных";
			deleteAllToolStripMenuItem.Click += deleteAllToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(306, 34);
			saveToolStripMenuItem.Text = "Сохранить базу данных";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// добавитьВодителяToolStripMenuItem
			// 
			добавитьВодителяToolStripMenuItem.Name = "добавитьВодителяToolStripMenuItem";
			добавитьВодителяToolStripMenuItem.Size = new Size(186, 29);
			добавитьВодителяToolStripMenuItem.Text = "Добавить водителя";
			добавитьВодителяToolStripMenuItem.Click += добавитьВодителяToolStripMenuItem_Click;
			// 
			// добавитьМаршрутToolStripMenuItem
			// 
			добавитьМаршрутToolStripMenuItem.Name = "добавитьМаршрутToolStripMenuItem";
			добавитьМаршрутToolStripMenuItem.Size = new Size(185, 29);
			добавитьМаршрутToolStripMenuItem.Text = "Добавить маршрут";
			добавитьМаршрутToolStripMenuItem.Click += добавитьМаршрутToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1134, 744);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			Name = "Form1";
			Text = "Автобусный парк";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button deleteObjectButton;
		private System.Windows.Forms.Button createObjectButton;
		private System.Windows.Forms.Button changeObjectButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button filtredDataGridViewButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private TextBox textBox4;
		private GroupBox groupBox4;
		private TextBox textBox5;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem deleteAllToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem добавитьВодителяToolStripMenuItem;
		private ToolStripMenuItem добавитьМаршрутToolStripMenuItem;
		private ComboBox comboBox3;
		private ComboBox comboBox2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private ToolStripMenuItem openToolStripMenuItem;
	}
}