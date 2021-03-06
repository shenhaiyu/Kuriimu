﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kontract.Interface;
using System.Drawing;

namespace Kontract.Image.Swizzle
{
    public class Linear : IImageSwizzle
    {
        public int Width { get; }
        public int Height { get; }

        MasterSwizzle _linear;

        public Linear(int widthStride)
        {
            Width = widthStride;
            Height = 0;

            _linear = new MasterSwizzle(widthStride, new Point(0, 0), Enumerable.Empty<(int, int)>());
        }

        public Point Get(Point point) => _linear.Get(point.Y * Width + point.X);
    }
}
