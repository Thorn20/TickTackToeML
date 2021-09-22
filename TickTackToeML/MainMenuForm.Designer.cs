
namespace TickTackToeML
{
    partial class MainMenuForm
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
            this.btn_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Green;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Play.Font = new System.Drawing.Font("Watch Cool jazz", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.Black;
            this.btn_Play.Location = new System.Drawing.Point(5, 12);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(310, 80);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play Game";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 336);
            this.Controls.Add(this.btn_Play);
            this.Name = "GameForm";
            this.Text = "Tick Tack Toe";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Play;
    }
}

