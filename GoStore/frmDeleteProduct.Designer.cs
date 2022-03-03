namespace GoStore
{
    partial class frmDeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteProduct));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtProductIdToDelete = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnDeleteProdect = new CustomControls.RJControls.RJButton();
            this.picDeleteProductClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteProductClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // txtProductIdToDelete
            // 
            this.txtProductIdToDelete.AcceptsReturn = false;
            this.txtProductIdToDelete.AcceptsTab = false;
            this.txtProductIdToDelete.AnimationSpeed = 200;
            this.txtProductIdToDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductIdToDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductIdToDelete.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtProductIdToDelete, "txtProductIdToDelete");
            this.txtProductIdToDelete.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductIdToDelete.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductIdToDelete.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtProductIdToDelete.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.txtProductIdToDelete.BorderRadius = 20;
            this.txtProductIdToDelete.BorderThickness = 1;
            this.txtProductIdToDelete.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductIdToDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductIdToDelete.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductIdToDelete.DefaultText = "";
            this.txtProductIdToDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.txtProductIdToDelete.ForeColor = System.Drawing.Color.White;
            this.txtProductIdToDelete.HideSelection = true;
            this.txtProductIdToDelete.IconLeft = null;
            this.txtProductIdToDelete.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductIdToDelete.IconPadding = 10;
            this.txtProductIdToDelete.IconRight = null;
            this.txtProductIdToDelete.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductIdToDelete.Lines = new string[0];
            this.txtProductIdToDelete.MaxLength = 32767;
            this.txtProductIdToDelete.Modified = false;
            this.txtProductIdToDelete.Multiline = false;
            this.txtProductIdToDelete.Name = "txtProductIdToDelete";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductIdToDelete.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductIdToDelete.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductIdToDelete.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductIdToDelete.OnIdleState = stateProperties4;
            this.txtProductIdToDelete.PasswordChar = '\0';
            this.txtProductIdToDelete.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductIdToDelete.PlaceholderText = "Enter Id Product To Delete";
            this.txtProductIdToDelete.ReadOnly = false;
            this.txtProductIdToDelete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductIdToDelete.SelectedText = "";
            this.txtProductIdToDelete.SelectionLength = 0;
            this.txtProductIdToDelete.SelectionStart = 0;
            this.txtProductIdToDelete.ShortcutsEnabled = true;
            this.txtProductIdToDelete.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductIdToDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductIdToDelete.TextMarginBottom = 0;
            this.txtProductIdToDelete.TextMarginLeft = 3;
            this.txtProductIdToDelete.TextMarginTop = 0;
            this.txtProductIdToDelete.TextPlaceholder = "Enter Id Product To Delete";
            this.txtProductIdToDelete.UseSystemPasswordChar = false;
            this.txtProductIdToDelete.WordWrap = true;
            // 
            // btnDeleteProdect
            // 
            this.btnDeleteProdect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.btnDeleteProdect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.btnDeleteProdect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.btnDeleteProdect.BorderRadius = 20;
            this.btnDeleteProdect.BorderSize = 1;
            this.btnDeleteProdect.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeleteProdect, "btnDeleteProdect");
            this.btnDeleteProdect.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProdect.Name = "btnDeleteProdect";
            this.btnDeleteProdect.TextColor = System.Drawing.Color.White;
            this.btnDeleteProdect.UseVisualStyleBackColor = false;
            this.btnDeleteProdect.Click += new System.EventHandler(this.btnDeleteProdect_Click);
            // 
            // picDeleteProductClose
            // 
            this.picDeleteProductClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.picDeleteProductClose, "picDeleteProductClose");
            this.picDeleteProductClose.Name = "picDeleteProductClose";
            this.picDeleteProductClose.TabStop = false;
            this.picDeleteProductClose.Click += new System.EventHandler(this.picDeleteProductClose_Click);
            // 
            // frmDeleteProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.picDeleteProductClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtProductIdToDelete);
            this.Controls.Add(this.btnDeleteProdect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteProductClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuTextBox txtProductIdToDelete;
        private CustomControls.RJControls.RJButton btnDeleteProdect;
        private System.Windows.Forms.PictureBox picDeleteProductClose;
    }
}