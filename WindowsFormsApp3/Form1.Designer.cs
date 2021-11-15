namespace WindowsFormsApp3
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
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.лаба2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.задние2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(266, 344);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Включить питание",
            "Включить генератор",
            "Включить насосы",
            "Включить левый ЭРД ",
            "Включить правый ЭРД ",
            "Открыть кран ВСУ",
            "Включить ВСУ",
            "Выбрать левый двигатель",
            "Выбрать правый двигатель",
            "Открыть кран левого двигателя",
            "Открыть кран правого двигателя",
            "Отпустить тормоз винтов",
            "Выбрать левый редуктор",
            "Выбрать правый редуктор",
            "Запустить двигатель",
            "Вывести РУД левого двигателя",
            "Вывести РУД правого двигателя",
            "Отключить ВСУ"});
			this.listBox1.Location = new System.Drawing.Point(33, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox1.Size = new System.Drawing.Size(170, 290);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(423, 32);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(170, 290);
			this.listBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(225, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Результат: Двигатель запущен";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Левый",
            "Правый"});
			this.comboBox1.Location = new System.Drawing.Point(228, 110);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(124, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Двигатель для запуска";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лаба2ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(629, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// лаба2ToolStripMenuItem
			// 
			this.лаба2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задние2ToolStripMenuItem,
            this.калькуляторToolStripMenuItem});
			this.лаба2ToolStripMenuItem.Name = "лаба2ToolStripMenuItem";
			this.лаба2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.лаба2ToolStripMenuItem.Text = "Лаба 2";
			// 
			// задание1ToolStripMenuItem
			// 
			this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
			this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.задание1ToolStripMenuItem.Text = "Задание 1";
			this.задание1ToolStripMenuItem.Click += new System.EventHandler(this.задание1ToolStripMenuItem_Click);
			// 
			// задние2ToolStripMenuItem
			// 
			this.задние2ToolStripMenuItem.Name = "задние2ToolStripMenuItem";
			this.задние2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.задние2ToolStripMenuItem.Text = "Задание 2";
			this.задние2ToolStripMenuItem.Click += new System.EventHandler(this.задние2ToolStripMenuItem_Click);
			// 
			// калькуляторToolStripMenuItem
			// 
			this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
			this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.калькуляторToolStripMenuItem.Text = "Калькулятор";
			this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 406);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem лаба2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem задание1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem задние2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
	}
}

