﻿using System;

namespace ConsoleForm
{
    internal class Point
    {
        private int v1;
        private int v2;

        public Point(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static implicit operator System.Drawing.Point(Point v)
        {
            throw new NotImplementedException();
        }
    }
}