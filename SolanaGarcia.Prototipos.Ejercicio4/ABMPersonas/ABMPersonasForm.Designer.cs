﻿namespace SolanaGarcia.Prototipos.Ejercicio4
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
            listView1 = new ListView();
            DNI = new ColumnHeader();
            Nombre = new ColumnHeader();
            Apellido = new ColumnHeader();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            Aceptar = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { DNI, Nombre, Apellido });
            listView1.Location = new Point(12, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(853, 146);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 190);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 27);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 27);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // button1
            // 
            button1.Location = new Point(737, 158);
            button1.Name = "button1";
            button1.Size = new Size(128, 38);
            button1.TabIndex = 2;
            button1.Text = "Nueva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(524, 160);
            button2.Name = "button2";
            button2.Size = new Size(207, 34);
            button2.TabIndex = 3;
            button2.Text = "Borrar seleccionado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(308, 160);
            button3.Name = "button3";
            button3.Size = new Size(210, 30);
            button3.TabIndex = 4;
            button3.Text = "Modificar seleccionado";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(402, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 31);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 101);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 6;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 101);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 7;
            label5.Text = "Cod Pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 101);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 8;
            label6.Text = "Cod Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 101);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 9;
            label7.Text = "Numero";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(196, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(382, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 31);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(550, 129);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 31);
            textBox7.TabIndex = 13;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(470, 442);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(181, 30);
            Aceptar.TabIndex = 5;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += button4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(676, 442);
            button4.Name = "button4";
            button4.Size = new Size(153, 30);
            button4.TabIndex = 6;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 511);
            Controls.Add(button4);
            Controls.Add(Aceptar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader DNI;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button Aceptar;
        private Button button4;
    }
}
