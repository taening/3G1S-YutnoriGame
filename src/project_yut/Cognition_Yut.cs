using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace project_yut
{
    public class Cognition_Yut
    {
        public int[] r_mode = new int[] { 0, 0, 116 };
        public int[] g_mode = new int[] { 0, 116, 0 };
        public int[] b_mode = new int[] { 150, 0, 0 };
        public int[] y_mode = new int[] { 0, 0, 0 };
        const int sigma = 27;
        const int height = 240;
        const int width = 320;

        public IplImage Adapt_Gaussian(IplImage mask_frame, IplImage ori_frame, out int yut)
        {
            int yut_cnt = 0;
            IplImage prob_map = new IplImage(mask_frame.Size, BitDepth.U8, 3);
            bool[] RGBY_bool = new bool[] { false, false, false, false }; ;
            int red_cnt = 0, green_cnt = 0, blue_cnt = 0, black_cnt = 0;
            for (int nRow = 0; nRow < height; nRow++)
            {
                for (int nCol = 0; nCol < width; nCol++)
                {
                    if (mask_frame[nRow, nCol] == 0)
                    {
                        // RGBY_bool[0] = 빨강, [1] = 초록, [2] = 파랑, [3] = 노랑
                        RGBY_bool[0] = Activation_Func(ori_frame[nRow, nCol], r_mode);
                        RGBY_bool[1] = Activation_Func(ori_frame[nRow, nCol], g_mode);
                        RGBY_bool[2] = Activation_Func(ori_frame[nRow, nCol], b_mode);
                        RGBY_bool[3] = Activation_Func(ori_frame[nRow, nCol], y_mode);

                        if (RGBY_bool[0] == true)
                        {
                            prob_map[nRow, nCol] = 255;
                            red_cnt++;
                        }
                        if (RGBY_bool[1] == true)
                        {
                            prob_map[nRow, nCol] = 255;
                            green_cnt++;
                        }
                        if (RGBY_bool[2] == true)
                        {
                            prob_map[nRow, nCol] = 255;
                            blue_cnt++;
                        }
                        if (RGBY_bool[3] == true)
                        {
                            prob_map[nRow, nCol] = 255;
                            black_cnt++;
                        }
                    }
                }
            }
            Console.WriteLine("Red_cnt" + red_cnt);
            Console.WriteLine("Blue_cnt" + blue_cnt);
            Console.WriteLine("Green_cnt" + green_cnt);
            Console.WriteLine("Black_cnt" + black_cnt);

            if (red_cnt >= 700) { yut_cnt++; }
            if (green_cnt >= 700) { yut_cnt++; }
            if (blue_cnt >= 700) { yut_cnt++; }
            if (black_cnt >= 700) { yut_cnt++; }
            if(yut_cnt==0) { yut_cnt = 5; }
            Console.WriteLine(yut_cnt);
            Console.WriteLine();

            yut = yut_cnt;

            return prob_map;
        }

        private bool Activation_Func(CvScalar value, int[] mean)
        {
            bool[] BGR_bool = new bool[] { false, false, false };
            if (value[0] < mean[0] + sigma * 2 && value[0] > mean[0] - sigma * 2) { BGR_bool[0] = true; }
            if (value[1] < mean[1] + sigma * 2 && value[1] > mean[1] - sigma * 2) { BGR_bool[1] = true; }
            if (value[2] < mean[2] + sigma * 2 && value[2] > mean[2] - sigma * 2) { BGR_bool[2] = true; }

            if (BGR_bool[0] == true && BGR_bool[1] == true && BGR_bool[2] == true) { return true; }
            else { return false; }
        }
    }
}
