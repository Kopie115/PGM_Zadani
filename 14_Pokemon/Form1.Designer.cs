namespace _14_Pokemon
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
            this.listBoxPokemons = new System.Windows.Forms.ListBox();
            this.groupBoxPokemonList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPokemonList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPokemons
            // 
            this.listBoxPokemons.FormattingEnabled = true;
            this.listBoxPokemons.ItemHeight = 15;
            this.listBoxPokemons.Location = new System.Drawing.Point(6, 22);
            this.listBoxPokemons.Name = "listBoxPokemons";
            this.listBoxPokemons.Size = new System.Drawing.Size(188, 184);
            this.listBoxPokemons.TabIndex = 0;
            // 
            // groupBoxPokemonList
            // 
            this.groupBoxPokemonList.Controls.Add(this.listBoxPokemons);
            this.groupBoxPokemonList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPokemonList.Name = "groupBoxPokemonList";
            this.groupBoxPokemonList.Size = new System.Drawing.Size(200, 213);
            this.groupBoxPokemonList.TabIndex = 1;
            this.groupBoxPokemonList.TabStop = false;
            this.groupBoxPokemonList.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPokemonList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPokemonList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxPokemons;
        private GroupBox groupBoxPokemonList;
        private Label label1;
    }
}