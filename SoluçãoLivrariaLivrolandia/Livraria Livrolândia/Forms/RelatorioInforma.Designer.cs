
namespace Livraria_Livrolândia.Forms
{
    partial class RelatorioInforma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioInforma));
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.cATEGORIASLIVROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book = new Livraria_Livrolândia.Dados.Book();
            this.button1 = new System.Windows.Forms.Button();
            this.cATEGORIAS_LIVROSTableAdapter = new Livraria_Livrolândia.Dados.BookTableAdapters.CATEGORIAS_LIVROSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASLIVROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(216, 60);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Location = new System.Drawing.Point(217, 31);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar Por Categoria";
            // 
            // cmbNome
            // 
            this.cmbNome.DataSource = this.cATEGORIASLIVROSBindingSource;
            this.cmbNome.DisplayMember = "CATEGORIA";
            this.cmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(15, 77);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(161, 21);
            this.cmbNome.TabIndex = 5;
            this.cmbNome.ValueMember = "CATEGORIA";
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // cATEGORIASLIVROSBindingSource
            // 
            this.cATEGORIASLIVROSBindingSource.DataMember = "CATEGORIAS_LIVROS";
            this.cATEGORIASLIVROSBindingSource.DataSource = this.book;
            // 
            // book
            // 
            this.book.DataSetName = "Book";
            this.book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cATEGORIAS_LIVROSTableAdapter
            // 
            this.cATEGORIAS_LIVROSTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioInforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioInforma";
            this.Text = "Relatorio Informa";
            this.Load += new System.EventHandler(this.RelatorioInforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASLIVROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Button button1;
        private Dados.Book book;
        private System.Windows.Forms.BindingSource cATEGORIASLIVROSBindingSource;
        private Dados.BookTableAdapters.CATEGORIAS_LIVROSTableAdapter cATEGORIAS_LIVROSTableAdapter;
    }
}