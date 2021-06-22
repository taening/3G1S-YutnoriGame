namespace project_yut
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timYutEffect = new System.Windows.Forms.Timer(this.components);
            this.timYutAsk = new System.Windows.Forms.Timer(this.components);
            this.timYutPalse = new System.Windows.Forms.Timer(this.components);
            this.timSelectAsk = new System.Windows.Forms.Timer(this.components);
            this.timSelectPalse = new System.Windows.Forms.Timer(this.components);
            this.timMove = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCOMs = new System.Windows.Forms.Label();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picBlueTurn = new System.Windows.Forms.PictureBox();
            this.picRedTurn = new System.Windows.Forms.PictureBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.picPlace23 = new System.Windows.Forms.PictureBox();
            this.picPlace26 = new System.Windows.Forms.PictureBox();
            this.picPlace27 = new System.Windows.Forms.PictureBox();
            this.picPlace28 = new System.Windows.Forms.PictureBox();
            this.picPlace24 = new System.Windows.Forms.PictureBox();
            this.picPlace25 = new System.Windows.Forms.PictureBox();
            this.picPlace22 = new System.Windows.Forms.PictureBox();
            this.picPlace21 = new System.Windows.Forms.PictureBox();
            this.picPlace20 = new System.Windows.Forms.PictureBox();
            this.picPlace19 = new System.Windows.Forms.PictureBox();
            this.picPlace18 = new System.Windows.Forms.PictureBox();
            this.picPlace17 = new System.Windows.Forms.PictureBox();
            this.picPlace16 = new System.Windows.Forms.PictureBox();
            this.picPlace15 = new System.Windows.Forms.PictureBox();
            this.picPlace14 = new System.Windows.Forms.PictureBox();
            this.picPlace13 = new System.Windows.Forms.PictureBox();
            this.picPlace12 = new System.Windows.Forms.PictureBox();
            this.picPlace11 = new System.Windows.Forms.PictureBox();
            this.picPlace10 = new System.Windows.Forms.PictureBox();
            this.picPlace9 = new System.Windows.Forms.PictureBox();
            this.picPlace8 = new System.Windows.Forms.PictureBox();
            this.picPlace7 = new System.Windows.Forms.PictureBox();
            this.picPlace6 = new System.Windows.Forms.PictureBox();
            this.picPlace5 = new System.Windows.Forms.PictureBox();
            this.picPlace4 = new System.Windows.Forms.PictureBox();
            this.picPlace3 = new System.Windows.Forms.PictureBox();
            this.picPlace2 = new System.Windows.Forms.PictureBox();
            this.picPlace1 = new System.Windows.Forms.PictureBox();
            this.picPlace0 = new System.Windows.Forms.PictureBox();
            this.picYut3 = new System.Windows.Forms.PictureBox();
            this.picYut2 = new System.Windows.Forms.PictureBox();
            this.picYut1 = new System.Windows.Forms.PictureBox();
            this.picYut0 = new System.Windows.Forms.PictureBox();
            this.picBase = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picRedStart = new System.Windows.Forms.PictureBox();
            this.lblRedStart = new System.Windows.Forms.Label();
            this.lblRedGoal = new System.Windows.Forms.Label();
            this.picRedGoal = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBlueStart = new System.Windows.Forms.PictureBox();
            this.lblBlueStart = new System.Windows.Forms.Label();
            this.lblBlueGoal = new System.Windows.Forms.Label();
            this.picBlueGoal = new System.Windows.Forms.PictureBox();
            this.lblYutStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipicResult = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.ipicBin = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.ipicMask = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.ipicSrc = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.barR = new System.Windows.Forms.TrackBar();
            this.barThreshold = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.barB = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.barG = new System.Windows.Forms.TrackBar();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timCam = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timChattering = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedGoal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueGoal)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipicResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barG)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timYutEffect
            // 
            this.timYutEffect.Interval = 30;
            this.timYutEffect.Tick += new System.EventHandler(this.timYutEffect_Tick);
            // 
            // timYutAsk
            // 
            this.timYutAsk.Tick += new System.EventHandler(this.timAskYut_Tick);
            // 
            // timYutPalse
            // 
            this.timYutPalse.Interval = 1000;
            this.timYutPalse.Tick += new System.EventHandler(this.timYutPalse_Tick);
            // 
            // timSelectAsk
            // 
            this.timSelectAsk.Tick += new System.EventHandler(this.timSelectAsk_Tick);
            // 
            // timSelectPalse
            // 
            this.timSelectPalse.Interval = 1000;
            this.timSelectPalse.Tick += new System.EventHandler(this.timSelectPalse_Tick);
            // 
            // timMove
            // 
            this.timMove.Interval = 600;
            this.timMove.Tick += new System.EventHandler(this.timMove_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCOMs);
            this.groupBox1.Controls.Add(this.txtPortNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.picBlueTurn);
            this.groupBox1.Controls.Add(this.picRedTurn);
            this.groupBox1.Controls.Add(this.txtTest2);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtTest1);
            this.groupBox1.Controls.Add(this.picPlace23);
            this.groupBox1.Controls.Add(this.picPlace26);
            this.groupBox1.Controls.Add(this.picPlace27);
            this.groupBox1.Controls.Add(this.picPlace28);
            this.groupBox1.Controls.Add(this.picPlace24);
            this.groupBox1.Controls.Add(this.picPlace25);
            this.groupBox1.Controls.Add(this.picPlace22);
            this.groupBox1.Controls.Add(this.picPlace21);
            this.groupBox1.Controls.Add(this.picPlace20);
            this.groupBox1.Controls.Add(this.picPlace19);
            this.groupBox1.Controls.Add(this.picPlace18);
            this.groupBox1.Controls.Add(this.picPlace17);
            this.groupBox1.Controls.Add(this.picPlace16);
            this.groupBox1.Controls.Add(this.picPlace15);
            this.groupBox1.Controls.Add(this.picPlace14);
            this.groupBox1.Controls.Add(this.picPlace13);
            this.groupBox1.Controls.Add(this.picPlace12);
            this.groupBox1.Controls.Add(this.picPlace11);
            this.groupBox1.Controls.Add(this.picPlace10);
            this.groupBox1.Controls.Add(this.picPlace9);
            this.groupBox1.Controls.Add(this.picPlace8);
            this.groupBox1.Controls.Add(this.picPlace7);
            this.groupBox1.Controls.Add(this.picPlace6);
            this.groupBox1.Controls.Add(this.picPlace5);
            this.groupBox1.Controls.Add(this.picPlace4);
            this.groupBox1.Controls.Add(this.picPlace3);
            this.groupBox1.Controls.Add(this.picPlace2);
            this.groupBox1.Controls.Add(this.picPlace1);
            this.groupBox1.Controls.Add(this.picPlace0);
            this.groupBox1.Controls.Add(this.picYut3);
            this.groupBox1.Controls.Add(this.picYut2);
            this.groupBox1.Controls.Add(this.picYut1);
            this.groupBox1.Controls.Add(this.picYut0);
            this.groupBox1.Controls.Add(this.picBase);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblYutStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 679);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblCOMs
            // 
            this.lblCOMs.AutoSize = true;
            this.lblCOMs.Location = new System.Drawing.Point(561, 202);
            this.lblCOMs.Name = "lblCOMs";
            this.lblCOMs.Size = new System.Drawing.Size(46, 18);
            this.lblCOMs.TabIndex = 99;
            this.lblCOMs.Text = "Com";
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(632, 284);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(141, 28);
            this.txtPortNum.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 97;
            this.label9.Text = "Port";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(216, 635);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 20);
            this.lblStatus.TabIndex = 96;
            this.lblStatus.Text = "기다리는 중";
            // 
            // picBlueTurn
            // 
            this.picBlueTurn.Image = global::project_yut.Properties.Resources.blue_turn;
            this.picBlueTurn.Location = new System.Drawing.Point(658, 402);
            this.picBlueTurn.Margin = new System.Windows.Forms.Padding(4);
            this.picBlueTurn.Name = "picBlueTurn";
            this.picBlueTurn.Size = new System.Drawing.Size(45, 45);
            this.picBlueTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBlueTurn.TabIndex = 95;
            this.picBlueTurn.TabStop = false;
            // 
            // picRedTurn
            // 
            this.picRedTurn.Image = global::project_yut.Properties.Resources.red_turn;
            this.picRedTurn.Location = new System.Drawing.Point(658, 129);
            this.picRedTurn.Margin = new System.Windows.Forms.Padding(4);
            this.picRedTurn.Name = "picRedTurn";
            this.picRedTurn.Size = new System.Drawing.Size(45, 45);
            this.picRedTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRedTurn.TabIndex = 94;
            this.picRedTurn.TabStop = false;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(632, 361);
            this.txtTest2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(141, 28);
            this.txtTest2.TabIndex = 92;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(683, 193);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 81);
            this.btnStart.TabIndex = 90;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(632, 325);
            this.txtTest1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(141, 28);
            this.txtTest1.TabIndex = 89;
            // 
            // picPlace23
            // 
            this.picPlace23.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace23.Location = new System.Drawing.Point(191, 357);
            this.picPlace23.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace23.Name = "picPlace23";
            this.picPlace23.Size = new System.Drawing.Size(27, 27);
            this.picPlace23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace23.TabIndex = 88;
            this.picPlace23.TabStop = false;
            // 
            // picPlace26
            // 
            this.picPlace26.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace26.Location = new System.Drawing.Point(191, 193);
            this.picPlace26.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace26.Name = "picPlace26";
            this.picPlace26.Size = new System.Drawing.Size(27, 27);
            this.picPlace26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace26.TabIndex = 87;
            this.picPlace26.TabStop = false;
            // 
            // picPlace27
            // 
            this.picPlace27.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace27.Location = new System.Drawing.Point(336, 357);
            this.picPlace27.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace27.Name = "picPlace27";
            this.picPlace27.Size = new System.Drawing.Size(27, 27);
            this.picPlace27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace27.TabIndex = 86;
            this.picPlace27.TabStop = false;
            // 
            // picPlace28
            // 
            this.picPlace28.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace28.Location = new System.Drawing.Point(406, 432);
            this.picPlace28.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace28.Name = "picPlace28";
            this.picPlace28.Size = new System.Drawing.Size(27, 27);
            this.picPlace28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace28.TabIndex = 85;
            this.picPlace28.TabStop = false;
            // 
            // picPlace24
            // 
            this.picPlace24.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace24.Location = new System.Drawing.Point(116, 432);
            this.picPlace24.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace24.Name = "picPlace24";
            this.picPlace24.Size = new System.Drawing.Size(27, 27);
            this.picPlace24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace24.TabIndex = 84;
            this.picPlace24.TabStop = false;
            // 
            // picPlace25
            // 
            this.picPlace25.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace25.Location = new System.Drawing.Point(116, 119);
            this.picPlace25.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace25.Name = "picPlace25";
            this.picPlace25.Size = new System.Drawing.Size(27, 27);
            this.picPlace25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace25.TabIndex = 83;
            this.picPlace25.TabStop = false;
            // 
            // picPlace22
            // 
            this.picPlace22.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace22.Location = new System.Drawing.Point(261, 275);
            this.picPlace22.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace22.Name = "picPlace22";
            this.picPlace22.Size = new System.Drawing.Size(27, 27);
            this.picPlace22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace22.TabIndex = 82;
            this.picPlace22.TabStop = false;
            // 
            // picPlace21
            // 
            this.picPlace21.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace21.Location = new System.Drawing.Point(336, 193);
            this.picPlace21.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace21.Name = "picPlace21";
            this.picPlace21.Size = new System.Drawing.Size(27, 27);
            this.picPlace21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace21.TabIndex = 81;
            this.picPlace21.TabStop = false;
            // 
            // picPlace20
            // 
            this.picPlace20.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace20.Location = new System.Drawing.Point(406, 119);
            this.picPlace20.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace20.Name = "picPlace20";
            this.picPlace20.Size = new System.Drawing.Size(27, 27);
            this.picPlace20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace20.TabIndex = 80;
            this.picPlace20.TabStop = false;
            // 
            // picPlace19
            // 
            this.picPlace19.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace19.Location = new System.Drawing.Point(391, 507);
            this.picPlace19.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace19.Name = "picPlace19";
            this.picPlace19.Size = new System.Drawing.Size(27, 27);
            this.picPlace19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace19.TabIndex = 79;
            this.picPlace19.TabStop = false;
            // 
            // picPlace18
            // 
            this.picPlace18.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace18.Location = new System.Drawing.Point(305, 507);
            this.picPlace18.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace18.Name = "picPlace18";
            this.picPlace18.Size = new System.Drawing.Size(27, 27);
            this.picPlace18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace18.TabIndex = 78;
            this.picPlace18.TabStop = false;
            // 
            // picPlace17
            // 
            this.picPlace17.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace17.Location = new System.Drawing.Point(219, 507);
            this.picPlace17.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace17.Name = "picPlace17";
            this.picPlace17.Size = new System.Drawing.Size(27, 27);
            this.picPlace17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace17.TabIndex = 77;
            this.picPlace17.TabStop = false;
            // 
            // picPlace16
            // 
            this.picPlace16.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace16.Location = new System.Drawing.Point(129, 507);
            this.picPlace16.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace16.Name = "picPlace16";
            this.picPlace16.Size = new System.Drawing.Size(27, 27);
            this.picPlace16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace16.TabIndex = 76;
            this.picPlace16.TabStop = false;
            // 
            // picPlace15
            // 
            this.picPlace15.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace15.Location = new System.Drawing.Point(45, 507);
            this.picPlace15.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace15.Name = "picPlace15";
            this.picPlace15.Size = new System.Drawing.Size(27, 27);
            this.picPlace15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace15.TabIndex = 75;
            this.picPlace15.TabStop = false;
            // 
            // picPlace14
            // 
            this.picPlace14.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace14.Location = new System.Drawing.Point(45, 414);
            this.picPlace14.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace14.Name = "picPlace14";
            this.picPlace14.Size = new System.Drawing.Size(27, 27);
            this.picPlace14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace14.TabIndex = 74;
            this.picPlace14.TabStop = false;
            // 
            // picPlace13
            // 
            this.picPlace13.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace13.Location = new System.Drawing.Point(45, 321);
            this.picPlace13.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace13.Name = "picPlace13";
            this.picPlace13.Size = new System.Drawing.Size(27, 27);
            this.picPlace13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace13.TabIndex = 73;
            this.picPlace13.TabStop = false;
            // 
            // picPlace12
            // 
            this.picPlace12.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace12.Location = new System.Drawing.Point(45, 227);
            this.picPlace12.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace12.Name = "picPlace12";
            this.picPlace12.Size = new System.Drawing.Size(27, 27);
            this.picPlace12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace12.TabIndex = 72;
            this.picPlace12.TabStop = false;
            // 
            // picPlace11
            // 
            this.picPlace11.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace11.Location = new System.Drawing.Point(45, 137);
            this.picPlace11.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace11.Name = "picPlace11";
            this.picPlace11.Size = new System.Drawing.Size(27, 27);
            this.picPlace11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace11.TabIndex = 71;
            this.picPlace11.TabStop = false;
            // 
            // picPlace10
            // 
            this.picPlace10.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace10.Location = new System.Drawing.Point(45, 48);
            this.picPlace10.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace10.Name = "picPlace10";
            this.picPlace10.Size = new System.Drawing.Size(27, 27);
            this.picPlace10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace10.TabIndex = 70;
            this.picPlace10.TabStop = false;
            // 
            // picPlace9
            // 
            this.picPlace9.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace9.Location = new System.Drawing.Point(129, 48);
            this.picPlace9.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace9.Name = "picPlace9";
            this.picPlace9.Size = new System.Drawing.Size(27, 27);
            this.picPlace9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace9.TabIndex = 69;
            this.picPlace9.TabStop = false;
            // 
            // picPlace8
            // 
            this.picPlace8.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace8.Location = new System.Drawing.Point(219, 48);
            this.picPlace8.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace8.Name = "picPlace8";
            this.picPlace8.Size = new System.Drawing.Size(27, 27);
            this.picPlace8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace8.TabIndex = 68;
            this.picPlace8.TabStop = false;
            // 
            // picPlace7
            // 
            this.picPlace7.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace7.Location = new System.Drawing.Point(305, 48);
            this.picPlace7.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace7.Name = "picPlace7";
            this.picPlace7.Size = new System.Drawing.Size(27, 27);
            this.picPlace7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace7.TabIndex = 67;
            this.picPlace7.TabStop = false;
            // 
            // picPlace6
            // 
            this.picPlace6.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace6.Location = new System.Drawing.Point(391, 48);
            this.picPlace6.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace6.Name = "picPlace6";
            this.picPlace6.Size = new System.Drawing.Size(27, 27);
            this.picPlace6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace6.TabIndex = 66;
            this.picPlace6.TabStop = false;
            // 
            // picPlace5
            // 
            this.picPlace5.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace5.Location = new System.Drawing.Point(474, 48);
            this.picPlace5.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace5.Name = "picPlace5";
            this.picPlace5.Size = new System.Drawing.Size(27, 27);
            this.picPlace5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace5.TabIndex = 65;
            this.picPlace5.TabStop = false;
            // 
            // picPlace4
            // 
            this.picPlace4.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace4.Location = new System.Drawing.Point(474, 137);
            this.picPlace4.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace4.Name = "picPlace4";
            this.picPlace4.Size = new System.Drawing.Size(27, 27);
            this.picPlace4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace4.TabIndex = 64;
            this.picPlace4.TabStop = false;
            // 
            // picPlace3
            // 
            this.picPlace3.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace3.Location = new System.Drawing.Point(474, 227);
            this.picPlace3.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace3.Name = "picPlace3";
            this.picPlace3.Size = new System.Drawing.Size(27, 27);
            this.picPlace3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace3.TabIndex = 63;
            this.picPlace3.TabStop = false;
            // 
            // picPlace2
            // 
            this.picPlace2.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace2.Location = new System.Drawing.Point(474, 321);
            this.picPlace2.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace2.Name = "picPlace2";
            this.picPlace2.Size = new System.Drawing.Size(27, 27);
            this.picPlace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace2.TabIndex = 62;
            this.picPlace2.TabStop = false;
            // 
            // picPlace1
            // 
            this.picPlace1.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace1.Location = new System.Drawing.Point(474, 414);
            this.picPlace1.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace1.Name = "picPlace1";
            this.picPlace1.Size = new System.Drawing.Size(27, 27);
            this.picPlace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace1.TabIndex = 61;
            this.picPlace1.TabStop = false;
            // 
            // picPlace0
            // 
            this.picPlace0.Image = global::project_yut.Properties.Resources.red1;
            this.picPlace0.Location = new System.Drawing.Point(474, 507);
            this.picPlace0.Margin = new System.Windows.Forms.Padding(4);
            this.picPlace0.Name = "picPlace0";
            this.picPlace0.Size = new System.Drawing.Size(27, 27);
            this.picPlace0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlace0.TabIndex = 60;
            this.picPlace0.TabStop = false;
            // 
            // picYut3
            // 
            this.picYut3.Image = global::project_yut.Properties.Resources.Front;
            this.picYut3.Location = new System.Drawing.Point(152, 585);
            this.picYut3.Margin = new System.Windows.Forms.Padding(4);
            this.picYut3.Name = "picYut3";
            this.picYut3.Size = new System.Drawing.Size(35, 50);
            this.picYut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picYut3.TabIndex = 59;
            this.picYut3.TabStop = false;
            // 
            // picYut2
            // 
            this.picYut2.Image = global::project_yut.Properties.Resources.Front;
            this.picYut2.Location = new System.Drawing.Point(105, 585);
            this.picYut2.Margin = new System.Windows.Forms.Padding(4);
            this.picYut2.Name = "picYut2";
            this.picYut2.Size = new System.Drawing.Size(35, 50);
            this.picYut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picYut2.TabIndex = 58;
            this.picYut2.TabStop = false;
            // 
            // picYut1
            // 
            this.picYut1.Image = global::project_yut.Properties.Resources.Front;
            this.picYut1.Location = new System.Drawing.Point(59, 585);
            this.picYut1.Margin = new System.Windows.Forms.Padding(4);
            this.picYut1.Name = "picYut1";
            this.picYut1.Size = new System.Drawing.Size(35, 50);
            this.picYut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picYut1.TabIndex = 57;
            this.picYut1.TabStop = false;
            // 
            // picYut0
            // 
            this.picYut0.Image = global::project_yut.Properties.Resources.Front;
            this.picYut0.Location = new System.Drawing.Point(14, 585);
            this.picYut0.Margin = new System.Windows.Forms.Padding(4);
            this.picYut0.Name = "picYut0";
            this.picYut0.Size = new System.Drawing.Size(35, 50);
            this.picYut0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picYut0.TabIndex = 56;
            this.picYut0.TabStop = false;
            // 
            // picBase
            // 
            this.picBase.Image = global::project_yut.Properties.Resources.Base8;
            this.picBase.Location = new System.Drawing.Point(12, 15);
            this.picBase.Margin = new System.Windows.Forms.Padding(4);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(526, 549);
            this.picBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBase.TabIndex = 55;
            this.picBase.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.picRedStart);
            this.groupBox2.Controls.Add(this.lblRedStart);
            this.groupBox2.Controls.Add(this.lblRedGoal);
            this.groupBox2.Controls.Add(this.picRedGoal);
            this.groupBox2.Location = new System.Drawing.Point(564, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(249, 123);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "홍팀";
            // 
            // picRedStart
            // 
            this.picRedStart.Image = global::project_yut.Properties.Resources.red4;
            this.picRedStart.Location = new System.Drawing.Point(40, 57);
            this.picRedStart.Margin = new System.Windows.Forms.Padding(4);
            this.picRedStart.Name = "picRedStart";
            this.picRedStart.Size = new System.Drawing.Size(33, 33);
            this.picRedStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRedStart.TabIndex = 7;
            this.picRedStart.TabStop = false;
            // 
            // lblRedStart
            // 
            this.lblRedStart.AutoSize = true;
            this.lblRedStart.Location = new System.Drawing.Point(37, 26);
            this.lblRedStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedStart.Name = "lblRedStart";
            this.lblRedStart.Size = new System.Drawing.Size(68, 18);
            this.lblRedStart.TabIndex = 6;
            this.lblRedStart.Text = "대기 중";
            // 
            // lblRedGoal
            // 
            this.lblRedGoal.AutoSize = true;
            this.lblRedGoal.Location = new System.Drawing.Point(170, 26);
            this.lblRedGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedGoal.Name = "lblRedGoal";
            this.lblRedGoal.Size = new System.Drawing.Size(44, 18);
            this.lblRedGoal.TabIndex = 5;
            this.lblRedGoal.Text = "도착";
            // 
            // picRedGoal
            // 
            this.picRedGoal.Image = global::project_yut.Properties.Resources.red4;
            this.picRedGoal.Location = new System.Drawing.Point(164, 57);
            this.picRedGoal.Margin = new System.Windows.Forms.Padding(4);
            this.picRedGoal.Name = "picRedGoal";
            this.picRedGoal.Size = new System.Drawing.Size(33, 33);
            this.picRedGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRedGoal.TabIndex = 4;
            this.picRedGoal.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.picBlueStart);
            this.groupBox3.Controls.Add(this.lblBlueStart);
            this.groupBox3.Controls.Add(this.lblBlueGoal);
            this.groupBox3.Controls.Add(this.picBlueGoal);
            this.groupBox3.Location = new System.Drawing.Point(564, 451);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(249, 123);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "청팀";
            // 
            // picBlueStart
            // 
            this.picBlueStart.Image = global::project_yut.Properties.Resources.blue4;
            this.picBlueStart.Location = new System.Drawing.Point(37, 56);
            this.picBlueStart.Margin = new System.Windows.Forms.Padding(4);
            this.picBlueStart.Name = "picBlueStart";
            this.picBlueStart.Size = new System.Drawing.Size(33, 33);
            this.picBlueStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBlueStart.TabIndex = 3;
            this.picBlueStart.TabStop = false;
            // 
            // lblBlueStart
            // 
            this.lblBlueStart.AutoSize = true;
            this.lblBlueStart.Location = new System.Drawing.Point(34, 24);
            this.lblBlueStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlueStart.Name = "lblBlueStart";
            this.lblBlueStart.Size = new System.Drawing.Size(68, 18);
            this.lblBlueStart.TabIndex = 2;
            this.lblBlueStart.Text = "대기 중";
            // 
            // lblBlueGoal
            // 
            this.lblBlueGoal.AutoSize = true;
            this.lblBlueGoal.Location = new System.Drawing.Point(167, 24);
            this.lblBlueGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlueGoal.Name = "lblBlueGoal";
            this.lblBlueGoal.Size = new System.Drawing.Size(44, 18);
            this.lblBlueGoal.TabIndex = 1;
            this.lblBlueGoal.Text = "도착";
            // 
            // picBlueGoal
            // 
            this.picBlueGoal.Image = global::project_yut.Properties.Resources.blue4;
            this.picBlueGoal.Location = new System.Drawing.Point(161, 56);
            this.picBlueGoal.Margin = new System.Windows.Forms.Padding(4);
            this.picBlueGoal.Name = "picBlueGoal";
            this.picBlueGoal.Size = new System.Drawing.Size(33, 33);
            this.picBlueGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBlueGoal.TabIndex = 0;
            this.picBlueGoal.TabStop = false;
            // 
            // lblYutStatus
            // 
            this.lblYutStatus.AutoSize = true;
            this.lblYutStatus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblYutStatus.Location = new System.Drawing.Point(211, 591);
            this.lblYutStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYutStatus.Name = "lblYutStatus";
            this.lblYutStatus.Size = new System.Drawing.Size(447, 36);
            this.lblYutStatus.TabIndex = 52;
            this.lblYutStatus.Text = "시작을 기다리는 중입니다.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(870, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 851);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.ipicResult);
            this.groupBox5.Controls.Add(this.ipicBin);
            this.groupBox5.Controls.Add(this.ipicMask);
            this.groupBox5.Controls.Add(this.ipicSrc);
            this.groupBox5.Location = new System.Drawing.Point(20, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(703, 778);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // ipicResult
            // 
            this.ipicResult.BackColor = System.Drawing.Color.White;
            this.ipicResult.Location = new System.Drawing.Point(377, 441);
            this.ipicResult.Name = "ipicResult";
            this.ipicResult.Size = new System.Drawing.Size(295, 295);
            this.ipicResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipicResult.TabIndex = 3;
            this.ipicResult.TabStop = false;
            // 
            // ipicBin
            // 
            this.ipicBin.BackColor = System.Drawing.Color.White;
            this.ipicBin.Location = new System.Drawing.Point(377, 63);
            this.ipicBin.Name = "ipicBin";
            this.ipicBin.Size = new System.Drawing.Size(295, 295);
            this.ipicBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipicBin.TabIndex = 2;
            this.ipicBin.TabStop = false;
            // 
            // ipicMask
            // 
            this.ipicMask.BackColor = System.Drawing.Color.White;
            this.ipicMask.Location = new System.Drawing.Point(27, 441);
            this.ipicMask.Name = "ipicMask";
            this.ipicMask.Size = new System.Drawing.Size(295, 295);
            this.ipicMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipicMask.TabIndex = 1;
            this.ipicMask.TabStop = false;
            // 
            // ipicSrc
            // 
            this.ipicSrc.BackColor = System.Drawing.Color.White;
            this.ipicSrc.Location = new System.Drawing.Point(27, 63);
            this.ipicSrc.Name = "ipicSrc";
            this.ipicSrc.Size = new System.Drawing.Size(295, 295);
            this.ipicSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipicSrc.TabIndex = 0;
            this.ipicSrc.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Threshold";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(415, 35);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(18, 18);
            this.lblThreshold.TabIndex = 53;
            this.lblThreshold.Text = "0";
            // 
            // barR
            // 
            this.barR.Location = new System.Drawing.Point(105, 35);
            this.barR.Maximum = 255;
            this.barR.Name = "barR";
            this.barR.Size = new System.Drawing.Size(267, 69);
            this.barR.TabIndex = 43;
            this.barR.Value = 120;
            this.barR.Scroll += new System.EventHandler(this.barR_Scroll);
            // 
            // barThreshold
            // 
            this.barThreshold.Location = new System.Drawing.Point(580, 35);
            this.barThreshold.Maximum = 255;
            this.barThreshold.Name = "barThreshold";
            this.barThreshold.Size = new System.Drawing.Size(267, 69);
            this.barThreshold.TabIndex = 52;
            this.barThreshold.Value = 100;
            this.barThreshold.Scroll += new System.EventHandler(this.barThreshold_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "G";
            // 
            // barB
            // 
            this.barB.Location = new System.Drawing.Point(580, 103);
            this.barB.Maximum = 255;
            this.barB.Name = "barB";
            this.barB.Size = new System.Drawing.Size(267, 69);
            this.barB.TabIndex = 44;
            this.barB.Value = 85;
            this.barB.Scroll += new System.EventHandler(this.barB_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "B";
            // 
            // barG
            // 
            this.barG.Location = new System.Drawing.Point(105, 103);
            this.barG.Maximum = 255;
            this.barG.Name = "barG";
            this.barG.Size = new System.Drawing.Size(267, 69);
            this.barG.TabIndex = 45;
            this.barG.Value = 85;
            this.barG.Scroll += new System.EventHandler(this.barG_Scroll);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(10, 103);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(18, 18);
            this.lblG.TabIndex = 47;
            this.lblG.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(415, 103);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 18);
            this.lblB.TabIndex = 48;
            this.lblB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "R";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(10, 35);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 18);
            this.lblR.TabIndex = 55;
            this.lblR.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.barR);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.lblR);
            this.groupBox6.Controls.Add(this.barG);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.lblG);
            this.groupBox6.Controls.Add(this.barThreshold);
            this.groupBox6.Controls.Add(this.lblThreshold);
            this.groupBox6.Controls.Add(this.lblB);
            this.groupBox6.Controls.Add(this.barB);
            this.groupBox6.Location = new System.Drawing.Point(12, 690);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(852, 173);
            this.groupBox6.TabIndex = 57;
            this.groupBox6.TabStop = false;
            // 
            // timCam
            // 
            this.timCam.Interval = 33;
            this.timCam.Tick += new System.EventHandler(this.timCam_Tick);
            // 
            // timChattering
            // 
            this.timChattering.Interval = 500;
            this.timChattering.Tick += new System.EventHandler(this.timChattering_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 896);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYut0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedGoal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueGoal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipicResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barG)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timYutEffect;
        private System.Windows.Forms.Timer timYutAsk;
        private System.Windows.Forms.Timer timYutPalse;
        private System.Windows.Forms.Timer timSelectAsk;
        private System.Windows.Forms.Timer timSelectPalse;
        private System.Windows.Forms.Timer timMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picBlueTurn;
        private System.Windows.Forms.PictureBox picRedTurn;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.PictureBox picPlace23;
        private System.Windows.Forms.PictureBox picPlace26;
        private System.Windows.Forms.PictureBox picPlace27;
        private System.Windows.Forms.PictureBox picPlace28;
        private System.Windows.Forms.PictureBox picPlace24;
        private System.Windows.Forms.PictureBox picPlace25;
        private System.Windows.Forms.PictureBox picPlace22;
        private System.Windows.Forms.PictureBox picPlace21;
        private System.Windows.Forms.PictureBox picPlace20;
        private System.Windows.Forms.PictureBox picPlace19;
        private System.Windows.Forms.PictureBox picPlace18;
        private System.Windows.Forms.PictureBox picPlace17;
        private System.Windows.Forms.PictureBox picPlace16;
        private System.Windows.Forms.PictureBox picPlace15;
        private System.Windows.Forms.PictureBox picPlace14;
        private System.Windows.Forms.PictureBox picPlace13;
        private System.Windows.Forms.PictureBox picPlace12;
        private System.Windows.Forms.PictureBox picPlace11;
        private System.Windows.Forms.PictureBox picPlace10;
        private System.Windows.Forms.PictureBox picPlace9;
        private System.Windows.Forms.PictureBox picPlace8;
        private System.Windows.Forms.PictureBox picPlace7;
        private System.Windows.Forms.PictureBox picPlace6;
        private System.Windows.Forms.PictureBox picPlace5;
        private System.Windows.Forms.PictureBox picPlace4;
        private System.Windows.Forms.PictureBox picPlace3;
        private System.Windows.Forms.PictureBox picPlace2;
        private System.Windows.Forms.PictureBox picPlace1;
        private System.Windows.Forms.PictureBox picPlace0;
        private System.Windows.Forms.PictureBox picYut3;
        private System.Windows.Forms.PictureBox picYut2;
        private System.Windows.Forms.PictureBox picYut1;
        private System.Windows.Forms.PictureBox picYut0;
        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picRedStart;
        private System.Windows.Forms.Label lblRedStart;
        private System.Windows.Forms.Label lblRedGoal;
        private System.Windows.Forms.PictureBox picRedGoal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBlueStart;
        private System.Windows.Forms.Label lblBlueStart;
        private System.Windows.Forms.Label lblBlueGoal;
        private System.Windows.Forms.PictureBox picBlueGoal;
        private System.Windows.Forms.Label lblYutStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OpenCvSharp.UserInterface.PictureBoxIpl ipicResult;
        private OpenCvSharp.UserInterface.PictureBoxIpl ipicBin;
        private OpenCvSharp.UserInterface.PictureBoxIpl ipicMask;
        private OpenCvSharp.UserInterface.PictureBoxIpl ipicSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar barR;
        private System.Windows.Forms.TrackBar barThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar barB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar barG;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Timer timCam;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label lblCOMs;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timChattering;
    }
}

