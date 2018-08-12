namespace KiRA.GUI
{
    partial class TaskManager
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
            this.dgvTaskManager = new System.Windows.Forms.DataGridView();         
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTaskModification = new System.Windows.Forms.Button();
            this.lTaskManager = new System.Windows.Forms.Label();           
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaskManager
            // 
            this.dgvTaskManager.AllowUserToAddRows = false;
            this.dgvTaskManager.AllowUserToDeleteRows = false;
            this.dgvTaskManager.AllowUserToOrderColumns = true;
            this.dgvTaskManager.AllowUserToResizeColumns = false;
            this.dgvTaskManager.AllowUserToResizeRows = false;
            this.dgvTaskManager.AutoGenerateColumns = false;
            this.dgvTaskManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskName});
            this.dgvTaskManager.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvTaskManager.DataSource = this.taskBindingSource;
            this.dgvTaskManager.Location = new System.Drawing.Point(46, 101);
            this.dgvTaskManager.Name = "dgvTaskManager";
            this.dgvTaskManager.ReadOnly = true;
            this.dgvTaskManager.RowHeadersVisible = false;
            this.dgvTaskManager.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTaskManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskManager.Size = new System.Drawing.Size(942, 409);
            this.dgvTaskManager.TabIndex = 1;
            this.dgvTaskManager.VirtualMode = true;
            // 
            // TaskID
            // 
            this.TaskID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskID.DataPropertyName = "TaskID";
            this.TaskID.HeaderText = "Task ID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Task name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            // 
            // btnTaskModification
            // 
            this.btnTaskModification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(197)))));
            this.btnTaskModification.FlatAppearance.BorderSize = 0;
            this.btnTaskModification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnTaskModification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnTaskModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskModification.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskModification.ForeColor = System.Drawing.Color.White;
            this.btnTaskModification.Location = new System.Drawing.Point(759, 38);
            this.btnTaskModification.Name = "btnTaskModification";
            this.btnTaskModification.Size = new System.Drawing.Size(229, 49);
            this.btnTaskModification.TabIndex = 0;
            this.btnTaskModification.Text = "Tasks modification";
            this.btnTaskModification.UseVisualStyleBackColor = false;
            this.btnTaskModification.Click += new System.EventHandler(this.btnTaskModification_Click);
            // 
            // lTaskManager
            // 
            this.lTaskManager.AutoSize = true;
            this.lTaskManager.Font = new System.Drawing.Font("Metrostyle Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTaskManager.Location = new System.Drawing.Point(40, 42);
            this.lTaskManager.Name = "lTaskManager";
            this.lTaskManager.Size = new System.Drawing.Size(254, 33);
            this.lTaskManager.TabIndex = 2;
            this.lTaskManager.Text = "Task manager";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lTaskManager);
            this.Controls.Add(this.dgvTaskManager);
            this.Controls.Add(this.btnTaskModification);
            this.Name = "TaskManager";
            this.Size = new System.Drawing.Size(1030, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTaskManager;
        private System.Windows.Forms.Button btnTaskModification;
        private System.Windows.Forms.Label lTaskManager;      
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
    }
}
