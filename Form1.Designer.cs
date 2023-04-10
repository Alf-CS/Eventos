namespace Eventos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDinners = new System.Windows.Forms.TabPage();
            this.tabBirthdays = new System.Windows.Forms.TabPage();
            this.checkBoxLuxeDecoration = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.labelTextOnCake = new System.Windows.Forms.Label();
            this.textBoxTextOnCake = new System.Windows.Forms.TextBox();
            this.labelCostDinner = new System.Windows.Forms.Label();
            this.textBoxCostDinner = new System.Windows.Forms.TextBox();
            this.labelCostBirthday = new System.Windows.Forms.Label();
            this.textBoxCostBirthday = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabDinners.SuspendLayout();
            this.tabBirthdays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDinners);
            this.tabControl1.Controls.Add(this.tabBirthdays);
            this.tabControl1.Location = new System.Drawing.Point(59, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDinners
            // 
            this.tabDinners.Controls.Add(this.textBoxCostDinner);
            this.tabDinners.Controls.Add(this.labelCostDinner);
            this.tabDinners.Controls.Add(this.checkBoxHealthyOption);
            this.tabDinners.Location = new System.Drawing.Point(4, 29);
            this.tabDinners.Name = "tabDinners";
            this.tabDinners.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinners.Size = new System.Drawing.Size(458, 191);
            this.tabDinners.TabIndex = 0;
            this.tabDinners.Text = "Cenas";
            this.tabDinners.UseVisualStyleBackColor = true;
            // 
            // tabBirthdays
            // 
            this.tabBirthdays.Controls.Add(this.textBoxCostBirthday);
            this.tabBirthdays.Controls.Add(this.labelCostBirthday);
            this.tabBirthdays.Controls.Add(this.textBoxTextOnCake);
            this.tabBirthdays.Controls.Add(this.labelTextOnCake);
            this.tabBirthdays.Location = new System.Drawing.Point(4, 29);
            this.tabBirthdays.Name = "tabBirthdays";
            this.tabBirthdays.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthdays.Size = new System.Drawing.Size(458, 191);
            this.tabBirthdays.TabIndex = 1;
            this.tabBirthdays.Text = "Cumpleaños";
            this.tabBirthdays.UseVisualStyleBackColor = true;
            // 
            // checkBoxLuxeDecoration
            // 
            this.checkBoxLuxeDecoration.AutoSize = true;
            this.checkBoxLuxeDecoration.Location = new System.Drawing.Point(135, 72);
            this.checkBoxLuxeDecoration.Name = "checkBoxLuxeDecoration";
            this.checkBoxLuxeDecoration.Size = new System.Drawing.Size(160, 24);
            this.checkBoxLuxeDecoration.TabIndex = 1;
            this.checkBoxLuxeDecoration.Text = "Decoración de Lujo";
            this.checkBoxLuxeDecoration.UseVisualStyleBackColor = true;
            this.checkBoxLuxeDecoration.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxHealthyOption
            // 
            this.checkBoxHealthyOption.AutoSize = true;
            this.checkBoxHealthyOption.Location = new System.Drawing.Point(62, 50);
            this.checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            this.checkBoxHealthyOption.Size = new System.Drawing.Size(149, 24);
            this.checkBoxHealthyOption.TabIndex = 0;
            this.checkBoxHealthyOption.Text = "Opción Saludable";
            this.checkBoxHealthyOption.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(135, 39);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(147, 20);
            this.labelNumberOfPeople.TabIndex = 2;
            this.labelNumberOfPeople.Text = "Número de personas";
            // 
            // numericUpDownNumberOfPeople
            // 
            this.numericUpDownNumberOfPeople.Location = new System.Drawing.Point(300, 37);
            this.numericUpDownNumberOfPeople.Name = "numericUpDownNumberOfPeople";
            this.numericUpDownNumberOfPeople.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownNumberOfPeople.TabIndex = 3;
            // 
            // labelTextOnCake
            // 
            this.labelTextOnCake.AutoSize = true;
            this.labelTextOnCake.Location = new System.Drawing.Point(42, 49);
            this.labelTextOnCake.Name = "labelTextOnCake";
            this.labelTextOnCake.Size = new System.Drawing.Size(119, 20);
            this.labelTextOnCake.TabIndex = 0;
            this.labelTextOnCake.Text = "Texto en la tarta:";
            // 
            // textBoxTextOnCake
            // 
            this.textBoxTextOnCake.Location = new System.Drawing.Point(42, 72);
            this.textBoxTextOnCake.Name = "textBoxTextOnCake";
            this.textBoxTextOnCake.Size = new System.Drawing.Size(347, 27);
            this.textBoxTextOnCake.TabIndex = 1;
            // 
            // labelCostDinner
            // 
            this.labelCostDinner.AutoSize = true;
            this.labelCostDinner.Location = new System.Drawing.Point(60, 118);
            this.labelCostDinner.Name = "labelCostDinner";
            this.labelCostDinner.Size = new System.Drawing.Size(49, 20);
            this.labelCostDinner.TabIndex = 1;
            this.labelCostDinner.Text = "Coste:";
            // 
            // textBoxCostDinner
            // 
            this.textBoxCostDinner.Location = new System.Drawing.Point(115, 111);
            this.textBoxCostDinner.Name = "textBoxCostDinner";
            this.textBoxCostDinner.Size = new System.Drawing.Size(125, 27);
            this.textBoxCostDinner.TabIndex = 2;
            // 
            // labelCostBirthday
            // 
            this.labelCostBirthday.AutoSize = true;
            this.labelCostBirthday.Location = new System.Drawing.Point(42, 132);
            this.labelCostBirthday.Name = "labelCostBirthday";
            this.labelCostBirthday.Size = new System.Drawing.Size(133, 20);
            this.labelCostBirthday.TabIndex = 2;
            this.labelCostBirthday.Text = "Coste cumpleaños:";
            // 
            // textBoxCostBirthday
            // 
            this.textBoxCostBirthday.Location = new System.Drawing.Point(198, 125);
            this.textBoxCostBirthday.Name = "textBoxCostBirthday";
            this.textBoxCostBirthday.Size = new System.Drawing.Size(125, 27);
            this.textBoxCostBirthday.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownNumberOfPeople);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.checkBoxLuxeDecoration);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDinners.ResumeLayout(false);
            this.tabDinners.PerformLayout();
            this.tabBirthdays.ResumeLayout(false);
            this.tabBirthdays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDinners;
        private TabPage tabBirthdays;
        private CheckBox checkBoxLuxeDecoration;
        private TextBox textBoxCostDinner;
        private Label labelCostDinner;
        private CheckBox checkBoxHealthyOption;
        private TextBox textBoxCostBirthday;
        private Label labelCostBirthday;
        private TextBox textBoxTextOnCake;
        private Label labelTextOnCake;
        private Label labelNumberOfPeople;
        private NumericUpDown numericUpDownNumberOfPeople;
    }
}