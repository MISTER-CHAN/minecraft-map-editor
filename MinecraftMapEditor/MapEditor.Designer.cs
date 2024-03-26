namespace MinecraftMapEditor
{
    partial class MapEditor
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this._lstColorPicker = new System.Windows.Forms.ListView();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this._itmNew = new System.Windows.Forms.ToolStripMenuItem();
            this._itmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this._itmBuild = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._itmBrush = new System.Windows.Forms.ToolStripMenuItem();
            this._itmBrushSize = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this._itmCellGrid = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuResolution1 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution2 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution4 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution8 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution16 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution32 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution64 = new System.Windows.Forms.ToolStripMenuItem();
            this._itmResolution128 = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._itmUsage = new System.Windows.Forms.ToolStripMenuItem();
            this._itmCredits = new System.Windows.Forms.ToolStripMenuItem();
            this._pnlColorViewer = new System.Windows.Forms.Panel();
            this._lblColorRight = new System.Windows.Forms.Label();
            this._lblColorLeft = new System.Windows.Forms.Label();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this._pnlTools = new System.Windows.Forms.Panel();
            this._rdoMarquee = new System.Windows.Forms.RadioButton();
            this._rdoBanner = new System.Windows.Forms.RadioButton();
            this._rdoEyedropper = new System.Windows.Forms.RadioButton();
            this._rdoBucket = new System.Windows.Forms.RadioButton();
            this._rdoBrush = new System.Windows.Forms.RadioButton();
            this._pnlBanners = new System.Windows.Forms.Panel();
            this._lstBannerColor = new System.Windows.Forms.ListBox();
            this._txtBannerName = new System.Windows.Forms.TextBox();
            this._pnlColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._menuStrip.SuspendLayout();
            this._pnlColorViewer.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this._pnlTools.SuspendLayout();
            this._pnlBanners.SuspendLayout();
            this._pnlColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lstColorPicker
            // 
            this._lstColorPicker.HideSelection = false;
            this._lstColorPicker.Location = new System.Drawing.Point(0, 45);
            this._lstColorPicker.Margin = new System.Windows.Forms.Padding(4);
            this._lstColorPicker.MultiSelect = false;
            this._lstColorPicker.Name = "_lstColorPicker";
            this._lstColorPicker.Size = new System.Drawing.Size(170, 80);
            this._lstColorPicker.TabIndex = 3;
            this._lstColorPicker.UseCompatibleStateImageBehavior = false;
            this._lstColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this._lstColorPicker_MouseClick);
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.Color.White;
            this._pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pictureBox.Location = new System.Drawing.Point(3, 36);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(148, 66);
            this._pictureBox.TabIndex = 5;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pictureBox_MouseDown);
            this._pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this._pictureBox_MouseMove);
            this._pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this._pictureBox_MouseUp);
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuFile,
            this._mnuEdit,
            this._mnuView,
            this._mnuHelp});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this._menuStrip.Size = new System.Drawing.Size(1200, 28);
            this._menuStrip.TabIndex = 6;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _mnuFile
            // 
            this._mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmNew,
            this._itmOpen,
            this._itmBuild});
            this._mnuFile.Name = "_mnuFile";
            this._mnuFile.Size = new System.Drawing.Size(48, 24);
            this._mnuFile.Text = "File";
            // 
            // _itmNew
            // 
            this._itmNew.Name = "_itmNew";
            this._itmNew.Size = new System.Drawing.Size(224, 26);
            this._itmNew.Text = "New";
            this._itmNew.Click += new System.EventHandler(this._itmNew_Click);
            // 
            // _itmOpen
            // 
            this._itmOpen.Name = "_itmOpen";
            this._itmOpen.Size = new System.Drawing.Size(224, 26);
            this._itmOpen.Text = "Open";
            this._itmOpen.Click += new System.EventHandler(this._itmOpen_Click);
            // 
            // _itmBuild
            // 
            this._itmBuild.Name = "_itmBuild";
            this._itmBuild.Size = new System.Drawing.Size(224, 26);
            this._itmBuild.Text = "Save";
            this._itmBuild.Click += new System.EventHandler(this._itmSave_Click);
            // 
            // _mnuEdit
            // 
            this._mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmBrush});
            this._mnuEdit.Name = "_mnuEdit";
            this._mnuEdit.Size = new System.Drawing.Size(51, 24);
            this._mnuEdit.Text = "Edit";
            // 
            // _itmBrush
            // 
            this._itmBrush.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmBrushSize});
            this._itmBrush.Name = "_itmBrush";
            this._itmBrush.Size = new System.Drawing.Size(132, 26);
            this._itmBrush.Text = "Brush";
            // 
            // _itmBrushSize
            // 
            this._itmBrushSize.Name = "_itmBrushSize";
            this._itmBrushSize.Size = new System.Drawing.Size(121, 26);
            this._itmBrushSize.Text = "Size";
            this._itmBrushSize.Click += new System.EventHandler(this._itmBrushSize_Click);
            // 
            // _mnuView
            // 
            this._mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmCellGrid,
            this._itmResolution});
            this._mnuView.Name = "_mnuView";
            this._mnuView.Size = new System.Drawing.Size(58, 24);
            this._mnuView.Text = "View";
            // 
            // _itmCellGrid
            // 
            this._itmCellGrid.Name = "_itmCellGrid";
            this._itmCellGrid.Size = new System.Drawing.Size(170, 26);
            this._itmCellGrid.Text = "Cell Grid";
            this._itmCellGrid.Click += new System.EventHandler(this._itmCellGrid_Click);
            // 
            // _itmResolution
            // 
            this._itmResolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuResolution1,
            this._itmResolution2,
            this._itmResolution4,
            this._itmResolution8,
            this._itmResolution16,
            this._itmResolution32,
            this._itmResolution64,
            this._itmResolution128});
            this._itmResolution.Name = "_itmResolution";
            this._itmResolution.Size = new System.Drawing.Size(170, 26);
            this._itmResolution.Text = "Resolution";
            // 
            // _mnuResolution1
            // 
            this._mnuResolution1.Name = "_mnuResolution1";
            this._mnuResolution1.Size = new System.Drawing.Size(157, 26);
            this._mnuResolution1.Tag = "128";
            this._mnuResolution1.Text = "1×1";
            this._mnuResolution1.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution2
            // 
            this._itmResolution2.Name = "_itmResolution2";
            this._itmResolution2.Size = new System.Drawing.Size(157, 26);
            this._itmResolution2.Tag = "64";
            this._itmResolution2.Text = "2×2";
            this._itmResolution2.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution4
            // 
            this._itmResolution4.Name = "_itmResolution4";
            this._itmResolution4.Size = new System.Drawing.Size(157, 26);
            this._itmResolution4.Tag = "32";
            this._itmResolution4.Text = "4×4";
            this._itmResolution4.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution8
            // 
            this._itmResolution8.Name = "_itmResolution8";
            this._itmResolution8.Size = new System.Drawing.Size(157, 26);
            this._itmResolution8.Tag = "16";
            this._itmResolution8.Text = "8×8";
            this._itmResolution8.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution16
            // 
            this._itmResolution16.Name = "_itmResolution16";
            this._itmResolution16.Size = new System.Drawing.Size(157, 26);
            this._itmResolution16.Tag = "8";
            this._itmResolution16.Text = "16×16";
            this._itmResolution16.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution32
            // 
            this._itmResolution32.Name = "_itmResolution32";
            this._itmResolution32.Size = new System.Drawing.Size(157, 26);
            this._itmResolution32.Tag = "4";
            this._itmResolution32.Text = "32×32";
            this._itmResolution32.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution64
            // 
            this._itmResolution64.Name = "_itmResolution64";
            this._itmResolution64.Size = new System.Drawing.Size(157, 26);
            this._itmResolution64.Tag = "2";
            this._itmResolution64.Text = "64×64";
            this._itmResolution64.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _itmResolution128
            // 
            this._itmResolution128.Checked = true;
            this._itmResolution128.CheckState = System.Windows.Forms.CheckState.Checked;
            this._itmResolution128.Name = "_itmResolution128";
            this._itmResolution128.Size = new System.Drawing.Size(157, 26);
            this._itmResolution128.Tag = "1";
            this._itmResolution128.Text = "128×128";
            this._itmResolution128.Click += new System.EventHandler(this._itmResolution_Click);
            // 
            // _mnuHelp
            // 
            this._mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmUsage,
            this._itmCredits});
            this._mnuHelp.Name = "_mnuHelp";
            this._mnuHelp.Size = new System.Drawing.Size(58, 24);
            this._mnuHelp.Text = "Help";
            // 
            // _itmUsage
            // 
            this._itmUsage.Name = "_itmUsage";
            this._itmUsage.Size = new System.Drawing.Size(138, 26);
            this._itmUsage.Text = "Help";
            this._itmUsage.Click += new System.EventHandler(this._itmUsage_Click);
            // 
            // _itmCredits
            // 
            this._itmCredits.Name = "_itmCredits";
            this._itmCredits.Size = new System.Drawing.Size(138, 26);
            this._itmCredits.Text = "About";
            this._itmCredits.Click += new System.EventHandler(this._itmCredits_Click);
            // 
            // _pnlColorViewer
            // 
            this._pnlColorViewer.Controls.Add(this._lblColorRight);
            this._pnlColorViewer.Controls.Add(this._lblColorLeft);
            this._pnlColorViewer.Location = new System.Drawing.Point(1, 0);
            this._pnlColorViewer.Margin = new System.Windows.Forms.Padding(4);
            this._pnlColorViewer.Name = "_pnlColorViewer";
            this._pnlColorViewer.Size = new System.Drawing.Size(91, 45);
            this._pnlColorViewer.TabIndex = 8;
            // 
            // _lblColorRight
            // 
            this._lblColorRight.BackColor = System.Drawing.Color.White;
            this._lblColorRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblColorRight.Location = new System.Drawing.Point(46, 0);
            this._lblColorRight.Name = "_lblColorRight";
            this._lblColorRight.Size = new System.Drawing.Size(46, 45);
            this._lblColorRight.TabIndex = 1;
            this._lblColorRight.Text = "0";
            this._lblColorRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblColorLeft
            // 
            this._lblColorLeft.BackColor = System.Drawing.Color.White;
            this._lblColorLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblColorLeft.Location = new System.Drawing.Point(0, 0);
            this._lblColorLeft.Name = "_lblColorLeft";
            this._lblColorLeft.Size = new System.Drawing.Size(46, 45);
            this._lblColorLeft.TabIndex = 0;
            this._lblColorLeft.Text = "0";
            this._lblColorLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _statusStrip
            // 
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblPos});
            this._statusStrip.Location = new System.Drawing.Point(0, 573);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this._statusStrip.Size = new System.Drawing.Size(1200, 26);
            this._statusStrip.TabIndex = 9;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _lblPos
            // 
            this._lblPos.Name = "_lblPos";
            this._lblPos.Size = new System.Drawing.Size(45, 20);
            this._lblPos.Text = "(0, 0)";
            // 
            // _pnlTools
            // 
            this._pnlTools.Controls.Add(this._rdoMarquee);
            this._pnlTools.Controls.Add(this._rdoBanner);
            this._pnlTools.Controls.Add(this._rdoEyedropper);
            this._pnlTools.Controls.Add(this._rdoBucket);
            this._pnlTools.Controls.Add(this._rdoBrush);
            this._pnlTools.Location = new System.Drawing.Point(0, 135);
            this._pnlTools.Name = "_pnlTools";
            this._pnlTools.Size = new System.Drawing.Size(225, 157);
            this._pnlTools.TabIndex = 10;
            // 
            // _rdoMarquee
            // 
            this._rdoMarquee.Appearance = System.Windows.Forms.Appearance.Button;
            this._rdoMarquee.Location = new System.Drawing.Point(0, 0);
            this._rdoMarquee.Name = "_rdoMarquee";
            this._rdoMarquee.Size = new System.Drawing.Size(59, 26);
            this._rdoMarquee.TabIndex = 4;
            this._rdoMarquee.Text = "Select";
            this._rdoMarquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._rdoMarquee.UseVisualStyleBackColor = true;
            this._rdoMarquee.CheckedChanged += new System.EventHandler(this._rdoSelect_CheckedChanged);
            // 
            // _rdoBanner
            // 
            this._rdoBanner.Appearance = System.Windows.Forms.Appearance.Button;
            this._rdoBanner.Location = new System.Drawing.Point(0, 128);
            this._rdoBanner.Name = "_rdoBanner";
            this._rdoBanner.Size = new System.Drawing.Size(65, 26);
            this._rdoBanner.TabIndex = 3;
            this._rdoBanner.Text = "Banner";
            this._rdoBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._rdoBanner.UseVisualStyleBackColor = true;
            this._rdoBanner.CheckedChanged += new System.EventHandler(this._rdoBanner_CheckedChanged);
            // 
            // _rdoEyedropper
            // 
            this._rdoEyedropper.Appearance = System.Windows.Forms.Appearance.Button;
            this._rdoEyedropper.AutoSize = true;
            this._rdoEyedropper.Location = new System.Drawing.Point(0, 96);
            this._rdoEyedropper.Name = "_rdoEyedropper";
            this._rdoEyedropper.Size = new System.Drawing.Size(97, 26);
            this._rdoEyedropper.TabIndex = 2;
            this._rdoEyedropper.Text = "Eyedropper";
            this._rdoEyedropper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._rdoEyedropper.UseVisualStyleBackColor = true;
            this._rdoEyedropper.CheckedChanged += new System.EventHandler(this._rdoEyedropper_CheckedChanged);
            // 
            // _rdoBucket
            // 
            this._rdoBucket.Appearance = System.Windows.Forms.Appearance.Button;
            this._rdoBucket.Location = new System.Drawing.Point(0, 64);
            this._rdoBucket.Name = "_rdoBucket";
            this._rdoBucket.Size = new System.Drawing.Size(65, 26);
            this._rdoBucket.TabIndex = 1;
            this._rdoBucket.Text = "Bucket";
            this._rdoBucket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._rdoBucket.UseVisualStyleBackColor = true;
            this._rdoBucket.CheckedChanged += new System.EventHandler(this._rdoBucket_CheckedChanged);
            // 
            // _rdoBrush
            // 
            this._rdoBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this._rdoBrush.Checked = true;
            this._rdoBrush.Location = new System.Drawing.Point(0, 32);
            this._rdoBrush.Name = "_rdoBrush";
            this._rdoBrush.Size = new System.Drawing.Size(59, 26);
            this._rdoBrush.TabIndex = 0;
            this._rdoBrush.TabStop = true;
            this._rdoBrush.Text = "Brush";
            this._rdoBrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._rdoBrush.UseVisualStyleBackColor = true;
            this._rdoBrush.CheckedChanged += new System.EventHandler(this._rdoBrush_CheckedChanged);
            // 
            // _pnlBanners
            // 
            this._pnlBanners.Controls.Add(this._lstBannerColor);
            this._pnlBanners.Controls.Add(this._txtBannerName);
            this._pnlBanners.Location = new System.Drawing.Point(810, 269);
            this._pnlBanners.Name = "_pnlBanners";
            this._pnlBanners.Size = new System.Drawing.Size(200, 100);
            this._pnlBanners.TabIndex = 11;
            // 
            // _lstBannerColor
            // 
            this._lstBannerColor.FormattingEnabled = true;
            this._lstBannerColor.ItemHeight = 16;
            this._lstBannerColor.Items.AddRange(new object[] {
            "white",
            "orange",
            "magenta",
            "light_blue",
            "yellow",
            "lime",
            "pink",
            "gray",
            "light_gray",
            "cyan",
            "purple",
            "blue",
            "brown",
            "green",
            "red",
            "black"});
            this._lstBannerColor.Location = new System.Drawing.Point(0, 23);
            this._lstBannerColor.Name = "_lstBannerColor";
            this._lstBannerColor.Size = new System.Drawing.Size(120, 84);
            this._lstBannerColor.TabIndex = 1;
            // 
            // _txtBannerName
            // 
            this._txtBannerName.Location = new System.Drawing.Point(0, 0);
            this._txtBannerName.Multiline = true;
            this._txtBannerName.Name = "_txtBannerName";
            this._txtBannerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtBannerName.Size = new System.Drawing.Size(100, 23);
            this._txtBannerName.TabIndex = 0;
            // 
            // _pnlColor
            // 
            this._pnlColor.Controls.Add(this._pnlColorViewer);
            this._pnlColor.Controls.Add(this._lstColorPicker);
            this._pnlColor.Location = new System.Drawing.Point(1016, 269);
            this._pnlColor.Name = "_pnlColor";
            this._pnlColor.Size = new System.Drawing.Size(200, 100);
            this._pnlColor.TabIndex = 12;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 599);
            this.Controls.Add(this._pnlColor);
            this.Controls.Add(this._pnlBanners);
            this.Controls.Add(this._pnlTools);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._menuStrip);
            this.Font = new System.Drawing.Font("MISTER_CHAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.ResizeEnd += new System.EventHandler(this.MapEditor_ResizeEnd);
            this.Resize += new System.EventHandler(this.MapEditor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._pnlColorViewer.ResumeLayout(false);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._pnlTools.ResumeLayout(false);
            this._pnlTools.PerformLayout();
            this._pnlBanners.ResumeLayout(false);
            this._pnlBanners.PerformLayout();
            this._pnlColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView _lstColorPicker;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _mnuFile;
        private System.Windows.Forms.ToolStripMenuItem _mnuView;
        private System.Windows.Forms.ToolStripMenuItem _itmCellGrid;
        private System.Windows.Forms.ToolStripMenuItem _mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem _itmBrush;
        private System.Windows.Forms.ToolStripMenuItem _itmBrushSize;
        private System.Windows.Forms.ToolStripMenuItem _itmBuild;
        private System.Windows.Forms.ToolStripMenuItem _itmOpen;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution;
        private System.Windows.Forms.Panel _pnlColorViewer;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _lblPos;
        private System.Windows.Forms.ToolStripMenuItem _itmNew;
        private System.Windows.Forms.ToolStripMenuItem _mnuResolution1;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution2;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution4;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution8;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution16;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution32;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution64;
        private System.Windows.Forms.ToolStripMenuItem _itmResolution128;
        private System.Windows.Forms.Panel _pnlTools;
        private System.Windows.Forms.Label _lblColorRight;
        private System.Windows.Forms.Label _lblColorLeft;
        private System.Windows.Forms.RadioButton _rdoEyedropper;
        private System.Windows.Forms.RadioButton _rdoBucket;
        private System.Windows.Forms.RadioButton _rdoBrush;
        private System.Windows.Forms.ToolStripMenuItem _mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem _itmCredits;
        private System.Windows.Forms.ToolStripMenuItem _itmUsage;
        private System.Windows.Forms.Panel _pnlBanners;
        private System.Windows.Forms.TextBox _txtBannerName;
        private System.Windows.Forms.ListBox _lstBannerColor;
        private System.Windows.Forms.Panel _pnlColor;
        private System.Windows.Forms.RadioButton _rdoBanner;
        private System.Windows.Forms.RadioButton _rdoMarquee;
    }
}

