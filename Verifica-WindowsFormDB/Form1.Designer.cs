namespace Verifica_WindowsFormDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridViewForm1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodiceFarnell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodiceProduttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantità = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCerca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForm1
            // 
            this.dataGridViewForm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodiceFarnell,
            this.CodiceProduttore,
            this.Quantità,
            this.Prezzo});
            this.dataGridViewForm1.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewForm1.Name = "dataGridViewForm1";
            this.dataGridViewForm1.RowTemplate.Height = 25;
            this.dataGridViewForm1.Size = new System.Drawing.Size(589, 321);
            this.dataGridViewForm1.TabIndex = 0;
            this.dataGridViewForm1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm1_cellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CodiceFarnell
            // 
            this.CodiceFarnell.HeaderText = "CodiceFarnell";
            this.CodiceFarnell.Name = "CodiceFarnell";
            // 
            // CodiceProduttore
            // 
            this.CodiceProduttore.HeaderText = "CodiceProduttore";
            this.CodiceProduttore.Name = "CodiceProduttore";
            // 
            // Quantità
            // 
            this.Quantità.HeaderText = "Quantità";
            this.Quantità.Name = "Quantità";
            // 
            // Prezzo
            // 
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            // 
            // textBoxCerca
            // 
            this.textBoxCerca.Location = new System.Drawing.Point(12, 38);
            this.textBoxCerca.Name = "textBoxCerca";
            this.textBoxCerca.Size = new System.Drawing.Size(137, 23);
            this.textBoxCerca.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCerca);
            this.Controls.Add(this.dataGridViewForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewForm1;
        private TextBox textBoxCerca;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CodiceFarnell;
        private DataGridViewTextBoxColumn CodiceProduttore;
        private DataGridViewTextBoxColumn Quantità;
        private DataGridViewTextBoxColumn Prezzo;
    }
}