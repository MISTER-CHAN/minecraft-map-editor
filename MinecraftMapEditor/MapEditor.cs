using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftMapEditor
{
    public partial class MapEditor : Form
    {
        bool isPainting = false;
        Brush brush = new SolidBrush(Color.White);
        byte cellSize = 0, resolution = 1, selColor = 0;
        byte[,] colors = new byte[0x80, 0x80];
        Graphics graphics;
        float size;
        int brushSize = 1;
        Pen pen = new Pen(Color.Black);
        Color[] colorTable = new Color[0x100]
        {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(89, 125, 39),
            Color.FromArgb(109, 153, 48),
            Color.FromArgb(127, 178, 56),
            Color.FromArgb(67, 94, 29),
            Color.FromArgb(174, 164, 115),
            Color.FromArgb(213, 201, 140),
            Color.FromArgb(247, 233, 163),
            Color.FromArgb(130, 123, 86),
            Color.FromArgb(140, 140, 140),
            Color.FromArgb(171, 171, 171),
            Color.FromArgb(199, 199, 199),
            Color.FromArgb(105, 105, 105),
            Color.FromArgb(180, 0, 0),
            Color.FromArgb(220, 0, 0),
            Color.FromArgb(255, 0, 0),
            Color.FromArgb(135, 0, 0),
            Color.FromArgb(112, 112, 180),
            Color.FromArgb(138, 138, 220),
            Color.FromArgb(160, 160, 255),
            Color.FromArgb(84, 84, 135),
            Color.FromArgb(117, 117, 117),
            Color.FromArgb(144, 144, 144),
            Color.FromArgb(167, 167, 167),
            Color.FromArgb(88, 88, 88),
            Color.FromArgb(0, 87, 0),
            Color.FromArgb(0, 106, 0),
            Color.FromArgb(0, 124, 0),
            Color.FromArgb(0, 65, 0),
            Color.FromArgb(180, 180, 180),
            Color.FromArgb(220, 220, 220),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(135, 135, 135),
            Color.FromArgb(115, 118, 129),
            Color.FromArgb(141, 144, 158),
            Color.FromArgb(164, 168, 184),
            Color.FromArgb(86, 88, 97),
            Color.FromArgb(106, 76, 54),
            Color.FromArgb(130, 94, 66),
            Color.FromArgb(151, 109, 77),
            Color.FromArgb(79, 57, 40),
            Color.FromArgb(79, 79, 79),
            Color.FromArgb(96, 96, 96),
            Color.FromArgb(112, 112, 112),
            Color.FromArgb(59, 59, 59),
            Color.FromArgb(45, 45, 180),
            Color.FromArgb(55, 55, 220),
            Color.FromArgb(64, 64, 255),
            Color.FromArgb(33, 33, 135),
            Color.FromArgb(100, 84, 50),
            Color.FromArgb(123, 102, 62),
            Color.FromArgb(143, 119, 72),
            Color.FromArgb(75, 63, 38),
            Color.FromArgb(180, 177, 172),
            Color.FromArgb(220, 217, 211),
            Color.FromArgb(255, 252, 245),
            Color.FromArgb(135, 133, 129),
            Color.FromArgb(152, 89, 36),
            Color.FromArgb(186, 109, 44),
            Color.FromArgb(216, 127, 51),
            Color.FromArgb(114, 67, 27),
            Color.FromArgb(125, 53, 152),
            Color.FromArgb(153, 65, 186),
            Color.FromArgb(178, 76, 216),
            Color.FromArgb(94, 40, 114),
            Color.FromArgb(72, 108, 152),
            Color.FromArgb(88, 132, 186),
            Color.FromArgb(102, 153, 216),
            Color.FromArgb(54, 81, 114),
            Color.FromArgb(161, 161, 36),
            Color.FromArgb(197, 197, 44),
            Color.FromArgb(229, 229, 51),
            Color.FromArgb(121, 121, 27),
            Color.FromArgb(89, 144, 17),
            Color.FromArgb(109, 176, 21),
            Color.FromArgb(127, 204, 25),
            Color.FromArgb(67, 108, 13),
            Color.FromArgb(170, 89, 116),
            Color.FromArgb(208, 109, 142),
            Color.FromArgb(242, 127, 165),
            Color.FromArgb(128, 67, 87),
            Color.FromArgb(53, 53, 53),
            Color.FromArgb(65, 65, 65),
            Color.FromArgb(76, 76, 76),
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(108, 108, 108),
            Color.FromArgb(132, 132, 132),
            Color.FromArgb(153, 153, 153),
            Color.FromArgb(81, 81, 81),
            Color.FromArgb(53, 89, 108),
            Color.FromArgb(65, 109, 132),
            Color.FromArgb(76, 127, 153),
            Color.FromArgb(40, 67, 81),
            Color.FromArgb(89, 44, 125),
            Color.FromArgb(109, 54, 153),
            Color.FromArgb(127, 63, 178),
            Color.FromArgb(67, 33, 94),
            Color.FromArgb(36, 53, 125),
            Color.FromArgb(44, 65, 153),
            Color.FromArgb(51, 76, 178),
            Color.FromArgb(27, 40, 94),
            Color.FromArgb(72, 53, 36),
            Color.FromArgb(88, 65, 44),
            Color.FromArgb(102, 76, 51),
            Color.FromArgb(54, 40, 27),
            Color.FromArgb(72, 89, 36),
            Color.FromArgb(88, 109, 44),
            Color.FromArgb(102, 127, 51),
            Color.FromArgb(54, 67, 27),
            Color.FromArgb(108, 36, 36),
            Color.FromArgb(132, 44, 44),
            Color.FromArgb(153, 51, 51),
            Color.FromArgb(81, 27, 27),
            Color.FromArgb(17, 17, 17),
            Color.FromArgb(21, 21, 21),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(13, 13, 13),
            Color.FromArgb(176, 168, 54),
            Color.FromArgb(215, 205, 66),
            Color.FromArgb(250, 238, 77),
            Color.FromArgb(132, 126, 40),
            Color.FromArgb(64, 154, 150),
            Color.FromArgb(79, 188, 183),
            Color.FromArgb(92, 219, 213),
            Color.FromArgb(48, 115, 112),
            Color.FromArgb(52, 90, 180),
            Color.FromArgb(63, 110, 220),
            Color.FromArgb(74, 128, 255),
            Color.FromArgb(39, 67, 135),
            Color.FromArgb(0, 153, 40),
            Color.FromArgb(0, 187, 50),
            Color.FromArgb(0, 217, 58),
            Color.FromArgb(0, 114, 30),
            Color.FromArgb(91, 60, 34),
            Color.FromArgb(111, 74, 42),
            Color.FromArgb(129, 86, 49),
            Color.FromArgb(68, 45, 25),
            Color.FromArgb(79, 1, 0),
            Color.FromArgb(96, 1, 0),
            Color.FromArgb(112, 2, 0),
            Color.FromArgb(59, 1, 0),
            Color.FromArgb(147, 124, 113),
            Color.FromArgb(180, 152, 138),
            Color.FromArgb(209, 177, 161),
            Color.FromArgb(110, 93, 85),
            Color.FromArgb(112, 57, 25),
            Color.FromArgb(137, 70, 31),
            Color.FromArgb(159, 82, 36),
            Color.FromArgb(84, 43, 19),
            Color.FromArgb(105, 61, 76),
            Color.FromArgb(128, 75, 93),
            Color.FromArgb(149, 87, 108),
            Color.FromArgb(78, 46, 57),
            Color.FromArgb(79, 76, 97),
            Color.FromArgb(96, 93, 119),
            Color.FromArgb(112, 108, 138),
            Color.FromArgb(59, 57, 73),
            Color.FromArgb(131, 93, 25),
            Color.FromArgb(160, 114, 31),
            Color.FromArgb(186, 133, 36),
            Color.FromArgb(98, 70, 19),
            Color.FromArgb(72, 82, 37),
            Color.FromArgb(88, 100, 45),
            Color.FromArgb(103, 117, 53),
            Color.FromArgb(54, 61, 28),
            Color.FromArgb(112, 54, 55),
            Color.FromArgb(138, 66, 67),
            Color.FromArgb(160, 77, 78),
            Color.FromArgb(84, 40, 41),
            Color.FromArgb(40, 28, 24),
            Color.FromArgb(49, 35, 30),
            Color.FromArgb(57, 41, 35),
            Color.FromArgb(30, 21, 18),
            Color.FromArgb(95, 75, 69),
            Color.FromArgb(116, 92, 84),
            Color.FromArgb(135, 107, 98),
            Color.FromArgb(71, 56, 51),
            Color.FromArgb(61, 64, 64),
            Color.FromArgb(75, 79, 79),
            Color.FromArgb(87, 92, 92),
            Color.FromArgb(46, 48, 48),
            Color.FromArgb(86, 51, 62),
            Color.FromArgb(105, 62, 75),
            Color.FromArgb(122, 73, 88),
            Color.FromArgb(64, 38, 46),
            Color.FromArgb(53, 43, 64),
            Color.FromArgb(65, 53, 79),
            Color.FromArgb(76, 62, 92),
            Color.FromArgb(40, 32, 48),
            Color.FromArgb(53, 35, 24),
            Color.FromArgb(65, 43, 30),
            Color.FromArgb(76, 50, 35),
            Color.FromArgb(40, 26, 18),
            Color.FromArgb(53, 57, 29),
            Color.FromArgb(65, 70, 36),
            Color.FromArgb(76, 82, 42),
            Color.FromArgb(40, 43, 22),
            Color.FromArgb(100, 42, 32),
            Color.FromArgb(122, 51, 39),
            Color.FromArgb(142, 60, 46),
            Color.FromArgb(75, 31, 24),
            Color.FromArgb(26, 15, 11),
            Color.FromArgb(31, 18, 13),
            Color.FromArgb(37, 22, 16),
            Color.FromArgb(19, 11, 8),
            Color.FromArgb(133, 33, 34),
            Color.FromArgb(163, 41, 42),
            Color.FromArgb(189, 48, 49),
            Color.FromArgb(100, 25, 25),
            Color.FromArgb(104, 44, 68),
            Color.FromArgb(127, 54, 83),
            Color.FromArgb(148, 63, 97),
            Color.FromArgb(78, 33, 51),
            Color.FromArgb(64, 17, 20),
            Color.FromArgb(79, 21, 25),
            Color.FromArgb(92, 25, 29),
            Color.FromArgb(48, 13, 15),
            Color.FromArgb(15, 88, 94),
            Color.FromArgb(18, 108, 115),
            Color.FromArgb(22, 126, 134),
            Color.FromArgb(11, 66, 70),
            Color.FromArgb(40, 100, 98),
            Color.FromArgb(50, 122, 120),
            Color.FromArgb(58, 142, 140),
            Color.FromArgb(30, 75, 74),
            Color.FromArgb(60, 31, 43),
            Color.FromArgb(74, 37, 53),
            Color.FromArgb(86, 44, 62),
            Color.FromArgb(45, 23, 32),
            Color.FromArgb(14, 127, 93),
            Color.FromArgb(17, 155, 114),
            Color.FromArgb(20, 180, 133),
            Color.FromArgb(10, 95, 70),
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(74, 74, 74),
            Color.FromArgb(86, 86, 86),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(131, 105, 88),
            Color.FromArgb(160, 129, 108),
            Color.FromArgb(186, 150, 126),
            Color.FromArgb(98, 79, 66),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255)
        };

        private void BrushSize_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Brush Size", "Map Editor", brushSize + "");
            if (s != "")
                brushSize = int.Parse(s);
        }

        private void Build_Click(object sender, EventArgs e)
        {
            string s = "";
            for (byte y = 0; y < 0x80; y++)
            {
                for (byte x = 0; x < 0x80; x++)
                {
                    s += colors[x, y] < 0x80 ? colors[x, y] : colors[x, y] - 0x100;
                    if ((x + 1) % 0x10 > 0)
                        s += "  ";
                    else
                        s += "\r\n";
                }
            }
            Clipboard.SetText(s.Substring(0, s.Length - 1));
            MessageBox.Show("Done! Saved to clipboard.", "Map Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (brush != null)
                brush.Dispose();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    selColor = byte.Parse(lblColorLeft.Text);
                    break;
                case MouseButtons.Right:
                    selColor = byte.Parse(lblColorRight.Text);
                    break;
            }
            brush = new SolidBrush(colorTable[selColor]);
            if (rbBucket.Checked)
            {
                byte c = colors[(byte)((float)e.X / picCanvas.ClientRectangle.Width * 0x80),
                    (byte)((float)e.Y / picCanvas.ClientRectangle.Height * 0x80)];
                for (byte y = 0; y < 0x80; y++)
                    for (byte x = 0; x < 0x80; x++)
                    {
                        if (colors[x, y] == c)
                        {
                            colors[x, y] = selColor;
                            graphics.FillRectangle(brush, new RectangleF(x * size, y * size, size, size));
                        }
                    }
            }
            else
            {
                isPainting = true;
                Canvas_MouseMove(sender, e);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)((float)e.X / picCanvas.ClientRectangle.Width * 0x80),
                y = (int)((float)e.Y / picCanvas.ClientRectangle.Height * 0x80);
            lblPos.Text = $"({x - 0x40}, {y - 0x40})";
            if (isPainting && !rbBucket.Checked)
            {
                if (0 <= e.X && e.X < picCanvas.ClientRectangle.Width && 0 <= e.Y && e.Y < picCanvas.ClientRectangle.Height)
                {
                    if (rbBrush.Checked)
                    {
                        byte left = (byte)((byte)(x / resolution - brushSize / 2) * resolution),
                            top = (byte)((byte)(y / resolution - brushSize / 2) * resolution);
                        for (byte by = top; by < top + brushSize * resolution; by++)
                        {
                            if (by >= 0x80)
                                break;
                            for (byte bx = left; bx < left + brushSize * resolution; bx++)
                            {
                                if (bx >= 0x80)
                                    break;
                                colors[bx, by] = selColor;
                            }
                        }
                        graphics.FillRectangle(brush, new RectangleF(left * size, top * size, brushSize * size * resolution, brushSize * size * resolution));
                    }
                    else if (rbEyedropper.Checked)
                    {
                        byte color = colors[(byte)((float)e.X / picCanvas.ClientRectangle.Width * 0x80), (byte)((float)e.Y / picCanvas.ClientRectangle.Height * 0x80)];
                        switch (e.Button)
                        {
                            case MouseButtons.Left:
                                lblColorLeft.Text = color + "";
                                lblColorLeft.BackColor = colorTable[color];
                                break;
                            case MouseButtons.Right:
                                lblColorRight.Text = color + "";
                                lblColorRight.BackColor = colorTable[color];
                                break;
                        }
                    }
                }
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
        }

        private void CellGrid_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Cell size", "Cell grid", cellSize + "");
            if (s != "")
            {
                cellSize = byte.Parse(s);
                RedrawCellGrid();
            }
        }

        private void ColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvColorPicker.SelectedItems.Count > 0)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        lblColorLeft.Text = lvColorPicker.SelectedItems[0].Text;
                        lblColorLeft.BackColor = lvColorPicker.SelectedItems[0].BackColor;
                        break;
                    case MouseButtons.Right:
                        lblColorRight.Text = lvColorPicker.SelectedItems[0].Text;
                        lblColorRight.BackColor = lvColorPicker.SelectedItems[0].BackColor;
                        break;
                }
            }
        }

        private void ColorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author\tMISTER_CHAN\nWebsite\thttps://github.com/MISTER-CHAN/MinecraftMapEditor", "Credits");
        }

        private void MapEditor_Resize(object sender, EventArgs e)
        {
            ResizeCanvas();
        }

        public MapEditor()
        {
            InitializeComponent();
            for (int i = 0; i < colorTable.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(i + "")
                {
                    BackColor = colorTable[i]
                };
                lvColorPicker.Items.Add(lvi);
            }
            lvColorPicker.Items[0].Selected = true;
            ResizeCanvas();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Format:\n<Decimal color ID>  <Decimal color ID>  ... (16 per line)\n<Decimal color ID>  <Decimal color ID>  ... (16 per line)\n... (1024 lines in total)\n\nPaste colors:", "Open", Clipboard.GetText());
            if (s != "")
            {
                s = Clipboard.GetText();
                byte[][] colors = Regex.Matches(s + "\r\n", "(([0-9-]+  ){15}[0-9-]+\\r\\n){8}").Cast<Match>().Select(m1 => Regex.Matches(m1.Value, "[0-9-]+").Cast<Match>().Select(m2 => m2.Value[0] == '-' ? (byte)(0x100 + short.Parse(m2.Value)) : byte.Parse(m2.Value)).ToArray()).ToArray();
                for (byte y = 0; y < 0x80; y++)
                    for (byte x = 0; x < 0x80; x++)
                        this.colors[x, y] = colors[y][x];
                RedrawMap();
            }
        }

        void RedrawCellGrid()
        {
            if (cellSize > 0)
            {
                pen.Color = Color.Red;
                for (int i = 0; i < 0x80; i += cellSize * resolution)
                {
                    graphics.DrawLine(pen, new PointF(size * i, 0), new PointF(size * i, picCanvas.ClientRectangle.Height));
                    graphics.DrawLine(pen, new PointF(0, size * i), new PointF(picCanvas.ClientRectangle.Width, size * i));
                }
            }
        }

        private void RedrawCellGrid_Click(object sender, EventArgs e)
        {
            RedrawCellGrid();
        }

        private void RedrawChunkGrid_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            for (byte b = 0; b < 0x10; b++)
            {
                graphics.DrawLine(pen, new PointF(size * 0x10 * b, 0), new PointF(size * 0x10 * b, picCanvas.ClientRectangle.Height));
                graphics.DrawLine(pen, new PointF(0, size * 0x10 * b), new PointF(picCanvas.ClientRectangle.Width, size * 0x10 * b));
            }
        }

        private void RedrawGrid_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
            for (byte b = 0; b < 0x80 / resolution; b++)
            {
                graphics.DrawLine(pen, new PointF(size * resolution * b, 0), new PointF(size * resolution * b, picCanvas.ClientRectangle.Height));
                graphics.DrawLine(pen, new PointF(0, size * resolution * b), new PointF(picCanvas.ClientRectangle.Width, size * resolution * b));
            }
        }

        void RedrawMap()
        {
            for (byte y = 0; y < 0x80; y++)
                for (byte x = 0; x < 0x80; x++)
                {
                    graphics.FillRectangle(new SolidBrush(colorTable[colors[x, y]]), size * x, size * y, size, size);
                }
        }

        private void RedrawMap_Click(object sender, EventArgs e)
        {
            RedrawMap();
        }

        void ResizeCanvas()
        {
            int height = ClientRectangle.Height - menuStrip.Height - statusStrip.Height;
            rbBrush.Size = rbEyedropper.Size;
            rbBucket.Size = rbEyedropper.Size;
            rbBucket.Top = rbBrush.Height;
            rbEyedropper.Top = rbBucket.Top + rbBucket.Height;
            pnlTools.Size = new Size(rbEyedropper.Width, rbEyedropper.Top + rbEyedropper.Height);
            pnlTools.Top = menuStrip.Height;
            picCanvas.Size = new Size(height, height);
            picCanvas.Location = new Point(pnlTools.Width, menuStrip.Height);
            size = (float)picCanvas.ClientRectangle.Height / 0x80;
            pnlColorViewer.Location = new Point(picCanvas.Left + picCanvas.Width, menuStrip.Height);
            pnlColorViewer.Width = ClientRectangle.Width - picCanvas.Left - picCanvas.Width;
            lblColorLeft.Width = pnlColorViewer.Width / 2;
            lblColorRight.Width = pnlColorViewer.Width / 2;
            lblColorRight.Left = pnlColorViewer.Width / 2;
            lvColorPicker.Location = new Point(picCanvas.Left + picCanvas.Width, menuStrip.Height + pnlColorViewer.Height);
            lvColorPicker.Size = new Size(pnlColorViewer.Width, height - pnlColorViewer.Height);
            if (graphics != null)
            {
                graphics.Flush();
                graphics.Dispose();
            }
            graphics = picCanvas.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void Resolution_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem mi in miResolution.DropDownItems)
                mi.Checked = false;
            ToolStripMenuItem menuItem = ((ToolStripMenuItem)sender);
            resolution = byte.Parse(menuItem.Tag + "");
            menuItem.Checked = true;
        }

        private void Usage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See https://github.com/MISTER-CHAN/MinecraftMapEditor", "Usage");
        }
    }
}
