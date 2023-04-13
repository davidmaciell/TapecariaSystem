
namespace TapecariaSystem
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrocliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroservico = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastromaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrofornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrousuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriossaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.labelnen = new System.Windows.Forms.Label();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(877, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrocliente,
            this.cadastroservico,
            this.cadastromaterial,
            this.cadastrofornecedor,
            this.cadastrousuarios});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrocliente
            // 
            this.cadastrocliente.Name = "cadastrocliente";
            this.cadastrocliente.Size = new System.Drawing.Size(134, 22);
            this.cadastrocliente.Text = "Cliente";
            this.cadastrocliente.Click += new System.EventHandler(this.cadastrocliente_Click);
            // 
            // cadastroservico
            // 
            this.cadastroservico.Name = "cadastroservico";
            this.cadastroservico.Size = new System.Drawing.Size(134, 22);
            this.cadastroservico.Text = "Serviços";
            this.cadastroservico.Click += new System.EventHandler(this.cadastroservico_Click);
            // 
            // cadastromaterial
            // 
            this.cadastromaterial.Name = "cadastromaterial";
            this.cadastromaterial.Size = new System.Drawing.Size(134, 22);
            this.cadastromaterial.Text = "Material";
            this.cadastromaterial.Click += new System.EventHandler(this.cadastromaterial_Click);
            // 
            // cadastrofornecedor
            // 
            this.cadastrofornecedor.Name = "cadastrofornecedor";
            this.cadastrofornecedor.Size = new System.Drawing.Size(134, 22);
            this.cadastrofornecedor.Text = "Fornecedor";
            this.cadastrofornecedor.Click += new System.EventHandler(this.cadastrofornecedor_Click);
            // 
            // cadastrousuarios
            // 
            this.cadastrousuarios.Name = "cadastrousuarios";
            this.cadastrousuarios.Size = new System.Drawing.Size(134, 22);
            this.cadastrousuarios.Text = "Usuários";
            this.cadastrousuarios.Click += new System.EventHandler(this.cadastrousuarios_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriossaidas});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatoriossaidas
            // 
            this.relatoriossaidas.Name = "relatoriossaidas";
            this.relatoriossaidas.Size = new System.Drawing.Size(110, 22);
            this.relatoriossaidas.Text = "Saídas ";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(38, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TapecariaSystem.Properties.Resources.sofaM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imgPrincipal
            // 
            this.imgPrincipal.Image = global::TapecariaSystem.Properties.Resources.sofaPrincipal;
            this.imgPrincipal.Location = new System.Drawing.Point(-1060, 12);
            this.imgPrincipal.Name = "imgPrincipal";
            this.imgPrincipal.Size = new System.Drawing.Size(624, 326);
            this.imgPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPrincipal.TabIndex = 1;
            this.imgPrincipal.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(90, 416);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário";
            // 
            // labelnen
            // 
            this.labelnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelnen.AutoSize = true;
            this.labelnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnen.Location = new System.Drawing.Point(13, 416);
            this.labelnen.Name = "labelnen";
            this.labelnen.Size = new System.Drawing.Size(81, 20);
            this.labelnen.TabIndex = 4;
            this.labelnen.Text = "Usuário: ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.labelnen);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrocliente;
        private System.Windows.Forms.ToolStripMenuItem cadastroservico;
        private System.Windows.Forms.ToolStripMenuItem cadastromaterial;
        private System.Windows.Forms.ToolStripMenuItem cadastrofornecedor;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriossaidas;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.PictureBox imgPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cadastrousuarios;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label labelnen;
    }
}

