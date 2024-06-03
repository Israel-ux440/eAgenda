namespace eAgenda.Winapp.Properties.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtData = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            label4 = new Label();
            txtHoraTermino = new DateTimePicker();
            label5 = new Label();
            checkMarcarContato = new CheckBox();
            cmbContatos = new ComboBox();
            groupBox1 = new GroupBox();
            txtLocal = new TextBox();
            txtLink = new TextBox();
            rdbPresencial = new RadioButton();
            rdbRemoto = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(27, 90);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(77, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(77, 57);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(288, 23);
            txtAssunto.TabIndex = 3;
            // 
            // txtData
            // 
            txtData.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(77, 87);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 4;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(77, 119);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(100, 23);
            txtHoraInicio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(27, 119);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Início:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(265, 120);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(100, 23);
            txtHoraTermino.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(193, 122);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 2;
            label5.Text = "Término:";
            // 
            // checkMarcarContato
            // 
            checkMarcarContato.AutoSize = true;
            checkMarcarContato.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMarcarContato.Location = new Point(45, 162);
            checkMarcarContato.Name = "checkMarcarContato";
            checkMarcarContato.Size = new Size(214, 24);
            checkMarcarContato.TabIndex = 5;
            checkMarcarContato.Text = "Deseja marcar um contato ?";
            checkMarcarContato.UseVisualStyleBackColor = true;
            checkMarcarContato.CheckedChanged += checkMarcarContato_CheckedChanged;
            // 
            // cmbContatos
            // 
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Items.AddRange(new object[] { "rech ", "tiago" });
            cmbContatos.Location = new Point(45, 192);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(214, 28);
            cmbContatos.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbRemoto);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(45, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 93);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Location = new Point(101, 53);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(225, 27);
            txtLocal.TabIndex = 10;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(101, 23);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(225, 27);
            txtLink.TabIndex = 9;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(6, 53);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(96, 24);
            rdbPresencial.TabIndex = 8;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Checked = true;
            rdbRemoto.Location = new Point(1, 23);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(83, 24);
            rdbRemoto.TabIndex = 8;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto:";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(123, 349);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(129, 48);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(258, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 48);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 415);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(cmbContatos);
            Controls.Add(checkMarcarContato);
            Controls.Add(txtHoraTermino);
            Controls.Add(txtHoraInicio);
            Controls.Add(txtData);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromisso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtAssunto;
        private DateTimePicker txtData;
        private DateTimePicker txtHoraInicio;
        private Label label4;
        private DateTimePicker txtHoraTermino;
        private Label label5;
        private CheckBox checkMarcarContato;
        private ComboBox cmbContatos;
        private GroupBox groupBox1;
        private RadioButton rdbPresencial;
        private RadioButton rdbRemoto;
        private TextBox txtLocal;
        private TextBox txtLink;
        private Button btnGravar;
        private Button btnCancelar;
    }
}