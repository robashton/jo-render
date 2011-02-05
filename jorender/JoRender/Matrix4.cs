using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoRender
{
    public class Matrix4
    {
        double xx;
        double xy;
        double xz;
        double xw;

        double yx;
        double yy;
        double yz;
        double yw;

        double zx;
        double zy;
        double zz;
        double zw;

        double wx;
        double wy;
        double wz;
        double ww;

        public double XX { get { return xx; } }
        public double XY { get { return xy; } }
        public double XZ { get { return xz; } }
        public double XW { get { return xw; } }

        public double YX { get { return yx; } }
        public double YY { get { return yy; } }
        public double YZ { get { return yz; } }
        public double YW { get { return yw; } }

        public double ZX { get { return zx; } }
        public double ZY { get { return zy; } }
        public double ZZ { get { return zz; } }
        public double ZW { get { return zw; } }

        public double WX { get { return wx; } }
        public double WY { get { return wy; } }
        public double WZ { get { return wz; } }
        public double WW { get { return ww; } }

        public Matrix4(double xx, double xy, double xz, double xw, double yx, double yy, double yz, double yw, double zx, double zy, double zz, double zw, double wx, double wy, double wz, double ww)
        {
            this.xx = xx;
            this.xy = xy;
            this.xz = xz;
            this.xw = xw;

            this.yx = yx;
            this.yy = yy;
            this.yz = yz;
            this.yw = yw;

            this.zx = zx;
            this.zy = zy;
            this.zz = zz;
            this.zw = zw;

            this.wx = wx;
            this.wy = wy;
            this.wz = wz;
            this.ww = ww;
        }

        public Matrix4 Multiply(double Scalar)
        {
            return new Matrix4
                (
                    xx * Scalar, xy * Scalar, xz * Scalar, xw * Scalar, 
                    yx * Scalar, yy * Scalar, yz * Scalar, yw * Scalar, 
                    zx * Scalar, zy * Scalar, zz * Scalar, zw * Scalar, 
                    wx * Scalar, wy * Scalar, wz * Scalar, ww * Scalar
                );
        }

        public Matrix4 MultiplyM(Matrix4 other)
        {
            return new Matrix4
                (
                    ((xx * other.xx) + (xy * other.yx) + (xz * other.zx) + (xw * other.wx)),
                    ((xx * other.xy) + (xy * other.yy) + (xz * other.zy) + (xw * other.wy)),
                    ((xx * other.xz) + (xy * other.yz) + (xz * other.zz) + (xw * other.wz)),
                    ((xx * other.xw) + (xy * other.yw) + (xz * other.zw) + (xw * other.ww)),

                    ((yx * other.xx) + (yy * other.yx) + (yz * other.zx) + (yw * other.wx)),
                    ((yx * other.xy) + (yy * other.yy) + (yz * other.zy) + (yw * other.wy)),
                    ((yx * other.xz) + (yy * other.yz) + (yz * other.zz) + (yw * other.wz)),
                    ((yx * other.xw) + (yy * other.yw) + (yz * other.zw) + (yw * other.ww)),

                    ((zx * other.xx) + (zy * other.yx) + (zz * other.zx) + (zw * other.wx)),
                    ((zx * other.xy) + (zy * other.yy) + (zz * other.zy) + (zw * other.wy)),
                    ((zx * other.xz) + (zy * other.yz) + (zz * other.zz) + (zw * other.wz)),
                    ((zx * other.xw) + (zy * other.yw) + (zz * other.zw) + (zw * other.ww)),

                    ((wx * other.xx) + (wy * other.yx) + (wz * other.zx) + (ww * other.wx)),
                    ((wx * other.xy) + (wy * other.yy) + (wz * other.zy) + (ww * other.wy)),
                    ((wx * other.xz) + (wy * other.yz) + (wz * other.zz) + (ww * other.wz)),
                    ((wx * other.xw) + (wy * other.yw) + (wz * other.zw) + (ww * other.ww))                
                );
        }
    }
}
