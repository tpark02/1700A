using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Serial_Communication
{
    public static class Command
    {
        public static string cmd1 = "*IDN?";                             //TESCOM,TC-1700A,<serial number>,0.01_230403	회사명, 모델명, 시리얼번호, F/W버전
        public static string cmd2 = "*RST";                              //OK	소프트웨어 리셋을 수행한다.
        public static string cmd3 = "*TST";                              //OK	셀프테스트를 진행한다 -결과 화면에 표시
        public static string cmd4 = "REBOOT";                            //OK	제품을 재부팅 시킨다
        public static string cmd5 = "CM#:MEAS ";                          //OK	전류메터 측정 ON/OFF
        public static string cmd6 = "CM#:MEAS?";                         //ON/OFF	전류메터 측정 ON/OFF 읽기		
        public static string cmd7 = "CM#:MEAS:CURR?";                    //0.0000(mA)	전류메터 전류 측정"
        public static string cmd8 = "PS#:EXEC ";                          //OK	전압 출력 ON/OFF
        public static string cmd9 = "PS#:EXEC?";                         //ON/OFF	전압 출력 ON/OFF 읽기
        public static string cmd10 = "PS#:VOLT";                         //OK	출력 전압 설정
        public static string cmd11 = "PS#:VOLT? ";                      //1.5~16	출력 전압 설정 읽기
        public static string cmd12 = "PS#:MEAS:VOLT?";                 //0.00000(V)	출력 전압 측정
        public static string cmd13 = "PS#:MEAS:CURR?";                 //0.0000(mA)	출력 전류 측정
        public static string cmd14 = "PS#:MEAS:WATT?";                 //0.0000(mW)	출력 전력 측정
        public static string cmd15 = "SYS:REM";                           //OK	리모트 컨트롤 모드로 전면 패널 조작 안됨
        public static string cmd16 = "SYS:LOC";                           //OK	전면 조작 패널 동작 가능 모드
        public static string cmd17 = "SYS:BRIG";						//OK	0~100 LCD 밝기 조정

        public static string cmd18 = "*CMD?";
        public static string cmd19 = "*INFO?";
        public static string cmd20 = "SYS:REM:UI #";
        public static string cmd21 = "SYS:ALC #";
        public static string cmd22 = "SYS:ALC:KP #";
        public static string cmd23 = "SYS:ALC:DIFF #";
        public static string cmd24 = "SYS:AVG #";
        public static string cmd25 = "SYS:MEAS:TICK";
        public static string cmd26 = "SYS:AUTO #";
        public static string cmd27 = "SYS:SET:TR #";
        public static string cmd28 = "SYS:EE:INIT";
        public static string cmd29 = "SYS:SELFTEST";
        public static string cmd30 = "SYS:SERIAL #";
        public static string cmd31 = "SYS:SERIAL?";
        public static string cmd32 = "CONF:D1:CAL:CH@ #";
        public static string cmd33 = "READ:RAW:D1D2";
        public static string cmd34 = "CONF:RAW:D1 #";
        public static string cmd35 = "CONF:RAW:D2 #";
        public static string cmd36 = "CONF:RAW:D1W #";
        public static string cmd37 = "CONF:RAW:D2W #";
        public static string cmd38 = "CONF:RAW:D1RES #";
        public static string cmd39 = "CONF:RAW:D2RES #";
        public static string cmd40 = "READ:RAW:INA228 #";
        public static string cmd41 = "CONF:INIT:INA228";
        public static string cmd42 = "CONF:RAW:AVG:CH@ #";
        public static string cmd43 = "CONF:RAW:VBUS:CH@ #";
        public static string cmd44 = "CONF:RAW:VSHT:CH@ #";
        public static string cmd45 = "READ:VOLT:CH@";
        public static string cmd46 = "CONF:VOLT:CH@ #";
        public static string cmd47 = "CONF:OCP:CH@ #";
        public static string cmd48 = "READ:CURR:CAL";
        public static string cmd49 = "CONF:CURR:CAL:CH@ #";
        public static string cmd50 = "CONF:CAL:RELAY:CH@ #";
        public static string cmd51 = "CONF:VOLT:CAL";

    }
}

public static class RichTextBoxExtensions
{
    private static List<string> _logList = new List<string>();
    private static List<string> _logList2 = new List<string>();
    private static List<string> _logList3 = new List<string>();

    //public static DateTime EndDate = DateTime.Today.AddDays(1).AddSeconds(-1); // 실전 24시간용
    public static DateTime endDate = DateTime.Now.AddMinutes(15);
    public static string projectPath = Directory.GetCurrentDirectory();
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    public static void addLog(string str, string portName, string type)
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dd MMMM yyyy HH: mm:ss");

        if (type == "PS1")
        {
            _logList.Add("[" + formattedDateTime + "][" + portName + "]" + str);
        }
        else if (type == "PS2")
        {
            //_logList2.Add("[" + formattedDateTime + "][" + portName + "]" + str);
        }
        else
        {
            //_logList3.Add("[" + formattedDateTime + "][" + portName + "]" + str);
        }
        Console.WriteLine(type + " : [" + formattedDateTime + "][" + portName + "]" + str);
    }
    public static void writeLog24(string type)
    {
        //if (DateTime.Now > endDate)
        {
            string logFilePath = Path.Combine(projectPath, "Logs");
            string fileNameDateTime = DateTime.Now.ToString("[yyyy-dd-MM HH_mm_ss]");
            string fileType = string.Empty;

            if (type == "PS1")
                fileType = "_LOG_PS1.txt";
            else if (type == "PS2")
                fileType = "_LOG_PS2.txt";
            else
                fileType = "_LOG.txt";

            string fileName = fileNameDateTime + fileType;
            string path = Path.Combine(logFilePath, fileName);
            string text = string.Empty;

            if (type == "PS1")
                 text = String.Join("", _logList.Select(p => p));
            else if (type == "PS2")
                text = String.Join("", _logList2.Select(p => p));
            else
                text = String.Join("", _logList3.Select(p => p));

            File.WriteAllText(path, text);
            //EndDate = DateTime.Today.AddDays(1).AddSeconds(-1); // // 실전 24시간용
            endDate = DateTime.Now.AddMinutes(15);
        }
    }
}

