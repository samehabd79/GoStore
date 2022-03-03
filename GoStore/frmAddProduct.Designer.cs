namespace GoStore
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnAddProduct = new CustomControls.RJControls.RJButton();
            this.txtProductName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtProductModel = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtProductPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picAddProductClose = new System.Windows.Forms.PictureBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.goStoreDataSet2 = new GoStore.GoStoreDataSet2();
            this.appleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appleTableAdapter = new GoStore.GoStoreDataSet2TableAdapters.AppleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddProductClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.btnAddProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.btnAddProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.btnAddProduct.BorderRadius = 20;
            this.btnAddProduct.BorderSize = 1;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(90, 345);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(206, 40);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextColor = System.Drawing.Color.White;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.AcceptsReturn = false;
            this.txtProductName.AcceptsTab = false;
            this.txtProductName.AnimationSpeed = 200;
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProductName.BackgroundImage")));
            this.txtProductName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductName.BorderRadius = 20;
            this.txtProductName.BorderThickness = 1;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductName.DefaultText = "";
            this.txtProductName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.HideSelection = true;
            this.txtProductName.IconLeft = null;
            this.txtProductName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.IconPadding = 10;
            this.txtProductName.IconRight = null;
            this.txtProductName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(55, 203);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProductName.Modified = false;
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnIdleState = stateProperties4;
            this.txtProductName.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductName.PlaceholderText = "Enter product name";
            this.txtProductName.ReadOnly = false;
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(272, 36);
            this.txtProductName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductName.TabIndex = 9;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductName.TextMarginBottom = 0;
            this.txtProductName.TextMarginLeft = 3;
            this.txtProductName.TextMarginTop = 0;
            this.txtProductName.TextPlaceholder = "Enter product name";
            this.txtProductName.UseSystemPasswordChar = false;
            this.txtProductName.WordWrap = true;
            // 
            // txtProductModel
            // 
            this.txtProductModel.AcceptsReturn = false;
            this.txtProductModel.AcceptsTab = false;
            this.txtProductModel.AnimationSpeed = 200;
            this.txtProductModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductModel.BackColor = System.Drawing.Color.Transparent;
            this.txtProductModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProductModel.BackgroundImage")));
            this.txtProductModel.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductModel.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductModel.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtProductModel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductModel.BorderRadius = 20;
            this.txtProductModel.BorderThickness = 1;
            this.txtProductModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductModel.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductModel.DefaultText = "";
            this.txtProductModel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.txtProductModel.ForeColor = System.Drawing.Color.White;
            this.txtProductModel.HideSelection = true;
            this.txtProductModel.IconLeft = null;
            this.txtProductModel.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductModel.IconPadding = 10;
            this.txtProductModel.IconRight = null;
            this.txtProductModel.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductModel.Lines = new string[0];
            this.txtProductModel.Location = new System.Drawing.Point(55, 245);
            this.txtProductModel.MaxLength = 32767;
            this.txtProductModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProductModel.Modified = false;
            this.txtProductModel.Multiline = false;
            this.txtProductModel.Name = "txtProductModel";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductModel.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductModel.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductModel.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductModel.OnIdleState = stateProperties8;
            this.txtProductModel.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductModel.PasswordChar = '\0';
            this.txtProductModel.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductModel.PlaceholderText = "Enter product model";
            this.txtProductModel.ReadOnly = false;
            this.txtProductModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductModel.SelectedText = "";
            this.txtProductModel.SelectionLength = 0;
            this.txtProductModel.SelectionStart = 0;
            this.txtProductModel.ShortcutsEnabled = true;
            this.txtProductModel.Size = new System.Drawing.Size(272, 36);
            this.txtProductModel.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductModel.TabIndex = 10;
            this.txtProductModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductModel.TextMarginBottom = 0;
            this.txtProductModel.TextMarginLeft = 3;
            this.txtProductModel.TextMarginTop = 0;
            this.txtProductModel.TextPlaceholder = "Enter product model";
            this.txtProductModel.UseSystemPasswordChar = false;
            this.txtProductModel.WordWrap = true;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AcceptsReturn = false;
            this.txtProductPrice.AcceptsTab = false;
            this.txtProductPrice.AnimationSpeed = 200;
            this.txtProductPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtProductPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProductPrice.BackgroundImage")));
            this.txtProductPrice.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtProductPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductPrice.BorderRadius = 20;
            this.txtProductPrice.BorderThickness = 1;
            this.txtProductPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductPrice.DefaultText = "";
            this.txtProductPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.txtProductPrice.ForeColor = System.Drawing.Color.White;
            this.txtProductPrice.HideSelection = true;
            this.txtProductPrice.IconLeft = null;
            this.txtProductPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.IconPadding = 10;
            this.txtProductPrice.IconRight = null;
            this.txtProductPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.Lines = new string[0];
            this.txtProductPrice.Location = new System.Drawing.Point(55, 287);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProductPrice.Modified = false;
            this.txtProductPrice.Multiline = false;
            this.txtProductPrice.Name = "txtProductPrice";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductPrice.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductPrice.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductPrice.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductPrice.OnIdleState = stateProperties12;
            this.txtProductPrice.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductPrice.PlaceholderText = "Enter price";
            this.txtProductPrice.ReadOnly = false;
            this.txtProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(272, 36);
            this.txtProductPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductPrice.TabIndex = 11;
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductPrice.TextMarginBottom = 0;
            this.txtProductPrice.TextMarginLeft = 3;
            this.txtProductPrice.TextMarginTop = 0;
            this.txtProductPrice.TextPlaceholder = "Enter price";
            this.txtProductPrice.UseSystemPasswordChar = false;
            this.txtProductPrice.WordWrap = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // picAddProductClose
            // 
            this.picAddProductClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddProductClose.Image = ((System.Drawing.Image)(resources.GetObject("picAddProductClose.Image")));
            this.picAddProductClose.Location = new System.Drawing.Point(365, -1);
            this.picAddProductClose.Name = "picAddProductClose";
            this.picAddProductClose.Size = new System.Drawing.Size(25, 28);
            this.picAddProductClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddProductClose.TabIndex = 13;
            this.picAddProductClose.TabStop = false;
            this.picAddProductClose.Click += new System.EventHandler(this.picAddProductClose_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Xaiomi"});
            this.category.Location = new System.Drawing.Point(90, 176);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(206, 21);
            this.category.TabIndex = 14;
            // 
            // goStoreDataSet2
            // 
            this.goStoreDataSet2.DataSetName = "GoStoreDataSet2";
            this.goStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appleBindingSource
            // 
            this.appleBindingSource.DataMember = "Apple";
            this.appleBindingSource.DataSource = this.goStoreDataSet2;
            // 
            // appleTableAdapter
            // 
            this.appleTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(389, 412);
            this.Controls.Add(this.category);
            this.Controls.Add(this.picAddProductClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductModel);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProduct";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddProductClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton btnAddProduct;
        private Bunifu.UI.WinForms.BunifuTextBox txtProductName;
        private Bunifu.UI.WinForms.BunifuTextBox txtProductModel;
        private Bunifu.UI.WinForms.BunifuTextBox txtProductPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picAddProductClose;
        private System.Windows.Forms.ComboBox category;
        private GoStoreDataSet2 goStoreDataSet2;
        private System.Windows.Forms.BindingSource appleBindingSource;
        private GoStoreDataSet2TableAdapters.AppleTableAdapter appleTableAdapter;
    }
}