namespace OS.Cadastro
{
    partial class OrdemServicoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemServicoLista));
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNovo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReabrir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFinalizar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPreview = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.icbSituacao = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcItens = new DevExpress.XtraGrid.GridControl();
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvItens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtAbertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControl
            // 
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.bbiNovo,
            this.bbiEditar,
            this.bbiExcluir,
            this.bbiReabrir,
            this.bbiFinalizar,
            this.bbiCancelar,
            this.bbiPreview});
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 10;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.RibbonControl.Size = new System.Drawing.Size(971, 141);
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
            this.bbiExcluir.Caption = "E&xcluir";
            this.bbiExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.Glyph")));
            this.bbiExcluir.Id = 3;
            this.bbiExcluir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.LargeGlyph")));
            this.bbiExcluir.Name = "bbiExcluir";
            this.bbiExcluir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbiExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExcluir_ItemClick);
            // 
            // bbiReabrir
            // 
            this.bbiReabrir.Caption = "Reabrir";
            this.bbiReabrir.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiReabrir.Glyph")));
            this.bbiReabrir.Id = 5;
            this.bbiReabrir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiReabrir.LargeGlyph")));
            this.bbiReabrir.Name = "bbiReabrir";
            this.bbiReabrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReabrir_ItemClick);
            // 
            // bbiFinalizar
            // 
            this.bbiFinalizar.Caption = "Finalizar";
            this.bbiFinalizar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFinalizar.Glyph")));
            this.bbiFinalizar.Id = 7;
            this.bbiFinalizar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFinalizar.LargeGlyph")));
            this.bbiFinalizar.Name = "bbiFinalizar";
            this.bbiFinalizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFinalizar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.Glyph")));
            this.bbiCancelar.Id = 8;
            this.bbiCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.LargeGlyph")));
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiPreview
            // 
            this.bbiPreview.Caption = "Visualizar OS";
            this.bbiPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPreview.Glyph")));
            this.bbiPreview.Id = 9;
            this.bbiPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPreview.LargeGlyph")));
            this.bbiPreview.Name = "bbiPreview";
            this.bbiPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPreview_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Principal";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiExcluir, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ações";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiFinalizar);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiReabrir, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Controle";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Relatórios";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiPreview);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Basico";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 141);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 247;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(247, 343);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Filtro(s)";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 240;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.layoutControl1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(247, 240);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAplicar);
            this.layoutControl1.Controls.Add(this.icbSituacao);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(247, 240);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.Location = new System.Drawing.Point(12, 36);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(223, 22);
            this.btnAplicar.StyleController = this.layoutControl1;
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "&Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // icbSituacao
            // 
            this.icbSituacao.EditValue = "A";
            this.icbSituacao.Location = new System.Drawing.Point(56, 12);
            this.icbSituacao.MenuManager = this.RibbonControl;
            this.icbSituacao.Name = "icbSituacao";
            this.icbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSituacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Todos", "T", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Abertas", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fechadas", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Canceladas", "C", -1)});
            this.icbSituacao.Size = new System.Drawing.Size(179, 20);
            this.icbSituacao.StyleController = this.layoutControl1;
            this.icbSituacao.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(247, 240);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.icbSituacao;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem1.Text = "Situação";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAplicar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 196);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gcItens
            // 
            this.gcItens.DataSource = this.ordemServicoBindingSource;
            this.gcItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItens.Location = new System.Drawing.Point(247, 141);
            this.gcItens.MainView = this.gvItens;
            this.gcItens.MenuManager = this.RibbonControl;
            this.gcItens.Name = "gcItens";
            this.gcItens.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemImageComboBox1});
            this.gcItens.Size = new System.Drawing.Size(724, 343);
            this.gcItens.TabIndex = 2;
            this.gcItens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItens});
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(OS.OrdemServico);
            this.ordemServicoBindingSource.CurrentChanged += new System.EventHandler(this.ordemServicoBindingSource_CurrentChanged);
            // 
            // gvItens
            // 
            this.gvItens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDtAbertura,
            this.colDtFechamento,
            this.colObservacao,
            this.colSituacao,
            this.colCliente});
            this.gvItens.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvItens.GridControl = this.gcItens;
            this.gvItens.Name = "gvItens";
            this.gvItens.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvItens.OptionsView.EnableAppearanceEvenRow = true;
            this.gvItens.OptionsView.ShowGroupPanel = false;
            this.gvItens.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDtAbertura, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 58;
            // 
            // colDtAbertura
            // 
            this.colDtAbertura.DisplayFormat.FormatString = "G";
            this.colDtAbertura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDtAbertura.FieldName = "DtAbertura";
            this.colDtAbertura.Name = "colDtAbertura";
            this.colDtAbertura.OptionsColumn.ReadOnly = true;
            this.colDtAbertura.Visible = true;
            this.colDtAbertura.VisibleIndex = 2;
            this.colDtAbertura.Width = 128;
            // 
            // colDtFechamento
            // 
            this.colDtFechamento.DisplayFormat.FormatString = "G";
            this.colDtFechamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDtFechamento.FieldName = "DtFechamento";
            this.colDtFechamento.Name = "colDtFechamento";
            this.colDtFechamento.OptionsColumn.ReadOnly = true;
            this.colDtFechamento.Visible = true;
            this.colDtFechamento.VisibleIndex = 3;
            this.colDtFechamento.Width = 147;
            // 
            // colObservacao
            // 
            this.colObservacao.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.OptionsColumn.ReadOnly = true;
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 5;
            this.colObservacao.Width = 69;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colSituacao
            // 
            this.colSituacao.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.OptionsColumn.AllowFocus = false;
            this.colSituacao.OptionsColumn.ReadOnly = true;
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 4;
            this.colSituacao.Width = 139;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aberto", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fechado", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cancelado", "C", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente.Nome";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.ReadOnly = true;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            this.colCliente.Width = 165;
            // 
            // OrdemServicoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 484);
            this.Controls.Add(this.gcItens);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.RibbonControl);
            this.Name = "OrdemServicoLista";
            this.Text = "Gestão de Ordens de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiNovo;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiExcluir;
        private DevExpress.XtraBars.BarButtonItem bbiReabrir;
        private DevExpress.XtraBars.BarButtonItem bbiFinalizar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcItens;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItens;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbSituacao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDtAbertura;
        private DevExpress.XtraGrid.Columns.GridColumn colDtFechamento;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraBars.BarButtonItem bbiPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}