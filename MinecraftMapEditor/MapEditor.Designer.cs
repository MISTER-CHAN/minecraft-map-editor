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
            this.lvColorPicker = new System.Windows.Forms.ListView();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrushSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedraw = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawMap = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawCellGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawChunkGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miCellGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResolution1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution8 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution16 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution32 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution64 = new System.Windows.Forms.ToolStripMenuItem();
            this.miResolution128 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlColorViewer = new System.Windows.Forms.Panel();
            this.lblColorRight = new System.Windows.Forms.Label();
            this.lblColorLeft = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.rbEyedropper = new System.Windows.Forms.RadioButton();
            this.rbBucket = new System.Windows.Forms.RadioButton();
            this.rbBrush = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlColorViewer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvColorPicker
            // 
            this.lvColorPicker.HideSelection = false;
            this.lvColorPicker.Location = new System.Drawing.Point(987, 389);
            this.lvColorPicker.Margin = new System.Windows.Forms.Padding(4);
            this.lvColorPicker.MultiSelect = false;
            this.lvColorPicker.Name = "lvColorPicker";
            this.lvColorPicker.Size = new System.Drawing.Size(170, 80);
            this.lvColorPicker.TabIndex = 3;
            this.lvColorPicker.UseCompatibleStateImageBehavior = false;
            this.lvColorPicker.SelectedIndexChanged += new System.EventHandler(this.ColorPicker_SelectedIndexChanged);
            this.lvColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_MouseClick);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(3, 36);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(148, 66);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miBuild});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 26);
            this.mnuFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(132, 26);
            this.miNew.Text = "New";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(132, 26);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // miBuild
            // 
            this.miBuild.Name = "miBuild";
            this.miBuild.Size = new System.Drawing.Size(132, 26);
            this.miBuild.Text = "Build";
            this.miBuild.Click += new System.EventHandler(this.Build_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrush});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(51, 26);
            this.mnuEdit.Text = "Edit";
            // 
            // miBrush
            // 
            this.miBrush.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrushSize});
            this.miBrush.Name = "miBrush";
            this.miBrush.Size = new System.Drawing.Size(132, 26);
            this.miBrush.Text = "Brush";
            // 
            // miBrushSize
            // 
            this.miBrushSize.Name = "miBrushSize";
            this.miBrushSize.Size = new System.Drawing.Size(121, 26);
            this.miBrushSize.Text = "Size";
            this.miBrushSize.Click += new System.EventHandler(this.BrushSize_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRedraw,
            this.miCellGrid,
            this.miResolution});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(58, 26);
            this.mnuView.Text = "View";
            // 
            // miRedraw
            // 
            this.miRedraw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRedrawMap,
            this.miRedrawGrid,
            this.miRedrawCellGrid,
            this.miRedrawChunkGrid});
            this.miRedraw.Name = "miRedraw";
            this.miRedraw.Size = new System.Drawing.Size(170, 26);
            this.miRedraw.Text = "Redraw";
            // 
            // miRedrawMap
            // 
            this.miRedrawMap.Name = "miRedrawMap";
            this.miRedrawMap.Size = new System.Drawing.Size(172, 26);
            this.miRedrawMap.Text = "Map";
            this.miRedrawMap.Click += new System.EventHandler(this.RedrawMap_Click);
            // 
            // miRedrawGrid
            // 
            this.miRedrawGrid.Name = "miRedrawGrid";
            this.miRedrawGrid.Size = new System.Drawing.Size(172, 26);
            this.miRedrawGrid.Text = "Grid";
            this.miRedrawGrid.Click += new System.EventHandler(this.RedrawGrid_Click);
            // 
            // miRedrawCellGrid
            // 
            this.miRedrawCellGrid.Name = "miRedrawCellGrid";
            this.miRedrawCellGrid.Size = new System.Drawing.Size(172, 26);
            this.miRedrawCellGrid.Text = "Cell grid";
            this.miRedrawCellGrid.Click += new System.EventHandler(this.RedrawCellGrid_Click);
            // 
            // miRedrawChunkGrid
            // 
            this.miRedrawChunkGrid.Name = "miRedrawChunkGrid";
            this.miRedrawChunkGrid.Size = new System.Drawing.Size(172, 26);
            this.miRedrawChunkGrid.Text = "Chunk Grid";
            this.miRedrawChunkGrid.Click += new System.EventHandler(this.RedrawChunkGrid_Click);
            // 
            // miCellGrid
            // 
            this.miCellGrid.Name = "miCellGrid";
            this.miCellGrid.Size = new System.Drawing.Size(170, 26);
            this.miCellGrid.Text = "Cell grid";
            this.miCellGrid.Click += new System.EventHandler(this.CellGrid_Click);
            // 
            // miResolution
            // 
            this.miResolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResolution1,
            this.miResolution2,
            this.miResolution4,
            this.miResolution8,
            this.miResolution16,
            this.miResolution32,
            this.miResolution64,
            this.miResolution128});
            this.miResolution.Name = "miResolution";
            this.miResolution.Size = new System.Drawing.Size(170, 26);
            this.miResolution.Text = "Resolution";
            // 
            // mnuResolution1
            // 
            this.mnuResolution1.Name = "mnuResolution1";
            this.mnuResolution1.Size = new System.Drawing.Size(157, 26);
            this.mnuResolution1.Tag = "128";
            this.mnuResolution1.Text = "1×1";
            this.mnuResolution1.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution2
            // 
            this.miResolution2.Name = "miResolution2";
            this.miResolution2.Size = new System.Drawing.Size(157, 26);
            this.miResolution2.Tag = "64";
            this.miResolution2.Text = "2×2";
            this.miResolution2.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution4
            // 
            this.miResolution4.Name = "miResolution4";
            this.miResolution4.Size = new System.Drawing.Size(157, 26);
            this.miResolution4.Tag = "32";
            this.miResolution4.Text = "4×4";
            this.miResolution4.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution8
            // 
            this.miResolution8.Name = "miResolution8";
            this.miResolution8.Size = new System.Drawing.Size(157, 26);
            this.miResolution8.Tag = "16";
            this.miResolution8.Text = "8×8";
            this.miResolution8.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution16
            // 
            this.miResolution16.Name = "miResolution16";
            this.miResolution16.Size = new System.Drawing.Size(157, 26);
            this.miResolution16.Tag = "8";
            this.miResolution16.Text = "16×16";
            this.miResolution16.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution32
            // 
            this.miResolution32.Name = "miResolution32";
            this.miResolution32.Size = new System.Drawing.Size(157, 26);
            this.miResolution32.Tag = "4";
            this.miResolution32.Text = "32×32";
            this.miResolution32.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution64
            // 
            this.miResolution64.Name = "miResolution64";
            this.miResolution64.Size = new System.Drawing.Size(157, 26);
            this.miResolution64.Tag = "2";
            this.miResolution64.Text = "64×64";
            this.miResolution64.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution128
            // 
            this.miResolution128.Checked = true;
            this.miResolution128.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miResolution128.Name = "miResolution128";
            this.miResolution128.Size = new System.Drawing.Size(157, 26);
            this.miResolution128.Tag = "1";
            this.miResolution128.Text = "128×128";
            this.miResolution128.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // pnlColorViewer
            // 
            this.pnlColorViewer.Controls.Add(this.lblColorRight);
            this.pnlColorViewer.Controls.Add(this.lblColorLeft);
            this.pnlColorViewer.Location = new System.Drawing.Point(0, 148);
            this.pnlColorViewer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColorViewer.Name = "pnlColorViewer";
            this.pnlColorViewer.Size = new System.Drawing.Size(91, 45);
            this.pnlColorViewer.TabIndex = 8;
            // 
            // lblColorRight
            // 
            this.lblColorRight.BackColor = System.Drawing.Color.White;
            this.lblColorRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorRight.Location = new System.Drawing.Point(46, 0);
            this.lblColorRight.Name = "lblColorRight";
            this.lblColorRight.Size = new System.Drawing.Size(46, 45);
            this.lblColorRight.TabIndex = 1;
            this.lblColorRight.Text = "0";
            this.lblColorRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorLeft
            // 
            this.lblColorLeft.BackColor = System.Drawing.Color.White;
            this.lblColorLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorLeft.Location = new System.Drawing.Point(0, 0);
            this.lblColorLeft.Name = "lblColorLeft";
            this.lblColorLeft.Size = new System.Drawing.Size(46, 45);
            this.lblColorLeft.TabIndex = 0;
            this.lblColorLeft.Text = "0";
            this.lblColorLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPos});
            this.statusStrip.Location = new System.Drawing.Point(0, 573);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblPos
            // 
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(45, 20);
            this.lblPos.Text = "(0, 0)";
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.rbEyedropper);
            this.pnlTools.Controls.Add(this.rbBucket);
            this.pnlTools.Controls.Add(this.rbBrush);
            this.pnlTools.Location = new System.Drawing.Point(0, 269);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(225, 107);
            this.pnlTools.TabIndex = 10;
            // 
            // rbEyedropper
            // 
            this.rbEyedropper.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEyedropper.AutoSize = true;
            this.rbEyedropper.Location = new System.Drawing.Point(0, 52);
            this.rbEyedropper.Name = "rbEyedropper";
            this.rbEyedropper.Size = new System.Drawing.Size(98, 26);
            this.rbEyedropper.TabIndex = 2;
            this.rbEyedropper.Text = "Eyedropper";
            this.rbEyedropper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEyedropper.UseVisualStyleBackColor = true;
            // 
            // rbBucket
            // 
            this.rbBucket.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBucket.Location = new System.Drawing.Point(0, 26);
            this.rbBucket.Name = "rbBucket";
            this.rbBucket.Size = new System.Drawing.Size(65, 26);
            this.rbBucket.TabIndex = 1;
            this.rbBucket.Text = "Bucket";
            this.rbBucket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBucket.UseVisualStyleBackColor = true;
            // 
            // rbBrush
            // 
            this.rbBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBrush.Checked = true;
            this.rbBrush.Location = new System.Drawing.Point(0, 0);
            this.rbBrush.Name = "rbBrush";
            this.rbBrush.Size = new System.Drawing.Size(59, 26);
            this.rbBrush.TabIndex = 0;
            this.rbBrush.TabStop = true;
            this.rbBrush.Text = "Brush";
            this.rbBrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBrush.UseVisualStyleBackColor = true;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 599);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.lvColorPicker);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlColorViewer);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("MISTER_CHAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.Resize += new System.EventHandler(this.MapEditor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlColorViewer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvColorPicker;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem miCellGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem miBrush;
        private System.Windows.Forms.ToolStripMenuItem miBrushSize;
        private System.Windows.Forms.ToolStripMenuItem miBuild;
        private System.Windows.Forms.ToolStripMenuItem miRedraw;
        private System.Windows.Forms.ToolStripMenuItem miRedrawMap;
        private System.Windows.Forms.ToolStripMenuItem miRedrawGrid;
        private System.Windows.Forms.ToolStripMenuItem miRedrawChunkGrid;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miResolution;
        private System.Windows.Forms.Panel pnlColorViewer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblPos;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem mnuResolution1;
        private System.Windows.Forms.ToolStripMenuItem miResolution2;
        private System.Windows.Forms.ToolStripMenuItem miResolution4;
        private System.Windows.Forms.ToolStripMenuItem miResolution8;
        private System.Windows.Forms.ToolStripMenuItem miResolution16;
        private System.Windows.Forms.ToolStripMenuItem miResolution32;
        private System.Windows.Forms.ToolStripMenuItem miResolution64;
        private System.Windows.Forms.ToolStripMenuItem miResolution128;
        private System.Windows.Forms.ToolStripMenuItem miRedrawCellGrid;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Label lblColorRight;
        private System.Windows.Forms.Label lblColorLeft;
        private System.Windows.Forms.RadioButton rbEyedropper;
        private System.Windows.Forms.RadioButton rbBucket;
        private System.Windows.Forms.RadioButton rbBrush;
    }
}

