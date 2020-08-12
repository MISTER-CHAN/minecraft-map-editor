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
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrushSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBucket = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEyedropper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedrawMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedrawGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedrawChunkGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCellGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.rbColorLeft = new System.Windows.Forms.RadioButton();
            this.pnlColorViewer = new System.Windows.Forms.Panel();
            this.rbColorRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlColorViewer.SuspendLayout();
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
            this.mnuOpen,
            this.mnuBuild});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(108, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // mnuBuild
            // 
            this.mnuBuild.Name = "mnuBuild";
            this.mnuBuild.Size = new System.Drawing.Size(108, 22);
            this.mnuBuild.Text = "Build";
            this.mnuBuild.Click += new System.EventHandler(this.Build_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBrush,
            this.mnuBucket,
            this.mnuEyedropper});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(42, 21);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuBrush
            // 
            this.mnuBrush.Checked = true;
            this.mnuBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuBrush.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBrushSize});
            this.mnuBrush.Name = "mnuBrush";
            this.mnuBrush.Size = new System.Drawing.Size(145, 22);
            this.mnuBrush.Text = "Brush";
            this.mnuBrush.Click += new System.EventHandler(this.Tool_Click);
            // 
            // mnuBrushSize
            // 
            this.mnuBrushSize.Name = "mnuBrushSize";
            this.mnuBrushSize.Size = new System.Drawing.Size(99, 22);
            this.mnuBrushSize.Text = "Size";
            this.mnuBrushSize.Click += new System.EventHandler(this.BrushSize_Click);
            // 
            // mnuBucket
            // 
            this.mnuBucket.Name = "mnuBucket";
            this.mnuBucket.Size = new System.Drawing.Size(145, 22);
            this.mnuBucket.Text = "Bucket";
            this.mnuBucket.Click += new System.EventHandler(this.Tool_Click);
            // 
            // mnuEyedropper
            // 
            this.mnuEyedropper.Name = "mnuEyedropper";
            this.mnuEyedropper.Size = new System.Drawing.Size(145, 22);
            this.mnuEyedropper.Text = "Eyedropper";
            this.mnuEyedropper.Click += new System.EventHandler(this.Tool_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedraw,
            this.mnuCellGrid,
            this.mnuResolution});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(47, 21);
            this.mnuView.Text = "View";
            // 
            // mnuRedraw
            // 
            this.mnuRedraw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedrawMap,
            this.mnuRedrawGrid,
            this.mnuRedrawChunkGrid});
            this.mnuRedraw.Name = "mnuRedraw";
            this.mnuRedraw.Size = new System.Drawing.Size(137, 22);
            this.mnuRedraw.Text = "Redraw";
            // 
            // mnuRedrawMap
            // 
            this.mnuRedrawMap.Name = "mnuRedrawMap";
            this.mnuRedrawMap.Size = new System.Drawing.Size(141, 22);
            this.mnuRedrawMap.Text = "Map";
            this.mnuRedrawMap.Click += new System.EventHandler(this.RedrawMap_Click);
            // 
            // mnuRedrawGrid
            // 
            this.mnuRedrawGrid.Name = "mnuRedrawGrid";
            this.mnuRedrawGrid.Size = new System.Drawing.Size(141, 22);
            this.mnuRedrawGrid.Text = "Grid";
            this.mnuRedrawGrid.Click += new System.EventHandler(this.RedrawGrid_Click);
            // 
            // mnuRedrawChunkGrid
            // 
            this.mnuRedrawChunkGrid.Name = "mnuRedrawChunkGrid";
            this.mnuRedrawChunkGrid.Size = new System.Drawing.Size(141, 22);
            this.mnuRedrawChunkGrid.Text = "Chunk Grid";
            this.mnuRedrawChunkGrid.Click += new System.EventHandler(this.RedrawChunkGrid_Click);
            // 
            // mnuCellGrid
            // 
            this.mnuCellGrid.Name = "mnuCellGrid";
            this.mnuCellGrid.Size = new System.Drawing.Size(137, 22);
            this.mnuCellGrid.Text = "Cell grid";
            // 
            // mnuResolution
            // 
            this.mnuResolution.Name = "mnuResolution";
            this.mnuResolution.Size = new System.Drawing.Size(137, 22);
            this.mnuResolution.Text = "Resolution";
            this.mnuResolution.Click += new System.EventHandler(this.Resolution_Click);
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
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvColorPicker;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuCellGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuBrush;
        private System.Windows.Forms.ToolStripMenuItem mnuBrushSize;
        private System.Windows.Forms.ToolStripMenuItem mnuBuild;
        private System.Windows.Forms.ToolStripMenuItem mnuRedraw;
        private System.Windows.Forms.ToolStripMenuItem mnuRedrawMap;
        private System.Windows.Forms.ToolStripMenuItem mnuRedrawGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuRedrawChunkGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuBucket;
        private System.Windows.Forms.ToolStripMenuItem mnuResolution;
        private System.Windows.Forms.ToolStripMenuItem mnuEyedropper;
        private System.Windows.Forms.RadioButton rbColorLeft;
        private System.Windows.Forms.Panel pnlColorViewer;
        private System.Windows.Forms.RadioButton rbColorRight;
    }
}

