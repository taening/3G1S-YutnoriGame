using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace project_yut
{
    static class TComm
    {
        //===================================================
        //  통신에 성공하면 true 리턴
        //  bits = 0x00 ~ 0xFF
        //===================================================
        public static bool SetLEDOutput(SerialPort serialPort, List<info_yut> info)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 송신 데이터를 담을 문자열
            string send_data = "";

            send_data += Util.Hex(info.Count);

            int LEDC = 0; //LED Color

            // 데이터만들기
            for (int i = 0; i < info.Count; i++)
            {
                send_data += ',';

                int num1 = info[i].pos / 0x10;
                int num2 = info[i].pos % 0x10;
                send_data += Util.Hex(num1) + Util.Hex(num2);

                string SColor = info[i].color;
                if (info[i].color == "R")
                {
                    LEDC = 1;
                }
                else if (info[i].color == "B")
                {
                    LEDC = 2;
                }
                else if (info[i].color == "RB")
                {
                    LEDC = 3;
                }
                else if (info[i].color == "G")
                {
                    LEDC = 4;
                }

                send_data += Util.Hex(LEDC);

                int twinkle = info[i].blink;
                send_data += Util.Hex(twinkle);
            }

            // 명령송신
            string st = SPort.sSTX() + "LO" + send_data + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "LO")
                    {
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }

        public static bool AskSWInput(SerialPort serialPort, out bool select, out bool done)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            select = false;
            done = false;

            // 명령송신
            string st = SPort.sSTX() + "SI" + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";

            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5)
                {
                    return false;
                }

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 5)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "SI")
                    {
                        if (rbuff.Substring(idx1 + 3, 2) == "10")
                        {
                            select = true;
                            done = false;
                        }

                        else if (rbuff.Substring(idx1 + 3, 2) == "01")
                        {
                            select = false;
                            done = true;
                        }

                        else if (rbuff.Substring(idx1 + 3, 2) == "00")
                        {
                            select = false;
                            done = false;
                        }

                        else if (rbuff.Substring(idx1 + 3, 2) == "11")
                        {
                            select = false;
                            done = false;
                        }

                        else return false;

                        success = true;
                        return success;
                    }
                }
            }
        }

        //public static bool AskSWDone(SerialPort serialPort, out int adval)
        //{
        //    adval = 0;

        //    // 수신버퍼청소
        //    string dum = SPort.Read(serialPort);

        //    // 명령송신
        //    string st = SPort.sSTX() + "SD" + SPort.sETX();
        //    SPort.Send(serialPort, st);

        //    // 송신시간기록
        //    DateTime stime = DateTime.Now;

        //    // 수신대기
        //    int idx1, idx2;
        //    bool success = false;
        //    string rbuff = "";
        //    while (true)
        //    {
        //        // timeout 검사
        //        double dtime = Util.TimeInSeconds(stime);
        //        if (dtime > 0.5) return false;

        //        // 수신버퍼검사
        //        rbuff += SPort.Read(serialPort);

        //        idx1 = rbuff.IndexOf(SPort.sACK());
        //        idx2 = rbuff.IndexOf(SPort.sETX());

        //        if (idx1 >= 0 && idx2 - idx1 == 2)
        //        {
        //            if (rbuff.Substring(idx1 + 1, 2) == "SD")
        //            {
        //                success = true;
        //                break;
        //            }
        //        }
        //    }
        //    return success;

        //}
    }
}