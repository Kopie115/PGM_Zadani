namespace SAKO
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartStopTimer = new System.Windows.Forms.Button();
            this.lblTotalCapacity = new System.Windows.Forms.Label();
            this.lblVehicleCapacity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numVehicleCount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timerShift = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCapacityStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRelativeCapacity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblShiftDay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIncidentStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVehicleCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.btnReset);
            this.groupBoxConfig.Controls.Add(this.label7);
            this.groupBoxConfig.Controls.Add(this.btnStartStopTimer);
            this.groupBoxConfig.Controls.Add(this.lblTotalCapacity);
            this.groupBoxConfig.Controls.Add(this.lblVehicleCapacity);
            this.groupBoxConfig.Controls.Add(this.label3);
            this.groupBoxConfig.Controls.Add(this.label2);
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Controls.Add(this.numVehicleCount);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(314, 202);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Konfigurace Střediska";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ovládání simulace";
            // 
            // btnStartStopTimer
            // 
            this.btnStartStopTimer.Location = new System.Drawing.Point(6, 173);
            this.btnStartStopTimer.Name = "btnStartStopTimer";
            this.btnStartStopTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopTimer.TabIndex = 6;
            this.btnStartStopTimer.Text = "Spustit";
            this.btnStartStopTimer.UseVisualStyleBackColor = true;
            this.btnStartStopTimer.Click += new System.EventHandler(this.btnStartStopTimer_Click);
            // 
            // lblTotalCapacity
            // 
            this.lblTotalCapacity.AutoSize = true;
            this.lblTotalCapacity.Location = new System.Drawing.Point(131, 63);
            this.lblTotalCapacity.Name = "lblTotalCapacity";
            this.lblTotalCapacity.Size = new System.Drawing.Size(27, 15);
            this.lblTotalCapacity.TabIndex = 5;
            this.lblTotalCapacity.Text = "null";
            // 
            // lblVehicleCapacity
            // 
            this.lblVehicleCapacity.AutoSize = true;
            this.lblVehicleCapacity.Location = new System.Drawing.Point(131, 48);
            this.lblVehicleCapacity.Name = "lblVehicleCapacity";
            this.lblVehicleCapacity.Size = new System.Drawing.Size(29, 15);
            this.lblVehicleCapacity.TabIndex = 4;
            this.lblVehicleCapacity.Text = "6.7 t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kapacita střediska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kapacita vozidla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Počet vozidel (4-6):";
            // 
            // numVehicleCount
            // 
            this.numVehicleCount.Location = new System.Drawing.Point(131, 22);
            this.numVehicleCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numVehicleCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numVehicleCount.Name = "numVehicleCount";
            this.numVehicleCount.Size = new System.Drawing.Size(45, 23);
            this.numVehicleCount.TabIndex = 0;
            this.numVehicleCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxLog);
            this.panel1.Controls.Add(this.btnExportLog);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 218);
            this.panel1.TabIndex = 1;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Location = new System.Drawing.Point(6, 43);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(656, 169);
            this.listBoxLog.TabIndex = 2;
            // 
            // btnExportLog
            // 
            this.btnExportLog.Enabled = false;
            this.btnExportLog.Location = new System.Drawing.Point(565, 6);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(97, 23);
            this.btnExportLog.TabIndex = 1;
            this.btnExportLog.Text = "Exportovat log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Log událostí";
            // 
            // timerShift
            // 
            this.timerShift.Interval = 1000;
            this.timerShift.Tick += new System.EventHandler(this.timerShift_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCapacityStatus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(332, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 54);
            this.panel2.TabIndex = 2;
            // 
            // lblCapacityStatus
            // 
            this.lblCapacityStatus.AutoSize = true;
            this.lblCapacityStatus.Location = new System.Drawing.Point(10, 30);
            this.lblCapacityStatus.Name = "lblCapacityStatus";
            this.lblCapacityStatus.Size = new System.Drawing.Size(27, 15);
            this.lblCapacityStatus.TabIndex = 1;
            this.lblCapacityStatus.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stav kapacity";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRelativeCapacity);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(332, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 50);
            this.panel3.TabIndex = 3;
            // 
            // lblRelativeCapacity
            // 
            this.lblRelativeCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRelativeCapacity.Location = new System.Drawing.Point(-1, 19);
            this.lblRelativeCapacity.Name = "lblRelativeCapacity";
            this.lblRelativeCapacity.Size = new System.Drawing.Size(175, 29);
            this.lblRelativeCapacity.TabIndex = 1;
            this.lblRelativeCapacity.Text = "? %";
            this.lblRelativeCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aktuální kapacita";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblShiftDay);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(512, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 50);
            this.panel4.TabIndex = 4;
            // 
            // lblShiftDay
            // 
            this.lblShiftDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShiftDay.Location = new System.Drawing.Point(-1, 19);
            this.lblShiftDay.Name = "lblShiftDay";
            this.lblShiftDay.Size = new System.Drawing.Size(175, 29);
            this.lblShiftDay.TabIndex = 1;
            this.lblShiftDay.Text = "? / ?";
            this.lblShiftDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Směna / Den";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblIncidentStatus);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(332, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 54);
            this.panel5.TabIndex = 3;
            // 
            // lblIncidentStatus
            // 
            this.lblIncidentStatus.AutoSize = true;
            this.lblIncidentStatus.Location = new System.Drawing.Point(10, 30);
            this.lblIncidentStatus.Name = "lblIncidentStatus";
            this.lblIncidentStatus.Size = new System.Drawing.Size(27, 15);
            this.lblIncidentStatus.TabIndex = 1;
            this.lblIncidentStatus.Text = "null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Stav incidentu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "Form1";
            this.Text = "SAKO Simulace";
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVehicleCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxConfig;
        private NumericUpDown numVehicleCount;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblVehicleCapacity;
        private Label lblTotalCapacity;
        private Panel panel1;
        private Label label6;
        private Button btnExportLog;
        private ListBox listBoxLog;
        private System.Windows.Forms.Timer timerShift;
        private Button btnStartStopTimer;
        private Panel panel2;
        private Label label4;
        private Label lblCapacityStatus;
        private Panel panel3;
        private Label label5;
        private Label lblRelativeCapacity;
        private Panel panel4;
        private Label lblShiftDay;
        private Label label8;
        private Label label7;
        private Panel panel5;
        private Label lblIncidentStatus;
        private Label label10;
        private Button btnReset;
    }
}