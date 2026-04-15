namespace ZamestnanciSestavy
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
            this.listBoxZamestnanci = new System.Windows.Forms.ListBox();
            this.btnGenerateRandomData = new System.Windows.Forms.Button();
            this.btnTop5Zamestnancu = new System.Windows.Forms.Button();
            this.btnVedouci = new System.Windows.Forms.Button();
            this.btnAboveAverage = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxZamestnanci
            // 
            this.listBoxZamestnanci.FormattingEnabled = true;
            this.listBoxZamestnanci.ItemHeight = 15;
            this.listBoxZamestnanci.Location = new System.Drawing.Point(12, 12);
            this.listBoxZamestnanci.Name = "listBoxZamestnanci";
            this.listBoxZamestnanci.Size = new System.Drawing.Size(247, 364);
            this.listBoxZamestnanci.TabIndex = 0;
            // 
            // btnGenerateRandomData
            // 
            this.btnGenerateRandomData.Location = new System.Drawing.Point(12, 388);
            this.btnGenerateRandomData.Name = "btnGenerateRandomData";
            this.btnGenerateRandomData.Size = new System.Drawing.Size(247, 50);
            this.btnGenerateRandomData.TabIndex = 1;
            this.btnGenerateRandomData.Text = "Vygenerovat náhodná data";
            this.btnGenerateRandomData.UseVisualStyleBackColor = true;
            this.btnGenerateRandomData.Click += new System.EventHandler(this.btnGenerateRandomData_Click);
            // 
            // btnTop5Zamestnancu
            // 
            this.btnTop5Zamestnancu.Location = new System.Drawing.Point(265, 12);
            this.btnTop5Zamestnancu.Name = "btnTop5Zamestnancu";
            this.btnTop5Zamestnancu.Size = new System.Drawing.Size(100, 50);
            this.btnTop5Zamestnancu.TabIndex = 2;
            this.btnTop5Zamestnancu.Text = "Top 5 Zaměstnanců";
            this.btnTop5Zamestnancu.UseVisualStyleBackColor = true;
            this.btnTop5Zamestnancu.Click += new System.EventHandler(this.btnTop5Zamestnancu_Click);
            // 
            // btnVedouci
            // 
            this.btnVedouci.Location = new System.Drawing.Point(265, 68);
            this.btnVedouci.Name = "btnVedouci";
            this.btnVedouci.Size = new System.Drawing.Size(100, 50);
            this.btnVedouci.TabIndex = 3;
            this.btnVedouci.Text = "Vedoucí Zaměstnanci";
            this.btnVedouci.UseVisualStyleBackColor = true;
            this.btnVedouci.Click += new System.EventHandler(this.btnVedouci_Click);
            // 
            // btnAboveAverage
            // 
            this.btnAboveAverage.Location = new System.Drawing.Point(265, 124);
            this.btnAboveAverage.Name = "btnAboveAverage";
            this.btnAboveAverage.Size = new System.Drawing.Size(100, 50);
            this.btnAboveAverage.TabIndex = 4;
            this.btnAboveAverage.Text = "Nadprůměrní zaměstnanci";
            this.btnAboveAverage.UseVisualStyleBackColor = true;
            this.btnAboveAverage.Click += new System.EventHandler(this.btnAboveAverage_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(265, 180);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(100, 50);
            this.btnSummary.TabIndex = 5;
            this.btnSummary.Text = "Souhrná soustava";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnAboveAverage);
            this.Controls.Add(this.btnVedouci);
            this.Controls.Add(this.btnTop5Zamestnancu);
            this.Controls.Add(this.btnGenerateRandomData);
            this.Controls.Add(this.listBoxZamestnanci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxZamestnanci;
        private Button btnGenerateRandomData;
        private Button btnTop5Zamestnancu;
        private Button btnVedouci;
        private Button btnAboveAverage;
        private Button btnSummary;
    }
}