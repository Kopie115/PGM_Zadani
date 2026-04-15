namespace _13_GenerovaniMapy
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
            lblMapOutput = new Label();
            btnGenerate = new Button();
            numWidth = new NumericUpDown();
            numHeight = new NumericUpDown();
            lblWidth = new Label();
            lblHeight = new Label();
            panelMapSettings = new Panel();
            lblTerrain = new Label();
            numGrass = new NumericUpDown();
            lblWater = new Label();
            numWater = new NumericUpDown();
            lblDetails = new Label();
            panelMapRender = new Panel();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            panelMapSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGrass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWater).BeginInit();
            SuspendLayout();
            // 
            // lblMapOutput
            // 
            lblMapOutput.AutoSize = true;
            lblMapOutput.Font = new Font("Consolas", 9F);
            lblMapOutput.Location = new Point(12, 9);
            lblMapOutput.Name = "lblMapOutput";
            lblMapOutput.Size = new Size(49, 14);
            lblMapOutput.TabIndex = 0;
            lblMapOutput.Text = "no map";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(3, 119);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(129, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Map";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(55, 32);
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(77, 23);
            numWidth.TabIndex = 2;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(55, 3);
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(77, 23);
            numHeight.TabIndex = 3;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(7, 5);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(42, 15);
            lblWidth.TabIndex = 4;
            lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(3, 34);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "Height:";
            // 
            // panelMapSettings
            // 
            panelMapSettings.Controls.Add(lblTerrain);
            panelMapSettings.Controls.Add(numGrass);
            panelMapSettings.Controls.Add(lblWater);
            panelMapSettings.Controls.Add(numWater);
            panelMapSettings.Controls.Add(lblHeight);
            panelMapSettings.Controls.Add(btnGenerate);
            panelMapSettings.Controls.Add(lblWidth);
            panelMapSettings.Controls.Add(numHeight);
            panelMapSettings.Controls.Add(numWidth);
            panelMapSettings.Location = new Point(12, 292);
            panelMapSettings.Name = "panelMapSettings";
            panelMapSettings.Size = new Size(135, 146);
            panelMapSettings.TabIndex = 6;
            // 
            // lblTerrain
            // 
            lblTerrain.AutoSize = true;
            lblTerrain.Location = new Point(8, 92);
            lblTerrain.Name = "lblTerrain";
            lblTerrain.Size = new Size(38, 15);
            lblTerrain.TabIndex = 9;
            lblTerrain.Text = "Grass:";
            // 
            // numGrass
            // 
            numGrass.DecimalPlaces = 4;
            numGrass.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numGrass.Location = new Point(55, 90);
            numGrass.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numGrass.Name = "numGrass";
            numGrass.Size = new Size(77, 23);
            numGrass.TabIndex = 8;
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Location = new Point(8, 63);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(41, 15);
            lblWater.TabIndex = 7;
            lblWater.Text = "Water:";
            // 
            // numWater
            // 
            numWater.DecimalPlaces = 4;
            numWater.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numWater.Location = new Point(55, 61);
            numWater.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numWater.Name = "numWater";
            numWater.Size = new Size(77, 23);
            numWater.TabIndex = 6;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(605, 21);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(0, 15);
            lblDetails.TabIndex = 7;
            // 
            // panelMapRender
            // 
            panelMapRender.Location = new Point(351, 99);
            panelMapRender.Name = "panelMapRender";
            panelMapRender.Size = new Size(421, 320);
            panelMapRender.TabIndex = 8;
            panelMapRender.Paint += panelMapRender_Paint;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(174, 411);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(panelMapRender);
            Controls.Add(lblDetails);
            Controls.Add(panelMapSettings);
            Controls.Add(lblMapOutput);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            panelMapSettings.ResumeLayout(false);
            panelMapSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGrass).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWater).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMapOutput;
        private Button btnGenerate;
        private NumericUpDown numWidth;
        private NumericUpDown numHeight;
        private Label lblWidth;
        private Label lblHeight;
        private Panel panelMapSettings;
        private Label lblWater;
        private NumericUpDown numWater;
        private Label lblDetails;
        private Panel panelMapRender;
        private Label lblTerrain;
        private NumericUpDown numGrass;
        private Button btnExport;
    }
}
