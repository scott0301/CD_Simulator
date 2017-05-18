using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using DispObject;
using DotNetMatrix;

namespace CMeasure
{
    public static class Computer
    {
        public static string TIME_GetTimeCode_MD_HMS_MS()
        {
            string strTime = string.Format("[{0:00}{1:00}_{2:00}:{3:00}:{4:00}_{5:00}]", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            return strTime;
        }
        public static string GetTimeCode4Save()
        {
            string strTime = string.Format("{0:00}_{1:00}_{2:00}{3:00}{4:00}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return strTime;
        }

        #region IMAGE IO
        public static void /*****/SaveImage(byte[] rawImage, int imageW, int imageH, string strPath)
        {
            Bitmap bmp = (Bitmap)HC_CONV_Byte2Bmp(rawImage, imageW, imageH);
            bmp.Save(strPath);
        }
        public static byte[] HC_CropImage(byte[] rawInput, int imageW, int imageH, int ptX, int ptY, int cropW, int cropH)
        {
            byte[] rawCrop = new byte[cropW * cropH];

            for (int y = ptY, copyLine = 0; y < ptY + cropH; y++)
            {
                Buffer.BlockCopy(rawInput, y * imageW + ptX, rawCrop, cropW * copyLine++, cropW);
            }

            return rawCrop;
        }
        public static byte[] HC_CropImage(byte[] rawInput, int imageW, int imageH, RectangleF rc)
        {
            int nLength = (int)rc.Width * (int)rc.Height;
            int toHeight = (int)rc.Y + (int)rc.Height;
            int toWidth = (int)rc.Width;
            int px = (int)rc.X;

            
            byte[] rawCrop = new byte[nLength];

            for (int y = (int)rc.Y, copyLine = 0; y < toHeight; y++)
            {
                Buffer.BlockCopy(rawInput, y * imageW + px, rawCrop, toWidth * copyLine++, toWidth);
            }

            return rawCrop;
        }
        public static byte[] HC_CropImage_Polar(byte[] rawInput, int imageW, int imageH, RectangleF rc)
        {
            int nCX = Convert.ToInt32(rc.Width / 2.0);
            int nCY = Convert.ToInt32(rc.Height/ 2.0);
            int nRadius = Math.Max(nCX, nCY);

            nCX += (int)rc.X;
            nCY += (int)rc.Y;

            byte[] rawPolar = new byte[360 * nRadius];

            for (int na = 0; na < 360; na++)
            {
                int nPolarY = nRadius;
                for (int nr = 0; nr < nRadius; nr++)
                {
                    double fDegree = ((na-90.0 ) * Math.PI / 180.0);

                    double x = nCX + (((double)nr) * Math.Cos(fDegree));
                    double y = nCY + (((double)nr) * Math.Sin(fDegree));

                    if (x < 0 || y < 0 || x >= imageW || y >= imageH)
                    {
                        continue;
                    }
                    rawPolar[--nPolarY * 360 + na] = rawInput[(int)y*imageW+(int)x];
                }
            }
            return rawPolar;
        }
        public static byte[] HC_CropImage_Interpolated_Polar(byte[] rawInput, int imageW, int imageH, RectangleF rc)
        {
            int nCX = Convert.ToInt32(rc.Width / 2.0);
            int nCY = Convert.ToInt32(rc.Height / 2.0);
            int nRadius = Math.Max(nCX, nCY);

            nCX += (int)rc.X;
            nCY += (int)rc.Y;

            byte[] rawPolar = new byte[360 * nRadius];

            for (int na = 0; na < 360; na++)
            {
                int nPolarY = nRadius;
                for (int nr = 0; nr < nRadius; nr++)
                {
                    double fDegree = ((na - 90.0) * Math.PI / 180.0);

                    double x = nCX + ((double)nr * Math.Cos(fDegree));
                    double y = nCY + ((double)nr * Math.Sin(fDegree));

                    if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                    int x1 = (int)Math.Floor(x);
                    int x2 = (int)Math.Ceiling(x);
                    int y1 = (int)Math.Floor(y);
                    int y2 = (int)Math.Ceiling(y);

                    int q11 = rawInput[y1 * imageW + x1];
                    int q12 = rawInput[y2 * imageW + x1];
                    int q21 = rawInput[y1 * imageW + x2];
                    int q22 = rawInput[y2 * imageW + x2];

                    double fInterplated = GetInterPolatedValue(x, y, x1, x2, y1, y2, q11, q12, q21, q22);

                    byte valueOrg = rawInput[(int)y * imageW + (int)x];

                    byte value = fInterplated < 0 ? (byte)0 : fInterplated > 255 ? (byte)255 : (byte)fInterplated;

                    if (double.IsNaN(fInterplated) == true ) value = valueOrg;

                    rawPolar[--nPolarY * 360 + na] = value;
                }
            }
            return rawPolar;
        }
        public static byte[] HC_CropImage_Rotate(byte[] rawInput, int imageW, int imageH, RectangleF rc, PointF ptGravity, float fAngle)
        {
            List<byte> listRot = new List<Byte>();

            int fromX = (int)(rc.X);
            int fromY = (int)(rc.Y);

            for (int y = fromY; y < (int) fromY+(int)rc.Height; y++)
            {
                for (int x = fromX; x < (int)fromX+(int)rc.Width; x++)
                {
                    PointF ptRot = _RotatePointByGravity(new PointF(x, y), ptGravity, fAngle);


                    double cx = ptRot.X;
                    double cy = ptRot.Y;
                    int x1 = (int)Math.Floor(cx);
                    int x2 = (int)Math.Ceiling(cx);
                    int y1 = (int)Math.Floor(cy);
                    int y2 = (int)Math.Ceiling(cy);

                    int q11 = rawInput[y1*imageW+x1];
                    int q12 = rawInput[y2*imageW+x1];
                    int q21 = rawInput[y1*imageW+x2];
                    int q22 = rawInput[y2*imageW+x2];

                    double fInterplated= GetInterPolatedValue(cx, cy, x1, x2, y1, y2, q11, q12, q21, q22);

                    byte value = fInterplated < 0 ? (byte)0 : fInterplated > 255 ? (byte)255 : (byte)fInterplated;
                    listRot.Add(value);
                }
            }
            
            byte[] rawRes = new byte[(int)rc.Width*(int)rc.Height];
            byte [] rawOut = listRot.ToArray();
            return rawOut;
        }

        #endregion

        public static int[] GetProjection_Horizontal(byte[] rawImage, int imageW, int imageH) // 170417 for circle distortion checking.
        {
            int[] proj = new int[imageW];

            Parallel.For(0, 360, x =>
            {
                for (int y = 0; y < imageH; y++)
                {
                    proj[x] += rawImage[y * imageW + x];
                }
            });
            return proj;
        }
        public static double GetInterPolatedValue(double cx, double cy, double x1, double x2, double y1, double y2, double q11, double q12, double q21, double q22)
        {
            double r1 = (((x2 - cx) / (x2 - x1)) * q11) + (((cx - x1) / (x2 - x1)) * q21);
            double r2 = (((x2 - cx) / (x2 - x1)) * q12) + (((cx - x1) / (x2 - x1)) * q22);
            double pvalue = (((y2 - cy) / (y2 - y1)) * r1) + (((cy - y1) / (y2 - y1)) * r2);
            return pvalue;
        }
        // 블럭 average 170511 테스트용
        public static double GetMeanValue(byte[] rawImage, int imageW, int imageH, int x, int y, int nKernelSize)
        {
            List<double> listArr = new List<double>();

 
            int nKs = nKernelSize / 2;

            for (int yy = y-nKs; yy < y+nKs; yy++)
            {
                for (int xx = x-nKs; xx < x + nKs; xx++)
                {
                    int nValue = rawImage[yy * imageW + xx];
                    listArr.Add(nValue);
                }
            }

           
            
            return listArr.Average();
        }
        private static PointF _RotatePointByGravity(PointF ptTarget, PointF ptGravity, double fAngle)
        {
            //x' = (x-a) * cosR - (y-b)sinR + a
            //y' = (x-a) * sinR + (y-b)cosR + b
            fAngle = fAngle * Math.PI / 180.0;

            PointF ptRotated = new PointF(0, 0);

            ptRotated.X = (float)(((ptTarget.X - ptGravity.X) * Math.Cos(fAngle) - (ptTarget.Y - ptGravity.Y) * Math.Sin(fAngle)) + ptGravity.X);
            ptRotated.Y = (float)(((ptTarget.X - ptGravity.X) * Math.Sin(fAngle) + (ptTarget.Y - ptGravity.Y) * Math.Cos(fAngle)) + ptGravity.Y);

            return ptRotated;
        }

        #region IMAGE CONVERSION
        public static Bitmap/***/HC_CONV_Byte2Bmp(byte[] rawImage, int imageW, int imageH)
        {
            if (imageW == 0 || imageH == 0)
            {
                return new Bitmap(444, 444, PixelFormat.Format24bppRgb);
            }

            Bitmap bmpImage = new Bitmap(imageW, imageH, PixelFormat.Format24bppRgb);

            int nStride = 0, bmpLength = 0;
            byte[] rawBmp = null;

            BitmapData bitmapData = bmpImage.LockBits(new Rectangle(0, 0, imageW, imageH), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            {
                nStride = Math.Abs(bitmapData.Stride);
                bmpLength = nStride * imageH;

            }
            bmpImage.UnlockBits(bitmapData);


            rawBmp = new byte[bmpLength];

            Parallel.For(0, imageH, y =>
            {
                for (int x = 0; x < imageW; x++)
                {
                    //rawBmp[(y * nStride) + x ] = rawImage[y * imageW + x];
                    rawBmp[(y * nStride) + (x * 3) + 0] =
                    rawBmp[(y * nStride) + (x * 3) + 1] =
                    rawBmp[(y * nStride) + (x * 3) + 2] = rawImage[y * imageW + x];
                }
            });


            bitmapData = bmpImage.LockBits(new Rectangle(0, 0, imageW, imageH), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            {
                System.Runtime.InteropServices.Marshal.Copy(rawBmp, 0, bitmapData.Scan0, bmpLength);
            }
            bmpImage.UnlockBits(bitmapData);

            return bmpImage;
        }
        public static double[] /***/HC_CONV_Byte2Double(byte[] byteArray)
        {
            double[] fArray = new double[byteArray.Length];

            if (fArray.Length == byteArray.Length)
            {
                Parallel.For(0, fArray.Length, i =>
                {
                    fArray[i] = byteArray[i];
                });
            }

            return fArray;
        }
        public static byte[] /**/HC_CONV_Double2Byte(double[] fArray)
        {
            byte[] rawImage = new byte[fArray.Length];

            Parallel.For(0, rawImage.Length, i =>
            {
                double fValue = fArray[i];
                fValue = fValue < 0x0 ? 0x0 : fValue > 0xff ? 0xff : fValue;
                rawImage[i] = (byte)fValue;

            });

            return rawImage;
        }
        public static byte[] /**/HC_CONV_Bmp2Raw(System.Drawing.Bitmap bmpImage, ref int imageW, ref int imageH)
        {
            imageW = bmpImage.Width;
            imageH = bmpImage.Height;

            int nRealW = 0, nStride = 0, bmpLength = 0;
            byte[] rawBmp = null;

            BitmapData bitmapData = bmpImage.LockBits(new Rectangle(0, 0, imageW, imageH), System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            {
                imageW = bitmapData.Width;
                imageH = bitmapData.Height;
                nRealW = imageW;

                nStride = Math.Abs(bitmapData.Stride);
                bmpLength = nStride * imageH;

                rawBmp = new byte[bmpLength];
                System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, rawBmp, 0, bmpLength);
            }
            bmpImage.UnlockBits(bitmapData);

            int nImageW = imageW;
            int nImageH = imageH;

            byte[] rawImage = new byte[imageW * imageH];

            System.Threading.Tasks.Parallel.For(0, imageH, y =>
            {
                for (int x = 0; x < nImageW; x++)
                {
                    rawImage[y * nImageW + x] = (byte)((rawBmp[(y * nStride) + (x * 3) + 0] + rawBmp[(y * nStride) + (x * 3) + 1] + rawBmp[(y * nStride) + (x * 3) + 2]) / 3);
                }
            });
            return rawImage;
        }
        public static byte[] /**/HC_CONV_BlendedImage(byte[] i1, byte[] i2, int imageW, int imageH, int nBlend)
        {
            byte[] returnRaw = new byte[imageW * imageH];

            //for (int i = 0; i < returnRaw.Length; i++)
            Parallel.For(0, returnRaw.Length, i =>
            {
                double fValue = (i1[i] * ((100 - nBlend) / 100.0)) + (i2[i] * (nBlend / 100.0));
                returnRaw[i] = fValue >= 255 ? (byte)255 : fValue < 0 ? (byte)0 : Convert.ToByte(fValue);

            });

            return returnRaw;
        }
        #endregion

        #region EXPERIMENTAL FUNCTIONS FOR DIGONAL LINES
        public static List<PointF> Get2ndDerivativeList_HorMax(byte[] rawImage, int imageW, int imageH)
        {
            double[] buff_1st = new double[imageW - 1];
            double[] buff_2nd = new double[imageW - 2];
            double fSubPixel = 0;

            List<PointF> list = new List<PointF>();

            for (int y = 0; y < imageH; y++)
            {
                Array.Clear(buff_1st, 0, buff_1st.Length);
                Array.Clear(buff_2nd, 0, buff_2nd.Length);
                fSubPixel = 0;

                for (int x = 0; x < imageW - 1; x++)
                {
                    buff_1st[x] = rawImage[y * imageW + x + 1] - rawImage[y * imageW + x];
                }

                for (int x = 0; x < imageW - 2; x++)
                {
                    buff_2nd[x] = buff_1st[x + 1] - buff_1st[x];
                }
                double fMax = buff_2nd.Max();
                int nPosMax = Array.IndexOf(buff_2nd, fMax);

                fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPosMax); 

                list.Add(new PointF((float)(nPosMax + fSubPixel), y));

            }
            return list;
        }
        public static List<PointF> Get2ndDerivativeList_HorMin(byte[] rawImage, int imageW, int imageH)
        {
            double[] buff_1st = new double[imageW - 1];
            double[] buff_2nd = new double[imageW - 2];
            double fSubPixel = 0;

            List<PointF> list = new List<PointF>();

            for (int y = 0; y < imageH; y++)
            {
                Array.Clear(buff_1st, 0, buff_1st.Length);
                Array.Clear(buff_2nd, 0, buff_2nd.Length);
                fSubPixel = 0;

                for (int x = 0; x < imageW - 1; x++)
                {
                    buff_1st[x] = rawImage[y * imageW + x + 1] - rawImage[y * imageW + x];
                }

                for (int x = 0; x < imageW - 2; x++)
                {
                    buff_2nd[x] = buff_1st[x + 1] - buff_1st[x];
                }

                double fMin = buff_2nd.Min();
                int nPosMin = Array.IndexOf(buff_2nd, fMin);

                fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPosMin);

                list.Add(new PointF((float)(nPosMin + fSubPixel), y));

            }
            return list;
        }
        #endregion

        #region EXPERIMENTAL FUNCTIONS FOR CIRCLES
        public static double Get2ndDerivativeLine_MaxPos(byte[] line)
        {
            double[] buff_1st = new double[line.Length - 1];
            double[] buff_2nd = new double[line.Length - 2];

            for (int nIndex = 0; nIndex < line.Length-1; nIndex++){buff_1st[nIndex] = line[nIndex + 1] - line[nIndex];}
            for (int nIndex = 0; nIndex < line.Length-2; nIndex++){buff_2nd[nIndex] = buff_1st[nIndex + 1] - buff_1st[nIndex];}
            
            double fMax = buff_2nd.Max();
            int/**/nPos = Array.IndexOf(buff_2nd, fMax);

            double fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPos);

            return fSubPixel+nPos;
        }
        public static double Get2ndDerivativeLine_MaxPos(double[] line)
        {
            double[] buff_1st = new double[line.Length - 1];
            double[] buff_2nd = new double[line.Length - 2];

            for (int nIndex = 0; nIndex < line.Length - 1; nIndex++) { buff_1st[nIndex] = line[nIndex + 1] - line[nIndex]; }
            for (int nIndex = 0; nIndex < line.Length - 2; nIndex++) { buff_2nd[nIndex] = buff_1st[nIndex + 1] - buff_1st[nIndex]; }

            double fMax = buff_2nd.Max();
            int/**/nPos = Array.IndexOf(buff_2nd, fMax);

            double fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPos);

            return fSubPixel + nPos;
        }
        public static double Get2ndDerivativeLine_MinPos(byte[] line)
        {
            double[] buff_1st = new double[line.Length - 1];
            double[] buff_2nd = new double[line.Length - 2];

            for (int nIndex = 0; nIndex < line.Length - 1; nIndex++){buff_1st[nIndex] = line[nIndex + 1] - line[nIndex];}
            for (int nIndex = 0; nIndex < line.Length - 2; nIndex++){buff_2nd[nIndex] = buff_1st[nIndex + 1] - buff_1st[nIndex];}

            double fMin = buff_2nd.Min();
            int/**/nPos = Array.IndexOf(buff_2nd, fMin);

            double fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPos);

            return fSubPixel+nPos;
        }
        public static double Get2ndDerivativeLine_MinPos(double[] line)
        {
            double[] buff_1st = new double[line.Length - 1];
            double[] buff_2nd = new double[line.Length - 2];

            for (int nIndex = 0; nIndex < line.Length - 1; nIndex++) { buff_1st[nIndex] = line[nIndex + 1] - line[nIndex]; }
            for (int nIndex = 0; nIndex < line.Length - 2; nIndex++) { buff_2nd[nIndex] = buff_1st[nIndex + 1] - buff_1st[nIndex]; }

            double fMin = buff_2nd.Min();
            int/**/nPos = Array.IndexOf(buff_2nd, fMin);

            double fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, nPos);

            return fSubPixel + nPos;
        }

        #endregion


        #region FOR LAPLACIAN OF GAUSSIAN 2ND DERIVATIVE FUCKER
        public static double[] GetLaplacianOfGaussianKernel(int nKernelSize, double fSigma )
        {
            //double[] fKernel = new double[5 * 5] 
            //{ 0,0,1,0,0,
            //  0,1,2,1,0,
            //  1,2,-16,2,1,
            //  0,1,2,1,0,
            //  0,0,1,0,0};

            double [] fKernel = new double[9*9]{
                0, 0, 3,  2,  2,  2, 3, 0, 0,
                0, 2, 3,  5,  5,  5, 3, 2, 0,
                3, 3, 5,  3,  0,  3, 5, 3, 3,
                2, 5, 3,-12,-23,-12, 3, 5, 2,
                2, 5, 0,-23,-40,-23, 0, 5, 2,
                2, 5, 3,-12,-23,-12, 3, 5, 2,
                3, 3, 5,  3,  0,  3, 5, 3, 3,
                0, 2, 3,  5,  5,  5, 3, 2, 0,
                0, 0, 3,  2,  2,  2, 3, 0, 0};


            return fKernel;
        }
        
        public static double GetLogPos(byte[] rawImage, int imageW, int imageH, PointF[] arrPoints, int nSign)
        {
            double [] fKernel = GetLaplacianOfGaussianKernel(5,1.6);

            double[] fImage = new double[arrPoints.Length];
            double[] fTemp = new double[arrPoints.Length];

            int KSIZE = (int)Math.Sqrt(fKernel.Length);
            int GAP = KSIZE / 2;

            for( int i = 0; i < arrPoints.Length;   i++)
            {
                int x = (int)arrPoints.ElementAt(i).X;
                int y = (int)arrPoints.ElementAt(i).Y;

                double kernelSum = 0;
                for (int j = -GAP; j <= GAP; j++)
                {
                    for (int k = -GAP; k <= GAP; k++)
                    {
                        kernelSum += (fKernel[(j + GAP) * KSIZE + k + GAP] * rawImage[(y - j) * imageW + (x - k)]);
                    }
                }
                fImage[i] = kernelSum;
                fTemp[i] = rawImage[y * imageW + x];
            }

            double fValue = 0;
            int nPos = 0;

            /***/if (nSign == -1){fValue = fImage.Min();}
            else if (nSign == +1){fValue = fImage.Max();}
            nPos = Array.IndexOf(fImage, fValue);
            
            double fSubPos = nPos + GetSubPixelFromLineBuff(fImage, nPos);

          
            

            return fSubPos;

        }
        public static double GetLoG_PosMax(byte[] rawImage, int imageW, int imageH, PointF[] list)
        {
            double[] arrDerivative = new double[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                int xx = (int)list.ElementAt(i).X;
                int yy = (int)list.ElementAt(i).Y;

                arrDerivative[i] = rawImage[yy * imageW + xx + 1] + rawImage[yy * imageW + xx - 1]  - (2 * rawImage[yy * imageW + xx]);
            }

            double fMaxVal = arrDerivative.Max();
            int nMaxPos = Array.IndexOf(arrDerivative, fMaxVal);

            double fSubPixel = GetSubPixelFromLineBuff(arrDerivative, nMaxPos);
 
            return nMaxPos + fSubPixel;
        }
        public static double GetLoG_PosMin(byte[] rawImage, int imageW, int imageH, PointF[] list)
        {
            double[] arrDerivative = new double[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                int xx = (int)list.ElementAt(i).X;
                int yy = (int)list.ElementAt(i).Y;

                arrDerivative[i] = rawImage[(yy + 0) * imageW + xx + 1] + 
                                   rawImage[(yy + 0) * imageW + xx - 1] + 
                                   rawImage[(yy + 1) * imageW + xx + 0] + 
                                   rawImage[(yy - 1) * imageW + xx + 0] - 
                                   (4 * rawImage[yy * imageW + xx]);
            }

            double fMin = arrDerivative.Min();
            int nMinPos = Array.IndexOf(arrDerivative, fMin);

            double fSubpixel = GetSubPixelFromLineBuff(arrDerivative, nMinPos);

            return nMinPos + fSubpixel;
        }
        #endregion

        #region FOR ZEROCROSSING
        public static double GetZeroCrossingPt(byte[] buff, int sign, double mag)
        {
            int[] differFST = new int[buff.Length];
            int[] differSCD = new int[buff.Length];

            for (int i = 0; i < buff.Length - 1; i++) { differFST[i] = buff[i + 1] - buff[i]; }
            for (int i = 0; i < buff.Length - 2; i++) { differSCD[i] = differFST[i + 1] - differFST[i]; }

            double ptEdge = 0.0;

            for (int j = 0; j < buff.Length - 2; j++)
            {
                if (((sign == -1) && (differFST[j + 1] < sign * mag)) ||
                     ((sign == +1) && (differFST[j + 1] > sign * mag)))
                {
                    if ((differSCD[j] * differSCD[j + 1] < 0))
                    {
                        double subpixel_range = (double)(-differSCD[j]) / (differSCD[j + 1] - differSCD[j]);
                        ptEdge = (j + 1) + subpixel_range;
                        break;
                    }
                    else if (j > 0 && differSCD[j] == 0)
                    {
                        if (differSCD[j - 1] * differSCD[j + 1] < 0)
                        {
                            ptEdge = j + 1;
                            break;
                        }
                    }
                }
            }

            if (Math.Floor(ptEdge) == Math.Floor(0.0))
            {
                for (int j = 0; j < buff.Length - 2; j++)
                {
                    if (((sign == -1) && (differFST[j + 1] > -sign * mag)) ||
                         ((sign == +1) && (differFST[j + 1] < -sign * mag)))
                    {
                        if ((differSCD[j] * differSCD[j + 1] < 0))
                        {
                            double subpixel_range = (double)(-differSCD[j]) / (differSCD[j + 1] - differSCD[j]);
                            ptEdge = (j + 1) + subpixel_range;
                            break;
                        }
                        else if (j > 0 && differSCD[j] == 0)
                        {
                            if (differSCD[j - 1] * differSCD[j + 1] < 0)
                            {
                                ptEdge = j + 1;
                                break;
                            }
                        }
                    }
                }
            }
            return ptEdge;
        }
        #endregion


        #region FOR 2nd DERIVATIVE APPROACH

        public static double[] Get2ndDerivativeArray(double[] arrProfile)
        {
            double[] arr1st = new double[arrProfile.Length - 1];
            double[] arr2nd = new double[arrProfile.Length - 2];

            for (int i = 0; i < arrProfile.Length - 1; i++)
            {
                arr1st[i] = arrProfile[i + 1] - arrProfile[i];
            }
            for (int i = 0; i < arr1st.Length-1 + 0; i++)
            {
                arr2nd[i] = arr1st[i + 1] - arr1st[i];
            }
            return arr2nd;
        }

        #endregion

        #region OVERLAY METHOD
        public static float GetNewtonRapRes(double[] arrAccProfile)
        {
            // set kernel size by default 
            const int KSIZE = 5;
            double[][] pMatrix = new double[5][];

            // allocation
            for (int y = 0; y < KSIZE; y++) { pMatrix[y] = new double[6]; }

            // get max position
            double fMin = arrAccProfile.Min();
            int nMinPos = Array.IndexOf(arrAccProfile, fMin);

            // assignment
            for (int y = 0; y < KSIZE; y++)
            {
                for (int x = 0; x < KSIZE; x++)
                {
                    pMatrix[y][x] = Math.Pow((double)(y + 1), (double)(KSIZE - 1 - x));
                }
                int nPos = (int)(nMinPos - ((KSIZE - 1) / 2.0) + y);

                // additive fuck exception : incase of Position want to place on the asshole 
                if (nPos > 0 && arrAccProfile.Length > nPos)
                {
                    pMatrix[y][KSIZE] = arrAccProfile[nPos];
                }
                else
                {
                    pMatrix[y][KSIZE] = 0;
                }
            }

            // fucking gauss
            _GaussElimination(pMatrix, KSIZE + 1, KSIZE);

            double[] pNewton = new double[KSIZE];

            for (int x = 0; x < KSIZE - 1; x++)
            {
                pNewton[x] = (double)(KSIZE - 1 - x) * pMatrix[x][KSIZE];
            }

            double NRValue = _NewtonRaphson(pNewton, KSIZE - 1, (double)(KSIZE + 1) / 2.0);

            // set fucking value
            return Convert.ToSingle(nMinPos + NRValue);
        }
        public static double[] GetAccPrewitHor(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nMeasureType)
        {
            const int RISING = 0;
            const int FALLING = 1;

            if (CRect.isValid(ref rc, imageW, imageH) == true)
            {
                int sy = (int)rc.Y;
                int ey = (int)rc.Y + (int)rc.Height;
                int sx = (int)rc.X;
                int ex = (int)rc.X + (int)rc.Width;

                double[] profile = new double[(int)rc.Height];

                // accumulation for each position
                for (int x = sx; x < ex; x++)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        if (nMeasureType == RISING)
                        {
                            profile[y - sy] += rawImage[(y + 1) * imageW + x] - rawImage[(y - 1) * imageW + x];
                        }
                        else if (nMeasureType == FALLING)
                        {
                            profile[y - sy] += rawImage[(y - 1) * imageW + x] - rawImage[(y + 1) * imageW + x];
                        }
                    }
                }
                return profile;
            }
            return new double[0];
        }
        public static double[] GetAccPrewitVer(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nMeasureType)
        {
            List<PointF> list = new List<PointF>();

            const int RISING = 0;
            const int FALLING = 1;

            int sy = (int)rc.Y;
            int ey = (int)rc.Y + (int)rc.Height;
            int sx = (int)rc.X;
            int ex = (int)rc.X + (int)rc.Width;

            double[] profile = new double[(int)rc.Width];

            // accumulation for each position
            for (int y = sy; y < ey; y++)
            {
                for (int x = sx; x < ex; x++)
                {
                    if (nMeasureType == RISING)
                    {
                        profile[x - sx] += rawImage[y * imageW + (x + 1)] - rawImage[y * imageW + (x - 1)];
                    }
                    else if (nMeasureType == FALLING)
                    {
                        profile[x - sx] += rawImage[y  * imageW + (x - 1)] - rawImage[y * imageW + (x + 1)];
                    }
                }
            }
            return profile;
        }
        public static double[] GetPrewitBuffLine(byte[] buffLine, int nMeasureType)
        {
            const int RISING = 0;
            const int FALLING = 1;

            double[] profile = new double[buffLine.Length];

            // accumulation for each position
            for (int nIndex = 1; nIndex < buffLine.Length-1; nIndex++)
            {
                if (nMeasureType == RISING)
                {
                    profile[nIndex] += buffLine[(nIndex + 1)] - buffLine[(nIndex - 1)];
                }
                else if (nMeasureType == FALLING)
                {
                    profile[nIndex] += buffLine[(nIndex - 1)] - buffLine[(nIndex + 1)];
                }
            }

            return profile;
        }
        public static double _NewtonRaphson(double []pNewton, int szPoly, double tStart)
        {
            double tSlope = 0;
	        double tPoint = tStart;

	        for(int itr = 0; itr < 10; itr++)
	        {
		        double tValue = tSlope = 0.0;

		        for(int i = 0; i < szPoly; i++)
                {
			        tValue += pNewton[i] * Math.Pow(tPoint, (double)(szPoly - 1 - i));
                }
		        for(int i = 0; i < szPoly - 1; i++)
                {
			        tSlope += (double)(szPoly - 1 - i) * pNewton[i] * Math.Pow(tPoint, (double)(szPoly - 2 - i));
                }
		        double bPoint = tPoint;

		        if(Math.Abs(tSlope) < 1e-10) break;
		        if(Math.Abs(tValue) < 1e-16) break;

		        tPoint = (tSlope * tPoint - tValue) / tSlope;
		        if( Math.Abs(bPoint - tPoint) < 1e-5) break;
	        }
	        return tPoint;
        }
        public static void _GaussElimination(double [][] pMatrix, int szX, int szY)
        {
	        // X must be bigger than Y by 1

	        // Left Diagonal
	        for(int i = 0; i < szX - 2; i++)
	        {
		        for(int j = i + 1; j < szY; j++)
		        {
			        if(pMatrix[j][i] * pMatrix[i][i] != double.NaN)
			        {
				        double eCoeff = pMatrix[j][i] / pMatrix[i][i];
                        for (int k = i; k < szX; k++)
                        {
                            pMatrix[j][k] = pMatrix[j][k] - pMatrix[i][k] * eCoeff;
                        }
			        }
		        }
	        }

	        // Right Diagonal
	        for(int j = 0; j < szY - 1; j++)
	        {
		        for(int i = j + 1; i < szX - 1; i++)
		        {
			        if(pMatrix[j][i] * pMatrix[i][i] != double.NaN)
			        {
				        double eCoeff = pMatrix[j][i] / pMatrix[i][i];
                        for (int k = i; k < szX; k++)
                        {
                            pMatrix[j][k] = pMatrix[j][k] - pMatrix[i][k] * eCoeff;
                        }
			        }
		        }
	        }

	        for(int j = 0; j < szY; j++)
	        {
		        if(pMatrix[j][j] != double.NaN)
		        {
			        double eCoeff = pMatrix[j][j];
			        pMatrix[j][j] = 1.0;
			        pMatrix[j][szX - 1] = pMatrix[j][szX - 1] / eCoeff;
		        }
	        }
        }
        #endregion

        public static double GetSubPixelFromLineBuff<T>(T[] lineBuff, int nPos)
        {
            double pa = 0; double pb = 0; double pc = 0;

            double fSubPixel = 0;

            try
            {
                if (nPos != 0 && nPos < lineBuff.Length - 1)
                {
                    pa = Convert.ToDouble(lineBuff[nPos - 1]);
                    pb = Convert.ToDouble(lineBuff[nPos + 0]);
                    pc = Convert.ToDouble(lineBuff[nPos + 1]);

                    // simple quadratic interpolation
                    fSubPixel = 0.5 * (pa - pc) / (pa - (2 * pb) + pc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return fSubPixel;
        }

        public static void HC_FIT_Circle(List<PointF> list, ref PointF ptCenter, ref double radius)
        {
            double sx = 0.0, sy = 0.0;
            double sx2 = 0.0, sy2 = 0.0, sxy = 0.0;
            double sx3 = 0.0, sy3 = 0.0, sx2y = 0.0, sxy2 = 0.0;

            /* compute summations */
            for (int k = 0; k < list.Count; k++)
            {
                double x = list.ElementAt(k).X;
                double y = list.ElementAt(k).Y;

                double xx = x * x;
                double yy = y * y;

                sx = sx + x;
                sy = sy + y;
                sx2 = sx2 + xx;
                sy2 = sy2 + yy;
                sxy = sxy + x * y;
                sx3 = sx3 + x * xx;
                sy3 = sy3 + y * yy;
                sx2y = sx2y + xx * y;
                sxy2 = sxy2 + yy * x;
            }
            /* compute a's,b's,c's */
            double a1 = 2.0 * (sx * sx - sx2 * list.Count);
            double a2 = 2.0 * (sx * sy - sxy * list.Count);
            double b1 = a2;
            double b2 = 2.0 * (sy * sy - sy2 * list.Count);
            double c1 = sx2 * sx - sx3 * list.Count + sx * sy2 - sxy2 * list.Count;
            double c2 = sx2 * sy - sy3 * list.Count + sy * sy2 - sx2y * list.Count;

            double det = a1 * b2 - a2 * b1;
            if (Math.Abs(det) < 0.0001)
            {                /*collinear한 경우임;*/
                return;
            }

            /* floating value  center */
            double cx = (c1 * b2 - c2 * b1) / det;
            double cy = (a1 * c2 - a2 * c1) / det;

            /* compute radius squared */
            double radsq = (sx2 - 2 * sx * cx + cx * cx * list.Count + sy2 - 2 * sy * cy + cy * cy * list.Count) / list.Count;
            radius = Math.Sqrt(radsq);
            /* integer value center */
            ptCenter.X = Convert.ToSingle(cx + 0.5);
            ptCenter.Y = Convert.ToSingle(cy + 0.5);

            return;
        }
        public static List<PointF> HC_FIT_Ellipse(List<PointF> ptListTarget, int density, ref PointF ptCenter)
        {
            double A = 0, B = 0;
            double cos_phi = 0, sin_phi = 0;

            double ptCX = 0;
            double ptCY = 0;
            HC_FIT_EllipseParamSet(ptListTarget, out ptCX, out ptCY, out A, out B, out cos_phi, out sin_phi);

            List<PointF> ptContourList = HC_FIT_EllipseGenContour(density, ptCX, ptCY, A, B, cos_phi, sin_phi);

            double fAVG_X = 0;
            double fAVG_Y = 0;

            foreach (PointF pt in ptContourList)
            {
                fAVG_X += pt.X; fAVG_Y += pt.Y;
            }
            fAVG_X /= ptContourList.Count;
            fAVG_Y /= ptContourList.Count;

            ptCenter = new PointF((float)fAVG_X, (float)fAVG_Y);

            return ptContourList;
        }
        public static List<PointF> HC_FIT_EllipseGenContour(int nSamplingDensity, double CX, double CY, double A, double B, double cos_phi, double sin_phi)
        {
            double fPitch = (2 * Math.PI) / nSamplingDensity;

            double[] contArrX = new double[nSamplingDensity];
            double[] contArrY = new double[nSamplingDensity];

            Parallel.For(0, nSamplingDensity, i =>
            {
                contArrX[i] = CX + (A * Math.Cos(fPitch * i));
                contArrY[i] = CY + (B * Math.Sin(fPitch * i));
            });

            double[][] arrContour = { contArrX, contArrY };
            DotNetMatrix.Matrix mtrpreContour = new DotNetMatrix.Matrix(arrContour);

            double[][] arrSC = { new double[] { cos_phi, sin_phi }, new double[] { -sin_phi, cos_phi } };
            DotNetMatrix.Matrix mtrSC = new DotNetMatrix.Matrix(arrSC);

            DotNetMatrix.Matrix mtrContour = mtrSC.Multiply(mtrpreContour);

            float x = 0;
            float y = 0;

            List<PointF> ptList = new List<PointF>();

            for (int i = 0; i < nSamplingDensity; i++)
            {
                x = (float)mtrContour.GetElement(0, i);
                y = (float)mtrContour.GetElement(1, i);

                ptList.Add(new PointF(x, y));
            }

            return ptList;
        }
        public static void HC_FIT_EllipseParamSet(List<PointF> ptListTarget, out double ptCX, out double ptCY, out double A, out double B, out double cos_phi, out double sin_phi)
        {
            if (ptListTarget.Count == 0)
            {
                A = B = 0;
                cos_phi = sin_phi = 0;
                ptCX = ptCY = 0;
                return;
            }
            int nDataCount = ptListTarget.Count;

            float[] CroodList_X = ptListTarget.Select(element => element.X).ToArray();
            float[] CroodList_Y = ptListTarget.Select(element => element.Y).ToArray();

            // required output : a, b, sign, cos, center x, center y
            A = B = 0; cos_phi = sin_phi = 0; ptCX = ptCY = 0;

            double meanX = CroodList_X.Average();
            double meanY = CroodList_Y.Average();

            double[] x1 = new double[nDataCount];
            double[] y1 = new double[nDataCount];
            double[] xx = new double[nDataCount];
            double[] yy = new double[nDataCount];
            double[] xy = new double[nDataCount];

            for (int i = 0; i < nDataCount; i++)
            {
                x1[i] = CroodList_X[i] - meanX;
                y1[i] = CroodList_Y[i] - meanY;
            }

            for (int i = 0; i < nDataCount; i++)
            {
                xx[i] = x1[i] * x1[i];
                yy[i] = y1[i] * y1[i];
                xy[i] = x1[i] * y1[i];
            }

            double[][] arrFittingData = { xx, xy, yy, x1, y1 };
            double[] arrFittingDataSum = new double[5];

            arrFittingDataSum[0] = xx.Sum();
            arrFittingDataSum[1] = xy.Sum();
            arrFittingDataSum[2] = yy.Sum();
            arrFittingDataSum[3] = x1.Sum();
            arrFittingDataSum[4] = y1.Sum();

            // make nemerator *********************************************************************
            // sum ( fitting data 1X5 matrix )

            DotNetMatrix.Matrix mtrNumerator = new DotNetMatrix.Matrix(arrFittingDataSum, 1);

            // make denominator  ******************************************************************
            // fitting data' * fitting data   by transpose & multiply

            DotNetMatrix.Matrix mtrFittingData = new DotNetMatrix.Matrix(arrFittingData);
            DotNetMatrix.Matrix mtrTrans = mtrFittingData.Transpose();
            DotNetMatrix.Matrix mtrDenominator = mtrFittingData.Multiply(mtrTrans);
            DotNetMatrix.Matrix mtrInvertDenom = mtrDenominator.Inverse();

            // calcuate parameters ****************************************************************
            DotNetMatrix.Matrix res = mtrNumerator.Multiply(mtrInvertDenom);

            A = res.GetElement(0, 0);
            B = res.GetElement(0, 1);

            double C = res.GetElement(0, 2);
            double D = res.GetElement(0, 3);
            double E = res.GetElement(0, 4);

            double oriental_Rad = 0;

            // fitting check value 
            double checkValue = Math.Min(Math.Abs(B / A), Math.Abs(B / C));

            if (checkValue > 0.0001) // pass case 
            {
                oriental_Rad = 1.0 / 2.0 * Math.Atan(B / (C - A));

                cos_phi = Math.Cos(oriental_Rad);
                sin_phi = Math.Sin(oriental_Rad);

                A = (A * cos_phi * cos_phi) - (B * cos_phi * sin_phi) + (C * sin_phi * sin_phi);
                B = 0;
                C = (A * sin_phi * sin_phi) + (B * cos_phi * sin_phi) + (C * cos_phi * cos_phi);
                D = (D * cos_phi - E * sin_phi);
                E = (D * sin_phi + E * cos_phi);

                meanX = cos_phi * meanX - sin_phi * meanY;
                meanY = sin_phi * meanX + cos_phi * meanY;
            }
            else // false case 
            {
                oriental_Rad = 0;
                cos_phi = Math.Cos(oriental_Rad);
                sin_phi = Math.Sin(oriental_Rad);
            }

            double Status = A * C;
            double F = 0;

            /***/
            if (Status == 0) Console.Write("Parabola Found\n");
            else if (Status < 0) Console.Write("Hyperbola Found\n");
            else if (Status > 0)
            {
                if (A < 0)
                {
                    A *= -1; C *= -1; D *= -1; E *= -1;
                }
                else
                {
                    ptCX = (float)(meanX - D / 2 / A);
                    ptCY = (float)(meanY - E / 2 / C);

                    F = 1 + (D * D) / (4 * A) + (E * E) / (4 * C);

                    A = Math.Sqrt(F / A);
                    B = Math.Sqrt(F / C);

                    #region MyRegion
                    // no meaning full variables for axis
                    //double long_Axis = 2 * Math.Max(a, b);
                    //double shor_Axis = 2 * Math.Min(a, b);

                    // Circle center calculation
                    //double[] arrXY = new double[] { CX, CY };

                    //Matrix mtrPosIN = new Matrix(arrXY, 1);
                    //Matrix mtrPosRes = mtrPosIN.Multiply(mtrSC);

                    //X0_in = (X0 * cos_phi )+  (Y0 * sin_phi);
                    //Y0_in = (X0 * -sin_phi) + (Y0 * cos_phi);

                    //ptCenter.X = Convert.ToInt32(mtrPosRes.GetElement(0, 0));
                    //ptCenter.Y = Convert.ToInt32(mtrPosRes.GetElement(0, 1));
                    #endregion

                    #region cross line calculation - no need

                    //double[][] verLine = { new double[] { X0, X0 }, new double[] { Y0 + (-B), Y0 + B } };
                    //double[][] horLine = { new double[] { X0 + (-A), X0 + A }, new double[] { Y0, Y0 } };

                    //Matrix mtrVerLine = new Matrix(verLine);
                    //Matrix mtrHorLine = new Matrix(horLine);

                    //Matrix mtrFinalLineVer = mtrSC.Multiply(mtrVerLine);
                    //Matrix mtrFinalLineHor = mtrSC.Multiply(mtrHorLine);

                    //Point pt_v1 = new Point(); Point pt_v2 = new Point();
                    //Point pt_h1 = new Point(); Point pt_h2 = new Point();

                    //pt_v1.X = (int)(mtrFinalLineVer.GetElement(0, 0));
                    //pt_v1.Y = (int)(mtrFinalLineVer.GetElement(1, 0));
                    //pt_v2.X = (int)(mtrFinalLineVer.GetElement(0, 1));
                    //pt_v2.Y = (int)(mtrFinalLineVer.GetElement(1, 1));

                    //pt_h1.X = (int)(mtrFinalLineHor.GetElement(0, 0));
                    //pt_h1.Y = (int)(mtrFinalLineHor.GetElement(1, 0));
                    //pt_h2.X = (int)(mtrFinalLineHor.GetElement(0, 1));
                    //pt_h2.Y = (int)(mtrFinalLineHor.GetElement(1, 1));

                    #endregion

                }
            }
        }
        public static  List<PointF> GetFilteredEllipsePoints(RectangleF rc, List<PointF> list)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(rc);

            List<PointF> listTemp = new List<PointF>();

            for( int i = 0; i < list.Count; i++)
            {
                PointF pt = list.ElementAt(i);
                if (myPath.IsVisible(pt) == true) { listTemp.Add(pt); }
            }
            return listTemp;
        }

        /************************************************************************************/
        // Convolution related functions
        /************************************************************************************/

        #region PADDING
        public static object ARRAY_Padding_LT(object rawImage, int imageW, int imageH, int nGap)
        {
            object ARRAY_DOUBLE = new double[1];
            object ARRAY_BYTE = new byte[1];
            object returnData = null;

            int newW = imageW + nGap;
            int newH = imageH + nGap;


            if (rawImage.GetType() == ARRAY_DOUBLE.GetType())
            {
                #region for double
                int size = sizeof(double);
                double[] fArray = (double[])rawImage;
                double[] newArray = new double[newW * newH];

                int orgY = 0;
                int CopyLength = imageW * size;
                for (int y = nGap; y < newH; y++)
                    Buffer.BlockCopy(fArray, (orgY++ * imageW) * size, newArray, ((y * newW) + nGap) * size, CopyLength);

                if (nGap > imageW) return newArray;

                Parallel.For(nGap, newH, y => { for (int x = 0; x <= nGap; x++) { newArray[y * newW + nGap - x] = newArray[y * newW + nGap + x]; } });

                CopyLength = newW * size;
                Parallel.For(0, nGap + 1, y => { Buffer.BlockCopy(newArray, ((nGap + y) * (newW)) * size, newArray, ((nGap - y) * (newW)) * size, CopyLength); });
                returnData = newArray;
                #endregion
            }
            else if (rawImage.GetType() == ARRAY_BYTE.GetType())
            {
                #region for byte

                byte[] byteArray = (byte[])rawImage;
                byte[] newArray = new byte[newW * newH];

                int orgY = 0;

                for (int y = nGap; y < newH; y++)
                    Buffer.BlockCopy(byteArray, orgY++ * imageW, newArray, y * newW + nGap, imageW);

                if (nGap > imageW) return newArray;

                Parallel.For(nGap, newH, y => { for (int x = 0; x <= nGap; x++) { newArray[y * newW + nGap - x] = newArray[y * newW + nGap + x]; } });
                Parallel.For(0, nGap + 1, y => { Buffer.BlockCopy(newArray, (nGap + y) * newW, newArray, (nGap - y) * newW, newW); });

                returnData = newArray;
                #endregion
            }

            return returnData;
        }
        public static object ARRAY_Padding_RB(object rawImage, int imageW, int imageH, int nGap)
        {
            object ARRAY_DOUBLE = new double[1];
            object ARRAY_BYTE = new byte[1];
            object returnData = null;

            int newW = imageW + nGap;
            int newH = imageH + nGap;

            if (rawImage.GetType() == ARRAY_DOUBLE.GetType())
            {
                int size = sizeof(double);
                double[] fArray = (double[])rawImage;
                double[] newArray = new double[newW * newH];

                int copyLength = imageW * sizeof(double);
                Parallel.For(0, imageH, y =>
                {
                    Buffer.BlockCopy(fArray, (y * imageW) * size, newArray, (y * newW) * size, copyLength);
                });

                // right direction copy
                Parallel.For(0, nGap, x =>
                {
                    for (int y = 0; y < imageH; y++)
                    {
                        newArray[y * newW + imageW + x] = newArray[y * newW + imageW - 1 - x];
                    }
                });

                double[] rawPadVert = new double[newW];

                // bottom direction copy - reverse
                copyLength = newW * sizeof(double);
                Parallel.For(0, nGap, y =>
                {
                    Buffer.BlockCopy(newArray, ((imageH - 1 - y) * newW) * size, rawPadVert, 0, copyLength);
                    Buffer.BlockCopy(rawPadVert, 0, newArray, ((imageH + y) * newW) * size, copyLength);
                });
                returnData = newArray;
            }
            else if (rawImage.GetType() == ARRAY_BYTE.GetType())
            {
                byte[] byteArray = (byte[])rawImage;
                byte[] newArray = new byte[newW * newH];

                Parallel.For(0, imageH, y =>
                {
                    Buffer.BlockCopy(byteArray, y * imageW, newArray, y * newW, imageW);
                });

                // right direction copy
                Parallel.For(0, nGap, x =>
                {
                    for (int y = 0; y < imageH; y++)
                    {
                        newArray[y * newW + imageW + x] = newArray[y * newW + imageW - 1 - x];
                    }
                });

                byte[] rawPadVert = new byte[newW];

                // bottom direction copy - reverse
                Parallel.For(0, nGap, y =>
                {
                    Buffer.BlockCopy(newArray, (imageH - 1 - y) * newW, rawPadVert, 0, newW);
                    Buffer.BlockCopy(rawPadVert, 0, newArray, (imageH + y) * newW, newW);
                });
                returnData = newArray;
            }
            return returnData;
        }
        public static Object ARRAY_Padding_ALL(Object obArray, int arrW, int arrH, int nGap)
        {
            object firstPadding = null;
            object seconPadding = null;
            Parallel.Invoke(() => { firstPadding = ARRAY_Padding_LT(obArray, arrW, arrH, nGap); });
            Parallel.Invoke(() => { seconPadding = ARRAY_Padding_RB(firstPadding, arrW + nGap, arrH + nGap, nGap); });
            return seconPadding;
        }
        #endregion

        //*****************************************************************************************
        // Convolution
        //*****************************************************************************************

        #region CONVOLUTION
        public static byte[] /*****/HC_FILTER_Convolution(double[] fKernel, byte[] rawImage, int imageW, int imageH)
        {
            double[] fImage = new double[imageW * imageH];

            int KSIZE = (int)Math.Sqrt(fKernel.Length);
            int GAP = KSIZE / 2;

            byte[] rawExpanded = (byte[])ARRAY_Padding_ALL(rawImage, imageW, imageH, GAP);

            int imageNewW = imageW + GAP * 2;
            int imageNewH = imageH + GAP * 2;

            //for (int y = GAP; y < imageNewH - GAP; y++)
            Parallel.For(GAP, imageNewH - GAP, y =>
            {
                for (int x = GAP; x < imageNewW - GAP; x++)
                {
                    double kernelSum = 0;
                    for (int j = -GAP; j <= GAP; j++)
                    {
                        for (int k = -GAP; k <= GAP; k++)
                        {
                            kernelSum += (fKernel[(j + GAP) * KSIZE + k + GAP] * rawExpanded[(y - j) * imageNewW + (x - k)]);
                        }
                    }
                    fImage[(y - GAP) * imageW + (x - GAP)] = kernelSum;
                }
            });

            byte[] res = new byte[imageW * imageH];


            Parallel.For(0, imageH, y =>
            {
                for (int x = 0; x < imageW; x++)
                {
                    res[y * imageW + x] = (byte)fImage[y * imageW + x];
                }
            });

            return res;
        }
        public static double[] /***/HC_FILTER_Convolution(double[] fKernel, double[] fRawImage, int imageW, int imageH)
        {
            int KSIZE = (int)Math.Sqrt(fKernel.Length);
            int GAP = KSIZE / 2;

            double[] rawExpanded = (double[])ARRAY_Padding_ALL(fRawImage, imageW, imageH, GAP);

            double[] fRawRes = new double[imageW * imageH];

            int imageNewW = imageW + GAP * 2;
            int imageNewH = imageH + GAP * 2;

            Parallel.For(GAP, imageNewH - GAP, y =>
            {
                for (int x = GAP; x < imageNewW - GAP; x++)
                {
                    double kernelSum = 0;
                    for (int j = -GAP; j <= GAP; j++)
                    {
                        for (int k = -GAP; k <= GAP; k++)
                        {
                            kernelSum += (fKernel[(j + GAP) * KSIZE + k + GAP] * rawExpanded[(y - j) * imageNewW + (x - k)]);
                        }
                    }
                    fRawRes[(y - GAP) * imageW + (x - GAP)] = kernelSum;
                }
            });
            return fRawRes;
        }
        public static byte[] /*****/HC_FILTER_ConvolutionWindow(double[] fKernel, byte[] rawImage, int imageW, int imageH, Rectangle rc)
        {
            double[] fImage = new double[rawImage.Length];

            int KSIZE = (int)Math.Sqrt(fKernel.Length);
            int GAP = KSIZE / 2;

            //for( int y = rc.Y; y < rc.Y + rc.Height; y++)
            Parallel.For(rc.Y, rc.Y + rc.Height, y =>
            {
                for (int x = rc.X; x < rc.X + rc.Width; x++)
                {
                    double kernelSum = 0;
                    for (int j = -GAP; j <= GAP; j++)
                    {
                        for (int k = -GAP; k <= GAP; k++)
                        {
                            kernelSum += (fKernel[(j + GAP) * KSIZE + k + GAP] * rawImage[(y - j) * imageW + (x - k)]);
                        }
                    }
                    //fImage[(y - GAP) * imageW + (x - GAP)] = kernelSum;
                    fImage[y * imageW + x] = kernelSum;
                }
            });

            Parallel.For(rc.Y, rc.Y + rc.Height, y =>
            {
                for (int x = rc.X; x < rc.X + rc.Width; x++)
                {
                    rawImage[y * imageW + x] = (byte)fImage[y * imageW + x];
                }
            });

            return rawImage;
        }
      
        public static double[] ARRAY_GetMeanImage(double[] rawImage, int imageW, int imageH, int nKernelSize)
        {
            int nGap = nKernelSize / 2;

            double[] fPadding = (double[])ARRAY_Padding_ALL(rawImage, imageW, imageH, nGap);

            double[] fmeanImage = new double[imageW * imageH];

            int nCount = nKernelSize * nKernelSize;
            
            for (int y = nGap; y < imageH + nGap; y++)
            //Parallel.For(nGap, imageH + nGap, y =>
            {
                for (int x = nGap; x < imageW + nGap; x++)
                {
                    double fBlockSum = 0x00;
                    for (int yy = y - nGap; yy <= y + nGap; yy++)
                    {
                        for (int xx = x - nGap; xx <= x + nGap; xx++)
                        {
                            fBlockSum += fPadding[yy * (imageW + nGap * 2) + xx];
                        }
                    }
                    fmeanImage[(y - nGap) * imageW + (x - nGap)] = fBlockSum / nCount;
                }
            }//);

            return fmeanImage;
        }
        public static double[] ARRAY_GetPowImage(double[] fImage)
        {
            double[] fPowImage = new double[fImage.Length];

            // in double case : just do it
            Parallel.For(0, fImage.Length, i =>
            {
                fPowImage[i] = fImage[i] * fImage[i];
                    
            });
            return fPowImage;
        }


        public static byte[] HC_CropImage_Overlap(byte[] rawInput, int imageW, int imageH, byte[] cropImage, int cropW, int cropH, RectangleF rc)
        {
            int posX = Convert.ToInt32(rc.X);
            int posY = Convert.ToInt32(rc.Y);
            Parallel.For(0, cropH, y => { Buffer.BlockCopy(cropImage, y * cropW, rawInput, (posY + y) * imageW + posX, cropW); });
            return rawInput;
        }
        public static byte[] ARRAY_GetNormalizedImage(double[] fImage)
        {
            double MIN = fImage.Min();
            double MAX = fImage.Max();

            if (double.IsNaN(MIN)){MIN = 0;}

            double RANGE = MAX - MIN;

            byte[] rawImage = new byte[fImage.Length];

            //for( int i = 0; i < rawImage.Length; i++ )
            Parallel.For(0, fImage.Length, i =>
            {
                double fValue = 0;

                /*****/if (RANGE != 0){fValue = ((fImage[i] - MIN) / (RANGE)) * 255.0;}
                //else if (RANGE == 0){ fValue = 0; }

                /***/if( double.IsNaN(fValue) == false){fValue = (int)(fValue);}
                else if (double.IsNaN(fValue) == true ){fValue = 0;}

                rawImage[i] = (byte)fValue;
            });
            return rawImage;
        }
        #endregion

        public static byte[] HC_FILTER_STD_Window(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nKernelSize, double powValue = 0.5)
        {
            int cropW = (int)rc.Width;
            int cropH = (int)rc.Height;
            byte[] cropImage = HC_CropImage(rawImage, imageW, imageH, rc);

            double[] fImageCrop = null;
            Parallel.Invoke(() => { fImageCrop = cropImage.Select(element => (double)element).ToArray(); });

            SaveImage(cropImage, cropW, cropH, "c:\\micle.bmp");

            double[] meanPow = ARRAY_GetMeanImage(fImageCrop, cropW, cropH, nKernelSize);
            meanPow = ARRAY_GetPowImage(meanPow);

            double[] powMean = ARRAY_GetPowImage(fImageCrop);
            powMean = ARRAY_GetMeanImage(powMean, cropW, cropH, 5);


            for (int i = 0; i < meanPow.Length; i++)
            //Parallel.For(0, meanPow.Length, i =>
            {
                double fValue1 = powMean[i];
                double fValue2 = meanPow[i];
                double fValue3 = fValue1 - fValue2;
                double fvalue4 = Math.Pow(fValue3, powValue);

                if (double.IsNaN(fvalue4) == true)
                {
                    fvalue4 = 0;
                }

                fImageCrop[i] = fvalue4;
            }
            byte[] cropRaw = ARRAY_GetNormalizedImage(fImageCrop); ;

            return HC_CropImage_Overlap(rawImage, imageW, imageH, cropRaw, cropW, cropH, rc);
        }
        public static byte[] HC_FILTER_STD(byte[] rawImage, int imageW, int imageH, int nKernelSize, double powValue=0.5)
        {
            double[] fImage = rawImage.Select(element => (double)element).ToArray();

            double[] meanPow = ARRAY_GetMeanImage(fImage, imageW, imageH, nKernelSize);
            meanPow = ARRAY_GetPowImage(meanPow);

            double[] powMean = ARRAY_GetPowImage(fImage);
            powMean = ARRAY_GetMeanImage(powMean, imageW, imageH, nKernelSize);

            for (int i = 0; i < meanPow.Length; i++)
            //Parallel.For(0, meanPow.Length, i =>
            {
                double fValue1 = powMean[i];
                double fValue2 = meanPow[i];
                double fValue3 = fValue1 - fValue2;
                double fvalue4 = Math.Pow(fValue3, powValue);

                if (double.IsNaN(fvalue4) == true)
                {
                    fvalue4 = 0;
                }

                fImage[i] = fvalue4;
            }
            return ARRAY_GetNormalizedImage(fImage); ;
        }

        public static byte[] HC_TRANS_SIGMOID_Contrast(byte[] rawImage, int imageW, int imageH, double fCutoff, double fGain)
        {
            double[] fImage = HC_CONV_Byte2Double(rawImage);

            double min = fImage.Min();
            Parallel.For(0, fImage.Length, i => { fImage[i] -= min; });

            // devision max
            double max = fImage.Max();

            Parallel.For(0, fImage.Length, i => { fImage[i] /= max; });

            // case 2 : gamma 
            Parallel.For(0, fImage.Length, i =>
            {
                double fValue = (fCutoff - fImage[i]) * fGain;
                fImage[i] = 1.0 / (1.0 + Math.Exp(fValue));
            });

            return ARRAY_GetNormalizedImage(fImage);

        }

        public static byte[] HC_FILTER_ADF(byte[] rawImage, int imageW, int imageH, double fKappa, double iter, double fDelta)
        {
            double[] KernelN = new double[9] { 0, 1, 0, 0, -1, 0, 0, 0, 0 };
            double[] KernelS = new double[9] { 0, 0, 0, 0, -1, 0, 0, 1, 0 };
            double[] KernelE = new double[9] { 0, 0, 0, 0, -1, 1, 0, 0, 0 };
            double[] KernelW = new double[9] { 0, 0, 0, 1, -1, 0, 0, 0, 0 };
            double[] KernelNE = new double[9] { 0, 0, 1, 0, -1, 0, 0, 0, 0 };
            double[] KernelSE = new double[9] { 0, 0, 0, 0, -1, 0, 0, 0, 1 };
            double[] KernelSW = new double[9] { 0, 0, 0, 0, -1, 0, 1, 0, 0 };
            double[] KernelNW = new double[9] { 1, 0, 0, 0, -1, 0, 0, 0, 0 };


            double[] rawImageN = new double[imageW * imageH];
            double[] rawImageS = new double[imageW * imageH];
            double[] rawImageE = new double[imageW * imageH];
            double[] rawImageW = new double[imageW * imageH];
            double[] rawImageNE = new double[imageW * imageH];
            double[] rawImageSE = new double[imageW * imageH];
            double[] rawImageSW = new double[imageW * imageH];
            double[] rawImageNW = new double[imageW * imageH];

            double[] diffusN = new double[imageW * imageH];
            double[] diffusS = new double[imageW * imageH];
            double[] diffusE = new double[imageW * imageH];
            double[] diffusW = new double[imageW * imageH];

            double[] diffusNE = new double[imageW * imageH];
            double[] diffusSE = new double[imageW * imageH];
            double[] diffusNW = new double[imageW * imageH];
            double[] diffusSW = new double[imageW * imageH];


            double[] fImage = HC_CONV_Byte2Double(rawImage);

            double dx = 1.0 / Math.Pow(1.0, 2);
            double dy = 1.0 / Math.Pow(1.0, 2);
            double dxy = 1.0 / Math.Pow(Math.Sqrt(2), 2);

            for (int loop = 0; loop < iter; loop++)
            {
                rawImageN = HC_FILTER_Convolution(KernelN, fImage, imageW, imageH);
                rawImageS = HC_FILTER_Convolution(KernelS, fImage, imageW, imageH);
                rawImageE = HC_FILTER_Convolution(KernelE, fImage, imageW, imageH);
                rawImageW = HC_FILTER_Convolution(KernelW, fImage, imageW, imageH);

                rawImageNE = HC_FILTER_Convolution(KernelNE, fImage, imageW, imageH);
                rawImageSE = HC_FILTER_Convolution(KernelSE, fImage, imageW, imageH);
                rawImageNW = HC_FILTER_Convolution(KernelNW, fImage, imageW, imageH);
                rawImageSW = HC_FILTER_Convolution(KernelSW, fImage, imageW, imageH);

                CalcDifussion(rawImageN, diffusN, fKappa);
                CalcDifussion(rawImageS, diffusS, fKappa);
                CalcDifussion(rawImageE, diffusE, fKappa);
                CalcDifussion(rawImageW, diffusW, fKappa);

                CalcDifussion(rawImageNE, diffusNE, fKappa);
                CalcDifussion(rawImageSE, diffusSE, fKappa);
                CalcDifussion(rawImageNW, diffusNW, fKappa);
                CalcDifussion(rawImageSW, diffusSW, fKappa);

                Parallel.For(0, imageW * imageH, i =>
                {
                    fImage[i] = fImage[i] + fDelta *
                        (
                              diffusN[i] * rawImageN[i] * dx
                            + diffusS[i] * rawImageS[i] * dx
                            + diffusE[i] * rawImageE[i] * dy
                            + diffusW[i] * rawImageW[i] * dy
                            + diffusNE[i] * rawImageNE[i] * dxy
                            + diffusSE[i] * rawImageSE[i] * dxy
                            + diffusNW[i] * rawImageNW[i] * dxy
                            + diffusSW[i] * rawImageSW[i] * dxy
                        ); ;
                });

            }

            CalcDiffuseNormal(fImage);

            rawImage = HC_CONV_Double2Byte(fImage);

            return rawImage;
        }
        private static double[] CalcDifussion(double[] rawImage, double[] fImage, double fkappa)
        {
            int nLength = rawImage.Length;

            Parallel.For(0, nLength, i =>
            {
                fImage[i] = Math.Exp(-Math.Pow((rawImage[i] / fkappa), 2));
            });

            return fImage;
        }
        private static void CalcDiffuseNormal(double[] fImage)
        {
            double fMax = fImage.Max();
            double fMin = fImage.Min();

            double fRange = fMax - fMin;

            Parallel.For(0, fImage.Length, i =>
            {
                fImage[i] = (fImage[i] - fMin) / fRange;
                fImage[i] *= 255;
            });
        }

        public static double[] HC_FILTER_GenerateGaussianFilter(double fSigma, int nKSize)
        {
            double[] fKernel = new double[nKSize * nKSize];

            int GAP = nKSize / 2;

            for (int y = -GAP; y <= GAP; y++)
            {
                for (int x = -GAP; x <= GAP; x++)
                {
                    fKernel[(y + GAP) * nKSize + x + GAP] = x;
                }
            }

            double s = 2.0 * fSigma * fSigma;

            double fSum = 0;

            for (int x = -GAP; x <= GAP; x++)
            {
                for (int y = -GAP; y <= GAP; y++)
                {
                    double r = Math.Sqrt(x * x + y * y);

                    fKernel[(y + GAP) * nKSize + x + GAP] = Math.Exp((-((r * r) / s))) / (s * Math.PI);
                    fSum += fKernel[(y + GAP) * nKSize + x + GAP];
                }
            }

            for (int y = 0; y < nKSize; y++)
            {
                for (int x = 0; x < nKSize; x++)
                {
                    fKernel[y * nKSize + x] /= fSum;
                }
            }

            return fKernel;
        }
 
        public static int GetMaxElementPosition(double[] array)
        {
            double fMax = array.Max();
            int nIndex = Array.IndexOf(array, fMax);

            return nIndex;
        }
        public static int GetMinElementPosition(double[] array)
        {
            double fMin = array.Min();
            int nIndex = Array.IndexOf(array, fMin);
            return nIndex;
        }
        
    }

    public class CModelEllipse
    {
        public double a, b, c, d, e, f;	// 타원방정식: ax^2 + bxy + cy^2 + dx + ey + f = 0
        public double cx, cy, w, h;		// 표준 형태: (x - cx)^2/w^2 + (y - cy)^2/h^2 = 1
        public double theta;				// 표준 형태 타원의 기울어진 각도

        public bool convert_std_form()
        {
            // 타원 방정식에서 표준 형태의 타원의 매개변수로 변경
            // 참조: http://blog.naver.com/helloktk/80035366367

            // orientation of ellipse;    
            theta = Math.Atan2(b, a - c) / 2.0;
            // scaled major/minor axes of ellipse;
            double ct = Math.Cos(theta);
            double st = Math.Sin(theta);
            double ap = a * ct * ct + b * ct * st + c * st * st;
            double cp = a * st * st - b * ct * st + c * ct * ct;

            // translations 
            cx = (2 * c * d - b * e) / (b * b - 4 * a * c);
            cy = (2 * a * e - b * d) / (b * b - 4 * a * c);

            // scale factor
            double val = a * cx * cx + b * cx * cy + c * cy * cy;
            double scale_inv = val - f;

            if (scale_inv / ap <= 0 || scale_inv / cp <= 0)
            {
                //not ellipse;
                return false;
            }

            w = Math.Sqrt(scale_inv / ap);
            h = Math.Sqrt(scale_inv / cp);
            return true;
        }
    }
    public class CModelLine
    {
        public double mx = 0;
        public double my = 0;
        public double sx = 0;
        public double sy = 0;

        public CModelLine()
        {
            mx = my = sx = sy = 0;
        }
    }
    public class CModelCircle
    {
        public double cx = 0;
        public double cy = 0;
        public double r = 0;

        public CModelCircle()
        {
            cx = cy = r = 0;
        }
    }

    public static class CRansac
    {
        //*****************************************************************************************
        // Random samples
        //*****************************************************************************************

        public static void get_samples(ref List<PointF> samples, int no_samples, PointF [] data)
        {
            Random rand = new Random();

            // 데이터에서 중복되지 않게 N개의 무작위 셈플을 채취한다.
            for (int i = 0; i < data.Length; i++ )
            {
                int nRand = rand.Next(0, data.Length-1);
            
                if (!find_in_samples(samples, data.ElementAt(nRand)))
                {
                    samples.Add(data[nRand]);
                    if (samples.Count == no_samples)
                    {
                        break;
                    }
                }
            }
            //for( int i = 0; i < no_samples; i++)
            //{
            //    samples.Add(data.ElementAt(i));
            //}
        }
        private static bool find_in_samples(List<PointF>  samples, PointF data)
            {
                for (int i = 0; i < samples.Count; ++i)
                {
                    if (samples[i].X == data.X && samples[i].Y == data.Y)
                    {
                        return true;
                    }
                }
                return false;
            }

        //*****************************************************************************************
        // Ellipse Fitting
        //*****************************************************************************************

        public static double ransac_ellipse_fitting(PointF[] data, ref CModelEllipse model, double distance_threshold)
        {
            const int no_samples = 30;
            int no_data = data.Length;

            if (no_data < no_samples)
            {
                return 0.0;
            }

            List<PointF> samples = new List<PointF>(); // count 5
            List<PointF> inliers = new List<PointF>(); // count 5;

            CModelEllipse estimated_model;
            double max_cost = 0.0;

            int max_iteration = (int)(1 + Math.Log(1.0 - 0.99) / Math.Log(1.0 - Math.Pow(0.5, no_samples)));


            for (int i = 0; i < 50; i++)
            {
                samples.Clear();

                // 1. hypothesis
                // 원본 데이터에서 임의로 N개의 셈플 데이터를 고른다.

                get_samples(ref samples, no_samples, data);

                // 이 데이터를 정상적인 데이터로 보고 모델 파라메터를 예측한다.
                estimated_model = compute_ellipse_model(ref samples);
                if (!estimated_model.convert_std_form()) { --i; continue; }

                // 2. Verification

                // 원본 데이터가 예측된 모델에 잘 맞는지 검사한다.
                double cost = verify_ellipse(inliers, ref estimated_model, data, distance_threshold);

                // 만일 예측된 모델이 잘 맞는다면, 이 모델에 대한 유효한 데이터로 새로운 모델을 구한다.
                if (max_cost < cost)
                {
                    max_cost = cost;

                    model = compute_ellipse_model(ref inliers);
                    model.convert_std_form();
                }
            }
            return max_cost;
        }
        
        //★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★

        public static CModelEllipse compute_ellipse_model(ref List<PointF> samples)
        {
            // 타원 방정식: x^2 + axy + by^2 + cx + dy + e = 0

            DotNetMatrix.Matrix A = new DotNetMatrix.Matrix(samples.Count, 5);
            DotNetMatrix.Matrix B = new DotNetMatrix.Matrix(samples.Count, 1);

            for (int i = 0; i < samples.Count; i++)
            {
                double x = samples[i].X;
                double y = samples[i].Y;

                A.SetElement(i, 0, x * y);
                A.SetElement(i, 1, y * y);
                A.SetElement(i, 2, x);
                A.SetElement(i, 3, y);
                A.SetElement(i, 4, 1.0);

                B.SetElement(i, 0, -x * x);
            }

            // AX=B 형태의 해를 least squares solution으로 구하기 위해
            // Moore-Penrose pseudo-inverse를 이용한다.
            //DotNetMatrix.Matrix invA = 

            DotNetMatrix.Matrix transA = A.Transpose();
            DotNetMatrix.Matrix multiA = transA.Multiply(A);
            DotNetMatrix.Matrix InverA = multiA.Inverse();
            DotNetMatrix.Matrix invA = InverA.Multiply(transA);
            //dMatrix invA = !(~A*A)*~A;

            DotNetMatrix.Matrix X = invA.Multiply(B);

            // c가 1보다 클 때는 c를 1이 되도록 ratio 값을 곱해준다.
            double ratio = (X.GetElement(1, 0) > 1.0) ? 1.0 / X.GetElement(1, 0) : 1.0;

            CModelEllipse model = new CModelEllipse();

            model.a = ratio * 1.0;
            model.b = ratio * X.GetElement(0, 0);
            model.c = ratio * X.GetElement(1, 0);
            model.d = ratio * X.GetElement(2, 0);
            model.e = ratio * X.GetElement(3, 0);
            model.f = ratio * X.GetElement(4, 0);

            return model;
        }
        public static double /*****/compute_ellipse_distance(ref CModelEllipse ellipse, PointF p)
        {
            // 한 점 p에서 타원에 내린 수선의 길이를 계산하기 힘들다.
            // 부정확하지만, 간단히 하기위하여 대수적 거리를 계산한다.
            double x = p.X;
            double y = p.Y;

            double e = Math.Abs(ellipse.a * x * x + ellipse.b * x * y + ellipse.c * y * y + ellipse.d * x + ellipse.e * y + ellipse.f);
            return Math.Sqrt(e);
        }
        public static double /*****/verify_ellipse (List<PointF> inliers, ref CModelEllipse estimated_model, PointF [] data, double distance_threshold)
        {
            inliers.Clear();


            double cost = 0.0;
            
            for(int i=0; i< data.Length; i++)
            {
		        // 직선에 내린 수선의 길이를 계산한다.
		        double distance = compute_ellipse_distance(ref estimated_model, data[i]);
	
		        // 예측된 모델에서 유효한 데이터인 경우, 유효한 데이터 집합에 더한다.
		        if (distance < distance_threshold) 
                {
			        cost += 1.0;

                    inliers.Add(data[i]);
		        }
            }
    
            return cost;
        }
        public static List<PointF> EllipseRot (CModelEllipse ellipse)
        {
            double ct = Math.Cos(ellipse.theta);
	        double st = Math.Sin(ellipse.theta);

            List<PointF> list = new List<PointF>();

            for (int i=0; i<=360; i+=1) 
            {
		        double a = i* Math.PI/180.0;
		        double x = ellipse.w*Math.Cos(a);
		        double y = ellipse.h*Math.Sin(a);

		        double rx = x*ct - y*st;
		        double ry = x*st + y*ct;
                    
                double newX = ellipse.cx + rx;
                double newY = ellipse.cy + ry;

                list.Add(new PointF( (float) newX, (float)newY));
            }

            return list;
        }

        //*****************************************************************************************
        // Line Fitting
        //*****************************************************************************************

        public static double ransac_Line_fitting(PointF[] data, ref CModelLine model, double distance_threshold, int no_samples, int iter)
        {
             int no_data = data.Length;

            if (no_data < no_samples)
            {
                return 0.0;
            }

            List<PointF> samples = new List<PointF>(); // count 5
            List<PointF> inliers = new List<PointF>(); // count 5;

            CModelLine estimated_model;
            double max_cost = 0.0;

            int max_iteration = (int)(1 + Math.Log(1.0 - 0.99) / Math.Log(1.0 - Math.Pow(0.5, no_samples)));

            for (int i = 0; i < iter; i++)
            {
                samples.Clear();

                // 1. hypothesis
                // 원본 데이터에서 임의로 N개의 셈플 데이터를 고른다.

                get_samples(ref samples, no_samples, data);

                // 이 데이터를 정상적인 데이터로 보고 모델 파라메터를 예측한다.
                estimated_model = compute_model_line(ref samples);

                // 2. Verification
                // 원본 데이터가 예측된 모델에 잘 맞는지 검사한다.
                double cost = verify_line(inliers, ref estimated_model, data, distance_threshold);

                // 만일 예측된 모델이 잘 맞는다면, 이 모델에 대한 유효한 데이터로 새로운 모델을 구한다.
                if (max_cost < cost)
                {
                    max_cost = cost;

                    model = compute_model_line(ref inliers);
                }
            }
            return max_cost;
        }

        //★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★

        public static CModelLine compute_model_line(ref List<PointF> samples)
        {
            // PCA 방식으로 직선 모델의 파라메터를 예측한다.

            double sx = 0, sy = 0;
            double sxx = 0, syy = 0;
            double sxy = 0, sw = 0;

            for (int i = 0; i < samples.Count; ++i)
            {
                double x = samples[i].X;
                double y = samples[i].Y;

                sx += x;
                sy += y;
                sxx += x * x;
                sxy += x * y;
                syy += y * y;
                sw += 1;
            }

            //variance;
            double vxx = (sxx - sx * sx / sw) / sw;
            double vxy = (sxy - sx * sy / sw) / sw;
            double vyy = (syy - sy * sy / sw) / sw;

            //principal axis
            double theta = Math.Atan2(2 * vxy, vxx - vyy) / 2.0;

            CModelLine model = new CModelLine();

            model.mx = Math.Cos(theta);
            model.my = Math.Sin(theta);

            //center of mass(xc, yc)
            model.sx = sx / sw;
            model.sy = sy / sw;

            //직선의 방정식: sin(theta)*(x - sx) = cos(theta)*(y - sy);
            return model;
        }
        public static double /**/compute_line_distance(ref CModelLine model, PointF p)
        {
            // 한 점(x)로부터 직선(line)에 내린 수선의 길이(distance)를 계산한다.
            return Math.Abs((p.X - model.sx) * model.my - (p.Y - model.sy) * model.mx) / Math.Sqrt(model.mx * model.mx + model.my * model.my);
        }
        public static double /**/verify_line(List<PointF> inliers, ref CModelLine estimated_model, PointF[] data, double distance_threshold)
            {
                inliers.Clear();


                double cost = 0.0;

                for (int i = 0; i < data.Length; i++)
                {
                    // 직선에 내린 수선의 길이를 계산한다.
                    double distance = compute_line_distance(ref estimated_model, data[i]);

                    // 예측된 모델에서 유효한 데이터인 경우, 유효한 데이터 집합에 더한다.
                    if (distance < distance_threshold)
                    {
                        cost += 1.0;

                        inliers.Add(data[i]);
                    }
                }

                return cost;
            }

        //*****************************************************************************************
        // Circle Fitting
        //*****************************************************************************************

        public static double ransac_Circle_fitting(PointF[] data, ref CModelCircle model, double distance_threshold, int no_samples, int iter)
        {
            int no_data = data.Length;

            if (no_data < no_samples)
            {
                return 0.0;
            }

            List<PointF> samples = new List<PointF>(); // count 5
            List<PointF> inliers = new List<PointF>(); // count 5;

            CModelCircle model_buffer = new CModelCircle();
            double max_cost = 0.0;

            int max_iteration = (int)(1 + Math.Log(1.0 - 0.99) / Math.Log(1.0 - Math.Pow(0.5, no_samples)));


            for (int i = 0; i < iter; i++)
            {
                samples.Clear();

                // 1. hypothesis
                // 원본 데이터에서 임의로 N개의 셈플 데이터를 고른다.

                get_samples(ref samples, no_samples, data);

                // 이 데이터를 정상적인 데이터로 보고 모델 파라메터를 예측한다.
                model = compute_circle_model(ref samples);

                // 2. Verification
                // 원본 데이터가 예측된 모델에 잘 맞는지 검사한다.
                double cost = verify_circle(inliers, ref model, data, distance_threshold);

                // 만일 예측된 모델이 잘 맞는다면, 이 모델에 대한 유효한 데이터로 새로운 모델을 구한다.
                if (max_cost < cost)
                {
                    max_cost = cost;

                    model = compute_circle_model(ref inliers);
                }
            }
            if (max_cost == 0)
            {
                model = model_buffer;
            }
            return max_cost;
        }

        //★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★

        public static CModelCircle compute_circle_model(ref List<PointF> samples)
        {
            // 중심 (a,b), 반지름 c인 원의 방정식: (x - a)^2 + (y - b)^2 = c^2
	        // 식을 전개하면: x^2 + y^2 - 2ax - 2by + a^2 + b^2 - c^2 = 0
            DotNetMatrix.Matrix A = new DotNetMatrix.Matrix(samples.Count, 3);
            DotNetMatrix.Matrix B = new DotNetMatrix.Matrix(samples.Count, 1);


            for (int i = 0; i < samples.Count; i++)
            {
                double x = samples[i].X;
                double y = samples[i].Y;

                A.SetElement(i, 0, x);
                A.SetElement(i, 1, y);
                A.SetElement(i, 2, 1.0);

                B.SetElement(i, 0, (-x * x) - (y*y));
            }

            // AX=B 형태의 해를 least squares solution으로 구하기 위해
            // Moore-Penrose pseudo-inverse를 이용한다.
            //DotNetMatrix.Matrix invA = 

            DotNetMatrix.Matrix transA = A.Transpose();
            DotNetMatrix.Matrix multiA = transA.Multiply(A);
            DotNetMatrix.Matrix InverA = multiA.Inverse();
            DotNetMatrix.Matrix invA = InverA.Multiply(transA);
            //dMatrix invA = !(~A*A)*~A;

            DotNetMatrix.Matrix X = invA.Multiply(B);

            CModelCircle model = new CModelCircle();
            
            double cx = -X.GetElement(0, 0) / 2.0;
            double cy = -X.GetElement(1, 0) / 2.0;

            model.r = Math.Sqrt(cx * cx + cy * cy - X.GetElement(2, 0));
            model.cx = cx;
            model.cy = cy;

            return model;
        }
        public static double /****/compute_circle_distance(ref CModelCircle model, PointF p)
        {
            // 원의 둘레로부터 떨어진 거리를 계산한다.
            // 즉, 점 x와 원의 중심 까지의 거리를 구해서 원의 반지름을 뺀다.

            double dx = model.cx - p.X;
            double dy = model.cy- p.Y;

            return Math.Abs(Math.Sqrt(dx * dx + dy * dy) - model.r);
        }
        public static double /****/verify_circle(List<PointF> inliers, ref CModelCircle estimated_model, PointF[] data, double distance_threshold)
        {
            inliers.Clear();


            double cost = 0.0;

            for (int i = 0; i < data.Length; i++)
            {
                // 직선에 내린 수선의 길이를 계산한다.
                double distance = compute_circle_distance(ref estimated_model, data[i]);

                // 예측된 모델에서 유효한 데이터인 경우, 유효한 데이터 집합에 더한다.
                if (distance < distance_threshold)
                {
                    cost += 1.0;

                    inliers.Add(data[i]);
                }
            }

            return cost;
        }

    }
}
