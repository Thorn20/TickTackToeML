
namespace TickTackToeML.Game
{
    partial class GameForm
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
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.lbl_TL = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_TR = new System.Windows.Forms.Label();
            this.lbl_MR = new System.Windows.Forms.Label();
            this.lbl_MC = new System.Windows.Forms.Label();
            this.lbl_ML = new System.Windows.Forms.Label();
            this.lbl_BR = new System.Windows.Forms.Label();
            this.lbl_BC = new System.Windows.Forms.Label();
            this.lbl_BL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.Font = new System.Drawing.Font("Watch Cool jazz", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turn.Location = new System.Drawing.Point(10, 323);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(300, 50);
            this.lbl_Turn.TabIndex = 9;
            this.lbl_Turn.Text = "Player X Turn";
            this.lbl_Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TL
            // 
            this.lbl_TL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TL.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TL.Location = new System.Drawing.Point(10, 10);
            this.lbl_TL.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TL.Name = "lbl_TL";
            this.lbl_TL.Size = new System.Drawing.Size(100, 100);
            this.lbl_TL.TabIndex = 0;
            this.lbl_TL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TL.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_TC
            // 
            this.lbl_TC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TC.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC.Location = new System.Drawing.Point(110, 10);
            this.lbl_TC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(100, 100);
            this.lbl_TC.TabIndex = 10;
            this.lbl_TC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TC.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_TR
            // 
            this.lbl_TR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TR.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TR.Location = new System.Drawing.Point(210, 10);
            this.lbl_TR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TR.Name = "lbl_TR";
            this.lbl_TR.Size = new System.Drawing.Size(100, 100);
            this.lbl_TR.TabIndex = 11;
            this.lbl_TR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TR.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_MR
            // 
            this.lbl_MR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MR.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MR.Location = new System.Drawing.Point(210, 110);
            this.lbl_MR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_MR.Name = "lbl_MR";
            this.lbl_MR.Size = new System.Drawing.Size(100, 100);
            this.lbl_MR.TabIndex = 14;
            this.lbl_MR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MR.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_MC
            // 
            this.lbl_MC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MC.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MC.Location = new System.Drawing.Point(110, 110);
            this.lbl_MC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_MC.Name = "lbl_MC";
            this.lbl_MC.Size = new System.Drawing.Size(100, 100);
            this.lbl_MC.TabIndex = 13;
            this.lbl_MC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MC.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_ML
            // 
            this.lbl_ML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ML.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ML.Location = new System.Drawing.Point(10, 110);
            this.lbl_ML.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ML.Name = "lbl_ML";
            this.lbl_ML.Size = new System.Drawing.Size(100, 100);
            this.lbl_ML.TabIndex = 12;
            this.lbl_ML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ML.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_BR
            // 
            this.lbl_BR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BR.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BR.Location = new System.Drawing.Point(210, 210);
            this.lbl_BR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BR.Name = "lbl_BR";
            this.lbl_BR.Size = new System.Drawing.Size(100, 100);
            this.lbl_BR.TabIndex = 17;
            this.lbl_BR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BR.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_BC
            // 
            this.lbl_BC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BC.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BC.Location = new System.Drawing.Point(110, 210);
            this.lbl_BC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BC.Name = "lbl_BC";
            this.lbl_BC.Size = new System.Drawing.Size(100, 100);
            this.lbl_BC.TabIndex = 16;
            this.lbl_BC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BC.Click += new System.EventHandler(this.Cell_Click);
            // 
            // lbl_BL
            // 
            this.lbl_BL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BL.Font = new System.Drawing.Font("Watch Cool jazz", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BL.Location = new System.Drawing.Point(10, 210);
            this.lbl_BL.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BL.Name = "lbl_BL";
            this.lbl_BL.Size = new System.Drawing.Size(100, 100);
            this.lbl_BL.TabIndex = 15;
            this.lbl_BL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BL.Click += new System.EventHandler(this.Cell_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 381);
            this.Controls.Add(this.lbl_BR);
            this.Controls.Add(this.lbl_BC);
            this.Controls.Add(this.lbl_BL);
            this.Controls.Add(this.lbl_MR);
            this.Controls.Add(this.lbl_MC);
            this.Controls.Add(this.lbl_ML);
            this.Controls.Add(this.lbl_TR);
            this.Controls.Add(this.lbl_TC);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.lbl_TL);
            this.Name = "GameForm";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.Label lbl_TL;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_TR;
        private System.Windows.Forms.Label lbl_MR;
        private System.Windows.Forms.Label lbl_MC;
        private System.Windows.Forms.Label lbl_ML;
        private System.Windows.Forms.Label lbl_BR;
        private System.Windows.Forms.Label lbl_BC;
        private System.Windows.Forms.Label lbl_BL;
    }
}