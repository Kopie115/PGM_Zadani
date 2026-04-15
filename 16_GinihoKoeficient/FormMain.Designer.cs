namespace _16_GinihoKoeficient
{
    partial class FormMain
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
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listBoxKumu = new System.Windows.Forms.ListBox();
            this.lblPlocha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 15;
            this.listBoxValues.Location = new System.Drawing.Point(12, 12);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(239, 259);
            this.listBoxValues.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(922, 494);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listBoxKumu
            // 
            this.listBoxKumu.FormattingEnabled = true;
            this.listBoxKumu.ItemHeight = 15;
            this.listBoxKumu.Location = new System.Drawing.Point(12, 277);
            this.listBoxKumu.Name = "listBoxKumu";
            this.listBoxKumu.Size = new System.Drawing.Size(239, 244);
            this.listBoxKumu.TabIndex = 2;
            // 
            // lblPlocha
            // 
            this.lblPlocha.AutoSize = true;
            this.lblPlocha.Location = new System.Drawing.Point(843, 9);
            this.lblPlocha.Name = "lblPlocha";
            this.lblPlocha.Size = new System.Drawing.Size(38, 15);
            this.lblPlocha.TabIndex = 3;
            this.lblPlocha.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(267, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 444);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPlocha);
            this.Controls.Add(this.listBoxKumu);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listBoxValues);
            this.Name = "FormMain";
            this.Text = "Gini Coefficient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxValues;
        private Button btnCalculate;
        private ListBox listBoxKumu;
        private Label lblPlocha;
        private Panel panel1;
    }
}