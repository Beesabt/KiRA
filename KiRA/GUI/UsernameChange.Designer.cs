namespace KiRA.GUI
{
    partial class UsernameChange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lUsernameChange = new System.Windows.Forms.Label();
            this.btnUNameChange = new System.Windows.Forms.Button();
            this.tbNewUsernameAgain = new System.Windows.Forms.TextBox();
            this.lNewUsername = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.lNewUsernameAgain = new System.Windows.Forms.Label();
            this.UsernameInfoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lOldUsername = new System.Windows.Forms.Label();
            this.tbOldUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lUsernameChange
            // 
            this.lUsernameChange.AutoSize = true;
            this.lUsernameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lUsernameChange.Location = new System.Drawing.Point(109, 68);
            this.lUsernameChange.Name = "lUsernameChange";
            this.lUsernameChange.Size = new System.Drawing.Size(278, 37);
            this.lUsernameChange.TabIndex = 5;
            this.lUsernameChange.Text = "Username change";
            // 
            // btnUNameChange
            // 
            this.btnUNameChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(197)))));
            this.btnUNameChange.FlatAppearance.BorderSize = 0;
            this.btnUNameChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnUNameChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnUNameChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUNameChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUNameChange.ForeColor = System.Drawing.Color.White;
            this.btnUNameChange.Location = new System.Drawing.Point(719, 423);
            this.btnUNameChange.Name = "btnUNameChange";
            this.btnUNameChange.Size = new System.Drawing.Size(203, 49);
            this.btnUNameChange.TabIndex = 3;
            this.btnUNameChange.Text = "Change";
            this.btnUNameChange.UseVisualStyleBackColor = false;
            this.btnUNameChange.Click += new System.EventHandler(this.btnUNameChange_Click);
            // 
            // tbNewUsernameAgain
            // 
            this.tbNewUsernameAgain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNewUsernameAgain.Location = new System.Drawing.Point(384, 326);
            this.tbNewUsernameAgain.MaxLength = 10;
            this.tbNewUsernameAgain.Name = "tbNewUsernameAgain";
            this.tbNewUsernameAgain.Size = new System.Drawing.Size(400, 26);
            this.tbNewUsernameAgain.TabIndex = 2;
            // 
            // lNewUsername
            // 
            this.lNewUsername.AutoSize = true;
            this.lNewUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNewUsername.Location = new System.Drawing.Point(252, 260);
            this.lNewUsername.Name = "lNewUsername";
            this.lNewUsername.Size = new System.Drawing.Size(118, 21);
            this.lNewUsername.TabIndex = 7;
            this.lNewUsername.Text = "New username:";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNewUsername.Location = new System.Drawing.Point(384, 260);
            this.tbNewUsername.MaxLength = 10;
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(400, 26);
            this.tbNewUsername.TabIndex = 1;
            // 
            // lNewUsernameAgain
            // 
            this.lNewUsernameAgain.AutoSize = true;
            this.lNewUsernameAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNewUsernameAgain.Location = new System.Drawing.Point(210, 328);
            this.lNewUsernameAgain.Name = "lNewUsernameAgain";
            this.lNewUsernameAgain.Size = new System.Drawing.Size(160, 21);
            this.lNewUsernameAgain.TabIndex = 8;
            this.lNewUsernameAgain.Text = "New username again:";
            // 
            // lOldUsername
            // 
            this.lOldUsername.AutoSize = true;
            this.lOldUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOldUsername.Location = new System.Drawing.Point(259, 182);
            this.lOldUsername.Name = "lOldUsername";
            this.lOldUsername.Size = new System.Drawing.Size(111, 21);
            this.lOldUsername.TabIndex = 6;
            this.lOldUsername.Text = "Old username:";
            // 
            // tbOldUsername
            // 
            this.tbOldUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOldUsername.Location = new System.Drawing.Point(384, 180);
            this.tbOldUsername.Name = "tbOldUsername";
            this.tbOldUsername.Size = new System.Drawing.Size(400, 26);
            this.tbOldUsername.TabIndex = 0;
            // 
            // UsernameChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lUsernameChange);
            this.Controls.Add(this.btnUNameChange);
            this.Controls.Add(this.tbNewUsernameAgain);
            this.Controls.Add(this.lOldUsername);
            this.Controls.Add(this.lNewUsername);
            this.Controls.Add(this.tbNewUsername);
            this.Controls.Add(this.lNewUsernameAgain);
            this.Controls.Add(this.tbOldUsername);
            this.Name = "UsernameChange";
            this.Size = new System.Drawing.Size(1030, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsernameChange;
        private System.Windows.Forms.Button btnUNameChange;
        private System.Windows.Forms.TextBox tbNewUsernameAgain;
        private System.Windows.Forms.Label lNewUsername;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.Label lNewUsernameAgain;
        private System.Windows.Forms.ToolTip UsernameInfoTooltip;
        private System.Windows.Forms.Label lOldUsername;
        private System.Windows.Forms.TextBox tbOldUsername;
    }
}
