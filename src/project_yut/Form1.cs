using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace project_yut
{
    public struct info_yut
    {
        public int pos;
        public string color;
        public int blink;
    }

    public partial class Form1 : Form
    {
        // OpenCv 관련 전역변수
        CvCapture cap;
        Cognition_Yut cam = new Cognition_Yut();
        List<int> info_yut = new List<int>();

        const int height = 240;
        const int width = 320;

        // 윷놀이 관련 전역변수
        private List<PictureBox> picPlace = new List<PictureBox>();

        List<int> result_yut = new List<int>();
        List<int> move_piece = new List<int>();
        List<int> move_yut = new List<int>();
        Piece[] piece_red = new Piece[4];
        Piece[] piece_blue = new Piece[4];

        private bool isTurnRed = true;
        private int present_piece = 0;
        private int present_movement = 0;
        private int number_of_select = 0;
        private int number_of_case = 0;

        private bool isYutFront = true;
        private bool isYutStop = true;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            start();
        }

        private void start()
        {
            // 1. OpenCv PictureBox초기화
            ipicBin.Image = null;
            ipicMask.Image = null;
            ipicResult.Image = null;

            lblR.Text = Convert.ToString(barR.Value);
            cam.r_mode[2] = barR.Value;
            lblG.Text = Convert.ToString(barG.Value);
            cam.g_mode[1] = barG.Value;
            lblB.Text = Convert.ToString(barB.Value);
            cam.b_mode[0] = barB.Value;
            lblThreshold.Text = Convert.ToString(barThreshold.Value);

            // 2. 윷놀이판 초기화
            picPlace.Add(picPlace0);
            picPlace.Add(picPlace1);
            picPlace.Add(picPlace2);
            picPlace.Add(picPlace3);
            picPlace.Add(picPlace4);
            picPlace.Add(picPlace5);
            picPlace.Add(picPlace6);
            picPlace.Add(picPlace7);
            picPlace.Add(picPlace8);
            picPlace.Add(picPlace9);
            picPlace.Add(picPlace10);
            picPlace.Add(picPlace11);
            picPlace.Add(picPlace12);
            picPlace.Add(picPlace13);
            picPlace.Add(picPlace14);
            picPlace.Add(picPlace15);
            picPlace.Add(picPlace16);
            picPlace.Add(picPlace17);
            picPlace.Add(picPlace18);
            picPlace.Add(picPlace19);
            picPlace.Add(picPlace20);
            picPlace.Add(picPlace21);
            picPlace.Add(picPlace22);
            picPlace.Add(picPlace23);
            picPlace.Add(picPlace24);
            picPlace.Add(picPlace25);
            picPlace.Add(picPlace26);
            picPlace.Add(picPlace27);
            picPlace.Add(picPlace28);

            for (int i = 0; i <= 3; i++)
            {
                piece_red[i] = new Piece(true);
                piece_blue[i] = new Piece(false);
            }
            isTurnRed = true;
            picBlueTurn.Image = Properties.Resources._null;
            picRedTurn.Image = Properties.Resources.red_turn;

            display(false);
        }

        private void yut_throw()
        {
            timYutAsk.Enabled = true;
            result_yut.Clear();
            lblYutStatus.Text = "윷을 굴려주세요.";
            lblStatus.Text = "윷을 던지기를 기다리는 중";
            display(false);
            communication_led(false, false);

            picYut0.Image = Properties.Resources.Front;
            picYut1.Image = Properties.Resources.Front;
            picYut2.Image = Properties.Resources.Front;
            picYut3.Image = Properties.Resources.Front;
            isYutFront = true;
            isYutStop = false;
            timYutEffect.Enabled = true;
        }

        private void timYutEffect_Tick(object sender, EventArgs e)
        {
            if (isYutStop) return;
            if (picYut0.Image != picYut1.Image) picYut1.Image = picYut0.Image;
            else if (picYut1.Image != picYut2.Image) picYut2.Image = picYut1.Image;
            else if (picYut2.Image != picYut3.Image) picYut3.Image = picYut2.Image;
            else
            {
                if (isYutFront) { picYut0.Image = Properties.Resources.Back; isYutFront = false; }
                else { picYut0.Image = Properties.Resources.Front; isYutFront = true; }
            }
        }

        private void display(bool priority)
        {
            for (int i = 0; i <= 28; i++)
                picPlace[i].Image = Properties.Resources._null;

            int red_initial = 0;
            int red_goal = 0;
            int blue_initial = 0;
            int blue_goal = 0;

            for (int i = 0; i <= 3; i++)
            {
                if (piece_red[i].initial) red_initial++;
                if (piece_red[i].goal) red_goal++;
                if (piece_blue[i].initial) blue_initial++;
                if (piece_blue[i].goal) blue_goal++;
            }

            switch(red_initial)
            {
                case 0:
                    picRedStart.Image = Properties.Resources._null;
                    break;
                case 1:
                    picRedStart.Image = Properties.Resources.red1;
                    break;
                case 2:
                    picRedStart.Image = Properties.Resources.red2;
                    break;
                case 3:
                    picRedStart.Image = Properties.Resources.red3;
                    break;
                case 4:
                    picRedStart.Image = Properties.Resources.red4;
                    break;
            }

            switch(blue_initial)
            {
                case 0:
                    picBlueStart.Image = Properties.Resources._null;
                    break;
                case 1:
                    picBlueStart.Image = Properties.Resources.blue1;
                    break;
                case 2:
                    picBlueStart.Image = Properties.Resources.blue2;
                    break;
                case 3:
                    picBlueStart.Image = Properties.Resources.blue3;
                    break;
                case 4:
                    picBlueStart.Image = Properties.Resources.blue4;
                    break;
            }

            switch (red_goal)
            {
                case 0:
                    picRedGoal.Image = Properties.Resources._null;
                    break;
                case 1:
                    picRedGoal.Image = Properties.Resources.red1;
                    break;
                case 2:
                    picRedGoal.Image = Properties.Resources.red2;
                    break;
                case 3:
                    picRedGoal.Image = Properties.Resources.red3;
                    break;
                case 4:
                    picRedGoal.Image = Properties.Resources.red4;
                    break;
            }

            switch (blue_goal)
            {
                case 0:
                    picBlueGoal.Image = Properties.Resources._null;
                    break;
                case 1:
                    picBlueGoal.Image = Properties.Resources.blue1;
                    break;
                case 2:
                    picBlueGoal.Image = Properties.Resources.blue2;
                    break;
                case 3:
                    picBlueGoal.Image = Properties.Resources.blue3;
                    break;
                case 4:
                    picBlueGoal.Image = Properties.Resources.blue4;
                    break;
            }

            for (int i=0; i<=3; i++)
            {
                piece_red[i].display(picPlace);
                piece_blue[i].display(picPlace);
            }

            if(priority)
            {
                if (isTurnRed) piece_red[present_piece].display(picPlace);
                else piece_blue[present_piece].display(picPlace);
            }
        }

        private void communication_led (bool priority, bool isSelect)
        {
            List<info_yut> info = new List<info_yut>();
            
            const int red_turn_position = 35;
            const int blue_turn_position = 45;
            int red_goal_position = 31;
            int blue_goal_position = 41;

            if (isTurnRed) turn_ON_LED(info, red_turn_position, "R");
            else turn_ON_LED(info, blue_turn_position, "B");

            for (int i = 0; i<=3; i++ )
            {
                if (piece_red[i].goal) turn_ON_LED(info, red_goal_position++, "R");
                if (piece_blue[i].goal) turn_ON_LED(info, blue_goal_position++, "B");
            }

            if (isSelect)
            {
                if (isTurnRed)
                {
                    piece_red[present_piece].comm_select_LED(info);
                    piece_red[present_piece].comm_course(info, present_movement, red_goal_position);
                }
                else
                {
                    piece_blue[present_piece].comm_select_LED(info);
                    piece_blue[present_piece].comm_course(info, present_movement, blue_goal_position);
                }
            }

            if (priority)
            {
                if (isTurnRed) piece_red[present_piece].comm_LED(info);
                else piece_blue[present_piece].comm_LED(info);
            }

            for (int i = 0; i <= 3; i++)
            {
                piece_red[i].comm_LED(info);
                piece_blue[i].comm_LED(info);
            }

            TComm.SetLEDOutput(serialPort, info);
            for(int i=0; i<info.Count; i++)
            {
                Console.Write(info[i].pos);
                Console.Write(info[i].color);
                Console.Write(info[i].blink);
                Console.Write(',');
            }

            Console.WriteLine();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool success = SPort.OpenPorts(serialPort, Convert.ToInt32(txtPortNum.Text));

            if (!success)
            {
                MessageBox.Show("시리얼포트를 열지 못했습니다", "오류");
            }

            btnStart.Enabled = false;
        
            // OpenCv 카메라 정보를 가져옴
            int idxcam = 0;
            cap = CvCapture.FromCamera(CaptureDevice.DShow, idxcam);
            Cv.SetCaptureProperty(cap, CaptureProperty.FrameHeight, height);
            Cv.SetCaptureProperty(cap, CaptureProperty.FrameWidth, width);

            communication_led(false, false);
            bool select, done;
            TComm.AskSWInput(serialPort, out select, out done);
            TComm.AskSWInput(serialPort, out select, out done);
            yut_throw();
        }

        private void turn_ON_LED(List<info_yut> info, int LED_pos, string LED_col)
        {
            info_yut info_piece;
            info_piece.pos = LED_pos;
            info_piece.color = LED_col;
            info_piece.blink = 1;

            info.Add(info_piece);
        }

        private void timAskYut_Tick(object sender, EventArgs e)
        {
            bool select, done;
            TComm.AskSWInput(serialPort, out select, out done);
            if (!done) return;

            info_yut.Clear();
            lblStatus.Text = "윷을 읽는 중";

            timYutEffect.Enabled = false;
            isYutStop = true;
            timCam.Enabled = true;
            timYutAsk.Enabled = false;
        }

        private void view_status()
        {
            string yut_list = "";

            for(int i=0; i<result_yut.Count(); i++)
            {
                switch (result_yut[i])
                {
                    case 1:
                        yut_list += "도";
                        break;
                    case 2:
                        yut_list += "개";
                        break;
                    case 3:
                        yut_list += "걸";
                        break;
                    case 4:
                        yut_list += "윷";
                        break;
                    case 5:
                        yut_list += "모";
                        break;
                }
                if (i == (result_yut.Count() - 1)) break;

                yut_list += ", ";
            }

            lblYutStatus.Text = yut_list;
            lblStatus.Text = "윷 정보를 받음";
        }

        private void timYutPalse_Tick(object sender, EventArgs e)
        {
            lblYutStatus.Text += ", 윷을 굴려주세요";
            lblStatus.Text = "윷을 던지기를 기다리는 중";

            timYutPalse.Enabled = false;

            timYutAsk.Enabled = true;
            timYutEffect.Enabled = true;
            isYutStop = false;
        }

        private void timSelectPalse_Tick(object sender, EventArgs e)
        {
            timSelectPalse.Enabled = false;
            bool select, done;
            TComm.AskSWInput(serialPort, out select, out done);
            TComm.AskSWInput(serialPort, out select, out done);
            start_select();
        }

        private void start_select()
        {
            lblYutStatus.Text += ", 버튼을 누르세요";
            lblStatus.Text = "Select버튼 입력과 Done버튼 입력을 받는 중";

            move_piece.Clear();
            move_yut.Clear();

            for(int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < result_yut.Count; j++ )
                    if (result_yut[j] == i)
                    {
                        move_yut.Add(i);
                        break;
                    }
            }

            if (isTurnRed)
            {
                for (int i = 0; i <= 3; i++)
                    if (piece_red[i].initial) 
                    {
                        move_piece.Add(i);
                        break; 
                    }
                for (int i = 0; i <= 3; i++)
                    if (!piece_red[i].goal && !piece_red[i].initial && piece_red[i].check_first())
                    {
                        move_piece.Add(i);
                    }
            }

            else
            {
                for (int i = 0; i <= 3; i++)
                    if (piece_blue[i].initial) 
                    { 
                        move_piece.Add(i);
                        break;
                    }
                for (int i = 0; i <= 3; i++)
                    if (!piece_blue[i].goal && !piece_blue[i].initial && piece_blue[i].check_first())
                    {
                        move_piece.Add(i);
                    }
            }

            number_of_select = 0;
            number_of_case = move_yut.Count() * move_piece.Count();

            present_piece = move_piece[0];
            present_movement = move_yut[0];
            communication_led(false, true);
            
            timSelectAsk.Enabled = true;
        }

        private void timSelectAsk_Tick(object sender, EventArgs e)
        {
            bool select, done;
            TComm.AskSWInput(serialPort, out select, out done);

            if (select) 
            {
                number_of_select ++;
                if (number_of_select >= number_of_case) number_of_select = 0;

                present_piece = move_piece[number_of_select / move_yut.Count];
                present_movement = move_yut[number_of_select % move_yut.Count];
                Console.WriteLine(present_piece);

                txtTest1.Text = Convert.ToString(number_of_case);
                txtTest2.Text = Convert.ToString(number_of_select);

                communication_led(false, true);
                timSelectAsk.Enabled = false;
                timChattering.Enabled = true;
                return;
            }

            else
            {
                present_piece = move_piece[number_of_select / move_yut.Count];
                present_movement = move_yut[number_of_select % move_yut.Count];

                txtTest1.Text = Convert.ToString(number_of_case);
                txtTest2.Text = Convert.ToString(number_of_select);
            }

            if (!done) return;

            result_yut.Remove(present_movement);

            if (isTurnRed) piece_red[present_piece].move_byway(ref present_movement);
            else piece_blue[present_piece].move_byway(ref present_movement);
            display(true);
            communication_led(true, false);
            view_status();
            lblStatus.Text = "선택 정보를 받음";

            timSelectAsk.Enabled = false;
            timMove.Enabled = true;
        }

        private void timMove_Tick(object sender, EventArgs e)
        {
            if (isTurnRed)
            {
                piece_red[present_piece].move(ref present_movement);
                display(true);
                communication_led(true, false);
                view_status();
                if (present_movement != 0) return;

                for (int i = 0; i <= 3; i++)
                {
                    if (piece_blue[i].die(piece_red[present_piece])) break;
                    if (i == present_piece) continue;
                    if (piece_red[i].carry(piece_red[present_piece])) break;
                }

                display(false);
                communication_led(false, false);

                if (result_yut.Count != 0)
                {
                    timMove.Enabled = false;
                    start_select();
                    return;
                }

                isTurnRed = false;

                picRedTurn.Image = Properties.Resources._null;
                picBlueTurn.Image = Properties.Resources.blue_turn;
            }

            else
            {
                piece_blue[present_piece].move(ref present_movement);
                display(true);
                communication_led(true, false);
                view_status();
                if (present_movement != 0) return;

                for (int i = 0; i <= 3; i++)
                {
                    if (piece_red[i].die(piece_blue[present_piece])) break;
                    if (i == present_piece) continue;
                    if (piece_blue[i].carry(piece_blue[present_piece])) break;
                }

                display(false);
                communication_led(false, false);

                if (result_yut.Count != 0)
                {
                    timMove.Enabled = false;
                    start_select();
                    return;
                }

                isTurnRed = true;

                picBlueTurn.Image = Properties.Resources._null;
                picRedTurn.Image = Properties.Resources.red_turn;
            }

            timMove.Enabled = false;
            yut_throw();
        }

        private void barR_Scroll(object sender, EventArgs e)
        {
            lblR.Text = Convert.ToString(barR.Value);
            cam.r_mode[2] = barR.Value;
        }

        private void barG_Scroll(object sender, EventArgs e)
        {
            lblG.Text = Convert.ToString(barG.Value);
            cam.g_mode[1] = barG.Value;
        }

        private void barB_Scroll(object sender, EventArgs e)
        {
            lblB.Text = Convert.ToString(barB.Value);
            cam.b_mode[0] = barB.Value;
        }

        private void barThreshold_Scroll(object sender, EventArgs e)
        {
            lblThreshold.Text = Convert.ToString(barThreshold.Value);
        }

        private void timCam_Tick(object sender, EventArgs e)
        {
            // 0 = 모, 1 = 도, 2 = 개, 3 = 걸, 4 = 윷
            int yut = 0;

            // 1. 이미지 불러오기 (320 * 240)
            IplImage ori_src = cap.QueryFrame();
            ipicSrc.ImageIpl = ori_src;

            // 2. 원본 이미지 이진화
            //Gray이미지
            Bitmap img = (Bitmap)ipicSrc.Image;
            IplImage src = new IplImage(img.Size.Width, img.Size.Height, BitDepth.U8, 3);
            src.CopyFrom(img);
            //ipicBin.ImageIpl = src;

            if (src == null) return;
            IplImage gray = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, gray, ColorConversion.BgrToGray);

            IplImage bin = new IplImage(gray.Size, BitDepth.U8, 1);

            //Threshold이미지
            Cv.Threshold(gray, bin, barThreshold.Value, 255, ThresholdType.Binary);
            ipicBin.ImageIpl = bin;

            // 3. 원본 이미지 마스킹
            IplImage mask_src = ipicSrc.ImageIpl;
            IplImage mask_bin = ipicBin.ImageIpl;
            IplImage mask = new IplImage(bin.Size, BitDepth.U8, 3);

            if (bin == null) return;
            for (int nRow = 0; nRow < height; nRow++)
            {
                for (int nCol = 0; nCol < width; nCol++)
                {
                    if (bin[nRow, nCol] == 255) { mask[nRow, nCol] = ori_src[nRow, nCol]; }
                    else { mask[nRow, nCol] = 0; }
                }
            }
            ipicMask.ImageIpl = mask;

            // 4. 정규분포 처리결과
            IplImage result = new IplImage(ori_src.Size, BitDepth.U8, 3);
            result = cam.Adapt_Gaussian(mask, ori_src, out yut);
            ipicResult.ImageIpl = result;

            info_yut.Add(yut);
            if (info_yut.Count < 10) { return; }

            timCam.Enabled = false;
            //if (cap != null) { cap.Dispose(); }
            calculus_yut();
        }

        private void calculus_yut()
        {
            int[] number_of_yut = new int[6] { 0, 0, 0, 0, 0, 0 };

            for (int i=0; i<info_yut.Count; i++)
            {
                number_of_yut[info_yut[i]]++;
            }

            int most_yut=0;

            for (int i=1; i<6; i++)
            {
                if (number_of_yut[most_yut] <= number_of_yut[i]) most_yut = i;
            }
            result_yut.Add(most_yut);

            switch (result_yut.Last())
            {
                case 1:
                    picYut0.Image = Properties.Resources.Back;
                    picYut1.Image = Properties.Resources.Front;
                    picYut2.Image = Properties.Resources.Front;
                    picYut3.Image = Properties.Resources.Front;
                    timSelectPalse.Enabled = true;
                    break;
                case 2:
                    picYut0.Image = Properties.Resources.Back;
                    picYut1.Image = Properties.Resources.Back;
                    picYut2.Image = Properties.Resources.Front;
                    picYut3.Image = Properties.Resources.Front;
                    timSelectPalse.Enabled = true;
                    break;
                case 3:
                    picYut0.Image = Properties.Resources.Back;
                    picYut1.Image = Properties.Resources.Back;
                    picYut2.Image = Properties.Resources.Back;
                    picYut3.Image = Properties.Resources.Front;
                    timSelectPalse.Enabled = true;
                    break;
                case 4:
                    picYut0.Image = Properties.Resources.Back;
                    picYut1.Image = Properties.Resources.Back;
                    picYut2.Image = Properties.Resources.Back;
                    picYut3.Image = Properties.Resources.Back;
                    timYutPalse.Enabled = true;
                    break;
                case 5:
                    picYut0.Image = Properties.Resources.Front;
                    picYut1.Image = Properties.Resources.Front;
                    picYut2.Image = Properties.Resources.Front;
                    picYut3.Image = Properties.Resources.Front;
                    timYutPalse.Enabled = true;
                    break;
            }
            view_status();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SPort.GetPortsList();

            lblCOMs.Text = "";
            for (int i = 0; i < ports.Length; i++)
            {
                lblCOMs.Text = lblCOMs.Text + ports[i] + "\r\n";
            }
        }

        private void timChattering_Tick(object sender, EventArgs e)
        {

            bool select, done;
            TComm.AskSWInput(serialPort, out select, out done);

            timChattering.Enabled = false;
            timSelectAsk.Enabled = true;
        }
    }
}
