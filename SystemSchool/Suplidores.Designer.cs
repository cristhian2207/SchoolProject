
namespace SystemSchool
{
    partial class Suplidores
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwSuplidores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Suplidores";
            // 
            // dgwSuplidores
            // 
            this.dgwSuplidores.AllowUserToAddRows = false;
            this.dgwSuplidores.AllowUserToDeleteRows = false;
            this.dgwSuplidores.AllowUserToResizeColumns = false;
            this.dgwSuplidores.AllowUserToResizeRows = false;
            this.dgwSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSuplidores.Location = new System.Drawing.Point(21, 101);
            this.dgwSuplidores.Name = "dgwSuplidores";
            this.dgwSuplidores.ShowCellToolTips = false;
            this.dgwSuplidores.ShowEditingIcon = false;
            this.dgwSuplidores.ShowRowErrors = false;
            this.dgwSuplidores.Size = new System.Drawing.Size(365, 341);
            this.dgwSuplidores.TabIndex = 5;
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 464);
            this.Controls.Add(this.dgwSuplidores);
            this.Controls.Add(this.label1);
            this.Name = "Suplidores";
            this.Text = "Suplidores";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuplidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwSuplidores;
    }
}