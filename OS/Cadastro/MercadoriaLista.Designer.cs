namespace OS.Cadastro
{
    partial class MercadoriaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MercadoriaLista));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNovo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcMercadoria = new DevExpress.XtraGrid.GridControl();
            this.mercadoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMercadoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEhServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMercadoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMercadoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNovo,
            this.bbiEditar,
            this.bbiExcluir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1039, 115);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiNovo
            // 
            this.bbiNovo.Caption = "&Novo";
            this.bbiNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNovo.Glyph")));
            this.bbiNovo.Id = 1;
            this.bbiNovo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNovo.LargeGlyph")));
            this.bbiNovo.Name = "bbiNovo";
            this.bbiNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNovo_ItemClick);
            // 
            // bbiEditar
            // 
            this.bbiEditar.Caption = "&Editar";
            this.bbiEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEditar.Glyph")));
            this.bbiEditar.Id = 2;
            this.bbiEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEditar.LargeGlyph")));
            this.bbiEditar.Name = "bbiEditar";
            this.bbiEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditar_ItemClick);
            // 
            // bbiExcluir
            // 
            this.bbiExcluir.Caption = "&Excluir";
            this.bbiExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.Glyph")));
            this.bbiExcluir.Id = 3;
            this.bbiExcluir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.LargeGlyph")));
            this.bbiExcluir.Name = "bbiExcluir";
            this.bbiExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExcluir_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiExcluir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ações";
            // 
            // gcMercadoria
            // 
            this.gcMercadoria.DataSource = this.mercadoriaBindingSource;
            this.gcMercadoria.Location = new System.Drawing.Point(500, 180);
            this.gcMercadoria.MainView = this.gvMercadoria;
            this.gcMercadoria.MenuManager = this.ribbonControl1;
            this.gcMercadoria.Name = "gcMercadoria";
            this.gcMercadoria.Size = new System.Drawing.Size(418, 195);
            this.gcMercadoria.TabIndex = 2;
            this.gcMercadoria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMercadoria});
            // 
            // mercadoriaBindingSource
            // 
            this.mercadoriaBindingSource.DataSource = typeof(OS.Mercadoria);
            // 
            // gvMercadoria
            // 
            this.gvMercadoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEhServico,
            this.colNome,
            this.colPreco,
            this.colQtde});
            this.gvMercadoria.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvMercadoria.GridControl = this.gcMercadoria;
            this.gvMercadoria.Name = "gvMercadoria";
            this.gvMercadoria.OptionsBehavior.Editable = false;
            this.gvMercadoria.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMercadoria.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMercadoria.OptionsView.ShowGroupPanel = false;
            this.gvMercadoria.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNome, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsFilter.AllowFilter = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 71;
            // 
            // colEhServico
            // 
            this.colEhServico.Caption = "Serviço ?";
            this.colEhServico.FieldName = "EhServico";
            this.colEhServico.Name = "colEhServico";
            this.colEhServico.Visible = true;
            this.colEhServico.VisibleIndex = 2;
            this.colEhServico.Width = 63;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 681;
            // 
            // colPreco
            // 
            this.colPreco.Caption = "Preço";
            this.colPreco.FieldName = "Preco";
            this.colPreco.Name = "colPreco";
            this.colPreco.Visible = true;
            this.colPreco.VisibleIndex = 3;
            this.colPreco.Width = 90;
            // 
            // colQtde
            // 
            this.colQtde.Caption = "Qtde";
            this.colQtde.FieldName = "Qtde";
            this.colQtde.Name = "colQtde";
            this.colQtde.Visible = true;
            this.colQtde.VisibleIndex = 4;
            this.colQtde.Width = 116;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MercadoriaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 451);
            this.Controls.Add(this.gcMercadoria);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MercadoriaLista";
            this.Text = "Gestao de Mercadoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMercadoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMercadoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gcMercadoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMercadoria;
        private DevExpress.XtraBars.BarButtonItem bbiNovo;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiExcluir;
        private System.Windows.Forms.BindingSource mercadoriaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEhServico;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colPreco;
        private DevExpress.XtraGrid.Columns.GridColumn colQtde;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}