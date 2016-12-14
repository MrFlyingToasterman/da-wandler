namespace da_wandler
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.eingabe_bin_box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.eingabe_vol_box = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ausgabe_bin_box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Bin_verlauf = new System.Windows.Forms.TextBox();
            this.Volt_verlauf = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ausgabe_vol_box = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.eingabe_bin_box);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe Binär";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Wandeln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eingabe_bin_box
            // 
            this.eingabe_bin_box.Location = new System.Drawing.Point(6, 19);
            this.eingabe_bin_box.MaxLength = 4;
            this.eingabe_bin_box.Name = "eingabe_bin_box";
            this.eingabe_bin_box.Size = new System.Drawing.Size(188, 20);
            this.eingabe_bin_box.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.eingabe_vol_box);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingabe Volt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Wandeln";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eingabe_vol_box
            // 
            this.eingabe_vol_box.Location = new System.Drawing.Point(6, 19);
            this.eingabe_vol_box.MaxLength = 2;
            this.eingabe_vol_box.Name = "eingabe_vol_box";
            this.eingabe_vol_box.Size = new System.Drawing.Size(188, 20);
            this.eingabe_vol_box.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ausgabe_vol_box);
            this.groupBox4.Location = new System.Drawing.Point(486, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ausgabe Volt";
            // 
            // ausgabe_bin_box
            // 
            this.ausgabe_bin_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe_bin_box.Location = new System.Drawing.Point(6, 19);
            this.ausgabe_bin_box.Multiline = true;
            this.ausgabe_bin_box.Name = "ausgabe_bin_box";
            this.ausgabe_bin_box.Size = new System.Drawing.Size(188, 75);
            this.ausgabe_bin_box.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(273, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digital / Analog\r\n     Wandler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "-->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "-->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "-->";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Bin_verlauf);
            this.groupBox5.Controls.Add(this.Volt_verlauf);
            this.groupBox5.Location = new System.Drawing.Point(12, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(674, 191);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Verlauf";
            // 
            // Bin_verlauf
            // 
            this.Bin_verlauf.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Bin_verlauf.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bin_verlauf.ForeColor = System.Drawing.Color.Chartreuse;
            this.Bin_verlauf.Location = new System.Drawing.Point(339, 19);
            this.Bin_verlauf.Multiline = true;
            this.Bin_verlauf.Name = "Bin_verlauf";
            this.Bin_verlauf.Size = new System.Drawing.Size(329, 166);
            this.Bin_verlauf.TabIndex = 1;
            this.Bin_verlauf.Text = "Warte auf eingabe...";
            // 
            // Volt_verlauf
            // 
            this.Volt_verlauf.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Volt_verlauf.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volt_verlauf.ForeColor = System.Drawing.Color.Chartreuse;
            this.Volt_verlauf.Location = new System.Drawing.Point(6, 19);
            this.Volt_verlauf.Multiline = true;
            this.Volt_verlauf.Name = "Volt_verlauf";
            this.Volt_verlauf.Size = new System.Drawing.Size(329, 166);
            this.Volt_verlauf.TabIndex = 0;
            this.Volt_verlauf.Text = "Warte auf eingabe...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ausgabe_bin_box);
            this.groupBox3.Location = new System.Drawing.Point(486, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausgabe Binär";
            // 
            // ausgabe_vol_box
            // 
            this.ausgabe_vol_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe_vol_box.Location = new System.Drawing.Point(6, 19);
            this.ausgabe_vol_box.Multiline = true;
            this.ausgabe_vol_box.Name = "ausgabe_vol_box";
            this.ausgabe_vol_box.Size = new System.Drawing.Size(188, 75);
            this.ausgabe_vol_box.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 427);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DA Wandler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Volt_verlauf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eingabe_bin_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox eingabe_vol_box;
        private System.Windows.Forms.TextBox ausgabe_bin_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ausgabe_vol_box;
        private System.Windows.Forms.TextBox Bin_verlauf;
    }
}

