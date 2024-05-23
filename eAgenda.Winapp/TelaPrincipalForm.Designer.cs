namespace eAgenda.Winapp
{
    partial class TelaPrincipalForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            statusLabelPrincipal = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusLabelPrincipal.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(573, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(176, 24);
            contatosMenuItem.Text = "Contatos";
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(176, 24);
            compromissosMenuItem.Text = "Compromissos";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusLabelPrincipal.Location = new Point(0, 309);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(573, 25);
            statusLabelPrincipal.TabIndex = 1;
            statusLabelPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(185, 20);
            toolStripStatusLabel1.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(573, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Text = "toolStripButton1";
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Text = "toolStripButton2";
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Text = "toolStripButton3";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(573, 240);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 334);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusLabelPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusLabelPrincipal.ResumeLayout(false);
            statusLabelPrincipal.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private StatusStrip statusLabelPrincipal;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
    }
}
