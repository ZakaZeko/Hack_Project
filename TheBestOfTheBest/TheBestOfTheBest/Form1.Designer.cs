namespace TheBestOfTheBest
{
    partial class Form1
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlMainMenu.Controls.Add(this.btnCreateGame);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1200, 600);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnCreateGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGame.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateGame.Location = new System.Drawing.Point(500, 250);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(200, 100);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlMainMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnCreateGame;
    }
}
