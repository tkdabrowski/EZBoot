using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Sockets.Plugin;
using System.IO;

namespace EZBoot
{
    class WakeOnLAN
    {

        public WakeOnLAN()
        {
        }

        //TODO: Create function that validates mac address
        /*public string WakeOnLan()
            {
                    MACAddress = Regex.Replace(MACAddress, @"[^0-9A-Fa-f]", ""); 

                    if (MACAddress.Length != 12)
                    {
                         return "Invalid MAC address. Try again!";
                    }
                    else
                    {
                        return Wakeup(MACAddress); 
                    }
                } */


        public string Wakeup(string macAddress)
        {
            try
            {
                var address;
                var port;

                var client = new UdpSocketClient();

                int byteCount = 0;
                byte[] bytes = new byte[1024];
                for (int trailer = 0; trailer < 6; trailer++)
                {
                    bytes[byteCount++] = 0xFF;
                }
                for (int macPackets = 0; macPackets < 16; macPackets++)
                {
                    int i = 0;
                    for (int macBytes = 0; macBytes < 6; macBytes++)
                    {
                        bytes[byteCount++] =
                        byte.Parse(macAddress.Substring(i, 2),
                        NumberStyles.HexNumber);
                        i += 2;
                    }
                }

                client.SendToAsync(bytes, address, port);
                return "Wakeup attempt made, check your machine";

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}

