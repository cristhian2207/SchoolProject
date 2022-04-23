
namespace SystemSchool
{
    partial class Docentes
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
            this.dgwProfesores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profesores Activos";
            // 
            // dgwProfesores
            // 
            this.dgwProfesores.AllowUserToAddRows = false;
            this.dgwProfesores.AllowUserToDeleteRows = false;
            this.dgwProfesores.AllowUserToResizeColumns = false;
            this.dgwProfesores.AllowUserToResizeRows = false;
            this.dgwProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfesores.Location = new System.Drawing.Point(12, 121);
            this.dgwProfesores.Name = "dgwProfesores";
            this.dgwProfesores.ShowCellToolTips = false;
            this.dgwProfesores.ShowEditingIcon = false;
            this.dgwProfesores.ShowRowErrors = false;
            this.dgwProfesores.Size = new System.Drawing.Size(523, 317);
            this.dgwProfesores.TabIndex = 5;
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.dgwProfesores);
            this.Controls.Add(this.label1);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwProfesores;
    }
}