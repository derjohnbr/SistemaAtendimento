namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            dgvConsultaAtendimento = new DataGridView();
            lblTipoFiltro = new Label();
            txtFiltro = new TextBox();
            btnPesquisar = new Button();
            imlIcones = new ImageList(components);
            cbxFiltro = new ComboBox();
            grbFiltro = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            grbFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(12, 84);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(619, 354);
            dgvConsultaAtendimento.TabIndex = 0;
            // 
            // lblTipoFiltro
            // 
            lblTipoFiltro.AutoSize = true;
            lblTipoFiltro.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoFiltro.Location = new Point(175, 13);
            lblTipoFiltro.Name = "lblTipoFiltro";
            lblTipoFiltro.Size = new Size(9, 12);
            lblTipoFiltro.TabIndex = 1;
            lblTipoFiltro.Text = "-";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(187, 37);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(336, 23);
            txtFiltro.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(517, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 38);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(18, 36);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(163, 23);
            cbxFiltro.TabIndex = 4;
            cbxFiltro.SelectedIndexChanged += cbxFiltro_SelectedIndexChanged;
            // 
            // grbFiltro
            // 
            grbFiltro.Controls.Add(lblTipoFiltro);
            grbFiltro.Controls.Add(btnPesquisar);
            grbFiltro.Location = new Point(12, 9);
            grbFiltro.Name = "grbFiltro";
            grbFiltro.Size = new Size(619, 69);
            grbFiltro.TabIndex = 6;
            grbFiltro.TabStop = false;
            grbFiltro.Text = "Filtrar por:";
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 450);
            Controls.Add(cbxFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(dgvConsultaAtendimento);
            Controls.Add(grbFiltro);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaAtendimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas de Atendimento";
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            grbFiltro.ResumeLayout(false);
            grbFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private Label lblTipoFiltro;
        private TextBox txtFiltro;
        private Button btnPesquisar;
        private ComboBox cbxFiltro;
        private ImageList imlIcones;
        private GroupBox grbFiltro;
    }
}