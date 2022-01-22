namespace OS.Cadastro
{
    partial class MercadoriaDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MercadoriaDetalhe));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFechar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lukFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mercadoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EhServicoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PrecoCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.QtdeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RepresentanteIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.representanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPreco = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEhServico = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQtde = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForRepresentanteID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lukFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EhServicoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecoCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtdeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentanteIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEhServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRepresentanteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowDrop = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSalvar,
            this.bbiFechar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(730, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSalvar
            // 
            this.bbiSalvar.Caption = "&Salvar";
            this.bbiSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSalvar.Glyph")));
            this.bbiSalvar.Id = 1;
            this.bbiSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSalvar.LargeGlyph")));
            this.bbiSalvar.Name = "bbiSalvar";
            this.bbiSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalvar_ItemClick);
            // 
            // bbiFechar
            // 
            this.bbiFechar.Caption = "&Fechar";
            this.bbiFechar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFechar.Glyph")));
            this.bbiFechar.Id = 2;
            this.bbiFechar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFechar.LargeGlyph")));
            this.bbiFechar.Name = "bbiFechar";
            this.bbiFechar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFechar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Principal";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalvar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiFechar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ações";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.lukFornecedor);
            this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EhServicoCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NomeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PrecoCalcEdit);
            this.dataLayoutControl1.Controls.Add(this.QtdeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RepresentanteIDLookUpEdit);
            this.dataLayoutControl1.DataSource = this.mercadoriaBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 95);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(331, 157, 975, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(730, 287);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // lukFornecedor
            // 
            this.lukFornecedor.Location = new System.Drawing.Point(102, 90);
            this.lukFornecedor.MenuManager = this.ribbonControl1;
            this.lukFornecedor.Name = "lukFornecedor";
            this.lukFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lukFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazaoSocial", "Razao Social", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TelefoneFixo", "Telefone Fixo", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lukFornecedor.Properties.DataSource = this.fornecedorBindingSource;
            this.lukFornecedor.Properties.DisplayMember = "RazaoSocial";
            this.lukFornecedor.Properties.ValueMember = "ID";
            this.lukFornecedor.Size = new System.Drawing.Size(261, 20);
            this.lukFornecedor.StyleController = this.dataLayoutControl1;
            this.lukFornecedor.TabIndex = 10;
            this.lukFornecedor.EditValueChanged += new System.EventHandler(this.lukFornecedor_EditValueChanged);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(OS.Fornecedor);
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IDTextEdit.Location = new System.Drawing.Point(90, 12);
            this.IDTextEdit.MenuManager = this.ribbonControl1;
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IDTextEdit.Properties.Mask.EditMask = "N0";
            this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IDTextEdit.Size = new System.Drawing.Size(159, 20);
            this.IDTextEdit.StyleController = this.dataLayoutControl1;
            this.IDTextEdit.TabIndex = 4;
            // 
            // mercadoriaBindingSource
            // 
            this.mercadoriaBindingSource.DataSource = typeof(OS.Mercadoria);
            this.mercadoriaBindingSource.CurrentItemChanged += new System.EventHandler(this.mercadoriaBindingSource_CurrentItemChanged);
            // 
            // EhServicoCheckEdit
            // 
            this.EhServicoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "EhServico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EhServicoCheckEdit.Location = new System.Drawing.Point(331, 12);
            this.EhServicoCheckEdit.MenuManager = this.ribbonControl1;
            this.EhServicoCheckEdit.Name = "EhServicoCheckEdit";
            this.EhServicoCheckEdit.Properties.Caption = "Eh Servico";
            this.EhServicoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EhServicoCheckEdit.Size = new System.Drawing.Size(32, 19);
            this.EhServicoCheckEdit.StyleController = this.dataLayoutControl1;
            this.EhServicoCheckEdit.TabIndex = 5;
            // 
            // NomeTextEdit
            // 
            this.NomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "Nome", true));
            this.NomeTextEdit.Location = new System.Drawing.Point(445, 12);
            this.NomeTextEdit.MenuManager = this.ribbonControl1;
            this.NomeTextEdit.Name = "NomeTextEdit";
            this.NomeTextEdit.Size = new System.Drawing.Size(273, 20);
            this.NomeTextEdit.StyleController = this.dataLayoutControl1;
            this.NomeTextEdit.TabIndex = 6;
            // 
            // PrecoCalcEdit
            // 
            this.PrecoCalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "Preco", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PrecoCalcEdit.Location = new System.Drawing.Point(90, 36);
            this.PrecoCalcEdit.MenuManager = this.ribbonControl1;
            this.PrecoCalcEdit.Name = "PrecoCalcEdit";
            this.PrecoCalcEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PrecoCalcEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrecoCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PrecoCalcEdit.Properties.Mask.EditMask = "G";
            this.PrecoCalcEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PrecoCalcEdit.Size = new System.Drawing.Size(273, 20);
            this.PrecoCalcEdit.StyleController = this.dataLayoutControl1;
            this.PrecoCalcEdit.TabIndex = 7;
            // 
            // QtdeTextEdit
            // 
            this.QtdeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "Qtde", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QtdeTextEdit.Location = new System.Drawing.Point(445, 36);
            this.QtdeTextEdit.MenuManager = this.ribbonControl1;
            this.QtdeTextEdit.Name = "QtdeTextEdit";
            this.QtdeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.QtdeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtdeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtdeTextEdit.Properties.Mask.EditMask = "N0";
            this.QtdeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QtdeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QtdeTextEdit.Size = new System.Drawing.Size(273, 20);
            this.QtdeTextEdit.StyleController = this.dataLayoutControl1;
            this.QtdeTextEdit.TabIndex = 8;
            // 
            // RepresentanteIDLookUpEdit
            // 
            this.RepresentanteIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mercadoriaBindingSource, "RepresentanteID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RepresentanteIDLookUpEdit.Location = new System.Drawing.Point(445, 90);
            this.RepresentanteIDLookUpEdit.MenuManager = this.ribbonControl1;
            this.RepresentanteIDLookUpEdit.Name = "RepresentanteIDLookUpEdit";
            this.RepresentanteIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RepresentanteIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RepresentanteIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepresentanteIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TelefoneCel", "Telefone Cel", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.RepresentanteIDLookUpEdit.Properties.DataSource = this.representanteBindingSource;
            this.RepresentanteIDLookUpEdit.Properties.DisplayMember = "Nome";
            this.RepresentanteIDLookUpEdit.Properties.NullText = "";
            this.RepresentanteIDLookUpEdit.Properties.ValueMember = "ID";
            this.RepresentanteIDLookUpEdit.Size = new System.Drawing.Size(261, 20);
            this.RepresentanteIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.RepresentanteIDLookUpEdit.TabIndex = 9;
            // 
            // representanteBindingSource
            // 
            this.representanteBindingSource.DataSource = typeof(OS.Representante);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(730, 287);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForPreco,
            this.ItemForEhServico,
            this.ItemForQtde,
            this.emptySpaceItem1,
            this.ItemForNome,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(710, 267);
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.IDTextEdit;
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(241, 24);
            this.ItemForID.Text = "ID";
            this.ItemForID.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForPreco
            // 
            this.ItemForPreco.Control = this.PrecoCalcEdit;
            this.ItemForPreco.Location = new System.Drawing.Point(0, 24);
            this.ItemForPreco.Name = "ItemForPreco";
            this.ItemForPreco.Size = new System.Drawing.Size(355, 24);
            this.ItemForPreco.Text = "Preco";
            this.ItemForPreco.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForEhServico
            // 
            this.ItemForEhServico.Control = this.EhServicoCheckEdit;
            this.ItemForEhServico.Location = new System.Drawing.Point(241, 0);
            this.ItemForEhServico.MaxSize = new System.Drawing.Size(0, 24);
            this.ItemForEhServico.MinSize = new System.Drawing.Size(112, 24);
            this.ItemForEhServico.Name = "ItemForEhServico";
            this.ItemForEhServico.Size = new System.Drawing.Size(114, 24);
            this.ItemForEhServico.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForEhServico.Text = "Serviço";
            this.ItemForEhServico.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForEhServico.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForQtde
            // 
            this.ItemForQtde.Control = this.QtdeTextEdit;
            this.ItemForQtde.Location = new System.Drawing.Point(355, 24);
            this.ItemForQtde.Name = "ItemForQtde";
            this.ItemForQtde.Size = new System.Drawing.Size(355, 24);
            this.ItemForQtde.Text = "Qtde";
            this.ItemForQtde.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(710, 153);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForNome
            // 
            this.ItemForNome.Control = this.NomeTextEdit;
            this.ItemForNome.Location = new System.Drawing.Point(355, 0);
            this.ItemForNome.Name = "ItemForNome";
            this.ItemForNome.Size = new System.Drawing.Size(355, 24);
            this.ItemForNome.Text = "Nome";
            this.ItemForNome.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForRepresentanteID,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(710, 66);
            this.layoutControlGroup3.Text = "Fornecedor";
            // 
            // ItemForRepresentanteID
            // 
            this.ItemForRepresentanteID.Control = this.RepresentanteIDLookUpEdit;
            this.ItemForRepresentanteID.Location = new System.Drawing.Point(343, 0);
            this.ItemForRepresentanteID.Name = "ItemForRepresentanteID";
            this.ItemForRepresentanteID.Size = new System.Drawing.Size(343, 24);
            this.ItemForRepresentanteID.Text = "Representante ";
            this.ItemForRepresentanteID.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lukFornecedor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(343, 24);
            this.layoutControlItem1.Text = "Nome";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // MercadoriaDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 382);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MercadoriaDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhe da Mercadoria";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lukFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EhServicoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecoCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtdeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentanteIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEhServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRepresentanteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private System.Windows.Forms.BindingSource mercadoriaBindingSource;
        private DevExpress.XtraEditors.TextEdit NomeTextEdit;
        private DevExpress.XtraEditors.CalcEdit PrecoCalcEdit;
        private DevExpress.XtraEditors.TextEdit QtdeTextEdit;
        private DevExpress.XtraEditors.LookUpEdit RepresentanteIDLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPreco;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRepresentanteID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQtde;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
        private DevExpress.XtraEditors.CheckEdit EhServicoCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEhServico;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource representanteBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lukFornecedor;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiSalvar;
        private DevExpress.XtraBars.BarButtonItem bbiFechar;
    }
}