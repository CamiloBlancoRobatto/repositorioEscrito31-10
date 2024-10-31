namespace capaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(786, 148);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 13;
            button2.Text = "ELIMINACION";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(786, 67);
            button4.Name = "button4";
            button4.Size = new Size(127, 47);
            button4.TabIndex = 15;
            button4.Text = "REFRESCAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 485);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 12;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(213, 485);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 14;
            button3.Text = "Modificacion";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(636, 439);
            button5.Name = "button5";
            button5.Size = new Size(154, 23);
            button5.TabIndex = 16;
            button5.Text = "ALTA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(147, 383);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(147, 409);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaption;
            textBox4.Location = new Point(147, 436);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(646, 383);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(132, 23);
            textBox6.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 391);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 25;
            label2.Text = "direccion de propiedad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 412);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 26;
            label3.Text = "metros cuadrados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 439);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 27;
            label4.Text = "precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(565, 386);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 29;
            label6.Text = "Iva a la venta";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "casa", "apartamento", "terreno" });
            comboBox1.Location = new Point(147, 358);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 361);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 31;
            label1.Text = "tipo propiedad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(62, 320);
            label5.Name = "label5";
            label5.Size = new Size(237, 30);
            label5.TabIndex = 32;
            label5.Text = "AGREGAR PROPIEDAD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(613, 320);
            label7.Name = "label7";
            label7.Size = new Size(186, 30);
            label7.TabIndex = 33;
            label7.Text = "AGREGAR VENTA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1044, 574);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private Label label1;
        private Label label5;
        private Label label7;
    }
}