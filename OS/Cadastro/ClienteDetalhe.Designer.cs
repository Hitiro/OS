namespace OS.Cadastro
{
    partial class ClienteDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteDetalhe));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFechar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.EhFisicoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DocuemtnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Telefone1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Telefone2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEhFisico = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefone1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocuemtno = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefone2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EhFisicoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocuemtnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEhFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocuemtno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(568, 94);
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
            this.ribbonPage1.Text = "ribbonPage1";
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
            this.dataLayoutControl1.Controls.Add(this.EhFisicoCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NomeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocuemtnoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Telefone1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Telefone2TextEdit);
            this.dataLayoutControl1.DataSource = this.clienteBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 94);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(906, 157, 250, 350);
            this.dataLayoutControl1.OptionsView.HighlightFocusedItem = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(568, 146);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // EhFisicoCheckEdit
            // 
            this.EhFisicoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "EhFisico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EhFisicoCheckEdit.Location = new System.Drawing.Point(69, 12);
            this.EhFisicoCheckEdit.MenuManager = this.ribbonControl1;
            this.EhFisicoCheckEdit.Name = "EhFisicoCheckEdit";
            this.EhFisicoCheckEdit.Properties.Caption = "Fisico";
            this.EhFisicoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EhFisicoCheckEdit.Size = new System.Drawing.Size(213, 19);
            this.EhFisicoCheckEdit.StyleController = this.dataLayoutControl1;
            this.EhFisicoCheckEdit.TabIndex = 4;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(OS.Cliente);
            this.clienteBindingSource.CurrentItemChanged += new System.EventHandler(this.clienteBindingSource_CurrentItemChanged);
            // 
            // NomeTextEdit
            // 
            this.NomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Nome", true));
            this.NomeTextEdit.Location = new System.Drawing.Point(69, 36);
            this.NomeTextEdit.MenuManager = this.ribbonControl1;
            this.NomeTextEdit.Name = "NomeTextEdit";
            this.NomeTextEdit.Properties.MaxLength = 50;
            this.NomeTextEdit.Size = new System.Drawing.Size(487, 20);
            this.NomeTextEdit.StyleController = this.dataLayoutControl1;
            this.NomeTextEdit.TabIndex = 5;
            // 
            // DocuemtnoTextEdit
            // 
            this.DocuemtnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Docuemtno", true));
            this.DocuemtnoTextEdit.Location = new System.Drawing.Point(343, 12);
            this.DocuemtnoTextEdit.MenuManager = this.ribbonControl1;
            this.DocuemtnoTextEdit.Name = "DocuemtnoTextEdit";
            this.DocuemtnoTextEdit.Properties.Mask.EditMask = "000.000.000-00";
            this.DocuemtnoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.DocuemtnoTextEdit.Properties.Mask.SaveLiteral = false;
            this.DocuemtnoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DocuemtnoTextEdit.Size = new System.Drawing.Size(213, 20);
            this.DocuemtnoTextEdit.StyleController = this.dataLayoutControl1;
            this.DocuemtnoTextEdit.TabIndex = 6;
            // 
            // Telefone1TextEdit
            // 
            this.Telefone1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Telefone1", true));
            this.Telefone1TextEdit.Location = new System.Drawing.Point(81, 91);
            this.Telefone1TextEdit.MenuManager = this.ribbonControl1;
            this.Telefone1TextEdit.Name = "Telefone1TextEdit";
            this.Telefone1TextEdit.Properties.Mask.EditMask = "(00) 0000-0000";
            this.Telefone1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Telefone1TextEdit.Properties.Mask.SaveLiteral = false;
            this.Telefone1TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Telefone1TextEdit.Size = new System.Drawing.Size(201, 20);
            this.Telefone1TextEdit.StyleController = this.dataLayoutControl1;
            this.Telefone1TextEdit.TabIndex = 7;
            // 
            // Telefone2TextEdit
            // 
            this.Telefone2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Telefone2", true));
            this.Telefone2TextEdit.Location = new System.Drawing.Point(343, 91);
            this.Telefone2TextEdit.MenuManager = this.ribbonControl1;
            this.Telefone2TextEdit.Name = "Telefone2TextEdit";
            this.Telefone2TextEdit.Properties.Mask.EditMask = "(00) 00000-0000";
            this.Telefone2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Telefone2TextEdit.Properties.Mask.SaveLiteral = false;
            this.Telefone2TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Telefone2TextEdit.Size = new System.Drawing.Size(201, 20);
            this.Telefone2TextEdit.StyleController = this.dataLayoutControl1;
            this.Telefone2TextEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(568, 146);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEhFisico,
            this.ItemForDocuemtno,
            this.ItemForNome,
            this.emptySpaceItem1,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(548, 126);
            // 
            // ItemForEhFisico
            // 
            this.ItemForEhFisico.Control = this.EhFisicoCheckEdit;
            this.ItemForEhFisico.Location = new System.Drawing.Point(0, 0);
            this.ItemForEhFisico.Name = "ItemForEhFisico";
            this.ItemForEhFisico.Size = new System.Drawing.Size(274, 24);
            this.ItemForEhFisico.Text = "Fisico ?";
            this.ItemForEhFisico.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForTelefone1
            // 
            this.ItemForTelefone1.Control = this.Telefone1TextEdit;
            this.ItemForTelefone1.Location = new System.Drawing.Point(0, 0);
            this.ItemForTelefone1.Name = "ItemForTelefone1";
            this.ItemForTelefone1.Size = new System.Drawing.Size(262, 24);
            this.ItemForTelefone1.Text = "Fixo";
            this.ItemForTelefone1.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDocuemtno
            // 
            this.ItemForDocuemtno.Control = this.DocuemtnoTextEdit;
            this.ItemForDocuemtno.Location = new System.Drawing.Point(274, 0);
            this.ItemForDocuemtno.Name = "ItemForDocuemtno";
            this.ItemForDocuemtno.Size = new System.Drawing.Size(274, 24);
            this.ItemForDocuemtno.Text = "Documento";
            this.ItemForDocuemtno.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForTelefone2
            // 
            this.ItemForTelefone2.Control = this.Telefone2TextEdit;
            this.ItemForTelefone2.Location = new System.Drawing.Point(262, 0);
            this.ItemForTelefone2.Name = "ItemForTelefone2";
            this.ItemForTelefone2.Size = new System.Drawing.Size(262, 24);
            this.ItemForTelefone2.Text = "Celular";
            this.ItemForTelefone2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForNome
            // 
            this.ItemForNome.Control = this.NomeTextEdit;
            this.ItemForNome.Location = new System.Drawing.Point(0, 24);
            this.ItemForNome.Name = "ItemForNome";
            this.ItemForNome.Size = new System.Drawing.Size(548, 24);
            this.ItemForNome.Text = "Nome";
            this.ItemForNome.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 115);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(548, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTelefone1,
            this.ItemForTelefone2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(548, 67);
            this.layoutControlGroup3.Text = "Telefone";
            // 
            // ClienteDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 240);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteDetalhe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhe de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EhFisicoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocuemtnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEhFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocuemtno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSalvar;
        private DevExpress.XtraBars.BarButtonItem bbiFechar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.TextEdit NomeTextEdit;
        private DevExpress.XtraEditors.TextEdit DocuemtnoTextEdit;
        private DevExpress.XtraEditors.TextEdit Telefone1TextEdit;
        private DevExpress.XtraEditors.TextEdit Telefone2TextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefone1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocuemtno;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefone2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit EhFisicoCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEhFisico;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}