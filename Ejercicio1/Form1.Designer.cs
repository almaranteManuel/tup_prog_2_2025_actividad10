namespace Ejercicio1
{
    partial class FormPrincipal
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
            openFileDialog1 = new OpenFileDialog();
            lsbVerSolicitudesImportadas = new ListBox();
            btnImpSol = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 21;
            lsbVerSolicitudesImportadas.Location = new Point(15, 17);
            lsbVerSolicitudesImportadas.Margin = new Padding(4);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(538, 256);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImpSol
            // 
            btnImpSol.Location = new Point(560, 87);
            btnImpSol.Name = "btnImpSol";
            btnImpSol.Size = new Size(149, 100);
            btnImpSol.TabIndex = 1;
            btnImpSol.Text = "Importar Solicitudes";
            btnImpSol.UseVisualStyleBackColor = true;
            btnImpSol.Click += btnImpSol_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnImpSol);
            Controls.Add(lsbVerSolicitudesImportadas);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImpSol;
        private SaveFileDialog saveFileDialog1;
    }
}
