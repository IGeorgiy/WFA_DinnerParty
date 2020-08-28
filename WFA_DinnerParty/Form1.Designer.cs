namespace WFA_DinnerParty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCost = new System.Windows.Forms.Label();
            this.checkBoxFancyDecorations = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthyDecorations = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCakeWriting = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.labelBPNumberOfPeople = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.textBoxWriting = new System.Windows.Forms.TextBox();
            this.labelCostBirthday = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 167);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(161, 167);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelNumberOfPeople);
            this.tabPage1.Controls.Add(this.textBoxCost);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.labelCost);
            this.tabPage1.Controls.Add(this.checkBoxFancyDecorations);
            this.tabPage1.Controls.Add(this.checkBoxHealthyDecorations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(153, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(6, 3);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(91, 13);
            this.labelNumberOfPeople.TabIndex = 1;
            this.labelNumberOfPeople.Text = "Number of people";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(51, 93);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(10, 96);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(36, 13);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Cost:";
            // 
            // checkBoxFancyDecorations
            // 
            this.checkBoxFancyDecorations.AutoSize = true;
            this.checkBoxFancyDecorations.Location = new System.Drawing.Point(9, 46);
            this.checkBoxFancyDecorations.Name = "checkBoxFancyDecorations";
            this.checkBoxFancyDecorations.Size = new System.Drawing.Size(113, 17);
            this.checkBoxFancyDecorations.TabIndex = 2;
            this.checkBoxFancyDecorations.Text = "Fancy decorations";
            this.checkBoxFancyDecorations.UseVisualStyleBackColor = true;
            this.checkBoxFancyDecorations.CheckedChanged += new System.EventHandler(this.checkBoxFancyDecorations_CheckedChanged);
            // 
            // checkBoxHealthyDecorations
            // 
            this.checkBoxHealthyDecorations.AutoSize = true;
            this.checkBoxHealthyDecorations.Location = new System.Drawing.Point(9, 69);
            this.checkBoxHealthyDecorations.Name = "checkBoxHealthyDecorations";
            this.checkBoxHealthyDecorations.Size = new System.Drawing.Size(120, 17);
            this.checkBoxHealthyDecorations.TabIndex = 3;
            this.checkBoxHealthyDecorations.Text = "Healthy decorations";
            this.checkBoxHealthyDecorations.UseVisualStyleBackColor = true;
            this.checkBoxHealthyDecorations.CheckedChanged += new System.EventHandler(this.checkBoxHealthyDecorations_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.labelCostBirthday);
            this.tabPage2.Controls.Add(this.textBoxWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.labelCakeWriting);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.labelBPNumberOfPeople);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(153, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCakeWriting
            // 
            this.labelCakeWriting.AutoSize = true;
            this.labelCakeWriting.Location = new System.Drawing.Point(9, 70);
            this.labelCakeWriting.Name = "labelCakeWriting";
            this.labelCakeWriting.Size = new System.Drawing.Size(68, 13);
            this.labelCakeWriting.TabIndex = 4;
            this.labelCakeWriting.Text = "Cake Writing";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(9, 46);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            // 
            // labelBPNumberOfPeople
            // 
            this.labelBPNumberOfPeople.AutoSize = true;
            this.labelBPNumberOfPeople.Location = new System.Drawing.Point(6, 3);
            this.labelBPNumberOfPeople.Name = "labelBPNumberOfPeople";
            this.labelBPNumberOfPeople.Size = new System.Drawing.Size(91, 13);
            this.labelBPNumberOfPeople.TabIndex = 1;
            this.labelBPNumberOfPeople.Text = "Number of people";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(9, 19);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 0;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(84, 70);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 5;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // textBoxWriting
            // 
            this.textBoxWriting.Location = new System.Drawing.Point(9, 87);
            this.textBoxWriting.Name = "textBoxWriting";
            this.textBoxWriting.Size = new System.Drawing.Size(138, 20);
            this.textBoxWriting.TabIndex = 6;
            this.textBoxWriting.Text = "Happy Birthday";
            // 
            // labelCostBirthday
            // 
            this.labelCostBirthday.AutoSize = true;
            this.labelCostBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostBirthday.Location = new System.Drawing.Point(10, 117);
            this.labelCostBirthday.Name = "labelCostBirthday";
            this.labelCostBirthday.Size = new System.Drawing.Size(32, 13);
            this.labelCostBirthday.TabIndex = 7;
            this.labelCostBirthday.Text = "Cost";
            // 
            // birthdayCost
            // 
            this.birthdayCost.Location = new System.Drawing.Point(48, 114);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(99, 20);
            this.birthdayCost.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 167);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumberOfPeople;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.CheckBox checkBoxHealthyDecorations;
        private System.Windows.Forms.CheckBox checkBoxFancyDecorations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCakeWriting;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label labelBPNumberOfPeople;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.TextBox birthdayCost;
        private System.Windows.Forms.Label labelCostBirthday;
        private System.Windows.Forms.TextBox textBoxWriting;
        private System.Windows.Forms.Label tooLongLabel;
    }
}

