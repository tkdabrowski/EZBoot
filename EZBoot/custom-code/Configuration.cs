using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EZBoot
{
    class Configuration
    {
        string MACAddress { get; set; }
        string IPAddress { get; set; }
        int Port { get; set; }
        string path = Android.OS.Environment.ExternalStorageDirectory + Java.IO.File.Separator;


        public Configuration(string configMACAddress, string configIPAddress, int configPort)
        {
            MACAddress = configMACAddress;
            IPAddress = configIPAddress;
            Port = configPort;
        }


        public void SaveDetailsToFile()
        {
            //Saves mac address, ip address and port to an external file. If a configuration already exists, to overwrite, delete file and create new one (Not optimal)
            string file = "info.ezb";
            string filename = Path.Combine(path, file);
            if (File.Exists(file))
            {
                File.Delete(file);
                SaveDetailsToFile();
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(filename, true))
                {
                    streamWriter.WriteLine(MACAddress);
                    streamWriter.WriteLine(IPAddress);
                    streamWriter.WriteLine(Port);
                    streamWriter.Close();
                }
            }

        }

        public string[] GetDetailsFromFile()
        {
            string[] config = new string[3];
            using (StreamReader streamReader = new StreamReader(path, true))
            {
                int counter = 0;

                while (counter < 3)
                    {

                    if (streamReader.ReadLine() != null)
                    {
                        config[counter] = streamReader.ReadLine();
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
                }
            return config;
        }
                
        }
    }
