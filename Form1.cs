using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Diagnostics;  //시리얼통신을 위해 추가해줘야 함
using ScottPlot.Plottable;
using ScottPlot;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace Serial_Communication
{   
    public partial class Form1 : Form
    {
        private List<Button> buttonlist = new List<Button>();
        private string ps = "1";
        private ConcurrentQueue<string> q = new ConcurrentQueue<string>();
        private bool isStop = true, isStop2 = true, isStop3 = true;
        //private bool isDeque = true;
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer autoTimer = new System.Windows.Forms.Timer();

        int NextPointIndex = 0, NextPointIndex2 = 0, NextPointIndex3 = 0;
        readonly double[] Values = new double[100000];
        readonly double[] Values2 = new double[100000];
        readonly double[] Values3 = new double[100000];


        ScottPlot.Plottable.SignalPlot SignalPlot, SignalPlot2, SignalPlot3;
        
        double maxLimitY = 0.0000001;
        double minLimitY = 0;

        double maxLimitY2 = 5;
        double minLimitY2 = 0;

        double maxLimitY3 = 20;
        double minLimitY3 = 0;

        //double stx = 0;
        //double edx = 100;

        //double stx2 = 0;
        //double edx2 = 100;

        //double stx3 = 0;
        //double edx3 = 100;

        bool isAutoOn = false;
        int autoRange = 100, autoRange2 = 100, autoRange3 = 100;
        int prevRange = 0, prevRange2 = 0;
        public Form1()
        {
            InitializeComponent();

            button1.Text = "*IDN?";
            button2.Text = "*RST";             
            button3.Text = "*TST";             
            button4.Text = "REBOOT";           
            button5.Text = "CM#:RUN ON";
            button6.Text = "CM#:RUN OFF";
            button7.Text = "PS#:RUN OFF";
            button8.Text = "CM#:MEAS:CURR?";   
            button9.Text = "PS#:RUN ON";   // ps#:run on, off     
            button10.Text = "PS#:RUN?";        
            button11.Text = "PS#:VOLT @";        
            button12.Text = "PS#:VOLT?";      
            button13.Text = "PS#:MEAS:VOLT?";  
            button14.Text = "PS#:MEAS:CURR?";  
            button15.Text = "PS#:MEAS:WATT?";  
            button16.Text = "SYS:REM ON";  // sys:rem on, off
            button17.Text = "SYS:REM?";  // sys:rem?       
            button18.Text = "SYS:BRIG @";
            button21.Text = "*CMD?";
            button22.Text = "*INFO?";
            button23.Text = "SYS:REM:UI #";
            button24.Text = "SYS:ALC #";
            button25.Text = "SYS:ALC:KP #";
            button26.Text = "SYS:ALC:DIFF #";
            button27.Text = "SYS:AVG #";
            button28.Text = "SYS:MEAS:TICK";
            button29.Text = "SYS:AUTO #";
            button30.Text = "SYS:SET:TR #";
            button31.Text = "SYS:EE:INIT";
            button32.Text = "SYS:SELFTEST";
            button33.Text = "SYS:SERIAL #";
            button34.Text = "SYS:SERIAL?";
            button35.Text = "CONF:D1:CAL:CH@ #";
            button36.Text = "READ:RAW:D1D2";
            button37.Text = "CONF:RAW:D1 #";
            button38.Text = "CONF:RAW:D2 #";
            button39.Text = "CONF:RAW:D1W #";
            button40.Text = "CONF:RAW:D2W #";
            button41.Text = "CONF:RAW:D1RES #";
            button42.Text = "CONF:RAW:D2RES #";
            button43.Text = "READ:RAW:INA228 #";
            button44.Text = "CONF:INIT:INA228";
            button45.Text = "CONF:RAW:AVG:CH@ #";
            button46.Text = "CONF:RAW:VBUS:CH@ #";
            button47.Text = "CONF:RAW:VSHT:CH@ #";
            button48.Text = "READ:VOLT:CH@";
            button49.Text = "CONF:VOLT:CH@ #";
            button50.Text = "CONF:OCP:CH@ #";
            button51.Text = "READ:CURR:CAL";
            button52.Text = "CONF:CURR:CAL:CH@ #";
            button53.Text = "CONF:CAL:RELAY:CH@ #";
            button54.Text = "CONF:VOLT:CAL";
            button56.Text = "SYS:REM OFF";  // sys:rem on, 
           

            buttonlist.Add(button1);
            buttonlist.Add(button2);
            buttonlist.Add(button3);
            buttonlist.Add(button4);
            buttonlist.Add(button5);
            buttonlist.Add(button6);
            buttonlist.Add(button7);
            buttonlist.Add(button8);
            buttonlist.Add(button9);
            buttonlist.Add(button10);
            buttonlist.Add(button11);
            buttonlist.Add(button12);
            buttonlist.Add(button13);
            buttonlist.Add(button14);
            buttonlist.Add(button15);
            buttonlist.Add(button16);
            buttonlist.Add(button17);
            buttonlist.Add(button18);
            buttonlist.Add(button21);
            buttonlist.Add(button22);
            buttonlist.Add(button23);
            buttonlist.Add(button24);
            buttonlist.Add(button25);
            buttonlist.Add(button26);
            buttonlist.Add(button27);
            buttonlist.Add(button28);
            buttonlist.Add(button29);
            buttonlist.Add(button30);
            buttonlist.Add(button31);
            buttonlist.Add(button32);
            buttonlist.Add(button33);
            buttonlist.Add(button34);
            buttonlist.Add(button35);
            buttonlist.Add(button36);
            buttonlist.Add(button37);
            buttonlist.Add(button38);
            buttonlist.Add(button39);
            buttonlist.Add(button40);
            buttonlist.Add(button41);
            buttonlist.Add(button42);
            buttonlist.Add(button43);
            buttonlist.Add(button44);
            buttonlist.Add(button45);
            buttonlist.Add(button46);
            buttonlist.Add(button47);
            buttonlist.Add(button48);
            buttonlist.Add(button49);
            buttonlist.Add(button50);
            buttonlist.Add(button51);
            buttonlist.Add(button52);
            buttonlist.Add(button53);
            buttonlist.Add(button54);
            buttonlist.Add(button56);

            hiddenButton.Text = "\u25B6"; // right arrow   

            int idx = 1;
            foreach (Control tempCtrl in this.Controls)
            {
                if (idx > 51)
                    break;

                if (tempCtrl.Name == "button" + idx.ToString())
                {
                    buttonlist.Add((Button) tempCtrl);
                }
            }
            psComboBox.Items.Add("1");
            psComboBox.Items.Add("2");
            psComboBox.SelectedIndex = 0;

            periodTextBox.Text = "100";
            periodBoxtemp = "100";

            // plot1
            //FormPlot.Plot.SetAxisLimits(0, 1, minLimitY, maxLimitY);           
            SignalPlot = FormPlot.Plot.PlotSignal(Values);
            SignalPlot.YAxisIndex = FormPlot.Plot.LeftAxis.AxisIndex;
            FormPlot.Plot.LeftAxis.Ticks(true);
            FormPlot.Plot.Width = 1060;

            FormPlot.Refresh();
        
            // plot2
           // FormPlot2.Plot.SetAxisLimits(0, 1, minLimitY2, maxLimitY2);
            SignalPlot2 = FormPlot2.Plot.PlotSignal(Values2);
            SignalPlot2.YAxisIndex = FormPlot2.Plot.LeftAxis.AxisIndex;

            SignalPlot3 = FormPlot2.plt.PlotSignal(Values3);
            SignalPlot3.YAxisIndex = FormPlot2.Plot.RightAxis.AxisIndex;
            FormPlot2.Plot.RightAxis.Ticks(true);

            FormPlot2.Plot.Width = 1060;

            FormPlot2.Refresh();
            

            // plot3
            //FormPlot3.Plot.SetAxisLimits(0, 1, minLimitY3, maxLimitY3);
            //SignalPlot3 = FormPlot3.plt.PlotSignal(Values3);
            //FormPlot3.Plot.Width = 1060;
            //FormPlot3.Refresh();
            
            //autoTimer.Interval = 3000;
            //autoTimer.Tick += new EventHandler((sv, ev) =>
            //{
            //    FormPlot.Plot.SetAxisLimits(xMax: edx, xMin: stx, yMin: minLimitY, yMax: maxLimitY);
            //    isAutoOn = false;
            //    autoTimer.Enabled = false;
            //});
         
            voltTextBox.Text = "1.5";

            valuesByPlot.Add(FormPlot, Values);
            valuesBy2.Add(FormPlot2, new List<double[]>() { Values2, Values3 });
            //valuesByPlot.Add(FormPlot2, Values2);          
            //valuesByPlot.Add(FormPlot3, Values3);

            //showGraph1();
            //showGraph2();
            //showGraph3();

            limitBox.Text = "100";
            brigTextbox.Text = "100";

            isStop = true;
            isStop2 = true;
            isRunning = false;

            deactivateButtons();
            activateStartStop(false);
        }

        private void Form1_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
        }
               
        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 115200;  //보레이트 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다
                //serialPort1.NewLine = "\r";
                serialPort1.Open();  //시리얼포트 열기

                //label_status.Text = "포트가 열렸습니다.";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
                RichTextBoxExtensions.addLog("OPEN" + "\n", serialPort1.PortName, "-");

                isStop = true;
                isStop2 = true;
                isRunning = false;
                activateStartStop(true);
                activateButton();

                isPaused[0] = true;
                isPaused[1] = true;
                START1.Text = "START";
                START2.Text = "START";
                resetPlot();
                resetPlot2();
                showGraph1();
                showGraph2();
                //executeLoop(true);

                //_ = Task.Run(async () =>
                //{
                //    while (true)
                //    {
                //        if (!isRunning) break;
                //        q.Enqueue("ALL:MEAS?");
                //        serialPort1.Write("ALL:MEAS?" + "\r");
                //        stopwatch.Start(); // 시간측정 시작
                //        var t = Int32.Parse(periodBoxtemp);
                //        await Task.Delay(t);
                //    }
                //});
            }
            else  //시리얼포트가 열려 있으면
            {
                //label_status.Text = "포트가 이미 열려 있습니다.";                
            }
        }
                
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {            
            this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        public List<byte> dutBuffer = new List<byte>();
        char ETX = (char)3;
        StringBuilder sb = new StringBuilder();
        string currentLine = string.Empty;
        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            string cmd = string.Empty;
            q.TryDequeue(out cmd);                        
            
            if (cmd == "" || cmd == null)
            {
                stopwatch.Reset(); //시간측정 끝
                return;
            }


            string Data = serialPort1.ReadExisting();
            currentLine = "";

            foreach (char c in Data)
            {
                if (c == '\r')
                {
                    stopwatch.Stop(); //시간측정 끝
                    sb.Append(c);

                    currentLine = sb.ToString();
                    sb.Clear();

                    //parse CurrentLine here or print it to textbox
                    //note you might have to invoke because this event is on its own thread
                }
                else
                {
                    sb.Append(c);
                }
            }
            if (currentLine == "" || currentLine.Contains("INVALID"))
            {
                stopwatch.Reset(); //시간측정 끝
                return;
            }
           
            stopwatch.Reset(); //시간측정 끝
            executePlotCommand(cmd);

            if (!cmd.Contains("ALL:MEAS?"))
            {
                richTextBox_received.AppendText(cmd + "\n", Color.Blue);
                richTextBox_received.AppendText(currentLine + "\n", Color.Red);
                richTextBox_received.ScrollToCaret();
                //richTextBox_received.AppendText(stopwatch.ElapsedMilliseconds + "\n", Color.Green);
            }
        }
        int flag1 = 0, flag2 = 0, flag3 = 0;
        private void executePlotCommand(string cmd)
        {
            if (!cmd.Contains("ALL:MEAS?") || cmd == null)
                return;

            if (!isPaused[0])
            {
                double currMin = FormPlot.Plot.GetAxisLimits().XMin;
                double res = 0;

                var arr = currentLine.Split(',');
                bool isNum = double.TryParse(arr[0], out res);

                if (isNum)
                {
                    numberLabel1.Text = res.ToString("0.0000");

                    if (res > 0)
                        flag1 |= 2;
                    else
                        flag1 |= 1;

                    Console.WriteLine("flag1 : " + flag1);

                    if (flag1 == 2 && maxLimitY < res)
                    {
                        maxLimitY = Math.Max(maxLimitY, res);
                        maxLimitY = res + (res * .1);
                        minLimitY = 0;
                    }
                    else if (flag1 == 1 && minLimitY > res)
                    {
                        maxLimitY = 0.0000001;                        
                        minLimitY = Math.Min(minLimitY, res);
                        minLimitY = res + (res * .5);
                    }
                    else if (flag1 == 3)
                    {
                        if (maxLimitY < res)
                        {
                            maxLimitY = res + (res * .5);
                            minLimitY = res + (res * .5);
                            minLimitY = -minLimitY;
                        }

                        if (res < minLimitY)
                        {
                            minLimitY = res + (res * .5);
                            maxLimitY = -minLimitY;
                        }
                    }

                }

                if (NextPointIndex > 3600 || NextPointIndex > Int32.Parse(limitBoxTemp))
                {
                    NextPointIndex = 0;
                    autoRange = 1;
                    prevRange = 0;
                    FormPlot.Plot.Clear();
                    Array.Clear(Values, 0, Values.Length);
                    SignalPlot = FormPlot.Plot.AddSignal(Values);

                    showGraph1();
                }
                Values[NextPointIndex] = res;
                SignalPlot.MaxRenderIndex = NextPointIndex;
                FormPlot.Plot.SetAxisLimits(xMax: autoRange, xMin: 0, yMin: minLimitY, yMax: maxLimitY, yAxisIndex: 0);
                //FormPlot.Plot.SetAxisLimits(xMax: autoRange, xMin: 0, yMin: minLimitY, yMax: maxLimitY);

                NextPointIndex += 1;                
                autoRange = NextPointIndex % Int32.Parse(limitBoxTemp) == 0 ? 1 : NextPointIndex % Int32.Parse(limitBoxTemp);

                //if (NextPointIndex > autoRange + prevRange)
                //{
                //    prevRange = NextPointIndex;
                //    autoRange = 1;
                //}

                FormPlot.Plot.Width = 1060;            
                FormPlot.Refresh();
            }

            if (!isPaused[1])
            {
                //double currMin = FormPlot2.Plot.GetAxisLimits(0).XMin;
                double res = 0;

                var arr = currentLine.Split(',');
                bool isNum = double.TryParse(arr[1], out res);

                if (isNum)
                {
                    numberLabel2.Text = res.ToString("0.00000");

                    if (res > 0)
                        flag2 |= 2;
                    else if (res < 0)
                        flag2 |= 1;


                    if (flag2 == 2 && maxLimitY2 < res)
                    {
                        maxLimitY2 = Math.Max(maxLimitY2, res);
                        maxLimitY2 = res + (res * .1);
                        minLimitY2 = 0;
                    }
                    else if (flag2 == 1 && minLimitY2 > res)
                    {
                        maxLimitY2 = 0.0000001;
                        minLimitY2 = Math.Min(minLimitY2, res);
                        minLimitY2 = res;
                    }
                    else if (flag2 == 3)
                    {
                        if (maxLimitY2 < res)
                        {
                            maxLimitY2 = res + (res * .5);
                            minLimitY2 = -maxLimitY2;
                        }
                        if (res < minLimitY2)
                        {
                            minLimitY2 = res + (res * .5);
                            maxLimitY2 = -minLimitY2;
                        }
                    }
                }

                //currMin = FormPlot3.Plot.GetAxisLimits(1).XMin;
                double res3 = 0;

                arr = currentLine.Split(',');
                isNum = double.TryParse(arr[2], out res3);


                Console.WriteLine("flag2 : " + flag2 + " res1 : " + res + " res2 : " + res3);


                if (isNum)
                {
                    numberLabel3.Text = res3.ToString("0.00000");
                    if (res3 > 0)
                        flag3 |= 2;
                    else if (res3 < 0)
                        flag3 |= 1;

                    Console.WriteLine("flag3 : " + flag3);

                    if (flag3 == 2 && maxLimitY3 < res3)
                    {
                        maxLimitY3 = Math.Max(maxLimitY3, res3);
                        maxLimitY3 = res3 + (res3 * .1);
                        minLimitY3 = 0;
                    }
                    else if (flag3 == 1 && minLimitY3 > res3)
                    {
                        maxLimitY3 = 0.0000001;
                        minLimitY3 = Math.Min(minLimitY3, res3);
                        minLimitY3 = res3 + (res3 * .5);
                    }
                    else if (flag3 == 3)
                    {
                        if (maxLimitY3 < res3)
                        {
                            maxLimitY3 = res3 + (res3 * .5);
                            minLimitY3 = -maxLimitY3;
                        }
                        if (res3 < minLimitY3)
                        {
                            minLimitY3 = res3 + (res3 * .5);
                            maxLimitY3 = -minLimitY3;
                        }
                    }
                }

                if (NextPointIndex2 > 3600 || NextPointIndex2 > Int32.Parse(limitBoxTemp))
                {
                    NextPointIndex2 = 0;
                    autoRange2 = 1;
                    prevRange2 = 0;

                    Array.Clear(Values2, 0, Values2.Length);
                    Array.Clear(Values3, 0, Values3.Length);

                    FormPlot2.Plot.Clear();

                    SignalPlot2 = FormPlot2.Plot.AddSignal(Values2);
                    SignalPlot2.YAxisIndex = FormPlot2.Plot.LeftAxis.AxisIndex;

                    SignalPlot3 = FormPlot2.plt.AddSignal(Values3);
                    SignalPlot3.YAxisIndex = FormPlot2.Plot.RightAxis.AxisIndex;
                    FormPlot2.Plot.RightAxis.Ticks(true);

                    showGraph2();
                }

                Values2[NextPointIndex2] = res;
                Values3[NextPointIndex2] = res3;
                SignalPlot3.MaxRenderIndex = SignalPlot2.MaxRenderIndex = NextPointIndex2;

                FormPlot2.Plot.SetAxisLimits(xMax: autoRange2 , xMin: 0, yMin: minLimitY2, yMax: maxLimitY2, yAxisIndex: 0);
                FormPlot2.Plot.SetAxisLimits(xMax: autoRange2 , xMin: 0, yMin: minLimitY3, yMax: maxLimitY3, yAxisIndex: 1);


                NextPointIndex2 += 1;
                autoRange2 = NextPointIndex2 % Int32.Parse(limitBoxTemp) == 0 ? 1 : NextPointIndex2 % Int32.Parse(limitBoxTemp);

                //if (NextPointIndex2 > autoRange2 + prevRange2)
                //{
                //    prevRange2 = NextPointIndex2;
                //    autoRange2 = 1;
                //}

                FormPlot2.Plot.Width = 1060;            
                FormPlot2.Refresh();
            //}

            //if (!isPaused[2])
            //{
                //currMin = FormPlot3.Plot.GetAxisLimits(1).XMin;
                //res = 0;

                //arr = currentLine.Split(',');
                //isNum = double.TryParse(arr[2], out res);

                //if (isNum)
                //{
                //    numberLabel3.Text = res.ToString("0.00000");
                //    if (res > 0)
                //        flag3 |= 2;
                //    else if (res < 0)
                //        flag3 |= 1;

                //    Console.WriteLine("flag3 : " + flag3);

                //    if (flag3 == 2 && maxLimitY3 < res)
                //    {
                //        maxLimitY3 = Math.Max(maxLimitY3, res);
                //        maxLimitY3 = res + (res * .1);
                //        minLimitY3 = 0;
                //    }
                //    else if (flag3 == 1 && minLimitY3 > res)
                //    {
                //        maxLimitY3 = 0.0000001;
                //        minLimitY3 = Math.Min(minLimitY3, res);
                //        minLimitY3 = res + (res * .5);
                //    }
                //    else if (flag3 == 3)
                //    {
                //        if (maxLimitY3 < res)
                //        {
                //            maxLimitY3 = res + (res * .5);
                //            minLimitY3 = -maxLimitY3;
                //        }
                //        if (res < minLimitY3)
                //        {
                //            minLimitY3 = res + (res * .5);
                //            maxLimitY3 = -minLimitY3;
                //        }
                //    }
                //}

                //if (NextPointIndex3 > 3600)
                //{
                //    NextPointIndex3 = 0;
                //    //FormPlot3.Plot.Clear();
                //    Array.Clear(Values3, 0, Values3.Length);
                //    SignalPlot3 = FormPlot3.Plot.PlotSignal(Values3);
                //}

                //Values3[NextPointIndex3] = res;
                //SignalPlot3.MaxRenderIndex = NextPointIndex3;
                //FormPlot3.Plot.SetAxisLimits(xMax: autoRange3, xMin: 0, yMin: minLimitY3, yMax: maxLimitY3);

                //NextPointIndex3 += 1;
                //autoRange3 = NextPointIndex3 % Int32.Parse(limitBoxTemp) == 0 ? 1 : NextPointIndex3 % Int32.Parse(limitBoxTemp);
                //FormPlot3.Width = 1060;

                //FormPlot3.Refresh();
                //Console.WriteLine("width : " + FormPlot3.Width);
            }
        }

        private void activateStartStop(bool isOn)
        {
            START1.Enabled = isOn;
            START2.Enabled = isOn;
            stop1.Enabled = isOn;
            STOP2.Enabled = isOn;
        }
        private void activateButton()
        {
            if (!isStop || !isStop2)
                return;

            foreach (var b in buttonlist)
                b.Enabled = true;
        }
        private void deactivateButtons()
        {
            foreach (var b in buttonlist)
                b.Enabled = false;            
        }
        private readonly Dictionary<FormsPlot, List<Crosshair>> crossBy2 = new Dictionary<FormsPlot, List<Crosshair>>();
        private readonly Dictionary<FormsPlot, List<double[]>> valuesBy2 = new Dictionary<FormsPlot, List<double[]>>();

        private readonly Dictionary<FormsPlot, Crosshair> CrosshairsByPlot = new Dictionary<FormsPlot, Crosshair>();
        private readonly Dictionary<FormsPlot, double[]> valuesByPlot = new Dictionary<FormsPlot, double[]>();
        static string customFormatter(double position)
        {
            if (position == 0)
                return "zero";
            else if (position > 0)
                return position.ToString();
            else
                return position.ToString();
        }
        private void FormsPlot_MouseMove2(object sender, MouseEventArgs e)
        {
            FormsPlot f = (FormsPlot) sender;
            var c = crossBy2[f];
            var v = valuesBy2[f];

            (double x, double y) = f.GetMouseCoordinates(xAxisIndex: 0, yAxisIndex: 0);
            (double x2, double y2) = f.GetMouseCoordinates(xAxisIndex: 0, yAxisIndex: 1);
            
            int nx = Convert.ToInt32(x);
            
            c[0].X = x;

            if (x >= 0)
            {
                c[0].Y = v[0][nx];
                c[1].Y = v[1][nx];
            }

            f.Render();
        }

        private void FormsPlot_MouseMove(object sender, MouseEventArgs e)
        {
            FormsPlot f = (FormsPlot)sender;           
            Crosshair crosshair = CrosshairsByPlot[f];
            double[] v = valuesByPlot[f];
            (double x, double y) = f.GetMouseCoordinates();
            int nx = Convert.ToInt32(x);
            crosshair.X = x;
            if (x >= 0)
                crosshair.Y = v[nx];
            f.Render();
        }

        //private void resetPlot3()
        //{
        //    //stx3 = 0;
        //    //edx3 = Int32.Parse(limitBoxTemp);
        //    maxLimitY3 = 0.0005;
        //    minLimitY3 = -0.0005;
        //    FormPlot3.Plot.Clear();
        //    FormPlot3.Plot.SetAxisLimits(xMax: 100, xMin: 0, yMin: minLimitY3, yMax: maxLimitY3);
        //    NextPointIndex3 = 0;
        //    autoRange3 = 1;
        //    SignalPlot3 = FormPlot3.plt.PlotSignal(Values3);
        //    Array.Clear(Values3, 0, Values2.Length);
        //    FormPlot3.Refresh();
        //    //q = new ConcurrentQueue<string>();
        //}
        private void resetPlot2()
        {
            //stx2 = 0;
            //edx2 = Int32.Parse(limitBoxTemp);
            maxLimitY2 = 0.0005;
            minLimitY2 = -0.0005;
            FormPlot2.Plot.Clear();

            prevRange2 = 0;
            NextPointIndex2 = 0;
            autoRange2 = 1;            

            Array.Clear(Values2, 0, Values2.Length);
            Array.Clear(Values3, 0, Values3.Length);

            SignalPlot2 = FormPlot2.Plot.AddSignal(Values2);
            SignalPlot2.YAxisIndex = FormPlot2.Plot.LeftAxis.AxisIndex;

            SignalPlot3 = FormPlot2.plt.AddSignal(Values3);
            SignalPlot3.YAxisIndex = FormPlot2.Plot.RightAxis.AxisIndex;
            FormPlot2.Plot.RightAxis.Ticks(true);

            SignalPlot3.MaxRenderIndex = SignalPlot2.MaxRenderIndex = NextPointIndex2;


            FormPlot2.Plot.SetAxisLimits(xMax: 100, xMin: 0, yMin: minLimitY2, yMax: maxLimitY2, yAxisIndex: 0);
            FormPlot2.Plot.SetAxisLimits(xMax: 100, xMin: 0, yMin: minLimitY3, yMax: maxLimitY3, yAxisIndex: 1);
            FormPlot2.Refresh();
            //q = new ConcurrentQueue<string>();
        }
        private void resetPlot()
        {
            //stx = 0;
            //edx = Int32.Parse(limitBoxTemp);
            maxLimitY = 0.0005;
            minLimitY = -0.0005;
            FormPlot.Plot.Clear();
            
            NextPointIndex = 0;
            autoRange = 1;
            prevRange = 0;

            Array.Clear(Values, 0, Values.Length);
            SignalPlot = FormPlot.Plot.AddSignal(Values);

            FormPlot.Plot.SetAxisLimits(xMax: 100, xMin: 0, yMin: minLimitY, yMax: maxLimitY);

            FormPlot.Refresh();
            //q = new ConcurrentQueue<string>();
        }
        bool[] isPaused = new bool[3] { true, true, true };
        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            if (!serialPort1.IsOpen)
                return;

            if (isRunning)
                return;

            string cmd = ((Button)sender).Text;
            Run(cmd);
            //if (cmd.Contains("#") && cmd.Contains("@"))
            //{
            //    cmd = cmd.Replace('#', char.Parse(ps));
            //    cmd = cmd.Replace('@', char.Parse(ps));
            //    Run(cmd);
            //    return;
            //}

            //if (cmd.Contains("START1") && (isPaused[0] || isStop))
            //{
            //    if (isStop)
            //    {
            //        resetPlot();
            //        showGraph1();
            //    }

            //    isPaused[0] = false;                 
            //    Run(cmd);
            //    return;
            //}
            //if (cmd.Contains("START2") && (isPaused[1] || isStop2))
            //{
            //    if (isStop2)
            //    {
            //        resetPlot2();
            //        showGraph2();

            //        //resetPlot3();
            //        //showGraph3();
            //    }

            //    isPaused[1] = false;
            //    Run(cmd);
            //    return;

            //    //_ = Task.Run(async () =>
            //    //{
            //    //    while (true)
            //    //    {
            //    //        testtwograph();
            //    //        var t = Int32.Parse(periodBoxtemp);
            //    //        await Task.Delay(10);
            //    //    }
            //    //});
            //}
            //if (cmd.Contains("START3") && (isPaused[2] || isStop3))
            //{
            //    if (isStop3)
            //    {
            //        resetPlot3();
            //        showGraph3();
            //    }

            //    isPaused[2] = false;
            //    Run(cmd);
            //    return;
            //}
            //if (!cmd.Contains("START"))
            //{
            //    Run(cmd);
            //    return;
            //}

            //if (cmd.Contains("START1"))
            //{
            //    isPaused[0] = true;
            //    //showGraph1();
            //}
            //if (cmd.Contains("START2"))
            //{
            //    isPaused[1] = true;
            //    //showGraph2();
            //}
            //if (cmd.Contains("START3"))
            //{
            //    isPaused[2] = true;
            //    //showGraph3();
            //}
        }
        Stopwatch stopwatch = new Stopwatch(); //객체 선언
        CancellationTokenSource cts = new CancellationTokenSource();

        private async void Run(string cmd)
        {
            //if (cmd.Contains("START1"))
            //{
            //    isStop = false;
            //}
            //else if (cmd.Contains("START2"))
            //{
            //    isStop2 = false;
            //}
            //else if (cmd.Contains("START3"))
            //{
            //    isStop3 = false;
            //}
            if (cmd.Contains("SYS:BRIG @"))
            {
                _ = Task.Run(async () =>
                {
                    cmd = cmd.Replace("@", brigTextbox.Text);
                    q.Enqueue(cmd);
                    serialPort1.Write(cmd + "\r");
                    await Task.Delay(Int32.Parse(periodBoxtemp));
                });
            }
            else if (cmd.Contains("PS#:VOLT @"))
            {
                _ = Task.Run(async () =>
                {
                    cmd = cmd.Replace("#", ps);
                    cmd = cmd.Replace("@", voltTextBox.Text);
                    q.Enqueue(cmd);
                    serialPort1.Write(cmd + "\r");
                    await Task.Delay(Int32.Parse(periodBoxtemp));
                });
            }
            else if (cmd.Contains("#") && !cmd.Contains("@"))
            {
                cmd = cmd.Replace("#", ps);
                q.Enqueue(cmd);
                serialPort1.Write(cmd + "\r");
                await Task.Delay(Int32.Parse(periodBoxtemp));
            }
            else //if (!cmd.Contains("START") && !cmd.Contains("STOP"))
            {
                _ = Task.Run(async () =>
                {
                    q.Enqueue(cmd);
                    serialPort1.Write(cmd + "\r");
                    await Task.Delay(Int32.Parse(periodBoxtemp));
                });
            }
        }
        bool isRunning = false;
        
        //private void executeLoop(bool isOn)
        //{           
        //    isRunning = isOn;
        //}
        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                //label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
                isPaused[0] = true;
                isPaused[1] = true;
                START1.Text = "START";
                START2.Text = "START";
                isStop = true;
                isStop2 = true;
                isRunning = false;
                activateStartStop(false);
                deactivateButtons();
                resetPlot();
                resetPlot2();
                showGraph1();
                showGraph2();
                //executeLoop(false);
            }
            else  //시리얼포트가 닫혀 있으면
            {
                //label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void psComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ps = psComboBox.SelectedItem as string;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // your code here
            RichTextBoxExtensions.writeLog24("-");
            //RichTextBoxExtensions.writeLog24("PS1");
            //RichTextBoxExtensions.writeLog24("PS2");
            base.OnFormClosing(e);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RichTextBoxExtensions.writeLog24("-");
            //RichTextBoxExtensions.writeLog24("PS1");
            //RichTextBoxExtensions.writeLog24("PS2");
        }
        string periodBoxtemp = "";
        string limitBoxTemp = "100";
        private void periodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void showGraph1(bool stopPressed = false)
        {
            RichTextBoxExtensions.addLog("STOP1" + "\n", serialPort1.PortName, "-");

            FormPlot.Plot.Clear();
            SignalPlot = FormPlot.Plot.AddSignal(Values);

            Crosshair cross = FormPlot.Plot.AddCrosshair(0.0, 0.0);

            if (!CrosshairsByPlot.ContainsKey(FormPlot))
            {
                CrosshairsByPlot.Add(FormPlot, cross);
                FormPlot.MouseMove += FormsPlot_MouseMove;
                cross.HorizontalLine.PositionFormatter = customFormatter;
            }
            else
                CrosshairsByPlot[FormPlot] = cross;

            int maxRange = 0;
            if (stopPressed)
                maxRange = NextPointIndex == 0 ? 1 : NextPointIndex - 1;
            SignalPlot.MaxRenderIndex = maxRange;
            //FormPlot.Plot.SetAxisLimits(xMax: autoRange + prevRange, xMin: prevRange, yMin: minLimitY, yMax: maxLimitY, yAxisIndex: 0);
            FormPlot.Plot.SetAxisLimits(xMax: autoRange, xMin: 0, yMin: minLimitY, yMax: maxLimitY);
            FormPlot.Render();
        }
        private void showGraph2(bool stopPressed = false)
        {
            RichTextBoxExtensions.addLog("STOP2" + "\n", serialPort1.PortName, "-");

            FormPlot2.Plot.Clear();
            SignalPlot2 = FormPlot2.Plot.AddSignal(Values2);
            SignalPlot2.YAxisIndex = FormPlot2.Plot.LeftAxis.AxisIndex;

            SignalPlot3 = FormPlot2.plt.AddSignal(Values3);
            SignalPlot3.YAxisIndex = FormPlot2.Plot.RightAxis.AxisIndex;
            FormPlot2.Plot.RightAxis.Ticks(true);

            Crosshair c1 = FormPlot2.Plot.AddCrosshair(0.0, 0.0);
            c1.YAxisIndex = SignalPlot2.YAxisIndex;
            Crosshair c2 = FormPlot2.Plot.AddCrosshair(0.0, 0.0);
            c2.YAxisIndex = SignalPlot3.YAxisIndex;

            if (!crossBy2.ContainsKey(FormPlot2))
            {

                crossBy2.Add(FormPlot2, new List<Crosshair>() { c1, c2 });
             
                FormPlot2.MouseMove += FormsPlot_MouseMove2;
                c1.HorizontalLine.PositionLabelFont.Size = 11;
                c1.HorizontalLine.PositionFormatter = customFormatter;

                c2.HorizontalLine.PositionLabelFont.Size = 11;
                c2.HorizontalLine.PositionFormatter = customFormatter;
            }
            else
            {
                crossBy2[FormPlot2] = new List<Crosshair>() { c1, c2 };
            }

            autoRange2 = NextPointIndex2 % Int32.Parse(limitBoxTemp) == 0 ? 1 : NextPointIndex2 % Int32.Parse(limitBoxTemp);

            int maxRange = 0;
            if (stopPressed)
                maxRange = NextPointIndex2 == 0 ? 1 : NextPointIndex2 - 1;
            
            SignalPlot3.MaxRenderIndex = SignalPlot2.MaxRenderIndex = maxRange;

            //if (isStop)
            //{
            //    autoRange2 = autoRange2 == 0 ? 1 : autoRange2 - 1;
            //    SignalPlot3.MaxRenderIndex = SignalPlot2.MaxRenderIndex = NextPointIndex2 - 1;
            //}

            FormPlot2.Plot.SetAxisLimits(xMax: autoRange2, xMin: 0, yMin: minLimitY2, yMax: maxLimitY2, yAxisIndex: 0);
            FormPlot2.Plot.SetAxisLimits(xMax: autoRange2, xMin: 0, yMin: minLimitY3, yMax: maxLimitY3, yAxisIndex: 1);

            FormPlot2.Render();
        }

        //private void showGraph3()
        //{
        //    RichTextBoxExtensions.addLog("STOP3" + "\n", serialPort1.PortName, "-");

        //    FormPlot3.Plot.Clear();
        //    FormPlot3.Plot.PlotSignal(Values3);

        //    Crosshair cross = FormPlot3.Plot.AddCrosshair(0.0, 0.0);

        //    if (!CrosshairsByPlot.ContainsKey(FormPlot3))
        //    {
        //        CrosshairsByPlot.Add(FormPlot3, cross);
        //        FormPlot3.MouseMove += FormsPlot_MouseMove;
        //        cross.HorizontalLine.PositionLabelFont.Size = 11;
        //        cross.HorizontalLine.PositionFormatter = customFormatter;
        //    }
        //    else
        //        CrosshairsByPlot[FormPlot3] = cross;

        //    FormPlot3.Plot.SetAxisLimits(xMax: autoRange3, xMin: 0, yMin: minLimitY3, yMax: maxLimitY3);
        //    FormPlot3.Render();
        //}

        private void brigTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void brigTextbox_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(brigTextbox.Text) < 0 || 100 < Int32.Parse(brigTextbox.Text))
            {
                MessageBox.Show("Brig값은 0 <= t <= 100 값이어야합니다.");
                brigTextbox.Text = "100";
                Invalidate();
                return;
            }            
        }

        private void limitBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void limitBox_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(limitBox.Text) < 100 || 3600 < Int32.Parse(limitBox.Text))
            {
                MessageBox.Show("주기는 100 <= t <= 3600 값이어야합니다.");
                limitBoxTemp = "100";
                //period = 1000;
                limitBox.Text = limitBoxTemp;
                autoRange2 = Int32.Parse(limitBoxTemp);
                Invalidate();
                return;
            }
            limitBoxTemp = limitBox.Text;
        }
        private void runLoop()
        {
            isRunning = true;

            _ = Task.Run(async () =>
            {
                while (true)
                {
                    if (!isRunning) break;                     
                    q.Enqueue("ALL:MEAS?");
                    serialPort1.Write("ALL:MEAS?" + "\r");
                    stopwatch.Start(); // 시간측정 시작
                    var t = Int32.Parse(periodBoxtemp);
                    await Task.Delay(t);
                }
            });
        }
        private void start1_Click(object sender, EventArgs e)
        {
            deactivateButtons();
            
            if (isStop)
            {
                resetPlot();
                showGraph1();
                isStop = false;
            }
            
            if (!isRunning) runLoop();
            isPaused[0] = !isPaused[0];
            START1.Text = isPaused[0] ? "PAUSED" : "START";
        }

        private void start2_Click(object sender, EventArgs e)
        {
            deactivateButtons();

            if (isStop2)
            {
                resetPlot2();
                showGraph2();
                isStop2 = false;
            }
            if (!isRunning) runLoop();            
            isPaused[1] = !isPaused[1];
            START2.Text = isPaused[1] ? "PAUSED" : "START";
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            isStop = true;
            isPaused[0] = true;
            START1.Text = "START";

            if (isStop && isStop2) isRunning = false;

            activateButton();
            showGraph1(true);

            //executeLoop(false);
        }

        private void stop2_Click(object sender, EventArgs e)
        {
            isStop2 = true;
            isPaused[1] = true;
            START2.Text = "START";

            if (isStop && isStop2) isRunning = false;

            activateButton();
            showGraph2(true);
            //executeLoop(false);
        }
        //private void stop3_Click(object sender, EventArgs e)
        //{
        //    isStop3 = true;
        //    isPaused[2] = true;

        //    activeButton();
        //    //showGraph3();
        //}
        private void hiddenButton_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == 1340)
            {
                var wnd = new LoginWindow();
                wnd.ShowDialog();

                if (wnd.DialogResult == DialogResult.OK)
                {
                    hiddenButton.Text = "\u25C0"; // left arrow
                    this.Size = new Size(2274, 936);
                }
                return;
            }

            hiddenButton.Text = "\u25B6"; // right arrow   
            this.Size = new Size(1340, 936);            
        }

        private void voltTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void voltTextBox_Leave(object sender, EventArgs e)
        {
            if (Double.Parse(voltTextBox.Text) < 1.5 || 16 < Double.Parse(voltTextBox.Text))
            {
                MessageBox.Show("주기는 1.5 <= t <= 16.");
                voltTextBox.Text = "1.5";               
                Invalidate();
                return;
            }
        }

        private void autoScaleButton_Click(object sender, EventArgs e)
        {
            int temp = 0;

            if (isStop)
            {
                FormPlot.Plot.SetAxisLimits(xMax: autoRange, xMin: 0, yMin: minLimitY, yMax: maxLimitY);
                FormPlot.Render();
            }
            else
            {
                isAutoOn = true;
                autoTimer.Enabled = true;
            }            
        }

        private void periodTextBox_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(periodTextBox.Text) < 100 || 10000 < Int32.Parse(periodTextBox.Text))
            {
                MessageBox.Show("주기는 100 <= t <= 10000값이어야합니다.");
                periodBoxtemp = "100";
                //period = 1000;
                periodTextBox.Text = periodBoxtemp;
                Invalidate();
                return;
            }
            periodBoxtemp = periodTextBox.Text;
            //edx = Int32.Parse(limitBoxTemp);
            //edx2 = Int32.Parse(limitBoxTemp);
            //edx3 = Int32.Parse(limitBoxTemp);
        }
    }
}
