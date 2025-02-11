namespace FileAnalyzer.UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ListBox listResults;
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // txtFilePath
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Size = new System.Drawing.Size(300, 20);

            // btnAnalyze
            this.btnAnalyze.Location = new System.Drawing.Point(320, 10);
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.Text = "Analizuj";

            // listResults
            this.listResults.Location = new System.Drawing.Point(12, 50);
            this.listResults.Size = new System.Drawing.Size(380, 150);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.listResults);
            this.Text = "Analiza pliku tekstowego";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
