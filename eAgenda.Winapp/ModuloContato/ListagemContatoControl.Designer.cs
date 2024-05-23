namespace eAgenda.Winapp.ModuloContato
{
    partial class ListagemContatoControl
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
            listContatos = new ListBox();
            SuspendLayout();
            // 
            // listContatos
            // 
            listContatos.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listContatos.FormattingEnabled = true;
            listContatos.ItemHeight = 15;
            listContatos.Location = new Point(3, 3);
            listContatos.Name = "listContatos";
            listContatos.Size = new Size(119, 34);
            listContatos.TabIndex = 0;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 8, 7, 8);
            Name = "ListagemContatoControl";
            Size = new Size(801, 386);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContatos;
    }
}
