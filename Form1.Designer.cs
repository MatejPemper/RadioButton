namespace radioButton
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1Avion = new System.Windows.Forms.RadioButton();
            this.radioButton2Autobus = new System.Windows.Forms.RadioButton();
            this.radioButton3Vlastiti = new System.Windows.Forms.RadioButton();
            this.button1Rezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3Vlastiti);
            this.groupBox1.Controls.Add(this.radioButton2Autobus);
            this.groupBox1.Controls.Add(this.radioButton1Avion);
            this.groupBox1.Location = new System.Drawing.Point(288, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // radioButton1Avion
            // 
            this.radioButton1Avion.AutoSize = true;
            this.radioButton1Avion.Location = new System.Drawing.Point(29, 20);
            this.radioButton1Avion.Name = "radioButton1Avion";
            this.radioButton1Avion.Size = new System.Drawing.Size(52, 17);
            this.radioButton1Avion.TabIndex = 0;
            this.radioButton1Avion.TabStop = true;
            this.radioButton1Avion.Text = "Avion";
            this.radioButton1Avion.UseVisualStyleBackColor = true;
            // 
            // radioButton2Autobus
            // 
            this.radioButton2Autobus.AutoSize = true;
            this.radioButton2Autobus.Location = new System.Drawing.Point(29, 44);
            this.radioButton2Autobus.Name = "radioButton2Autobus";
            this.radioButton2Autobus.Size = new System.Drawing.Size(64, 17);
            this.radioButton2Autobus.TabIndex = 1;
            this.radioButton2Autobus.TabStop = true;
            this.radioButton2Autobus.Text = "Autobus";
            this.radioButton2Autobus.UseVisualStyleBackColor = true;
            // 
            // radioButton3Vlastiti
            // 
            this.radioButton3Vlastiti.AutoSize = true;
            this.radioButton3Vlastiti.Location = new System.Drawing.Point(29, 68);
            this.radioButton3Vlastiti.Name = "radioButton3Vlastiti";
            this.radioButton3Vlastiti.Size = new System.Drawing.Size(94, 17);
            this.radioButton3Vlastiti.TabIndex = 2;
            this.radioButton3Vlastiti.TabStop = true;
            this.radioButton3Vlastiti.Text = "Vlastiti prijevoz";
            this.radioButton3Vlastiti.UseVisualStyleBackColor = true;
            // 
            // button1Rezerviraj
            // 
            this.button1Rezerviraj.Location = new System.Drawing.Point(336, 180);
            this.button1Rezerviraj.Name = "button1Rezerviraj";
            this.button1Rezerviraj.Size = new System.Drawing.Size(75, 23);
            this.button1Rezerviraj.TabIndex = 1;
            this.button1Rezerviraj.Text = "Rezerviraj";
            this.button1Rezerviraj.UseVisualStyleBackColor = true;
            this.button1Rezerviraj.Click += new System.EventHandler(this.button1Rezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 115);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1Rezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3Vlastiti;
        private System.Windows.Forms.RadioButton radioButton2Autobus;
        private System.Windows.Forms.RadioButton radioButton1Avion;
        private System.Windows.Forms.Button button1Rezerviraj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

