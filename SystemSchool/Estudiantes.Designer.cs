
namespace SystemSchool
{
    partial class Estudiantes
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
            this.dgwEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudiantes Activos";
            // 
            // dgwEstudiantes
            // 
            this.dgwEstudiantes.AllowUserToAddRows = false;
            this.dgwEstudiantes.AllowUserToDeleteRows = false;
            this.dgwEstudiantes.AllowUserToResizeColumns = false;
            this.dgwEstudiantes.AllowUserToResizeRows = false;
            this.dgwEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEstudiantes.Location = new System.Drawing.Point(12, 111);
            this.dgwEstudiantes.Name = "dgwEstudiantes";
            this.dgwEstudiantes.ShowCellToolTips = false;
            this.dgwEstudiantes.ShowEditingIcon = false;
            this.dgwEstudiantes.ShowRowErrors = false;
            this.dgwEstudiantes.Size = new System.Drawing.Size(422, 317);
            this.dgwEstudiantes.TabIndex = 4;
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 440);
            this.Controls.Add(this.dgwEstudiantes);
            this.Controls.Add(this.label1);
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwEstudiantes;
    }
}