namespace OS.Cadastro
{
    partial class FuncionarioLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioLista));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNovoAdm = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNovoCms = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.gcFuncionario = new DevExpress.XtraGrid.GridControl();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvFuncionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNovoAdm,
            this.bbiEditar,
            this.bbiExcluir,
            this.bbiNovoCms});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(821, 94);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiNovoAdm
            // 
            this.bbiNovoAdm.Caption = "Novo Adm";
            this.bbiNovoAdm.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNovoAdm.Glyph")));
            this.bbiNovoAdm.Id = 1;
            this.bbiNovoAdm.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNovoAdm.LargeGlyph")));
            this.bbiNovoAdm.Name = "bbiNovoAdm";
            this.bbiNovoAdm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNovoAdm_ItemClick);
            // 
            // bbiEditar
            // 
            this.bbiEditar.Caption = "Editar";
            this.bbiEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEditar.Glyph")));
            this.bbiEditar.Id = 2;
            this.bbiEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEditar.LargeGlyph")));
            this.bbiEditar.Name = "bbiEditar";
            this.bbiEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditar_ItemClick);
            // 
            // bbiExcluir
            // 
            this.bbiExcluir.Caption = "Excluir";
            this.bbiExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.Glyph")));
            this.bbiExcluir.Id = 3;
            this.bbiExcluir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExcluir.LargeGlyph")));
            this.bbiExcluir.Name = "bbiExcluir";
            this.bbiExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExcluir_ItemClick);
            // 
            // bbiNovoCms
            // 
            this.bbiNovoCms.Caption = "Novo CMS";
            this.bbiNovoCms.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNovoCms.Glyph")));
            this.bbiNovoCms.Id = 4;
            this.bbiNovoCms.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNovoCms.LargeGlyph")));
            this.bbiNovoCms.Name = "bbiNovoCms";
            this.bbiNovoCms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNovoCms_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovoAdm);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovoCms);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditar, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiExcluir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Opções";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 94);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(140, 363);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 80;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(140, 247);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // gcFuncionario
            // 
            this.gcFuncionario.DataSource = this.funcionarioBindingSource;
            this.gcFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFuncionario.Location = new System.Drawing.Point(140, 94);
            this.gcFuncionario.MainView = this.gvFuncionario;
            this.gcFuncionario.MenuManager = this.ribbonControl1;
            this.gcFuncionario.Name = "gcFuncionario";
            this.gcFuncionario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcFuncionario.Size = new System.Drawing.Size(681, 363);
            this.gcFuncionario.TabIndex = 3;
            this.gcFuncionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFuncionario});
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(OS.Funcionario);
            // 
            // gvFuncionario
            // 
            this.gvFuncionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNome,
            this.colCPF});
            this.gvFuncionario.GridControl = this.gcFuncionario;
            this.gvFuncionario.Name = "gvFuncionario";
            this.gvFuncionario.OptionsBehavior.Editable = false;
            this.gvFuncionario.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvFuncionario.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFuncionario.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 74;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 371;
            // 
            // colCPF
            // 
            this.colCPF.ColumnEdit = this.repositoryItemTextEdit1;
            this.colCPF.FieldName = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.Visible = true;
            this.colCPF.VisibleIndex = 2;
            this.colCPF.Width = 215;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "000.000.000-00";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.repositoryItemTextEdit1.Mask.SaveLiteral = false;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // FuncionarioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 457);
            this.Controls.Add(this.gcFuncionario);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FuncionarioLista";
            this.Text = "Gestao de Funcionarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiNovoAdm;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiExcluir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraGrid.GridControl gcFuncionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFuncionario;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colCPF;
        private DevExpress.XtraBars.BarButtonItem bbiNovoCms;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}