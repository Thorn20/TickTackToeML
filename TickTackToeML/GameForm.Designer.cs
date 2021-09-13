
namespace TickTackToeML
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
            this.grpBox_Board = new System.Windows.Forms.GroupBox();
            this.lbl_BR = new System.Windows.Forms.Label();
            this.lbl_BC = new System.Windows.Forms.Label();
            this.lbl_BL = new System.Windows.Forms.Label();
            this.lbl_MR = new System.Windows.Forms.Label();
            this.lbl_MC = new System.Windows.Forms.Label();
            this.lbl_ML = new System.Windows.Forms.Label();
            this.lbl_TR = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_TL = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.grpBox_Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Board
            // 
            this.grpBox_Board.Controls.Add(this.lbl_BR);
            this.grpBox_Board.Controls.Add(this.lbl_BC);
            this.grpBox_Board.Controls.Add(this.lbl_BL);
            this.grpBox_Board.Controls.Add(this.lbl_MR);
            this.grpBox_Board.Controls.Add(this.lbl_MC);
            this.grpBox_Board.Controls.Add(this.lbl_ML);
            this.grpBox_Board.Controls.Add(this.lbl_TR);
            this.grpBox_Board.Controls.Add(this.lbl_TC);
            this.grpBox_Board.Controls.Add(this.lbl_TL);
            this.grpBox_Board.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_Board.Location = new System.Drawing.Point(5, 9);
            this.grpBox_Board.Margin = new System.Windows.Forms.Padding(0);
            this.grpBox_Board.Name = "grpBox_Board";
            this.grpBox_Board.Size = new System.Drawing.Size(310, 320);
            this.grpBox_Board.TabIndex = 0;
            this.grpBox_Board.TabStop = false;
            this.grpBox_Board.Visible = false;
            // 
            // lbl_BR
            // 
            this.lbl_BR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BR.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BR.Location = new System.Drawing.Point(206, 216);
            this.lbl_BR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BR.Name = "lbl_BR";
            this.lbl_BR.Size = new System.Drawing.Size(100, 100);
            this.lbl_BR.TabIndex = 8;
            this.lbl_BR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BR.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_BC
            // 
            this.lbl_BC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BC.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BC.Location = new System.Drawing.Point(106, 216);
            this.lbl_BC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BC.Name = "lbl_BC";
            this.lbl_BC.Size = new System.Drawing.Size(100, 100);
            this.lbl_BC.TabIndex = 7;
            this.lbl_BC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BC.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_BL
            // 
            this.lbl_BL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BL.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BL.Location = new System.Drawing.Point(6, 216);
            this.lbl_BL.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BL.Name = "lbl_BL";
            this.lbl_BL.Size = new System.Drawing.Size(100, 100);
            this.lbl_BL.TabIndex = 6;
            this.lbl_BL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BL.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_MR
            // 
            this.lbl_MR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MR.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MR.Location = new System.Drawing.Point(206, 116);
            this.lbl_MR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_MR.Name = "lbl_MR";
            this.lbl_MR.Size = new System.Drawing.Size(100, 100);
            this.lbl_MR.TabIndex = 5;
            this.lbl_MR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MR.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_MC
            // 
            this.lbl_MC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MC.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MC.Location = new System.Drawing.Point(106, 116);
            this.lbl_MC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_MC.Name = "lbl_MC";
            this.lbl_MC.Size = new System.Drawing.Size(100, 100);
            this.lbl_MC.TabIndex = 4;
            this.lbl_MC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MC.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_ML
            // 
            this.lbl_ML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ML.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ML.Location = new System.Drawing.Point(6, 116);
            this.lbl_ML.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ML.Name = "lbl_ML";
            this.lbl_ML.Size = new System.Drawing.Size(100, 100);
            this.lbl_ML.TabIndex = 3;
            this.lbl_ML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ML.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_TR
            // 
            this.lbl_TR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TR.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TR.Location = new System.Drawing.Point(206, 16);
            this.lbl_TR.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TR.Name = "lbl_TR";
            this.lbl_TR.Size = new System.Drawing.Size(100, 100);
            this.lbl_TR.TabIndex = 2;
            this.lbl_TR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TR.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_TC
            // 
            this.lbl_TC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TC.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC.Location = new System.Drawing.Point(106, 16);
            this.lbl_TC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(100, 100);
            this.lbl_TC.TabIndex = 1;
            this.lbl_TC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TC.Click += new System.EventHandler(this.CellClicked);
            // 
            // lbl_TL
            // 
            this.lbl_TL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TL.Font = new System.Drawing.Font("Watch Cool jazz", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TL.Location = new System.Drawing.Point(6, 16);
            this.lbl_TL.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TL.Name = "lbl_TL";
            this.lbl_TL.Size = new System.Drawing.Size(100, 100);
            this.lbl_TL.TabIndex = 0;
            this.lbl_TL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TL.Click += new System.EventHandler(this.CellClicked);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Green;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Play.Font = new System.Drawing.Font("Watch Cool jazz", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.Black;
            this.btn_Play.Location = new System.Drawing.Point(5, 9);
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
            this.ClientSize = new System.Drawing.Size(324, 337);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.grpBox_Board);
            this.Name = "GameForm";
            this.Text = "Tick Tack Toe";
            this.grpBox_Board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Board;
        private System.Windows.Forms.Button btn_Play;
        public System.Windows.Forms.Label lbl_BR;
        public System.Windows.Forms.Label lbl_BC;
        public System.Windows.Forms.Label lbl_BL;
        public System.Windows.Forms.Label lbl_MR;
        public System.Windows.Forms.Label lbl_MC;
        public System.Windows.Forms.Label lbl_ML;
        public System.Windows.Forms.Label lbl_TR;
        public System.Windows.Forms.Label lbl_TC;
        public System.Windows.Forms.Label lbl_TL;
    }
}

