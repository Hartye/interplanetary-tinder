
namespace tinder_interplanetario
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jorge Carvalho",
            "Terra",
            "M",
            "F"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Silver, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Antónia Manela",
            "Mercúrio",
            "F",
            "M, F"}, 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.cmb_planeta = new System.Windows.Forms.ComboBox();
            this.gpb_genero = new System.Windows.Forms.GroupBox();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.gpb_procura = new System.Windows.Forms.GroupBox();
            this.ckb_feminino = new System.Windows.Forms.CheckBox();
            this.ckb_masculino = new System.Windows.Forms.CheckBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_masculinos = new System.Windows.Forms.Label();
            this.lbl_femininos = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.ltv_list = new System.Windows.Forms.ListView();
            this.clh_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_planeta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_procura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.igl_icon = new System.Windows.Forms.ImageList(this.components);
            this.cms_escolha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_large = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_list = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_details = new System.Windows.Forms.ToolStripMenuItem();
            this.gpb_genero.SuspendLayout();
            this.gpb_procura.SuspendLayout();
            this.cms_escolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(13, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(12, 29);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(220, 20);
            this.txb_nome.TabIndex = 1;
            this.txb_nome.TextChanged += new System.EventHandler(this.txb_nome_TextChanged);
            this.txb_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nome_KeyPress);
            // 
            // cmb_planeta
            // 
            this.cmb_planeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_planeta.FormattingEnabled = true;
            this.cmb_planeta.Items.AddRange(new object[] {
            "Terra",
            "Marte",
            "Vênus",
            "Mercúrio",
            "Júpiter",
            "Plutão"});
            this.cmb_planeta.Location = new System.Drawing.Point(250, 29);
            this.cmb_planeta.Name = "cmb_planeta";
            this.cmb_planeta.Size = new System.Drawing.Size(135, 21);
            this.cmb_planeta.TabIndex = 2;
            // 
            // gpb_genero
            // 
            this.gpb_genero.Controls.Add(this.rdb_feminino);
            this.gpb_genero.Controls.Add(this.rdb_masculino);
            this.gpb_genero.Location = new System.Drawing.Point(12, 69);
            this.gpb_genero.Name = "gpb_genero";
            this.gpb_genero.Size = new System.Drawing.Size(97, 82);
            this.gpb_genero.TabIndex = 3;
            this.gpb_genero.TabStop = false;
            this.gpb_genero.Text = "Género";
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(6, 42);
            this.rdb_feminino.Name = "rdb_feminino";
            this.rdb_feminino.Size = new System.Drawing.Size(67, 17);
            this.rdb_feminino.TabIndex = 1;
            this.rdb_feminino.TabStop = true;
            this.rdb_feminino.Text = "Feminino";
            this.rdb_feminino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(6, 19);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_masculino.TabIndex = 0;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_procura
            // 
            this.gpb_procura.Controls.Add(this.ckb_feminino);
            this.gpb_procura.Controls.Add(this.ckb_masculino);
            this.gpb_procura.Location = new System.Drawing.Point(135, 69);
            this.gpb_procura.Name = "gpb_procura";
            this.gpb_procura.Size = new System.Drawing.Size(97, 82);
            this.gpb_procura.TabIndex = 4;
            this.gpb_procura.TabStop = false;
            this.gpb_procura.Text = "Género";
            // 
            // ckb_feminino
            // 
            this.ckb_feminino.AutoSize = true;
            this.ckb_feminino.Location = new System.Drawing.Point(6, 42);
            this.ckb_feminino.Name = "ckb_feminino";
            this.ckb_feminino.Size = new System.Drawing.Size(68, 17);
            this.ckb_feminino.TabIndex = 1;
            this.ckb_feminino.Text = "Feminino";
            this.ckb_feminino.UseVisualStyleBackColor = true;
            // 
            // ckb_masculino
            // 
            this.ckb_masculino.AutoSize = true;
            this.ckb_masculino.Location = new System.Drawing.Point(6, 20);
            this.ckb_masculino.Name = "ckb_masculino";
            this.ckb_masculino.Size = new System.Drawing.Size(74, 17);
            this.ckb_masculino.TabIndex = 0;
            this.ckb_masculino.Text = "Masculino";
            this.ckb_masculino.UseVisualStyleBackColor = true;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Enabled = false;
            this.btn_inserir.Location = new System.Drawing.Point(250, 89);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(135, 23);
            this.btn_inserir.TabIndex = 5;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(250, 128);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 23);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_masculinos
            // 
            this.lbl_masculinos.AutoSize = true;
            this.lbl_masculinos.Location = new System.Drawing.Point(13, 178);
            this.lbl_masculinos.Name = "lbl_masculinos";
            this.lbl_masculinos.Size = new System.Drawing.Size(12, 13);
            this.lbl_masculinos.TabIndex = 7;
            this.lbl_masculinos.Text = "x";
            // 
            // lbl_femininos
            // 
            this.lbl_femininos.AutoSize = true;
            this.lbl_femininos.Location = new System.Drawing.Point(97, 178);
            this.lbl_femininos.Name = "lbl_femininos";
            this.lbl_femininos.Size = new System.Drawing.Size(12, 13);
            this.lbl_femininos.TabIndex = 8;
            this.lbl_femininos.Text = "y";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(250, 398);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(135, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ltv_list
            // 
            this.ltv_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_nome,
            this.clh_planeta,
            this.clh_genero,
            this.clh_procura});
            this.ltv_list.ContextMenuStrip = this.cms_escolha;
            this.ltv_list.FullRowSelect = true;
            this.ltv_list.HideSelection = false;
            this.ltv_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ltv_list.LargeImageList = this.igl_icon;
            this.ltv_list.Location = new System.Drawing.Point(12, 204);
            this.ltv_list.Margin = new System.Windows.Forms.Padding(175, 65, 50, 50);
            this.ltv_list.Name = "ltv_list";
            this.ltv_list.Size = new System.Drawing.Size(373, 188);
            this.ltv_list.SmallImageList = this.igl_icon;
            this.ltv_list.TabIndex = 10;
            this.ltv_list.UseCompatibleStateImageBehavior = false;
            this.ltv_list.View = System.Windows.Forms.View.Details;
            // 
            // clh_nome
            // 
            this.clh_nome.Text = "Nome";
            this.clh_nome.Width = 160;
            // 
            // clh_planeta
            // 
            this.clh_planeta.Text = "Planeta";
            // 
            // clh_genero
            // 
            this.clh_genero.Text = "Gênero";
            this.clh_genero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clh_procura
            // 
            this.clh_procura.Text = "Procura";
            this.clh_procura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // igl_icon
            // 
            this.igl_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("igl_icon.ImageStream")));
            this.igl_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.igl_icon.Images.SetKeyName(0, "mars.png");
            this.igl_icon.Images.SetKeyName(1, "femenine.png");
            // 
            // cms_escolha
            // 
            this.cms_escolha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_large,
            this.tsmi_list,
            this.tsmi_details});
            this.cms_escolha.Name = "cms_escolha";
            this.cms_escolha.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmi_large
            // 
            this.tsmi_large.Name = "tsmi_large";
            this.tsmi_large.Size = new System.Drawing.Size(180, 22);
            this.tsmi_large.Text = "Large";
            this.tsmi_large.ToolTipText = "Icons 32x32";
            this.tsmi_large.Click += new System.EventHandler(this.tsmi_large_Click);
            // 
            // tsmi_list
            // 
            this.tsmi_list.Name = "tsmi_list";
            this.tsmi_list.Size = new System.Drawing.Size(180, 22);
            this.tsmi_list.Text = "List";
            this.tsmi_list.ToolTipText = "Icons 16x16 em lista";
            this.tsmi_list.Click += new System.EventHandler(this.tsmi_list_Click);
            // 
            // tsmi_details
            // 
            this.tsmi_details.Name = "tsmi_details";
            this.tsmi_details.Size = new System.Drawing.Size(180, 22);
            this.tsmi_details.Text = "Details";
            this.tsmi_details.ToolTipText = "Icons 16x16 details";
            this.tsmi_details.Click += new System.EventHandler(this.tsmi_details_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 433);
            this.Controls.Add(this.ltv_list);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_femininos);
            this.Controls.Add(this.lbl_masculinos);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.gpb_procura);
            this.Controls.Add(this.gpb_genero);
            this.Controls.Add(this.cmb_planeta);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Agência Interplanetária de Encontros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_genero.ResumeLayout(false);
            this.gpb_genero.PerformLayout();
            this.gpb_procura.ResumeLayout(false);
            this.gpb_procura.PerformLayout();
            this.cms_escolha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.ComboBox cmb_planeta;
        private System.Windows.Forms.GroupBox gpb_genero;
        private System.Windows.Forms.RadioButton rdb_feminino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.GroupBox gpb_procura;
        private System.Windows.Forms.CheckBox ckb_feminino;
        private System.Windows.Forms.CheckBox ckb_masculino;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_masculinos;
        private System.Windows.Forms.Label lbl_femininos;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ListView ltv_list;
        private System.Windows.Forms.ColumnHeader clh_nome;
        private System.Windows.Forms.ColumnHeader clh_planeta;
        private System.Windows.Forms.ColumnHeader clh_genero;
        private System.Windows.Forms.ColumnHeader clh_procura;
        private System.Windows.Forms.ImageList igl_icon;
        private System.Windows.Forms.ContextMenuStrip cms_escolha;
        private System.Windows.Forms.ToolStripMenuItem tsmi_large;
        private System.Windows.Forms.ToolStripMenuItem tsmi_list;
        private System.Windows.Forms.ToolStripMenuItem tsmi_details;
    }
}

