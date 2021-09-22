
namespace TickTackToeML
{
    partial class PlayerSelectMenu
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
            this.grpBox_Player1 = new System.Windows.Forms.GroupBox();
            this.cboBox_Player1Selection = new System.Windows.Forms.ComboBox();
            this.grpBox_Player2 = new System.Windows.Forms.GroupBox();
            this.cboBox_Player2Selection = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.grpBox_Player1.SuspendLayout();
            this.grpBox_Player2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Player1
            // 
            this.grpBox_Player1.Controls.Add(this.cboBox_Player1Selection);
            this.grpBox_Player1.Font = new System.Drawing.Font("Watch Cool jazz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Player1.ForeColor = System.Drawing.Color.Black;
            this.grpBox_Player1.Location = new System.Drawing.Point(6, 12);
            this.grpBox_Player1.Name = "grpBox_Player1";
            this.grpBox_Player1.Size = new System.Drawing.Size(327, 69);
            this.grpBox_Player1.TabIndex = 0;
            this.grpBox_Player1.TabStop = false;
            this.grpBox_Player1.Text = "Player 1";
            // 
            // cboBox_Player1Selection
            // 
            this.cboBox_Player1Selection.Font = new System.Drawing.Font("Watch Cool jazz", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBox_Player1Selection.FormattingEnabled = true;
            this.cboBox_Player1Selection.Location = new System.Drawing.Point(6, 29);
            this.cboBox_Player1Selection.Name = "cboBox_Player1Selection";
            this.cboBox_Player1Selection.Size = new System.Drawing.Size(315, 33);
            this.cboBox_Player1Selection.TabIndex = 0;
            // 
            // grpBox_Player2
            // 
            this.grpBox_Player2.Controls.Add(this.cboBox_Player2Selection);
            this.grpBox_Player2.Font = new System.Drawing.Font("Watch Cool jazz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Player2.ForeColor = System.Drawing.Color.Black;
            this.grpBox_Player2.Location = new System.Drawing.Point(6, 87);
            this.grpBox_Player2.Name = "grpBox_Player2";
            this.grpBox_Player2.Size = new System.Drawing.Size(327, 69);
            this.grpBox_Player2.TabIndex = 1;
            this.grpBox_Player2.TabStop = false;
            this.grpBox_Player2.Text = "Player 2";
            // 
            // cboBox_Player2Selection
            // 
            this.cboBox_Player2Selection.Font = new System.Drawing.Font("Watch Cool jazz", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBox_Player2Selection.FormattingEnabled = true;
            this.cboBox_Player2Selection.Location = new System.Drawing.Point(6, 29);
            this.cboBox_Player2Selection.Name = "cboBox_Player2Selection";
            this.cboBox_Player2Selection.Size = new System.Drawing.Size(315, 33);
            this.cboBox_Player2Selection.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Watch Cool jazz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(6, 162);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(154, 51);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Green;
            this.btn_Start.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Start.Font = new System.Drawing.Font("Watch Cool jazz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(179, 162);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(154, 51);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            // 
            // PlayerSelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 224);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.grpBox_Player2);
            this.Controls.Add(this.grpBox_Player1);
            this.Name = "PlayerSelectMenu";
            this.Text = "Player Selection";
            this.grpBox_Player1.ResumeLayout(false);
            this.grpBox_Player2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Start;
        public System.Windows.Forms.ComboBox cboBox_Player1Selection;
        public System.Windows.Forms.GroupBox grpBox_Player1;
        public System.Windows.Forms.GroupBox grpBox_Player2;
        public System.Windows.Forms.ComboBox cboBox_Player2Selection;
    }
}