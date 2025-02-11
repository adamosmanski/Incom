namespace ToDoList.UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblTask;

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
            txtTaskDescription = new TextBox();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            dgvTasks = new DataGridView();
            cbStatus = new ComboBox();
            lblTask = new Label();
            btnAcceptChange = new Button();
            label1 = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Font = new Font("Segoe UI", 12F);
            txtTaskDescription.Location = new Point(18, 38);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(532, 29);
            txtTaskDescription.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.LightGreen;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTask.Location = new Point(556, 39);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(132, 28);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Dodaj zadanie";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.BackColor = Color.LightCoral;
            btnRemoveTask.FlatStyle = FlatStyle.Flat;
            btnRemoveTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveTask.Location = new Point(414, 95);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(146, 28);
            btnRemoveTask.TabIndex = 2;
            btnRemoveTask.Text = "Usuń zadanie";
            btnRemoveTask.UseVisualStyleBackColor = false;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(18, 129);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.Size = new Size(665, 234);
            dgvTasks.TabIndex = 4;
            // 
            // cbStatus
            // 
            cbStatus.Location = new Point(0, 0);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 0;
            // 
            // lblTask
            // 
            lblTask.Font = new Font("Segoe UI", 10F);
            lblTask.Location = new Point(18, 14);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(131, 19);
            lblTask.TabIndex = 5;
            lblTask.Text = "Opis zadania:";
            // 
            // btnAcceptChange
            // 
            btnAcceptChange.BackColor = Color.LightSkyBlue;
            btnAcceptChange.FlatStyle = FlatStyle.Flat;
            btnAcceptChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAcceptChange.Location = new Point(248, 95);
            btnAcceptChange.Name = "btnAcceptChange";
            btnAcceptChange.Size = new Size(160, 28);
            btnAcceptChange.TabIndex = 6;
            btnAcceptChange.Text = "Zatwierdź zmiany";
            btnAcceptChange.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(18, 70);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 7;
            label1.Text = "Ustaw nowy status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(18, 100);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(219, 23);
            cmbStatus.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 375);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(btnAcceptChange);
            Controls.Add(txtTaskDescription);
            Controls.Add(btnAddTask);
            Controls.Add(btnRemoveTask);
            Controls.Add(dgvTasks);
            Controls.Add(lblTask);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "To-Do List";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceptChange;
        private Label label1;
        private ComboBox cmbStatus;
    }
}
