namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    partial class InitDialog
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
            numWidth = new NumericUpDown();
            lblWidth = new Label();
            lblHeight = new Label();
            numHeight = new NumericUpDown();
            panelMap = new Panel();
            panelEntities = new Panel();
            lblCarnivores = new Label();
            numCarnivores = new NumericUpDown();
            lblPlants = new Label();
            numHerbivores = new NumericUpDown();
            lblHerbivores = new Label();
            numPlants = new NumericUpDown();
            btnInitialize = new Button();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            panelMap.SuspendLayout();
            panelEntities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCarnivores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHerbivores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlants).BeginInit();
            SuspendLayout();
            // 
            // numWidth
            // 
            numWidth.Location = new Point(48, 3);
            numWidth.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(51, 23);
            numWidth.TabIndex = 0;
            numWidth.Value = new decimal(new int[] { 60, 0, 0, 0 });
            numWidth.ValueChanged += num_ValueChanged;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(5, 5);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(42, 15);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(1, 34);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height:";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(48, 32);
            numHeight.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(51, 23);
            numHeight.TabIndex = 3;
            numHeight.Value = new decimal(new int[] { 43, 0, 0, 0 });
            numHeight.ValueChanged += num_ValueChanged;
            // 
            // panelMap
            // 
            panelMap.Controls.Add(lblWidth);
            panelMap.Controls.Add(numHeight);
            panelMap.Controls.Add(numWidth);
            panelMap.Controls.Add(lblHeight);
            panelMap.Location = new Point(144, 12);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(102, 58);
            panelMap.TabIndex = 4;
            // 
            // panelEntities
            // 
            panelEntities.Controls.Add(lblCarnivores);
            panelEntities.Controls.Add(numCarnivores);
            panelEntities.Controls.Add(lblPlants);
            panelEntities.Controls.Add(numHerbivores);
            panelEntities.Controls.Add(lblHerbivores);
            panelEntities.Controls.Add(numPlants);
            panelEntities.Location = new Point(12, 12);
            panelEntities.Name = "panelEntities";
            panelEntities.Size = new Size(126, 88);
            panelEntities.TabIndex = 5;
            // 
            // lblCarnivores
            // 
            lblCarnivores.AutoSize = true;
            lblCarnivores.Location = new Point(1, 63);
            lblCarnivores.Name = "lblCarnivores";
            lblCarnivores.Size = new Size(66, 15);
            lblCarnivores.TabIndex = 5;
            lblCarnivores.Text = "Carnivores:";
            // 
            // numCarnivores
            // 
            numCarnivores.Location = new Point(71, 61);
            numCarnivores.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCarnivores.Name = "numCarnivores";
            numCarnivores.Size = new Size(51, 23);
            numCarnivores.TabIndex = 4;
            numCarnivores.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numCarnivores.ValueChanged += num_ValueChanged;
            // 
            // lblPlants
            // 
            lblPlants.AutoSize = true;
            lblPlants.Location = new Point(3, 5);
            lblPlants.Name = "lblPlants";
            lblPlants.Size = new Size(42, 15);
            lblPlants.TabIndex = 1;
            lblPlants.Text = "Plants:";
            // 
            // numHerbivores
            // 
            numHerbivores.Location = new Point(71, 32);
            numHerbivores.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numHerbivores.Name = "numHerbivores";
            numHerbivores.Size = new Size(51, 23);
            numHerbivores.TabIndex = 3;
            numHerbivores.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numHerbivores.ValueChanged += num_ValueChanged;
            // 
            // lblHerbivores
            // 
            lblHerbivores.AutoSize = true;
            lblHerbivores.Location = new Point(1, 34);
            lblHerbivores.Name = "lblHerbivores";
            lblHerbivores.Size = new Size(67, 15);
            lblHerbivores.TabIndex = 2;
            lblHerbivores.Text = "Herbivores:";
            // 
            // numPlants
            // 
            numPlants.Location = new Point(51, 3);
            numPlants.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPlants.Name = "numPlants";
            numPlants.Size = new Size(71, 23);
            numPlants.TabIndex = 0;
            numPlants.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numPlants.ValueChanged += num_ValueChanged;
            // 
            // btnInitialize
            // 
            btnInitialize.Location = new Point(144, 77);
            btnInitialize.Name = "btnInitialize";
            btnInitialize.Size = new Size(102, 23);
            btnInitialize.TabIndex = 6;
            btnInitialize.Text = "Create";
            btnInitialize.UseVisualStyleBackColor = true;
            btnInitialize.Click += btnInitialize_Click;
            // 
            // InitDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 109);
            Controls.Add(btnInitialize);
            Controls.Add(panelEntities);
            Controls.Add(panelMap);
            Name = "InitDialog";
            Text = "Ecosystem creator";
            Load += InitDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            panelMap.ResumeLayout(false);
            panelMap.PerformLayout();
            panelEntities.ResumeLayout(false);
            panelEntities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCarnivores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHerbivores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlants).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numWidth;
        private Label lblWidth;
        private Label lblHeight;
        private NumericUpDown numHeight;
        private Panel panelMap;
        private Panel panelEntities;
        private NumericUpDown numCarnivores;
        private Label lblPlants;
        private NumericUpDown numHerbivores;
        private Label lblHerbivores;
        private NumericUpDown numPlants;
        private Label lblCarnivores;
        private Button btnInitialize;
    }
}