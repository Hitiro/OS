namespace OS.Cadastro
{
    partial class OrdemServicoItemDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemServicoItemDetalhe));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFechar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.PrecoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ordemServicoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QtdeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ObservacaoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.MercadoriaIDTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMercadoriaID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQtde = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForObservacao = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPreco = new DevExpress.XtraLayout.LayoutControlItem();
            this.mercadoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEhServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtde = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtdeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacaoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercadoriaIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMercadoriaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
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
            this.ribbonControl1.Size = new System.Drawing.Size(653, 116);
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
            this.dataLayoutControl1.Controls.Add(this.PrecoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QtdeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ObservacaoMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.MercadoriaIDTextEdit);
            this.dataLayoutControl1.DataSource = this.ordemServicoItemBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 116);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(653, 208);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // PrecoTextEdit
            // 
            this.PrecoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordemServicoItemBindingSource, "Preco", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PrecoTextEdit.Enabled = false;
            this.PrecoTextEdit.Location = new System.Drawing.Point(398, 36);
            this.PrecoTextEdit.MenuManager = this.ribbonControl1;
            this.PrecoTextEdit.Name = "PrecoTextEdit";
            this.PrecoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PrecoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrecoTextEdit.Properties.Mask.EditMask = "G";
            this.PrecoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PrecoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PrecoTextEdit.Size = new System.Drawing.Size(243, 20);
            this.PrecoTextEdit.StyleController = this.dataLayoutControl1;
            this.PrecoTextEdit.TabIndex = 5;
            // 
            // ordemServicoItemBindingSource
            // 
            this.ordemServicoItemBindingSource.DataSource = typeof(OS.OrdemServicoItem);
            // 
            // QtdeTextEdit
            // 
            this.QtdeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordemServicoItemBindingSource, "Qtde", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QtdeTextEdit.Location = new System.Drawing.Point(82, 36);
            this.QtdeTextEdit.MenuManager = this.ribbonControl1;
            this.QtdeTextEdit.Name = "QtdeTextEdit";
            this.QtdeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtdeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtdeTextEdit.Properties.Mask.EditMask = "G";
            this.QtdeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QtdeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QtdeTextEdit.Size = new System.Drawing.Size(242, 20);
            this.QtdeTextEdit.StyleController = this.dataLayoutControl1;
            this.QtdeTextEdit.TabIndex = 6;
            // 
            // ObservacaoMemoEdit
            // 
            this.ObservacaoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordemServicoItemBindingSource, "Observacao", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ObservacaoMemoEdit.Location = new System.Drawing.Point(82, 60);
            this.ObservacaoMemoEdit.MenuManager = this.ribbonControl1;
            this.ObservacaoMemoEdit.Name = "ObservacaoMemoEdit";
            this.ObservacaoMemoEdit.Size = new System.Drawing.Size(559, 136);
            this.ObservacaoMemoEdit.StyleController = this.dataLayoutControl1;
            this.ObservacaoMemoEdit.TabIndex = 7;
            // 
            // MercadoriaIDTextEdit
            // 
            this.MercadoriaIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordemServicoItemBindingSource, "MercadoriaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MercadoriaIDTextEdit.Location = new System.Drawing.Point(82, 12);
            this.MercadoriaIDTextEdit.MenuManager = this.ribbonControl1;
            this.MercadoriaIDTextEdit.Name = "MercadoriaIDTextEdit";
            this.MercadoriaIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MercadoriaIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MercadoriaIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MercadoriaIDTextEdit.Properties.DataSource = this.mercadoriaBindingSource;
            this.MercadoriaIDTextEdit.Properties.DisplayMember = "Nome";
            this.MercadoriaIDTextEdit.Properties.NullText = "";
            this.MercadoriaIDTextEdit.Properties.ValueMember = "ID";
            this.MercadoriaIDTextEdit.Properties.View = this.searchLookUpEdit1View;
            this.MercadoriaIDTextEdit.Size = new System.Drawing.Size(559, 20);
            this.MercadoriaIDTextEdit.StyleController = this.dataLayoutControl1;
            this.MercadoriaIDTextEdit.TabIndex = 4;
            this.MercadoriaIDTextEdit.EditValueChanged += new System.EventHandler(this.MercadoriaIDTextEdit_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEhServico,
            this.colNome,
            this.colPreco,
            this.colQtde});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(653, 208);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMercadoriaID,
            this.ItemForQtde,
            this.ItemForObservacao,
            this.ItemForPreco});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(633, 188);
            // 
            // ItemForMercadoriaID
            // 
            this.ItemForMercadoriaID.Control = this.MercadoriaIDTextEdit;
            this.ItemForMercadoriaID.Location = new System.Drawing.Point(0, 0);
            this.ItemForMercadoriaID.Name = "ItemForMercadoriaID";
            this.ItemForMercadoriaID.Size = new System.Drawing.Size(633, 24);
            this.ItemForMercadoriaID.Text = "Mercadoria ID";
            this.ItemForMercadoriaID.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForQtde
            // 
            this.ItemForQtde.Control = this.QtdeTextEdit;
            this.ItemForQtde.Location = new System.Drawing.Point(0, 24);
            this.ItemForQtde.Name = "ItemForQtde";
            this.ItemForQtde.Size = new System.Drawing.Size(316, 24);
            this.ItemForQtde.Text = "Qtde";
            this.ItemForQtde.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForObservacao
            // 
            this.ItemForObservacao.Control = this.ObservacaoMemoEdit;
            this.ItemForObservacao.Location = new System.Drawing.Point(0, 48);
            this.ItemForObservacao.Name = "ItemForObservacao";
            this.ItemForObservacao.Size = new System.Drawing.Size(633, 140);
            this.ItemForObservacao.StartNewLine = true;
            this.ItemForObservacao.Text = "Observacao";
            this.ItemForObservacao.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForPreco
            // 
            this.ItemForPreco.Control = this.PrecoTextEdit;
            this.ItemForPreco.Location = new System.Drawing.Point(316, 24);
            this.ItemForPreco.Name = "ItemForPreco";
            this.ItemForPreco.Size = new System.Drawing.Size(317, 24);
            this.ItemForPreco.Text = "Preco";
            this.ItemForPreco.TextSize = new System.Drawing.Size(67, 13);
            // 
            // mercadoriaBindingSource
            // 
            this.mercadoriaBindingSource.DataSource = typeof(OS.Mercadoria);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colEhServico
            // 
            this.colEhServico.FieldName = "EhServico";
            this.colEhServico.Name = "colEhServico";
            this.colEhServico.Visible = true;
            this.colEhServico.VisibleIndex = 1;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 2;
            // 
            // colPreco
            // 
            this.colPreco.FieldName = "Preco";
            this.colPreco.Name = "colPreco";
            this.colPreco.Visible = true;
            this.colPreco.VisibleIndex = 3;
            // 
            // colQtde
            // 
            this.colQtde.FieldName = "Qtde";
            this.colQtde.Name = "colQtde";
            this.colQtde.Visible = true;
            this.colQtde.VisibleIndex = 4;
            // 
            // OrdemServicoItemDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdemServicoItemDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Item";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrecoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtdeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacaoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercadoriaIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMercadoriaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiSalvar;
        private DevExpress.XtraBars.BarButtonItem bbiFechar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit PrecoTextEdit;
        private System.Windows.Forms.BindingSource ordemServicoItemBindingSource;
        private DevExpress.XtraEditors.TextEdit QtdeTextEdit;
        private DevExpress.XtraEditors.MemoEdit ObservacaoMemoEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit MercadoriaIDTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMercadoriaID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQtde;
        private DevExpress.XtraLayout.LayoutControlItem ItemForObservacao;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPreco;
        private System.Windows.Forms.BindingSource mercadoriaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEhServico;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colPreco;
        private DevExpress.XtraGrid.Columns.GridColumn colQtde;
    }
}