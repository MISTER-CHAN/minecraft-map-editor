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
            this.miBucket = new System.Windows.Forms.ToolStripMenuItem();
            this.miEyedropper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedraw = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawMap = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedrawGrid = new System.Windows.Forms.ToolStripMenuItem();
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
            this.rbColorLeft = new System.Windows.Forms.RadioButton();
            this.pnlColorViewer = new System.Windows.Forms.Panel();
            this.rbColorRight = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.miRedrawCellGrid = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlColorViewer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvColorPicker
            // 
            this.lvColorPicker.HideSelection = false;
            this.lvColorPicker.Location = new System.Drawing.Point(658, 292);
            this.lvColorPicker.MultiSelect = false;
            this.lvColorPicker.Name = "lvColorPicker";
            this.lvColorPicker.Size = new System.Drawing.Size(115, 61);
            this.lvColorPicker.TabIndex = 3;
            this.lvColorPicker.UseCompatibleStateImageBehavior = false;
            this.lvColorPicker.SelectedIndexChanged += new System.EventHandler(this.ColorPicker_SelectedIndexChanged);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(2, 27);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(100, 50);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 25);
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
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(108, 22);
            this.miNew.Text = "New";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(108, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // miBuild
            // 
            this.miBuild.Name = "miBuild";
            this.miBuild.Size = new System.Drawing.Size(108, 22);
            this.miBuild.Text = "Build";
            this.miBuild.Click += new System.EventHandler(this.Build_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrush,
            this.miBucket,
            this.miEyedropper});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(42, 21);
            this.mnuEdit.Text = "Edit";
            // 
            // miBrush
            // 
            this.miBrush.Checked = true;
            this.miBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miBrush.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrushSize});
            this.miBrush.Name = "miBrush";
            this.miBrush.Size = new System.Drawing.Size(145, 22);
            this.miBrush.Text = "Brush";
            this.miBrush.Click += new System.EventHandler(this.Tool_Click);
            // 
            // miBrushSize
            // 
            this.miBrushSize.Name = "miBrushSize";
            this.miBrushSize.Size = new System.Drawing.Size(99, 22);
            this.miBrushSize.Text = "Size";
            this.miBrushSize.Click += new System.EventHandler(this.BrushSize_Click);
            // 
            // miBucket
            // 
            this.miBucket.Name = "miBucket";
            this.miBucket.Size = new System.Drawing.Size(145, 22);
            this.miBucket.Text = "Bucket";
            this.miBucket.Click += new System.EventHandler(this.Tool_Click);
            // 
            // miEyedropper
            // 
            this.miEyedropper.Name = "miEyedropper";
            this.miEyedropper.Size = new System.Drawing.Size(145, 22);
            this.miEyedropper.Text = "Eyedropper";
            this.miEyedropper.Click += new System.EventHandler(this.Tool_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRedraw,
            this.miCellGrid,
            this.miResolution});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(47, 21);
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
            this.miRedraw.Size = new System.Drawing.Size(180, 22);
            this.miRedraw.Text = "Redraw";
            // 
            // miRedrawMap
            // 
            this.miRedrawMap.Name = "miRedrawMap";
            this.miRedrawMap.Size = new System.Drawing.Size(180, 22);
            this.miRedrawMap.Text = "Map";
            this.miRedrawMap.Click += new System.EventHandler(this.RedrawMap_Click);
            // 
            // miRedrawGrid
            // 
            this.miRedrawGrid.Name = "miRedrawGrid";
            this.miRedrawGrid.Size = new System.Drawing.Size(180, 22);
            this.miRedrawGrid.Text = "Grid";
            this.miRedrawGrid.Click += new System.EventHandler(this.RedrawGrid_Click);
            // 
            // miRedrawChunkGrid
            // 
            this.miRedrawChunkGrid.Name = "miRedrawChunkGrid";
            this.miRedrawChunkGrid.Size = new System.Drawing.Size(180, 22);
            this.miRedrawChunkGrid.Text = "Chunk Grid";
            this.miRedrawChunkGrid.Click += new System.EventHandler(this.RedrawChunkGrid_Click);
            // 
            // miCellGrid
            // 
            this.miCellGrid.Name = "miCellGrid";
            this.miCellGrid.Size = new System.Drawing.Size(180, 22);
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
            this.miResolution.Size = new System.Drawing.Size(180, 22);
            this.miResolution.Text = "Resolution";
            // 
            // mnuResolution1
            // 
            this.mnuResolution1.Name = "mnuResolution1";
            this.mnuResolution1.Size = new System.Drawing.Size(180, 22);
            this.mnuResolution1.Tag = "128";
            this.mnuResolution1.Text = "1×1";
            this.mnuResolution1.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution2
            // 
            this.miResolution2.Name = "miResolution2";
            this.miResolution2.Size = new System.Drawing.Size(180, 22);
            this.miResolution2.Tag = "64";
            this.miResolution2.Text = "2×2";
            this.miResolution2.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution4
            // 
            this.miResolution4.Name = "miResolution4";
            this.miResolution4.Size = new System.Drawing.Size(180, 22);
            this.miResolution4.Tag = "32";
            this.miResolution4.Text = "4×4";
            this.miResolution4.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution8
            // 
            this.miResolution8.Name = "miResolution8";
            this.miResolution8.Size = new System.Drawing.Size(180, 22);
            this.miResolution8.Tag = "16";
            this.miResolution8.Text = "8×8";
            this.miResolution8.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution16
            // 
            this.miResolution16.Name = "miResolution16";
            this.miResolution16.Size = new System.Drawing.Size(180, 22);
            this.miResolution16.Tag = "8";
            this.miResolution16.Text = "16×16";
            this.miResolution16.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution32
            // 
            this.miResolution32.Name = "miResolution32";
            this.miResolution32.Size = new System.Drawing.Size(180, 22);
            this.miResolution32.Tag = "4";
            this.miResolution32.Text = "32×32";
            this.miResolution32.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution64
            // 
            this.miResolution64.Name = "miResolution64";
            this.miResolution64.Size = new System.Drawing.Size(180, 22);
            this.miResolution64.Tag = "2";
            this.miResolution64.Text = "64×64";
            this.miResolution64.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // miResolution128
            // 
            this.miResolution128.Checked = true;
            this.miResolution128.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miResolution128.Name = "miResolution128";
            this.miResolution128.Size = new System.Drawing.Size(180, 22);
            this.miResolution128.Tag = "1";
            this.miResolution128.Text = "128×128";
            this.miResolution128.Click += new System.EventHandler(this.Resolution_Click);
            // 
            // rbColorLeft
            // 
            this.rbColorLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbColorLeft.BackColor = System.Drawing.Color.White;
            this.rbColorLeft.Checked = true;
            this.rbColorLeft.Location = new System.Drawing.Point(0, 0);
            this.rbColorLeft.Name = "rbColorLeft";
            this.rbColorLeft.Size = new System.Drawing.Size(31, 61);
            this.rbColorLeft.TabIndex = 7;
            this.rbColorLeft.TabStop = true;
            this.rbColorLeft.Text = " ";
            this.rbColorLeft.UseVisualStyleBackColor = false;
            // 
            // pnlColorViewer
            // 
            this.pnlColorViewer.Controls.Add(this.rbColorRight);
            this.pnlColorViewer.Controls.Add(this.rbColorLeft);
            this.pnlColorViewer.Location = new System.Drawing.Point(0, 111);
            this.pnlColorViewer.Name = "pnlColorViewer";
            this.pnlColorViewer.Size = new System.Drawing.Size(61, 61);
            this.pnlColorViewer.TabIndex = 8;
            // 
            // rbColorRight
            // 
            this.rbColorRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbColorRight.BackColor = System.Drawing.Color.White;
            this.rbColorRight.Location = new System.Drawing.Point(31, 0);
            this.rbColorRight.Name = "rbColorRight";
            this.rbColorRight.Size = new System.Drawing.Size(30, 61);
            this.rbColorRight.TabIndex = 8;
            this.rbColorRight.Text = " ";
            this.rbColorRight.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPos});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblPos
            // 
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(37, 17);
            this.lblPos.Text = "(0, 0)";
            // 
            // miRedrawCellGrid
            // 
            this.miRedrawCellGrid.Name = "miRedrawCellGrid";
            this.miRedrawCellGrid.Size = new System.Drawing.Size(180, 22);
            this.miRedrawCellGrid.Text = "Cell grid";
            this.miRedrawCellGrid.Click += new System.EventHandler(this.RedrawCellGrid_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlColorViewer);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lvColorPicker);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.Resize += new System.EventHandler(this.MapEditor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlColorViewer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem miBucket;
        private System.Windows.Forms.ToolStripMenuItem miResolution;
        private System.Windows.Forms.ToolStripMenuItem miEyedropper;
        private System.Windows.Forms.RadioButton rbColorLeft;
        private System.Windows.Forms.Panel pnlColorViewer;
        private System.Windows.Forms.RadioButton rbColorRight;
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
    }
}

