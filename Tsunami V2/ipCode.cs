using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using JRPC_Client;

namespace Tsunami_V2
{
    class IPCode
    {
        public static void FetchMW3()
        { 
            for (int n = 0; n < 18; n++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc3970de4 + 0x108) + ((uint)(0x158 * n)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc3970de4 + 0x1c0) + ((uint)(0x158 * n)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3970de4 + 0x1c4) + ((uint)(0x158 * n)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3970de4 + 0x204) + ((uint)(0x158 * n)), 8)).Replace("-", "");

                if (xuid != "0000000000000000") //I believe this prevents empty player slots from showing up in the listView
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchMW2()
        {
            for (int m = 0; m < 18; m++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc375ee70 + 0x52) + ((uint)(0xc0 * m)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc375ee70 + 0x94) + ((uint)(0xc0 * m)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc375ee70 + 0x98) + ((uint)(0xc0 * m)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc375ee70 + 0x100) + ((uint)(0xc0 * m)), 8)).Replace("-", "");
               
                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchMW()
        {
            for (int k = 0; k < 18; k++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc4fad6f0 + 0x18) + ((uint)(0xb8 * k)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc4fad6f0 + 0x68) + ((uint)(0xb8 * k)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc4fad6f0 + 0x6c) + ((uint)(0xb8 * k)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc4fad6f0 + 0x10) + ((uint)(0xb8 * k)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchBO3()
        {
            for (int num10 = 0; num10 < 0x12; num10++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0x700511b6 + 0x9b) + ((uint)(0x100 * num10)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory(((0x700511b6 + 0x177) + ((uint)(0x100 * num10))), 4).Reverse<byte>().ToArray<byte>()).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0x700511b6 + 0x92) + ((uint)(0x100 * num10)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = "N/A", XUID = xuid });
                }
            }
        }

        public static void FetchBO2()
        {
            for (int num9 = 0; num9 < 18; num9++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc403c368 + 0x40) + ((uint)(0x148 * num9)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc403c368 + 180) + ((uint)(0x148 * num9)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc403c368 + 0xb7) + ((uint)(0x148 * num9)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc403c368 + 0x38) + ((uint)(0x148 * num9)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchBO()
        {
            for (int num8 = 0; num8 < 18; num8++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc3ea83f0 + 0x68) + ((uint)(0x200 * num8)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc3ea83f0 + 0xc0) + ((uint)(0x200 * num8)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3ea83f0 + 0xc4) + ((uint)(0x200 * num8)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3ea83f0 + 0x60) + ((uint)(0x200 * num8)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchGhosts()
        {
            for (int j = 0; j < 15; j++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc3aad4d7 + 0x15d) + ((uint)(0x1c0 * j)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc3aad4d7 + 0x245) + ((uint)(0x1c0 * j)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3aad4d7 + 0x249) + ((uint)(0x1c0 * j)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc3aad4d7 + 0x291) + ((uint)(0x1c0 * j)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchAW()
        {
            for (int i = 0; i < 18; i++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc43ee492 + 430) + ((uint)(0x350 * i)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc43ee492 + 0x44a) + ((uint)(0x350 * i)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc43ee492 + 0x44e) + ((uint)(0x350 * i)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc43ee492 + 0x496) + ((uint)(0x350 * i)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchWAW()
        {
            for (int num12 = 0; num12 < 18; num12++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc58f6d50 + 0x20) + ((uint)(200 * num12)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc58f6d50 + 0x70) + ((uint)(200 * num12)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc58f6d50 + 0x74) + ((uint)(200 * num12)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc58f6d50 + 0x18) + ((uint)(200 * num12)), 8)).Replace("-", "");

                if (xuid != "0000000000000000")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }

        public static void FetchH3()
        {
            for (int i = 0; i < 16; i++)
            {
                string gamerTag = Encoding.Unicode.GetString(TsunamiForm.xbox.GetMemory((0xc22a8c70 + 0x141) + ((uint)(280 * i)), 0x20)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc22a8c70 + 0xf4) + ((uint)(280 * i)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc22a8c70 + 0xf8) + ((uint)(280 * i)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                if (gamerTag != "")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = "N/A" });
                }
            }
        }

        public static void FetchHR()
        {
            for (int i = 0; i < 16; i++)
            {
                string gamerTag = Encoding.Unicode.GetString(TsunamiForm.xbox.GetMemory((0xc2290480 + 0x17d) + ((uint)(0x178 * i)), 0x20)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc2290480 + 0x10c) + ((uint)(0x178 * i)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc2290480 + 0x110) + ((uint)(0x178 * i)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();

                if (gamerTag != "")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = "N/A" });
                }
            }
        }

        public static void FetchGTAV()
        {
            for (int num = 0; num < 32; num++)
            {
                string gamerTag = Encoding.ASCII.GetString(TsunamiForm.xbox.GetMemory((0xc89a2adb + 0x61) + ((uint)(120 * num)), 15)).TrimEnd(new char[1]);
                string ipAddress = new IPAddress(TsunamiForm.xbox.GetMemory((0xc89a2adb + 0x19) + ((uint)(120 * num)), 4)).ToString();
                string port = int.Parse(BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc89a2adb + 0x1d) + ((uint)(120 * num)), 2)).Replace("-", ""), NumberStyles.HexNumber).ToString();
                string xuid = BitConverter.ToString(TsunamiForm.xbox.GetMemory((0xc89a2adb + 0x4d) + ((uint)(120 * num)), 8)).Replace("-", "");

                if (gamerTag != "")
                {
                    TsunamiForm.userList.Add(new User { Gamertag = gamerTag, IPAddress = ipAddress, Port = port, XUID = xuid });
                }
            }
        }
    }
}
