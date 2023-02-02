
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
            this.cadastrocliente.Size = new System.Drawing.Size(180, 22);
            this.cadastrocliente.Text = "Cliente";
            this.cadastrocliente.Click += new System.EventHandler(this.cadastrocliente_Click);
            // 
            // cadastroservico
            // 
            this.cadastroservico.Name = "cadastroservico";
            this.cadastroservico.Size = new System.Drawing.Size(180, 22);
            this.cadastroservico.Text = "Serviço";
            // 
            // cadastromaterial
            // 
            this.cadastromaterial.Name = "cadastromaterial";
            this.cadastromaterial.Size = new System.Drawing.Size(180, 22);
            this.cadastromaterial.Text = "Material";
            // 
            // cadastrofornecedor
            // 
            this.cadastrofornecedor.Name = "cadastrofornecedor";
            this.cadastrofornecedor.Size = new System.Drawing.Size(180, 22);
            this.cadastrofornecedor.Text = "Fornecedor";
            this.cadastrofornecedor.Click += new System.EventHandler(this.cadastrofornecedor_Click);
            // 
            // cadastrousuarios
            // 
            this.cadastrousuarios.Name = "cadastrousuarios";
            this.cadastrousuarios.Size = new System.Drawing.Size(180, 22);
            this.cadastrousuarios.Text = "Usuários";
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
            this.pictureBox1.Image = global::TapecariaSystem.Properties.Resources.sofa1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 399);
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
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
    }
}

