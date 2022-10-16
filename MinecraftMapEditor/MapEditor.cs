using Microsoft.VisualBasic;
using Substrate.Core;
using Substrate.Nbt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftMapEditor
{
    public partial class MapEditor : Form
    {
        private Bitmap _bitmap;
        private bool _isPainting = false;
        private Brush _brush = new SolidBrush(Color.White);
        private byte _cellSize = 0, _resolution = 1, _selColor = 0;
        private byte[] _colors = new byte[0x4000];
        private float _scale;
        private Graphics _graphics;
        private int _brushSize = 1;
        private int _xCenter, _zCenter;
        private Dictionary<Point, Banner> _bannerDict = new();
        private NBTFile _file;
        private NbtTree _tree;
        private readonly Pen _pen = new(Color.Black);
        private TagNodeList _banners = new(TagType.TAG_COMPOUND);

        private readonly Color[] colorTable = new Color[0x100]
        {
            Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), // 0
            Color.FromArgb(89, 125, 39), Color.FromArgb(109, 153, 48), Color.FromArgb(127, 178, 56), Color.FromArgb(67, 94, 29), // 1
            Color.FromArgb(174, 164, 115), Color.FromArgb(213, 201, 140), Color.FromArgb(247, 233, 163), Color.FromArgb(130, 123, 86), // 2
            Color.FromArgb(140, 140, 140), Color.FromArgb(171, 171, 171), Color.FromArgb(199, 199, 199), Color.FromArgb(105, 105, 105), // 3
            Color.FromArgb(180, 0, 0), Color.FromArgb(220, 0, 0), Color.FromArgb(255, 0, 0), Color.FromArgb(135, 0, 0), // 4
            Color.FromArgb(112, 112, 180), Color.FromArgb(138, 138, 220), Color.FromArgb(160, 160, 255), Color.FromArgb(84, 84, 135), // 5
            Color.FromArgb(117, 117, 117), Color.FromArgb(144, 144, 144), Color.FromArgb(167, 167, 167), Color.FromArgb(88, 88, 88), // 6
            Color.FromArgb(0, 87, 0), Color.FromArgb(0, 106, 0), Color.FromArgb(0, 124, 0), Color.FromArgb(0, 65, 0), // 7
            Color.FromArgb(180, 180, 180), Color.FromArgb(220, 220, 220), Color.FromArgb(255, 255, 255), Color.FromArgb(135, 135, 135), // 8
            Color.FromArgb(115, 118, 129), Color.FromArgb(141, 144, 158), Color.FromArgb(164, 168, 184), Color.FromArgb(86, 88, 97), // 9
            Color.FromArgb(106, 76, 54), Color.FromArgb(130, 94, 66), Color.FromArgb(151, 109, 77), Color.FromArgb(79, 57, 40), // 10
            Color.FromArgb(79, 79, 79), Color.FromArgb(96, 96, 96), Color.FromArgb(112, 112, 112), Color.FromArgb(59, 59, 59), // 11
            Color.FromArgb(45, 45, 180), Color.FromArgb(55, 55, 220), Color.FromArgb(64, 64, 255), Color.FromArgb(33, 33, 135), // 12
            Color.FromArgb(100, 84, 50), Color.FromArgb(123, 102, 62), Color.FromArgb(143, 119, 72), Color.FromArgb(75, 63, 38), // 13
            Color.FromArgb(180, 177, 172), Color.FromArgb(220, 217, 211), Color.FromArgb(255, 252, 245), Color.FromArgb(135, 133, 129), // 14
            Color.FromArgb(152, 89, 36), Color.FromArgb(186, 109, 44), Color.FromArgb(216, 127, 51), Color.FromArgb(114, 67, 27), // 15
            Color.FromArgb(125, 53, 152), Color.FromArgb(153, 65, 186), Color.FromArgb(178, 76, 216), Color.FromArgb(94, 40, 114), // 16
            Color.FromArgb(72, 108, 152), Color.FromArgb(88, 132, 186), Color.FromArgb(102, 153, 216), Color.FromArgb(54, 81, 114), // 17
            Color.FromArgb(161, 161, 36), Color.FromArgb(197, 197, 44), Color.FromArgb(229, 229, 51), Color.FromArgb(121, 121, 27), // 18
            Color.FromArgb(89, 144, 17), Color.FromArgb(109, 176, 21), Color.FromArgb(127, 204, 25), Color.FromArgb(67, 108, 13), // 19
            Color.FromArgb(170, 89, 116), Color.FromArgb(208, 109, 142), Color.FromArgb(242, 127, 165), Color.FromArgb(128, 67, 87), // 20
            Color.FromArgb(53, 53, 53), Color.FromArgb(65, 65, 65), Color.FromArgb(76, 76, 76), Color.FromArgb(40, 40, 40), // 21
            Color.FromArgb(108, 108, 108), Color.FromArgb(132, 132, 132), Color.FromArgb(153, 153, 153), Color.FromArgb(81, 81, 81), // 22
            Color.FromArgb(53, 89, 108), Color.FromArgb(65, 109, 132), Color.FromArgb(76, 127, 153), Color.FromArgb(40, 67, 81), // 23
            Color.FromArgb(89, 44, 125), Color.FromArgb(109, 54, 153), Color.FromArgb(127, 63, 178), Color.FromArgb(67, 33, 94), // 24
            Color.FromArgb(36, 53, 125), Color.FromArgb(44, 65, 153), Color.FromArgb(51, 76, 178), Color.FromArgb(27, 40, 94), // 25
            Color.FromArgb(72, 53, 36), Color.FromArgb(88, 65, 44), Color.FromArgb(102, 76, 51), Color.FromArgb(54, 40, 27), // 26
            Color.FromArgb(72, 89, 36), Color.FromArgb(88, 109, 44), Color.FromArgb(102, 127, 51), Color.FromArgb(54, 67, 27), // 27
            Color.FromArgb(108, 36, 36), Color.FromArgb(132, 44, 44), Color.FromArgb(153, 51, 51), Color.FromArgb(81, 27, 27), // 28
            Color.FromArgb(17, 17, 17), Color.FromArgb(21, 21, 21), Color.FromArgb(25, 25, 25), Color.FromArgb(13, 13, 13), // 29
            Color.FromArgb(176, 168, 54), Color.FromArgb(215, 205, 66), Color.FromArgb(250, 238, 77), Color.FromArgb(132, 126, 40), // 30
            Color.FromArgb(64, 154, 150), Color.FromArgb(79, 188, 183), Color.FromArgb(92, 219, 213), Color.FromArgb(48, 115, 112), // 31
            Color.FromArgb(52, 90, 180), Color.FromArgb(63, 110, 220), Color.FromArgb(74, 128, 255), Color.FromArgb(39, 67, 135), // 32
            Color.FromArgb(0, 153, 40), Color.FromArgb(0, 187, 50), Color.FromArgb(0, 217, 58), Color.FromArgb(0, 114, 30), // 33
            Color.FromArgb(91, 60, 34), Color.FromArgb(111, 74, 42), Color.FromArgb(129, 86, 49), Color.FromArgb(68, 45, 25), // 34
            Color.FromArgb(79, 1, 0), Color.FromArgb(96, 1, 0), Color.FromArgb(112, 2, 0), Color.FromArgb(59, 1, 0), // 35
            Color.FromArgb(147, 124, 113), Color.FromArgb(180, 152, 138), Color.FromArgb(209, 177, 161), Color.FromArgb(110, 93, 85), // 36
            Color.FromArgb(112, 57, 25), Color.FromArgb(137, 70, 31), Color.FromArgb(159, 82, 36), Color.FromArgb(84, 43, 19), // 37
            Color.FromArgb(105, 61, 76), Color.FromArgb(128, 75, 93), Color.FromArgb(149, 87, 108), Color.FromArgb(78, 46, 57), // 38
            Color.FromArgb(79, 76, 97), Color.FromArgb(96, 93, 119), Color.FromArgb(112, 108, 138), Color.FromArgb(59, 57, 73), // 39
            Color.FromArgb(131, 93, 25), Color.FromArgb(160, 114, 31), Color.FromArgb(186, 133, 36), Color.FromArgb(98, 70, 19), // 40
            Color.FromArgb(72, 82, 37), Color.FromArgb(88, 100, 45), Color.FromArgb(103, 117, 53), Color.FromArgb(54, 61, 28), // 41
            Color.FromArgb(112, 54, 55), Color.FromArgb(138, 66, 67), Color.FromArgb(160, 77, 78), Color.FromArgb(84, 40, 41), // 42
            Color.FromArgb(40, 28, 24), Color.FromArgb(49, 35, 30), Color.FromArgb(57, 41, 35), Color.FromArgb(30, 21, 18), // 43
            Color.FromArgb(95, 75, 69), Color.FromArgb(116, 92, 84), Color.FromArgb(135, 107, 98), Color.FromArgb(71, 56, 51), // 44
            Color.FromArgb(61, 64, 64), Color.FromArgb(75, 79, 79), Color.FromArgb(87, 92, 92), Color.FromArgb(46, 48, 48), // 45
            Color.FromArgb(86, 51, 62), Color.FromArgb(105, 62, 75), Color.FromArgb(122, 73, 88), Color.FromArgb(64, 38, 46), // 46
            Color.FromArgb(53, 43, 64), Color.FromArgb(65, 53, 79), Color.FromArgb(76, 62, 92), Color.FromArgb(40, 32, 48), // 47
            Color.FromArgb(53, 35, 24), Color.FromArgb(65, 43, 30), Color.FromArgb(76, 50, 35), Color.FromArgb(40, 26, 18), // 48
            Color.FromArgb(53, 57, 29), Color.FromArgb(65, 70, 36), Color.FromArgb(76, 82, 42), Color.FromArgb(40, 43, 22), // 49
            Color.FromArgb(100, 42, 32), Color.FromArgb(122, 51, 39), Color.FromArgb(142, 60, 46), Color.FromArgb(75, 31, 24), // 50
            Color.FromArgb(26, 15, 11), Color.FromArgb(31, 18, 13), Color.FromArgb(37, 22, 16), Color.FromArgb(19, 11, 8), // 51
            Color.FromArgb(133, 33, 34), Color.FromArgb(163, 41, 42), Color.FromArgb(189, 48, 49), Color.FromArgb(100, 25, 25), // 52
            Color.FromArgb(104, 44, 68), Color.FromArgb(127, 54, 83), Color.FromArgb(148, 63, 97), Color.FromArgb(78, 33, 51), // 53
            Color.FromArgb(64, 17, 20), Color.FromArgb(79, 21, 25), Color.FromArgb(92, 25, 29), Color.FromArgb(48, 13, 15), // 54
            Color.FromArgb(15, 88, 94), Color.FromArgb(18, 108, 115), Color.FromArgb(22, 126, 134), Color.FromArgb(11, 66, 70), // 55
            Color.FromArgb(40, 100, 98), Color.FromArgb(50, 122, 120), Color.FromArgb(58, 142, 140), Color.FromArgb(30, 75, 74), // 56
            Color.FromArgb(60, 31, 43), Color.FromArgb(74, 37, 53), Color.FromArgb(86, 44, 62), Color.FromArgb(45, 23, 32), // 57
            Color.FromArgb(14, 127, 93), Color.FromArgb(17, 155, 114), Color.FromArgb(20, 180, 133), Color.FromArgb(10, 95, 70), // 58
            Color.FromArgb(70, 70, 70), Color.FromArgb(86, 86, 86), Color.FromArgb(100, 100, 100), Color.FromArgb(52, 52, 52), // 59
            Color.FromArgb(152, 123, 59), Color.FromArgb(186, 150, 126), Color.FromArgb(216, 175, 147), Color.FromArgb(114, 92, 77), // 60
            Color.FromArgb(89, 117, 105), Color.FromArgb(109, 144, 129), Color.FromArgb(127, 167, 150), Color.FromArgb(67, 88, 79), // 61
            Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255)
        };

        public MapEditor()
        {
            InitializeComponent();

            for (int i = 0; i < colorTable.Length; ++i)
            {
                ListViewItem lvi = new(i.ToString())
                {
                    BackColor = colorTable[i]
                };
                _lstColorPicker.Items.Add(lvi);
            }
            _lstColorPicker.Items[0].Selected = true;

            ResizeForm();

            _bitmap = new(_pictureBox.ClientRectangle.Width, _pictureBox.ClientRectangle.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            _pictureBox.Image = _bitmap;

            RedrawGrids();

            _rdoBrush_CheckedChanged(_rdoBrush, null);
        }

        private void _itmBrushSize_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Brush Size", "Map Editor", _brushSize.ToString());
            if (s != "")
                _brushSize = int.Parse(s);
        }

        private void _itmCellGrid_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Cell size", "Cell grid", _cellSize.ToString());
            if (s != "")
            {
                _cellSize = byte.Parse(s);
                RedrawCellGrid();
            }
        }

        private void _itmOpen_Click(object sender, EventArgs e)
        {
            if (!Open())
                MessageBox.Show("Failed.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _itmResolution_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem itm in _itmResolution.DropDownItems)
                itm.Checked = false;
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            _resolution = byte.Parse(menuItem.Tag.ToString());
            menuItem.Checked = true;
        }

        private void _itmSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void _itmUsage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See https://github.com/MISTER-CHAN/minecraft-map-editor", "Usage");
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author\tMISTER_CHAN\nWebsite\thttps://github.com/MISTER-CHAN/minecraft-map-editor", "Credits");
        }

        private int IndexOf(byte x, byte y) => x + y * 0x80;

        private T Lookup<T>(TagNodeCompound compound, string key) where T : TagNode
        {
            if (compound == null)
                return default;

            for (int i = 0; i < compound.Count; ++i)
                if (compound.Keys.ElementAt(i) == key)
                    return compound.Values.ElementAt(i) is T t ? t : default;

            return default;
        }

        private void _lstColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (_lstColorPicker.SelectedItems.Count > 0)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        _lblColorLeft.Text = _lstColorPicker.SelectedItems[0].Text;
                        _lblColorLeft.BackColor = _lstColorPicker.SelectedItems[0].BackColor;
                        break;
                    case MouseButtons.Right:
                        _lblColorRight.Text = _lstColorPicker.SelectedItems[0].Text;
                        _lblColorRight.BackColor = _lstColorPicker.SelectedItems[0].BackColor;
                        break;
                }
            }
        }

        private void MapEditor_Resize(object sender, EventArgs e)
        {
            ResizeForm();
            if (WindowState == FormWindowState.Maximized)
                ResizeFormEnd();

        }

        private void MapEditor_ResizeEnd(object sender, EventArgs e)
        {
            ResizeFormEnd();
        }

        private void MapEditor_SizeChanged(object sender, EventArgs e)
        {

        }

        private bool Open()
        {
            OpenFileDialog ofd = new()
            {
                RestoreDirectory = true,
                Filter = "NBT Files (*.dat)|*.dat",
                Title = "Open"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
                return true;

            _file = new(ofd.FileName);
            _tree = new();
            _tree.ReadFrom(_file.GetDataInputStream(CompressionType.GZip));

            TagNodeCompound root = _tree.Root;
            if (root == null) return false;

            TagNodeCompound data = Lookup<TagNodeCompound>(root, "data");
            if (data == null) return false;

            TagNodeByteArray colors = Lookup<TagNodeByteArray>(data, "colors");
            if (colors == null) return false;

            TagNodeInt xCenter = Lookup<TagNodeInt>(data, "xCenter");
            if (xCenter == null) return false;
            _xCenter = xCenter.Data;

            TagNodeInt zCenter = Lookup<TagNodeInt>(data, "zCenter");
            if (zCenter == null) return false;
            _zCenter = zCenter.Data;

            TagNodeByte scale = Lookup<TagNodeByte>(data, "scale");
            if (scale == null) return false;
            if (scale.Data == 0)
            {
                _rdoBanner.Enabled = true;
            }
            else
            {
                _rdoBanner.Enabled = false;
                MessageBox.Show("Banners cannot be edited while the scale is not 1:1.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            TagNodeByte locked = Lookup<TagNodeByte>(data, "locked");
            if (locked == null) data.Add("locked", new TagNodeByte(1));
            else if (locked != 1) locked.Data = 1;

            if (scale.Data == 0)
            {
                _banners = Lookup<TagNodeList>(data, "banners");
                if (_banners == null)
                {
                    _banners = new(TagType.TAG_COMPOUND);
                    data.Add("banners", _banners);
                    _bannerDict = new();
                }
                else
                {
                    _bannerDict = new();

                    foreach (TagNodeCompound banner in _banners.Cast<TagNodeCompound>())
                    {
                        TagNodeCompound pos = Lookup<TagNodeCompound>(banner, "Pos");
                        if (pos == null) continue;
                        TagNodeInt x = Lookup<TagNodeInt>(pos, "X");
                        if (x == null) continue;
                        TagNodeInt z = Lookup<TagNodeInt>(pos, "Z");
                        if (z == null) continue;
                        TagNodeString color = Lookup<TagNodeString>(banner, "Color");
                        if (color == null) continue;
                        TagNodeString name = Lookup<TagNodeString>(banner, "Name");
                        if (name == null) continue;

                        _bannerDict.Add(new(x, z), new() { banner = banner, color = color, name = name });
                    }
                }
            }
            else
            {
                _banners = new(TagType.TAG_COMPOUND);
                _bannerDict = new();
            }

            if (colors.Length != 0x4000)
                return false;

            _colors = colors.Data;

            Redraw();

            return true;
        }

        private void _pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_brush != null)
                _brush.Dispose();
        }

        private void _pictureBox_MouseDownWithBanner(object sender, MouseEventArgs e)
        {
            byte ux = ToUnscaled(e.X), uy = ToUnscaled(e.Y);
            int x = ux + (_xCenter - 0x40), z = uy + (_zCenter - 0x40);
            Point p = new(x, z);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if (_bannerDict.TryGetValue(p, out Banner banner))
                        {
                            _txtBannerName.Text = banner.name.Data;
                            _lstBannerColor.SelectedItem = banner.color.Data;
                        }
                        else if (_lstBannerColor.SelectedItem != null)
                        {
                            TagNodeString color = new((string)_lstBannerColor.SelectedItem);
                            TagNodeString name = new(_txtBannerName.Text);

                            TagNodeCompound node = new()
                            {
                                { "Color", color },
                                { "Name", name },
                                { "Pos",
                                    new TagNodeCompound()
                                    {
                                        { "X", new TagNodeInt(x) },
                                        { "Y", new TagNodeInt(0) },
                                        { "Z", new TagNodeInt(z) }
                                    }
                                }
                            };

                            _bannerDict.Add(p, new() { banner = node, color = color, name = name });
                            _banners.Add(node);

                            DrawBanner(ux, uy);
                            _pictureBox.Invalidate();
                        }
                        break;
                    }
                case MouseButtons.Right:
                    {
                        if (_bannerDict.TryGetValue(p, out Banner banner))
                        {
                            _bannerDict.Remove(p);
                            _banners.Remove(banner.banner);

                            _graphics.FillRectangle(new SolidBrush(colorTable[_colors[IndexOf(ux, uy)]]), _scale * ux, _scale * uy, _scale, _scale);
                            RedrawGrids();
                        }
                        break;
                    }

            }
        }

        private void _pictureBox_MouseDownWithBrush(object sender, MouseEventArgs e)
        {
            _isPainting = true;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    _selColor = byte.Parse(_lblColorLeft.Text);
                    break;

                case MouseButtons.Right:
                    _selColor = byte.Parse(_lblColorRight.Text);
                    break;
            }

            _brush = new SolidBrush(colorTable[_selColor]);

            _pictureBox_MouseMoveWithBrush(sender, e);
        }

        private void _pictureBox_MouseDownWithBucket(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    _selColor = byte.Parse(_lblColorLeft.Text);
                    break;

                case MouseButtons.Right:
                    _selColor = byte.Parse(_lblColorRight.Text);
                    break;
            }

            _brush = new SolidBrush(colorTable[_selColor]);

            byte color = _colors[ToUnscaled(e.X) + ToUnscaled(e.Y)];

            for (byte y = 0; y < 0x80; ++y)
            {
                for (byte x = 0; x < 0x80; ++x)
                {
                    if (_colors[IndexOf(x, y)] == color)
                    {
                        _colors[IndexOf(x, y)] = _selColor;
                        _graphics.FillRectangle(_brush, x * _scale, y * _scale, _scale, _scale);
                    }
                }
            }

            Redraw();
        }

        private void _pictureBox_MouseDownWithEyedropper(object sender, MouseEventArgs e)
        {
            _isPainting = true;
            _pictureBox_MouseMoveWithEyedropper(sender, e);
        }

        private void _pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            byte x = ToUnscaled(e.X), y = ToUnscaled(e.Y);
            _lblPos.Text = $"({x - 0x40}, {y - 0x40})";

        }

        private void _pictureBox_MouseMoveWithBrush(object sender, MouseEventArgs e)
        {
            if (!_isPainting)
                return;

            if (!(0 <= e.X && e.X < _bitmap.Width && 0 <= e.Y && e.Y < _bitmap.Height))
                return;

            byte x = ToUnscaled(e.X), y = ToUnscaled(e.Y);

            byte left = (byte)Math.Max(0, (x / _resolution - (_brushSize >> 1)) * _resolution),
                top = (byte)Math.Max(0, (y / _resolution - (_brushSize >> 1)) * _resolution),
                right = (byte)Math.Min(top + _brushSize * _resolution, 0x80),
                bottom = (byte)Math.Min(left + _brushSize * _resolution, 0x80);

            for (byte by = top; by < right; ++by)
                for (byte bx = left; bx < bottom; ++bx)
                    _colors[IndexOf(bx, by)] = _selColor;

            _graphics.FillRectangle(_brush, left * _scale, top * _scale, _brushSize * _scale * _resolution, _brushSize * _scale * _resolution);

            RedrawGrids();
        }

        private void _pictureBox_MouseMoveWithEyedropper(object sender, MouseEventArgs e)
        {
            if (!_isPainting)
                return;

            if (!(0 <= e.X && e.X < _bitmap.Width && 0 <= e.Y && e.Y < _bitmap.Height))
                return;

            byte x = ToUnscaled(e.X), y = ToUnscaled(e.Y);

            byte color = _colors[IndexOf(x, y)];
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _lblColorLeft.Text = color.ToString();
                    _lblColorLeft.BackColor = colorTable[color];
                    break;

                case MouseButtons.Right:
                    _lblColorRight.Text = color.ToString();
                    _lblColorRight.BackColor = colorTable[color];
                    break;
            }
        }

        private void _pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isPainting = false;
        }

        private void _rdoBanner_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _pnlBanners.BringToFront();
                _pictureBox.MouseDown += _pictureBox_MouseDownWithBanner;
            }
            else
            {
                _pnlBanners.SendToBack();
                _pictureBox.MouseDown -= _pictureBox_MouseDownWithBanner;
            }
        }

        private void _rdoBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _pictureBox.MouseDown += _pictureBox_MouseDownWithBrush;
                _pictureBox.MouseMove += _pictureBox_MouseMoveWithBrush;
            }
            else
            {
                _pictureBox.MouseDown -= _pictureBox_MouseDownWithBrush;
                _pictureBox.MouseMove -= _pictureBox_MouseMoveWithBrush;
            }
        }

        private void _rdoBucket_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _pictureBox.MouseDown += _pictureBox_MouseDownWithBucket;
            }
            else
            {
                _pictureBox.MouseDown -= _pictureBox_MouseDownWithBucket;
            }
        }

        private void _rdoEyedropper_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _pictureBox.MouseDown += _pictureBox_MouseDownWithEyedropper;
                _pictureBox.MouseMove += _pictureBox_MouseMoveWithEyedropper;
            }
            else
            {
                _pictureBox.MouseDown -= _pictureBox_MouseDownWithEyedropper;
                _pictureBox.MouseMove -= _pictureBox_MouseMoveWithEyedropper;
            }
        }

        private void Redraw()
        {
            RedrawMap();
            RedrawGrid();
            RedrawChunkGrid();
            RedrawCellGrid();
            RedrawBanners();
        }

        private void DrawBanner(byte x, byte y)
        {
            _pen.Color = Color.Red;

            _graphics.DrawLine(_pen, ToScaled(x), ToScaled(y), ToScaled((byte)(x + 1)), ToScaled((byte)(y + 1)));
            _graphics.DrawLine(_pen, ToScaled((byte)(x + 1)), ToScaled(y), ToScaled(x), ToScaled((byte)(y + 1)));
        }

        private void RedrawBanners()
        {
            foreach (KeyValuePair<Point, Banner> banner in _bannerDict)
                DrawBanner((byte)(banner.Key.X - (_xCenter - 0x40)), (byte)(banner.Key.Y - (_zCenter - 0x40)));

            _pictureBox.Invalidate();
        }

        private void RedrawCellGrid()
        {
            if (_cellSize <= 0)
                return;

            _pen.Color = Color.Red;
            for (int i = 0; i < 0x80; i += _cellSize * _resolution)
            {
                _graphics.DrawLine(_pen, _scale * i, 0.0f,_scale * i, _bitmap.Height);
                _graphics.DrawLine(_pen, 0.0f, _scale * i, _bitmap.Width, _scale * i);
            }

            _pictureBox.Invalidate();
        }

        private void RedrawChunkGrid()
        {
            _pen.Color = Color.Black;
            for (byte b = 0; b < 0x10; ++b)
            {
                _graphics.DrawLine(_pen, _scale * 0x10 * b, 0.0f,_scale * 0x10 * b, _bitmap.Height);
                _graphics.DrawLine(_pen, 0.0f, _scale * 0x10 * b, _bitmap.Width, _scale * 0x10 * b);
            }

            _pictureBox.Invalidate();
        }

        private void RedrawGrid()
        {
            _pen.Color = Color.Gray;
            for (byte b = 0; b < 0x80 / _resolution; ++b)
            {
                _graphics.DrawLine(_pen, _scale * _resolution * b, 0.0f, _scale * _resolution * b, _bitmap.Height);
                _graphics.DrawLine(_pen, 0.0f, _scale * _resolution * b, _bitmap.Width, _scale * _resolution * b);
            }

            _pictureBox.Invalidate();
        }

        private void RedrawGrids()
        {
            RedrawGrid();
            RedrawChunkGrid();
            RedrawCellGrid();
            RedrawBanners();
        }

        void RedrawMap()
        {
            for (byte y = 0; y < 0x80; ++y)
                for (byte x = 0; x < 0x80; ++x)
                    _graphics.FillRectangle(new SolidBrush(colorTable[_colors[IndexOf(x, y)]]), _scale * x, _scale * y, _scale, _scale);

            _pictureBox.Invalidate();
        }

        void ResizeForm()
        {
            int height = ClientRectangle.Height - _menuStrip.Height - _statusStrip.Height;
            _rdoBrush.Size = _rdoEyedropper.Size;
            _rdoBucket.Size = _rdoEyedropper.Size;
            _rdoBanner.Size = _rdoEyedropper.Size;
            _rdoBucket.Top = _rdoBrush.Height;
            _rdoEyedropper.Top = _rdoBucket.Top + _rdoBucket.Height;
            _rdoBanner.Top = _rdoEyedropper.Top + _rdoEyedropper.Height;
            _pnlTools.Size = new(_rdoEyedropper.Width, height);
            _pnlTools.Top = _menuStrip.Height;
            _pictureBox.Size = new(height, height);
            _pictureBox.Location = new(_pnlTools.Width, _menuStrip.Height);
            _scale = (float)_pictureBox.ClientRectangle.Height / 0x80;
            _pnlColor.Location = new(_pictureBox.Left + _pictureBox.Width, _menuStrip.Height);
            _pnlColor.Size = new(ClientRectangle.Width - _pictureBox.Left - _pictureBox.Width, height);
            _pnlColorViewer.Width = _pnlColor.Width;
            _lblColorLeft.Width = _pnlColorViewer.Width >> 1;
            _lblColorRight.Width = _pnlColorViewer.Width >> 1;
            _lblColorRight.Left = _pnlColorViewer.Width >> 1;
            _lstColorPicker.Size = new(_pnlColor.Width, height - _pnlColorViewer.Height);
            _pnlBanners.Location = _pnlColor.Location;
            _pnlBanners.Size = _pnlColor.Size;
            _txtBannerName.Size = new(_pnlBanners.Width, height >> 1);
            _lstBannerColor.Top = _txtBannerName.Height;
            _lstBannerColor.Size = new(_pnlBanners.Width, height >> 1);
        }

        private void ResizeFormEnd()
        {
            if (_bitmap == null)
                return;

            _bitmap.Dispose();
            _graphics.Flush();
            _graphics.Dispose();
            _bitmap = new(_pictureBox.ClientRectangle.Width, _pictureBox.ClientRectangle.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _pictureBox.Image = _bitmap;
            Redraw();
        }

        private void Save()
        {
            if (_file == null)
                return;

            using (Stream str = _file.GetDataOutputStream(CompressionType.GZip))
                _tree.WriteTo(str);

            MessageBox.Show("Done!", "Map Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private float ToScaled(byte unscaled) => unscaled * _scale;

        private byte ToUnscaled(float scaled) => (byte)(scaled / _scale);
    }

    class Banner
    {
        public TagNodeCompound banner;
        public TagNodeString color;
        public TagNodeString name;
    }
}
