using System.Drawing;

namespace MinecraftMapEditor;

class SelectTool
{
    public byte[] colors;
    public Point dl;
    public Point src, dst;
    public Size size;

    public SelectTool()
    {
        src = dst = new();
        size = new();
    }

    public void CopyColors(byte[] colors)
    {
        Sort();
        this.colors = new byte[size.Width * size.Height];

        for (int i = 0, y = src.Y; y < src.Y + size.Height; ++y)
        {
            for (int x = src.X; x < src.X + size.Width; ++x, ++i)
            {
                this.colors[i] = colors[x + y * 0x80];
            }
        }
    }

    public void PasteColors(byte[] colors)
    {
        for (int i = 0, y = dst.Y; y < dst.Y + size.Height; ++y)
        {
            for (int x = dst.X; x < dst.X + size.Width; ++x, ++i)
            {
                if (0x0 <= x && x < 0x80 && 0x0 <= y && y < 0x80)
                    colors[x + y * 0x80] = this.colors[i];
            }
        }
    }

    public void Sort()
    {
        if (size.Width < 0)
        {
            src.X += size.Width;
            size.Width = -size.Width;
        }
        if (size.Height < 0)
        {
            src.Y += size.Height;
            size.Height = -size.Height;
        }
        if (src.X < 0x0) src.X = 0x0;
        if (src.Y < 0x0) src.Y = 0x0;
        if (src.X + size.Width >= 0x80) size.Width = 0x80 - src.X;
        if (src.Y + size.Height >= 0x80) size.Height = 0x80 - src.Y;
    }
}
