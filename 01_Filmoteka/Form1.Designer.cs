namespace Filmotéka
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
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.panelMovies = new System.Windows.Forms.Panel();
            this.lblDirectorName = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 15;
            this.listBoxMovies.Location = new System.Drawing.Point(77, 155);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(120, 94);
            this.listBoxMovies.TabIndex = 0;
            // 
            // panelMovies
            // 
            this.panelMovies.Controls.Add(this.lblDirectorName);
            this.panelMovies.Controls.Add(this.lblMovieName);
            this.panelMovies.Controls.Add(this.txtMovieDirector);
            this.panelMovies.Controls.Add(this.txtMovieName);
            this.panelMovies.Controls.Add(this.btnRemoveMovie);
            this.panelMovies.Controls.Add(this.btnAddMovie);
            this.panelMovies.Controls.Add(this.listBoxMovies);
            this.panelMovies.Location = new System.Drawing.Point(12, 12);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(345, 274);
            this.panelMovies.TabIndex = 1;
            // 
            // lblDirectorName
            // 
            this.lblDirectorName.AutoSize = true;
            this.lblDirectorName.Location = new System.Drawing.Point(3, 35);
            this.lblDirectorName.Name = "lblDirectorName";
            this.lblDirectorName.Size = new System.Drawing.Size(52, 15);
            this.lblDirectorName.TabIndex = 6;
            this.lblDirectorName.Text = "Director:";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(3, 11);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(42, 15);
            this.lblMovieName.TabIndex = 5;
            this.lblMovieName.Text = "Name:";
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(61, 27);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(153, 23);
            this.txtMovieDirector.TabIndex = 4;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(51, 3);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(163, 23);
            this.txtMovieName.TabIndex = 3;
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(220, 35);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveMovie.TabIndex = 2;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(220, 7);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(100, 23);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(417, 77);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 336);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panelMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMovies.ResumeLayout(false);
            this.panelMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxMovies;
        private Panel panelMovies;
        private TextBox txtMovieName;
        private Button btnRemoveMovie;
        private Button btnAddMovie;
        private TextBox txtMovieDirector;
        private Label lblDirectorName;
        private Label lblMovieName;
        private Label lblInfo;
    }
}
