namespace CurrencyApp.UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnFetchCurrent;
        private System.Windows.Forms.Button btnFetchHistorical;

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
            txtYear = new TextBox();
            cmbMonth = new ComboBox();
            btnFetchCurrent = new Button();
            btnFetchHistorical = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dgv_rates = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rates).BeginInit();
            SuspendLayout();
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 12);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Wprowadź rok";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cmbMonth.Location = new Point(120, 12);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(120, 23);
            cmbMonth.TabIndex = 1;
            // 
            // btnFetchCurrent
            // 
            btnFetchCurrent.Location = new Point(388, 12);
            btnFetchCurrent.Name = "btnFetchCurrent";
            btnFetchCurrent.Size = new Size(100, 23);
            btnFetchCurrent.TabIndex = 2;
            btnFetchCurrent.Text = "Aktualne kursy";
            // 
            // btnFetchHistorical
            // 
            btnFetchHistorical.Location = new Point(246, 12);
            btnFetchHistorical.Name = "btnFetchHistorical";
            btnFetchHistorical.Size = new Size(120, 23);
            btnFetchHistorical.TabIndex = 3;
            btnFetchHistorical.Text = "Archiwalne kursy";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtYear);
            panel1.Controls.Add(btnFetchHistorical);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(btnFetchCurrent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 51);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_rates);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 229);
            panel2.TabIndex = 5;
            // 
            // dgv_rates
            // 
            dgv_rates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rates.Dock = DockStyle.Fill;
            dgv_rates.Location = new Point(0, 0);
            dgv_rates.Name = "dgv_rates";
            dgv_rates.Size = new Size(500, 229);
            dgv_rates.TabIndex = 0;
            // 
            // MainWindow
            // 
            ClientSize = new Size(500, 280);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainWindow";
            Text = "Kursy Walut NBP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_rates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgv_rates;
    }
}
