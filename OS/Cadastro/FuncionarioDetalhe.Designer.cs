namespace OS.Cadastro
{
    partial class FuncionarioDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioDetalhe));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFechar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.porcentagemSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.funcionarioComissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarioSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.funcionarioAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CPFTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCPF = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layComissionado = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAdministrativo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentagemSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioComissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioAdmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPFTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layComissionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(519, 94);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSalvar
            // 
            this.bbiSalvar.Caption = "Salvar";
            this.bbiSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSalvar.Glyph")));
            this.bbiSalvar.Id = 1;
            this.bbiSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSalvar.LargeGlyph")));
            this.bbiSalvar.Name = "bbiSalvar";
            this.bbiSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalvar_ItemClick);
            // 
            // bbiFechar
            // 
            this.bbiFechar.Caption = "Cancelar";
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
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalvar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiFechar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.porcentagemSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.salarioSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NomeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CPFTextEdit);
            this.dataLayoutControl1.DataSource = this.funcionarioBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 94);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(884, 128, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(519, 167);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // porcentagemSpinEdit
            // 
            this.porcentagemSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioComissaoBindingSource, "Porcentagem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.porcentagemSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.porcentagemSpinEdit.Location = new System.Drawing.Point(94, 96);
            this.porcentagemSpinEdit.MenuManager = this.ribbonControl1;
            this.porcentagemSpinEdit.Name = "porcentagemSpinEdit";
            this.porcentagemSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.porcentagemSpinEdit.Size = new System.Drawing.Size(401, 20);
            this.porcentagemSpinEdit.StyleController = this.dataLayoutControl1;
            this.porcentagemSpinEdit.TabIndex = 9;
            // 
            // funcionarioComissaoBindingSource
            // 
            this.funcionarioComissaoBindingSource.DataSource = typeof(OS.FuncionarioComissao);
            // 
            // salarioSpinEdit
            // 
            this.salarioSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioAdmBindingSource, "Salario", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.salarioSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.salarioSpinEdit.Location = new System.Drawing.Point(94, 96);
            this.salarioSpinEdit.MenuManager = this.ribbonControl1;
            this.salarioSpinEdit.Name = "salarioSpinEdit";
            this.salarioSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.salarioSpinEdit.Size = new System.Drawing.Size(401, 20);
            this.salarioSpinEdit.StyleController = this.dataLayoutControl1;
            this.salarioSpinEdit.TabIndex = 8;
            // 
            // funcionarioAdmBindingSource
            // 
            this.funcionarioAdmBindingSource.DataSource = typeof(OS.FuncionarioAdm);
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IDTextEdit.Enabled = false;
            this.IDTextEdit.Location = new System.Drawing.Point(82, 12);
            this.IDTextEdit.MenuManager = this.ribbonControl1;
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IDTextEdit.Properties.Mask.EditMask = "N0";
            this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IDTextEdit.Size = new System.Drawing.Size(101, 20);
            this.IDTextEdit.StyleController = this.dataLayoutControl1;
            this.IDTextEdit.TabIndex = 4;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(OS.Funcionario);
            // 
            // NomeTextEdit
            // 
            this.NomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NomeTextEdit.Location = new System.Drawing.Point(82, 37);
            this.NomeTextEdit.MenuManager = this.ribbonControl1;
            this.NomeTextEdit.Name = "NomeTextEdit";
            this.NomeTextEdit.Properties.MaxLength = 50;
            this.NomeTextEdit.Size = new System.Drawing.Size(425, 20);
            this.NomeTextEdit.StyleController = this.dataLayoutControl1;
            this.NomeTextEdit.TabIndex = 5;
            // 
            // CPFTextEdit
            // 
            this.CPFTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "CPF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPFTextEdit.Location = new System.Drawing.Point(257, 12);
            this.CPFTextEdit.MenuManager = this.ribbonControl1;
            this.CPFTextEdit.Name = "CPFTextEdit";
            this.CPFTextEdit.Properties.Mask.EditMask = "000.000.000-00";
            this.CPFTextEdit.Properties.Mask.IgnoreMaskBlank = false;
            this.CPFTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.CPFTextEdit.Properties.Mask.SaveLiteral = false;
            this.CPFTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CPFTextEdit.Size = new System.Drawing.Size(250, 20);
            this.CPFTextEdit.StyleController = this.dataLayoutControl1;
            this.CPFTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(519, 167);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForNome,
            this.ItemForCPF,
            this.emptySpaceItem1,
            this.simpleSeparator1,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(499, 147);
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.IDTextEdit;
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(175, 24);
            this.ItemForID.Text = "ID";
            this.ItemForID.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForNome
            // 
            this.ItemForNome.Control = this.NomeTextEdit;
            this.ItemForNome.Location = new System.Drawing.Point(0, 25);
            this.ItemForNome.Name = "ItemForNome";
            this.ItemForNome.Size = new System.Drawing.Size(499, 24);
            this.ItemForNome.Text = "Nome";
            this.ItemForNome.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForCPF
            // 
            this.ItemForCPF.Control = this.CPFTextEdit;
            this.ItemForCPF.Location = new System.Drawing.Point(175, 0);
            this.ItemForCPF.Name = "ItemForCPF";
            this.ItemForCPF.Size = new System.Drawing.Size(324, 24);
            this.ItemForCPF.Text = "CPF";
            this.ItemForCPF.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(499, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(499, 1);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 49);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layComissionado;
            this.tabbedControlGroup1.SelectedTabPageIndex = 1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(499, 71);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layAdministrativo,
            this.layComissionado});
            // 
            // layComissionado
            // 
            this.layComissionado.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layComissionado.Location = new System.Drawing.Point(0, 0);
            this.layComissionado.Name = "layComissionado";
            this.layComissionado.Size = new System.Drawing.Size(475, 24);
            this.layComissionado.Text = "Comissionado";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.porcentagemSpinEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(475, 24);
            this.layoutControlItem2.Text = "Porcentagem:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layAdministrativo
            // 
            this.layAdministrativo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layAdministrativo.Location = new System.Drawing.Point(0, 0);
            this.layAdministrativo.Name = "layAdministrativo";
            this.layAdministrativo.Size = new System.Drawing.Size(475, 24);
            this.layAdministrativo.Text = "Administrativo";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.salarioSpinEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(475, 24);
            this.layoutControlItem1.Text = "Salario:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // FuncionarioDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FuncionarioDetalhe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhe de Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.porcentagemSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioComissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioAdmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPFTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layComissionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAdministrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit salarioSpinEdit;
        private System.Windows.Forms.BindingSource funcionarioAdmBindingSource;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DevExpress.XtraEditors.TextEdit NomeTextEdit;
        private DevExpress.XtraEditors.TextEdit CPFTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCPF;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.SpinEdit porcentagemSpinEdit;
        private System.Windows.Forms.BindingSource funcionarioComissaoBindingSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layComissionado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layAdministrativo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiSalvar;
        private DevExpress.XtraBars.BarButtonItem bbiFechar;
    }
}