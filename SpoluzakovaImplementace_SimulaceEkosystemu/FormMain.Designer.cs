namespace SpoluzakovaImplementace_SimulaceEkosystemu
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
            components = new System.ComponentModel.Container();
            panelMapRender = new Panel();
            btnNextDay = new Button();
            btnRestart = new Button();
            panelDay = new Panel();
            lblDayCount = new Label();
            lblTitleDay = new Label();
            panelEntities = new Panel();
            lblCarnivoreCount = new Label();
            lblHerbivoreCount = new Label();
            lblPlantCount = new Label();
            lblTitleEntities = new Label();
            panelPlant = new Panel();
            lblPlantTitle = new Label();
            lblHerbivoreTitle = new Label();
            panelHerbivore = new Panel();
            lblCarnivoreTitle = new Label();
            panelCarnivore = new Panel();
            lblEmptyTitle = new Label();
            panelEmpty = new Panel();
            sliderAutoNextDay = new TrackBar();
            panelTimerSettings = new Panel();
            checkBoxAutoNextDay = new CheckBox();
            timerAutoNextDay = new System.Windows.Forms.Timer(components);
            panelDay.SuspendLayout();
            panelEntities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sliderAutoNextDay).BeginInit();
            panelTimerSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelMapRender
            // 
            panelMapRender.Location = new Point(12, 12);
            panelMapRender.Name = "panelMapRender";
            panelMapRender.Size = new Size(600, 430);
            panelMapRender.TabIndex = 0;
            panelMapRender.Paint += panelMapRender_Paint;
            // 
            // btnNextDay
            // 
            btnNextDay.Font = new Font("Verdana", 15.75F);
            btnNextDay.Location = new Point(626, 362);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(156, 35);
            btnNextDay.TabIndex = 1;
            btnNextDay.Text = "Next Day";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Click += btnNextDay_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Verdana", 14.25F);
            btnRestart.Location = new Point(626, 403);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(156, 35);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // panelDay
            // 
            panelDay.Controls.Add(lblDayCount);
            panelDay.Controls.Add(lblTitleDay);
            panelDay.Location = new Point(626, 12);
            panelDay.Name = "panelDay";
            panelDay.Padding = new Padding(3, 3, 0, 0);
            panelDay.Size = new Size(162, 51);
            panelDay.TabIndex = 4;
            // 
            // lblDayCount
            // 
            lblDayCount.AutoSize = true;
            lblDayCount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            lblDayCount.Location = new Point(3, 19);
            lblDayCount.Margin = new Padding(0);
            lblDayCount.Name = "lblDayCount";
            lblDayCount.Size = new Size(25, 27);
            lblDayCount.TabIndex = 6;
            lblDayCount.Text = "0";
            // 
            // lblTitleDay
            // 
            lblTitleDay.AutoSize = true;
            lblTitleDay.Font = new Font("Arial", 9.75F);
            lblTitleDay.Location = new Point(3, 3);
            lblTitleDay.Margin = new Padding(0);
            lblTitleDay.Name = "lblTitleDay";
            lblTitleDay.Size = new Size(33, 16);
            lblTitleDay.TabIndex = 5;
            lblTitleDay.Text = "DAY";
            // 
            // panelEntities
            // 
            panelEntities.Controls.Add(lblCarnivoreCount);
            panelEntities.Controls.Add(lblHerbivoreCount);
            panelEntities.Controls.Add(lblPlantCount);
            panelEntities.Controls.Add(lblTitleEntities);
            panelEntities.Location = new Point(626, 163);
            panelEntities.Name = "panelEntities";
            panelEntities.Padding = new Padding(3, 3, 0, 0);
            panelEntities.Size = new Size(162, 109);
            panelEntities.TabIndex = 7;
            // 
            // lblCarnivoreCount
            // 
            lblCarnivoreCount.AutoSize = true;
            lblCarnivoreCount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            lblCarnivoreCount.Location = new Point(6, 76);
            lblCarnivoreCount.Margin = new Padding(0);
            lblCarnivoreCount.Name = "lblCarnivoreCount";
            lblCarnivoreCount.Size = new Size(58, 27);
            lblCarnivoreCount.TabIndex = 8;
            lblCarnivoreCount.Text = "0 \U0001f98a";
            // 
            // lblHerbivoreCount
            // 
            lblHerbivoreCount.AutoSize = true;
            lblHerbivoreCount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            lblHerbivoreCount.Location = new Point(6, 49);
            lblHerbivoreCount.Margin = new Padding(0);
            lblHerbivoreCount.Name = "lblHerbivoreCount";
            lblHerbivoreCount.Size = new Size(58, 27);
            lblHerbivoreCount.TabIndex = 7;
            lblHerbivoreCount.Text = "0 🐇";
            // 
            // lblPlantCount
            // 
            lblPlantCount.AutoSize = true;
            lblPlantCount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            lblPlantCount.Location = new Point(6, 22);
            lblPlantCount.Margin = new Padding(0);
            lblPlantCount.Name = "lblPlantCount";
            lblPlantCount.Size = new Size(58, 27);
            lblPlantCount.TabIndex = 6;
            lblPlantCount.Text = "0 🌿";
            // 
            // lblTitleEntities
            // 
            lblTitleEntities.AutoSize = true;
            lblTitleEntities.Font = new Font("Arial", 9.75F);
            lblTitleEntities.Location = new Point(6, 6);
            lblTitleEntities.Margin = new Padding(0);
            lblTitleEntities.Name = "lblTitleEntities";
            lblTitleEntities.Size = new Size(63, 16);
            lblTitleEntities.TabIndex = 5;
            lblTitleEntities.Text = "ENTITIES";
            // 
            // panelPlant
            // 
            panelPlant.Location = new Point(626, 77);
            panelPlant.Name = "panelPlant";
            panelPlant.Size = new Size(16, 16);
            panelPlant.TabIndex = 8;
            // 
            // lblPlantTitle
            // 
            lblPlantTitle.AutoSize = true;
            lblPlantTitle.Font = new Font("Arial", 9.75F);
            lblPlantTitle.Location = new Point(645, 77);
            lblPlantTitle.Margin = new Padding(0);
            lblPlantTitle.Name = "lblPlantTitle";
            lblPlantTitle.Size = new Size(37, 16);
            lblPlantTitle.TabIndex = 7;
            lblPlantTitle.Text = "Plant";
            // 
            // lblHerbivoreTitle
            // 
            lblHerbivoreTitle.AutoSize = true;
            lblHerbivoreTitle.Font = new Font("Arial", 9.75F);
            lblHerbivoreTitle.Location = new Point(645, 96);
            lblHerbivoreTitle.Margin = new Padding(0);
            lblHerbivoreTitle.Name = "lblHerbivoreTitle";
            lblHerbivoreTitle.Size = new Size(60, 16);
            lblHerbivoreTitle.TabIndex = 9;
            lblHerbivoreTitle.Text = "Herbivore";
            // 
            // panelHerbivore
            // 
            panelHerbivore.Location = new Point(626, 96);
            panelHerbivore.Name = "panelHerbivore";
            panelHerbivore.Size = new Size(16, 16);
            panelHerbivore.TabIndex = 10;
            // 
            // lblCarnivoreTitle
            // 
            lblCarnivoreTitle.AutoSize = true;
            lblCarnivoreTitle.Font = new Font("Arial", 9.75F);
            lblCarnivoreTitle.Location = new Point(645, 115);
            lblCarnivoreTitle.Margin = new Padding(0);
            lblCarnivoreTitle.Name = "lblCarnivoreTitle";
            lblCarnivoreTitle.Size = new Size(60, 16);
            lblCarnivoreTitle.TabIndex = 11;
            lblCarnivoreTitle.Text = "Carnivore";
            // 
            // panelCarnivore
            // 
            panelCarnivore.Location = new Point(626, 115);
            panelCarnivore.Name = "panelCarnivore";
            panelCarnivore.Size = new Size(16, 16);
            panelCarnivore.TabIndex = 12;
            // 
            // lblEmptyTitle
            // 
            lblEmptyTitle.AutoSize = true;
            lblEmptyTitle.Font = new Font("Arial", 9.75F);
            lblEmptyTitle.Location = new Point(645, 134);
            lblEmptyTitle.Margin = new Padding(0);
            lblEmptyTitle.Name = "lblEmptyTitle";
            lblEmptyTitle.Size = new Size(45, 16);
            lblEmptyTitle.TabIndex = 13;
            lblEmptyTitle.Text = "Empty";
            // 
            // panelEmpty
            // 
            panelEmpty.Location = new Point(626, 134);
            panelEmpty.Name = "panelEmpty";
            panelEmpty.Size = new Size(16, 16);
            panelEmpty.TabIndex = 14;
            // 
            // sliderAutoNextDay
            // 
            sliderAutoNextDay.Location = new Point(6, 22);
            sliderAutoNextDay.Maximum = 10000;
            sliderAutoNextDay.Minimum = 100;
            sliderAutoNextDay.Name = "sliderAutoNextDay";
            sliderAutoNextDay.Size = new Size(153, 45);
            sliderAutoNextDay.TabIndex = 15;
            sliderAutoNextDay.Value = 100;
            sliderAutoNextDay.ValueChanged += sliderAutoNextDay_ValueChanged;
            // 
            // panelTimerSettings
            // 
            panelTimerSettings.Controls.Add(checkBoxAutoNextDay);
            panelTimerSettings.Controls.Add(sliderAutoNextDay);
            panelTimerSettings.Location = new Point(626, 287);
            panelTimerSettings.Name = "panelTimerSettings";
            panelTimerSettings.Padding = new Padding(3, 3, 0, 0);
            panelTimerSettings.Size = new Size(162, 69);
            panelTimerSettings.TabIndex = 7;
            // 
            // checkBoxAutoNextDay
            // 
            checkBoxAutoNextDay.AutoSize = true;
            checkBoxAutoNextDay.Font = new Font("Arial", 9.75F);
            checkBoxAutoNextDay.Location = new Point(14, 6);
            checkBoxAutoNextDay.Name = "checkBoxAutoNextDay";
            checkBoxAutoNextDay.Size = new Size(135, 20);
            checkBoxAutoNextDay.TabIndex = 16;
            checkBoxAutoNextDay.Text = "AUTO - NEXT DAY";
            checkBoxAutoNextDay.TextAlign = ContentAlignment.MiddleRight;
            checkBoxAutoNextDay.UseVisualStyleBackColor = true;
            checkBoxAutoNextDay.CheckedChanged += checkBoxAutoNextDay_CheckedChanged;
            // 
            // timerAutoNextDay
            // 
            timerAutoNextDay.Interval = 1;
            timerAutoNextDay.Tick += timerAutoNextDay_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTimerSettings);
            Controls.Add(lblEmptyTitle);
            Controls.Add(panelEmpty);
            Controls.Add(lblCarnivoreTitle);
            Controls.Add(panelCarnivore);
            Controls.Add(lblHerbivoreTitle);
            Controls.Add(panelHerbivore);
            Controls.Add(lblPlantTitle);
            Controls.Add(panelPlant);
            Controls.Add(panelEntities);
            Controls.Add(panelDay);
            Controls.Add(btnRestart);
            Controls.Add(btnNextDay);
            Controls.Add(panelMapRender);
            Name = "FormMain";
            Text = "Ecosystem Simulation";
            Load += FormMain_Load;
            panelDay.ResumeLayout(false);
            panelDay.PerformLayout();
            panelEntities.ResumeLayout(false);
            panelEntities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sliderAutoNextDay).EndInit();
            panelTimerSettings.ResumeLayout(false);
            panelTimerSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panelMapRender;
        private Button btnNextDay;
        private Button btnRestart;
        private Panel panelDay;
        private Label lblTitleDay;
        private Label lblDayCount;
        private Panel panelEntities;
        private Label lblPlantCount;
        private Label lblTitleEntities;
        private Label lblCarnivoreCount;
        private Label lblHerbivoreCount;
        private Panel panelPlant;
        private Label lblPlantTitle;
        private Label lblHerbivoreTitle;
        private Panel panelHerbivore;
        private Label lblCarnivoreTitle;
        private Panel panelCarnivore;
        private Label lblEmptyTitle;
        private Panel panelEmpty;
        private TrackBar sliderAutoNextDay;
        private Panel panelTimerSettings;
        private CheckBox checkBoxAutoNextDay;
        private System.Windows.Forms.Timer timerAutoNextDay;
    }
}