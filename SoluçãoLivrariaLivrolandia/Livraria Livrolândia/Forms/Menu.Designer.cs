namespace Livraria_Livrolândia.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioComFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioInformaFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioAgrupadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarLivroToolStripMenuItem
            // 
            this.cadastrarLivroToolStripMenuItem.Name = "cadastrarLivroToolStripMenuItem";
            this.cadastrarLivroToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cadastrarLivroToolStripMenuItem.Text = "Cadastrar Livro";
            this.cadastrarLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLivroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCadastroToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultarCadastroToolStripMenuItem
            // 
            this.consultarCadastroToolStripMenuItem.Name = "consultarCadastroToolStripMenuItem";
            this.consultarCadastroToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarCadastroToolStripMenuItem.Text = "Consultar Cadastro";
            this.consultarCadastroToolStripMenuItem.Click += new System.EventHandler(this.ConsultarCadastroToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatóriosToolStripMenuItem,
            this.relatórioComFiltrosToolStripMenuItem,
            this.relatórioInformaFiltroToolStripMenuItem,
            this.relatórioAgrupadoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // gerarRelatóriosToolStripMenuItem
            // 
            this.gerarRelatóriosToolStripMenuItem.Name = "gerarRelatóriosToolStripMenuItem";
            this.gerarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gerarRelatóriosToolStripMenuItem.Text = "Gerar Relatório Geral";
            this.gerarRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.GerarRelatóriosToolStripMenuItem_Click_1);
            // 
            // relatórioComFiltrosToolStripMenuItem
            // 
            this.relatórioComFiltrosToolStripMenuItem.Name = "relatórioComFiltrosToolStripMenuItem";
            this.relatórioComFiltrosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioComFiltrosToolStripMenuItem.Text = "Relatório com Filtros";
            this.relatórioComFiltrosToolStripMenuItem.Click += new System.EventHandler(this.RelatórioComFiltrosToolStripMenuItem_Click);
            // 
            // relatórioInformaFiltroToolStripMenuItem
            // 
            this.relatórioInformaFiltroToolStripMenuItem.Name = "relatórioInformaFiltroToolStripMenuItem";
            this.relatórioInformaFiltroToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioInformaFiltroToolStripMenuItem.Text = "Relatório informa Filtro";
            this.relatórioInformaFiltroToolStripMenuItem.Click += new System.EventHandler(this.relatórioInformaFiltroToolStripMenuItem_Click);
            // 
            // relatórioAgrupadoToolStripMenuItem
            // 
            this.relatórioAgrupadoToolStripMenuItem.Name = "relatórioAgrupadoToolStripMenuItem";
            this.relatórioAgrupadoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioAgrupadoToolStripMenuItem.Text = "Relatório Agrupado";
            this.relatórioAgrupadoToolStripMenuItem.Click += new System.EventHandler(this.relatórioAgrupadoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1128, 609);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioComFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioInformaFiltroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioAgrupadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

