using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;



using System.Drawing.Printing;
using System.Runtime.InteropServices;
using deuBarkod.EczaneIlacWS;

namespace deuBarkod
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string sekme, string anahtar, string def, StringBuilder retVal, int size, string inidosya); //ini dosyasından okuma apisi

        public string iniOku(String sekme, String anahtar, String iniDosya)
        {
            StringBuilder anahtarDeger = new StringBuilder(255);
            GetPrivateProfileString(sekme, anahtar, "", anahtarDeger, 255, iniDosya);
            return anahtarDeger.ToString();
        }

        public String dosyaOku(String filePath)
        {
            String barkodData="";

            barkodData = System.IO.File.ReadAllText(@filePath);


            return barkodData;
        }


        private String replaceTurString(String turString)
        {
            String x = "";

            x = turString.Replace("İ", "I");
            x = x.Replace("Ş", "S");
            x = x.Replace("Ü", "U");
            x = x.Replace("Ğ", "G");
//            x = x.Replace("Ç", "C");

            return x;
        }

        private String GetBarkodData(string param1, string param2)
        {
            String etiketGenislik;
            String etiketYukseklik;
            try
            {
                 etiketGenislik = iniOku("AYAR", "etiketGenislik", ".\\config.ini");
                 etiketYukseklik = iniOku("AYAR", "etiketYukseklik", ".\\config.ini");
            }
            catch (Exception ex)
            {                
                etiketGenislik = "q400";
                etiketYukseklik = "Q204,23";            
            }

            String solBosluk = "90";
            String barkod = Environment.NewLine + "N" + Environment.NewLine +
                etiketGenislik + Environment.NewLine +
                etiketYukseklik + Environment.NewLine +
                /*
//               "B0" + solBosluk + ",10,0,3,2,5,50,N,\"" + tbBarkod.Text + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",40,0,4,1,2,N,\"" + param1 + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",100,0,4,1,2,N,\"" + param2 + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",150,0,4,1,2,N,\"" + tbTarih.Text + "\"" + Environment.NewLine +
            /*  "A0" + solBosluk + ",150,0,2,1,1,N,\"" + "ILAC ADI, DOZU, FORMU:" + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",180,0,3,1,1,N,\"" + replaceTurString(tb1.Text) + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",230,0,2,1,1,N,\"" + "SON KULLANMA TARIHI:" + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",260,0,3,1,1,N,\"" + replaceTurString(tbTarih.Text) + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",350,0,3,1,1,N,\"" + "KULLANILAN ILAC/BESINLERE" + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",380,0,3,1,1,N,\"" + "ETKILESIMI RxMediaPharma'DAN" + "\"" + Environment.NewLine +
               "A0" + solBosluk + ",410,0,3,1,1,N,\"" + "KONTROL EDILMELIDIR." + "\"" + Environment.NewLine +        */       
              "P1" + Environment.NewLine;

            return barkod;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
           // tbTarih.Text = DateTime.Now.ToShortDateString();
            tbYaziciAdi.Text = iniOku("AYAR", "tbYaziciAdi", ".\\config.ini");
            String[] arguments = Environment.GetCommandLineArgs();

           // tbYazilacak.Text = "GetCommandLineArgs: " + String.Join(", ", arguments);
            try
            {
                int baskiAdet = 1;

               
                try
                {
                    baskiAdet = Convert.ToInt32(arguments[1].ToString());
                }
                catch { }

                tbYazilacakDosya.Text = arguments[2].ToString();

                String barkodData=dosyaOku(tbYazilacakDosya.Text);
                yazdirCmdLine(baskiAdet, barkodData);

                if (arguments[2] != null)
                {
                    Application.Exit();
                }
              

            }
            catch { }

        }


        private void yazdirCmdLine(int baskiAdet=1, String barkodData="")
        {

            tbYazilacak.Clear();

            try
            {
             
                for (int i = 0; i < baskiAdet; i++)
                {
                    tbYazilacak.AppendText(barkodData);
                }

                RawPrinterHelper.SendStringToPrinter(tbYaziciAdi.Text, tbYazilacak.Text);

            }
            catch
            {

            }
        }


        private void yazdir(string param1, string param2)
        {
           
            tbYazilacak.Clear();

            try
            {
                int baskiAdet = 1;
                try
                {
                    baskiAdet = Convert.ToInt32(tbAdet.Text);
                }
                catch (Exception ex)
                {
                    baskiAdet = 1;
                }

                for (int i = 0; i < baskiAdet; i++)
                {
                    tbYazilacak.AppendText(GetBarkodData(param1, param2));
                }

                RawPrinterHelper.SendStringToPrinter(tbYaziciAdi.Text, tbYazilacak.Text);

            }
            catch
            {

            }        
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            yazdir("SF AMP.","");
        }

     

 

 
 
    }



 public class RawPrinterHelper
    {


        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint="OpenPrinterA", SetLastError=true, CharSet=CharSet.Ansi, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint="ClosePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint="StartDocPrinterA", SetLastError=true, CharSet=CharSet.Ansi, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool StartDocPrinter( IntPtr hPrinter, Int32 level,  [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint="EndDocPrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint="StartPagePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint="EndPagePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint="WritePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten );

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter( string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32    dwError = 0, dwWritten = 0;
            IntPtr    hPrinter = new IntPtr(0);
            DOCINFOA    di = new DOCINFOA();
            bool    bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if( OpenPrinter( szPrinterName.Normalize(), out hPrinter, IntPtr.Zero ) )
            {
                // Start a document.
                if( StartDocPrinter(hPrinter, 1, di) )
                {
                    // Start a page.
                    if( StartPagePrinter(hPrinter) )
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if( bSuccess == false )
            {
                    dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter( string szPrinterName, string szFileName )
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte []bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes( nLength );
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter( string szPrinterName, string szString )
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
