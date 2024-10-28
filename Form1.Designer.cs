namespace Serial_Communication
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.FormPlot = new ScottPlot.FormsPlot();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.psComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.START1 = new System.Windows.Forms.Button();
            this.stop1 = new System.Windows.Forms.Button();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.hiddenButton = new System.Windows.Forms.Button();
            this.autoScaleButton = new System.Windows.Forms.Button();
            this.FormPlot2 = new ScottPlot.FormsPlot();
            this.STOP2 = new System.Windows.Forms.Button();
            this.START2 = new System.Windows.Forms.Button();
            this.voltTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.numberLabel2 = new System.Windows.Forms.Label();
            this.numberLabel3 = new System.Windows.Forms.Label();
            this.limitBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brigTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 41);
            this.comboBox_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(234, 20);
            this.comboBox_port.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(10, 80);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(111, 55);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "연결하기";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(123, 80);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(111, 55);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(932, 13);
            this.richTextBox_received.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(251, 245);
            this.richTextBox_received.TabIndex = 3;
            this.richTextBox_received.Text = "";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(12, 19);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 12);
            this.label_port.TabIndex = 5;
            this.label_port.Text = "COM 포트 설정";
            // 
            // FormPlot
            // 
            this.FormPlot.Location = new System.Drawing.Point(129, 290);
            this.FormPlot.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FormPlot.Name = "FormPlot";
            this.FormPlot.Size = new System.Drawing.Size(1056, 213);
            this.FormPlot.TabIndex = 8;
            this.FormPlot.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(817, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 55);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 55);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 55);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(357, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 55);
            this.button8.TabIndex = 13;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(240, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 55);
            this.button9.TabIndex = 24;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(700, 142);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 55);
            this.button10.TabIndex = 23;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(495, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(111, 55);
            this.button11.TabIndex = 22;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(378, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 55);
            this.button12.TabIndex = 21;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(355, 142);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(111, 55);
            this.button13.TabIndex = 20;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(815, 142);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(111, 55);
            this.button14.TabIndex = 19;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(702, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(111, 55);
            this.button15.TabIndex = 18;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(470, 142);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(111, 55);
            this.button16.TabIndex = 17;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(587, 197);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(111, 55);
            this.button17.TabIndex = 25;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // psComboBox
            // 
            this.psComboBox.FormattingEnabled = true;
            this.psComboBox.Location = new System.Drawing.Point(281, 41);
            this.psComboBox.Name = "psComboBox";
            this.psComboBox.Size = new System.Drawing.Size(147, 20);
            this.psComboBox.TabIndex = 26;
            this.psComboBox.SelectedIndexChanged += new System.EventHandler(this.psComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "PS값";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(718, 65);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(111, 55);
            this.button18.TabIndex = 28;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // START1
            // 
            this.START1.Location = new System.Drawing.Point(12, 325);
            this.START1.Name = "START1";
            this.START1.Size = new System.Drawing.Size(109, 68);
            this.START1.TabIndex = 29;
            this.START1.Text = "START";
            this.START1.UseVisualStyleBackColor = true;
            this.START1.Click += new System.EventHandler(this.start1_Click);
            // 
            // stop1
            // 
            this.stop1.Location = new System.Drawing.Point(10, 412);
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(109, 68);
            this.stop1.TabIndex = 30;
            this.stop1.Text = "STOP";
            this.stop1.UseVisualStyleBackColor = true;
            this.stop1.Click += new System.EventHandler(this.stop1_Click);
            // 
            // periodTextBox
            // 
            this.periodTextBox.Location = new System.Drawing.Point(565, 40);
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.Size = new System.Drawing.Size(147, 21);
            this.periodTextBox.TabIndex = 31;
            this.periodTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodTextBox_KeyPress);
            this.periodTextBox.Leave += new System.EventHandler(this.periodTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "주기 (ms)";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(2099, 284);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(147, 80);
            this.button21.TabIndex = 52;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(2099, 198);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(147, 80);
            this.button22.TabIndex = 51;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(2099, 112);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(147, 80);
            this.button23.TabIndex = 50;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(2099, 26);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(147, 80);
            this.button24.TabIndex = 49;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(1793, 26);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(147, 80);
            this.button25.TabIndex = 48;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(1793, 112);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(147, 80);
            this.button26.TabIndex = 47;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(1793, 198);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(147, 80);
            this.button27.TabIndex = 46;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(1793, 284);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(147, 80);
            this.button28.TabIndex = 45;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(1946, 26);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(147, 80);
            this.button29.TabIndex = 44;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(1946, 112);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(147, 80);
            this.button30.TabIndex = 43;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(1946, 198);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(147, 80);
            this.button31.TabIndex = 42;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(1946, 284);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(147, 80);
            this.button32.TabIndex = 41;
            this.button32.Text = "button32";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(1640, 26);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(147, 80);
            this.button33.TabIndex = 40;
            this.button33.Text = "button33";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(1640, 112);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(147, 80);
            this.button34.TabIndex = 39;
            this.button34.Text = "button34";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(1640, 198);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(147, 80);
            this.button35.TabIndex = 38;
            this.button35.Text = "button35";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(1640, 284);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(147, 80);
            this.button36.TabIndex = 37;
            this.button36.Text = "button36";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(1487, 198);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(147, 80);
            this.button37.TabIndex = 36;
            this.button37.Text = "button37";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(1487, 284);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(147, 80);
            this.button38.TabIndex = 35;
            this.button38.Text = "button38";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(1487, 112);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(147, 80);
            this.button39.TabIndex = 34;
            this.button39.Text = "button39";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(1487, 26);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(147, 80);
            this.button40.TabIndex = 33;
            this.button40.Text = "button40";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(2099, 628);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(147, 80);
            this.button41.TabIndex = 72;
            this.button41.Text = "button41";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(2099, 542);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(147, 80);
            this.button42.TabIndex = 71;
            this.button42.Text = "button42";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(2099, 456);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(147, 80);
            this.button43.TabIndex = 70;
            this.button43.Text = "button43";
            this.button43.UseVisualStyleBackColor = true;
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(2099, 370);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(147, 80);
            this.button44.TabIndex = 69;
            this.button44.Text = "button44";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(1793, 370);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(147, 80);
            this.button45.TabIndex = 68;
            this.button45.Text = "button45";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(1793, 456);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(147, 80);
            this.button46.TabIndex = 67;
            this.button46.Text = "button46";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(1793, 542);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(147, 80);
            this.button47.TabIndex = 66;
            this.button47.Text = "button47";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(1793, 628);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(147, 80);
            this.button48.TabIndex = 65;
            this.button48.Text = "button48";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(1946, 370);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(147, 80);
            this.button49.TabIndex = 64;
            this.button49.Text = "button49";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(1946, 456);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(147, 80);
            this.button50.TabIndex = 63;
            this.button50.Text = "button50";
            this.button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(1946, 542);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(147, 80);
            this.button51.TabIndex = 62;
            this.button51.Text = "button51";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(1946, 628);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(147, 80);
            this.button52.TabIndex = 73;
            this.button52.Text = "button52";
            this.button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(1640, 370);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(147, 80);
            this.button53.TabIndex = 74;
            this.button53.Text = "button53";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(1640, 456);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(147, 80);
            this.button54.TabIndex = 75;
            this.button54.Text = "button54";
            this.button54.UseVisualStyleBackColor = true;
            // 
            // hiddenButton
            // 
            this.hiddenButton.Location = new System.Drawing.Point(1282, 6);
            this.hiddenButton.Name = "hiddenButton";
            this.hiddenButton.Size = new System.Drawing.Size(33, 907);
            this.hiddenButton.TabIndex = 76;
            this.hiddenButton.Text = "hiddenButton";
            this.hiddenButton.UseVisualStyleBackColor = true;
            this.hiddenButton.Click += new System.EventHandler(this.hiddenButton_Click);
            // 
            // autoScaleButton
            // 
            this.autoScaleButton.Location = new System.Drawing.Point(976, 171);
            this.autoScaleButton.Name = "autoScaleButton";
            this.autoScaleButton.Size = new System.Drawing.Size(300, 81);
            this.autoScaleButton.TabIndex = 77;
            this.autoScaleButton.Text = "Auto Scale";
            this.autoScaleButton.UseVisualStyleBackColor = true;
            this.autoScaleButton.Visible = false;
            this.autoScaleButton.Click += new System.EventHandler(this.autoScaleButton_Click);
            // 
            // FormPlot2
            // 
            this.FormPlot2.Location = new System.Drawing.Point(127, 495);
            this.FormPlot2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FormPlot2.Name = "FormPlot2";
            this.FormPlot2.Size = new System.Drawing.Size(1056, 416);
            this.FormPlot2.TabIndex = 78;
            // 
            // STOP2
            // 
            this.STOP2.Location = new System.Drawing.Point(8, 607);
            this.STOP2.Name = "STOP2";
            this.STOP2.Size = new System.Drawing.Size(109, 68);
            this.STOP2.TabIndex = 80;
            this.STOP2.Text = "STOP";
            this.STOP2.UseVisualStyleBackColor = true;
            this.STOP2.Click += new System.EventHandler(this.stop2_Click);
            // 
            // START2
            // 
            this.START2.Location = new System.Drawing.Point(10, 520);
            this.START2.Name = "START2";
            this.START2.Size = new System.Drawing.Size(109, 68);
            this.START2.TabIndex = 79;
            this.START2.Text = "START";
            this.START2.UseVisualStyleBackColor = true;
            this.START2.Click += new System.EventHandler(this.start2_Click);
            // 
            // voltTextBox
            // 
            this.voltTextBox.Location = new System.Drawing.Point(276, 87);
            this.voltTextBox.Name = "voltTextBox";
            this.voltTextBox.Size = new System.Drawing.Size(91, 21);
            this.voltTextBox.TabIndex = 82;
            this.voltTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltTextBox_KeyPress);
            this.voltTextBox.Leave += new System.EventHandler(this.voltTextBox_Leave);
            // 
            // numberLabel1
            // 
            this.numberLabel1.AutoSize = true;
            this.numberLabel1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numberLabel1.Location = new System.Drawing.Point(1204, 381);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(44, 24);
            this.numberLabel1.TabIndex = 83;
            this.numberLabel1.Text = "0.0";
            // 
            // numberLabel2
            // 
            this.numberLabel2.AutoSize = true;
            this.numberLabel2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numberLabel2.Location = new System.Drawing.Point(1204, 564);
            this.numberLabel2.Name = "numberLabel2";
            this.numberLabel2.Size = new System.Drawing.Size(44, 24);
            this.numberLabel2.TabIndex = 84;
            this.numberLabel2.Text = "0.0";
            // 
            // numberLabel3
            // 
            this.numberLabel3.AutoSize = true;
            this.numberLabel3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numberLabel3.Location = new System.Drawing.Point(1204, 776);
            this.numberLabel3.Name = "numberLabel3";
            this.numberLabel3.Size = new System.Drawing.Size(44, 24);
            this.numberLabel3.TabIndex = 87;
            this.numberLabel3.Text = "0.0";
            // 
            // limitBox
            // 
            this.limitBox.Location = new System.Drawing.Point(446, 40);
            this.limitBox.Name = "limitBox";
            this.limitBox.Size = new System.Drawing.Size(91, 21);
            this.limitBox.TabIndex = 88;
            this.limitBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitBox_KeyPress);
            this.limitBox.Leave += new System.EventHandler(this.limitBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "그래프 개수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 90;
            this.label4.Text = "Volt";
            // 
            // brigTextbox
            // 
            this.brigTextbox.Location = new System.Drawing.Point(621, 86);
            this.brigTextbox.Name = "brigTextbox";
            this.brigTextbox.Size = new System.Drawing.Size(91, 21);
            this.brigTextbox.TabIndex = 91;
            this.brigTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brigTextbox_KeyPress);
            this.brigTextbox.Leave += new System.EventHandler(this.brigTextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 92;
            this.label5.Text = "Brig";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(242, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 55);
            this.button7.TabIndex = 93;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button56
            // 
            this.button56.Location = new System.Drawing.Point(472, 203);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(111, 55);
            this.button56.TabIndex = 94;
            this.button56.Text = "button56";
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1324, 925);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brigTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limitBox);
            this.Controls.Add(this.numberLabel3);
            this.Controls.Add(this.numberLabel2);
            this.Controls.Add(this.numberLabel1);
            this.Controls.Add(this.voltTextBox);
            this.Controls.Add(this.STOP2);
            this.Controls.Add(this.START2);
            this.Controls.Add(this.FormPlot2);
            this.Controls.Add(this.autoScaleButton);
            this.Controls.Add(this.hiddenButton);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodTextBox);
            this.Controls.Add(this.stop1);
            this.Controls.Add(this.START1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.psComboBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FormPlot);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.comboBox_port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.Label label_port;
        private System.IO.Ports.SerialPort serialPort1;
        private ScottPlot.FormsPlot FormPlot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox psComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button START1;
        private System.Windows.Forms.Button stop1;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button hiddenButton;
        private System.Windows.Forms.Button autoScaleButton;
        private ScottPlot.FormsPlot FormPlot2;
        private System.Windows.Forms.Button STOP2;
        private System.Windows.Forms.Button START2;
        private System.Windows.Forms.TextBox voltTextBox;
        private System.Windows.Forms.Label numberLabel1;
        private System.Windows.Forms.Label numberLabel2;
        private System.Windows.Forms.Label numberLabel3;
        private System.Windows.Forms.TextBox limitBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brigTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button56;
    }
}

