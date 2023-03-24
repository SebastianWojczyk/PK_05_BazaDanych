namespace PK_05_BazaDanych
{
    partial class FormPerson
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
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.dateTimePickerPersonBirthDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPersonHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersonHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(103, 9);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPersonName.TabIndex = 0;
            this.textBoxPersonName.TextChanged += new System.EventHandler(this.textBoxPersonName_TextChanged);
            // 
            // dateTimePickerPersonBirthDate
            // 
            this.dateTimePickerPersonBirthDate.Location = new System.Drawing.Point(103, 35);
            this.dateTimePickerPersonBirthDate.MaxDate = new System.DateTime(2023, 3, 25, 0, 0, 0, 0);
            this.dateTimePickerPersonBirthDate.Name = "dateTimePickerPersonBirthDate";
            this.dateTimePickerPersonBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPersonBirthDate.TabIndex = 1;
            this.dateTimePickerPersonBirthDate.Value = new System.DateTime(2023, 3, 24, 0, 0, 0, 0);
            this.dateTimePickerPersonBirthDate.ValueChanged += new System.EventHandler(this.dateTimePickerPersonBirthDate_ValueChanged);
            // 
            // numericUpDownPersonHeight
            // 
            this.numericUpDownPersonHeight.Location = new System.Drawing.Point(103, 61);
            this.numericUpDownPersonHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownPersonHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPersonHeight.Name = "numericUpDownPersonHeight";
            this.numericUpDownPersonHeight.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPersonHeight.TabIndex = 2;
            this.numericUpDownPersonHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPersonHeight.ValueChanged += new System.EventHandler(this.numericUpDownPersonHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wzrost";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(103, 87);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 121);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPersonHeight);
            this.Controls.Add(this.dateTimePickerPersonBirthDate);
            this.Controls.Add(this.textBoxPersonName);
            this.Name = "FormPerson";
            this.Text = "FormPerson";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersonHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPersonBirthDate;
        private System.Windows.Forms.NumericUpDown numericUpDownPersonHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
    }
}