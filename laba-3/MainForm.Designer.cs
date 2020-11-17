namespace laba_3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.setLabel2 = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.setLabel1 = new System.Windows.Forms.Label();
            this.setBox2 = new System.Windows.Forms.MaskedTextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.setBox1 = new System.Windows.Forms.MaskedTextBox();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BY_LABEL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            // 
            // setLabel2
            // 
            resources.ApplyResources(this.setLabel2, "setLabel2");
            this.setLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setLabel2.Name = "setLabel2";
            // 
            // setLabel
            // 
            resources.ApplyResources(this.setLabel, "setLabel");
            this.setLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setLabel.Name = "setLabel";
            // 
            // setLabel1
            // 
            resources.ApplyResources(this.setLabel1, "setLabel1");
            this.setLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setLabel1.Name = "setLabel1";
            // 
            // setBox2
            // 
            this.setBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.setBox2, "setBox2");
            this.setBox2.Name = "setBox2";
            this.setBox2.TextChanged += new System.EventHandler(this.setBox2_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.resultBox, "resultBox");
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            // 
            // setBox1
            // 
            this.setBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.setBox1, "setBox1");
            this.setBox1.Name = "setBox1";
            this.setBox1.TextChanged += new System.EventHandler(this.setBox1_TextChanged);
            // 
            // operationBox
            // 
            this.operationBox.BackColor = System.Drawing.Color.Moccasin;
            this.operationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.operationBox, "operationBox");
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Items.AddRange(new object[] {
            resources.GetString("operationBox.Items"),
            resources.GetString("operationBox.Items1"),
            resources.GetString("operationBox.Items2")});
            this.operationBox.Name = "operationBox";
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.operationBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BY_LABEL
            // 
            resources.ApplyResources(this.BY_LABEL, "BY_LABEL");
            this.BY_LABEL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BY_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BY_LABEL.Name = "BY_LABEL";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BY_LABEL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.setLabel2);
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.setLabel1);
            this.Controls.Add(this.setBox2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.setBox1);
            this.Controls.Add(this.operationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.MaskedTextBox setBox1;
        protected internal System.Windows.Forms.MaskedTextBox setBox2;
        protected internal System.Windows.Forms.TextBox resultBox;
        protected internal System.Windows.Forms.ComboBox operationBox;
        protected internal System.Windows.Forms.CheckBox checkBox2;
        protected internal System.Windows.Forms.CheckBox checkBox1;
        protected internal System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.Label setLabel2;
        protected internal System.Windows.Forms.Label setLabel;
        protected internal System.Windows.Forms.Label setLabel1;
        protected internal System.Windows.Forms.Label BY_LABEL;
        private System.Windows.Forms.Button button2;
    }
}

