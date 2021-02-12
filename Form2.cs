using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PsPen
{
    public partial class Form2 : Form
    {
        public static String usbid = ""; //variavel que receberá o nome de volume do pendrive
        public static String caminhoArquivo = "";//variavel que receberá o caminho do arquivo
        public static String result = "";
        public static String caminhoEncontrado = "";
        public static bool chamaSistema = false;
        public static bool verificarMalware = false;
        const int WM_DEVICEARRIVAL = 0X8000;
        const int WM_DEVICECHANGE = 0X219;



        void DetectUsbdive()
        {
            try
            {
                Thread thread = new Thread(() =>
               {
                   
                    ManagementScope scope = null;
                    ConnectionOptions option = new ConnectionOptions();
                    //option.Impersonation = System.Management.ImpersonationLevel.Impersonate;

                    scope = new ManagementScope("\\\\DESKTOP-H50H97J\\root\\cimv2");//tentando conectar ao windows management
                    scope.Connect();


                    ObjectQuery query = new ObjectQuery("SELECT * from Win32_USBHub");


                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                    ManagementObjectCollection queryCollection = searcher.Get();

                    foreach (ManagementObject drive in queryCollection)
                    {
                        if (drive["Description"].ToString().Contains("Mass Storage Device")) //esse método serve para saber se o dispositivo conectado é um pendrive
                        {
                            result = informacaoDrive();
                            VerifyusbName();


                        }


                    }

                  
                });
                thread.Start();
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }
        protected String informacaoDrive()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            String caminho = "";

            foreach (DriveInfo d in driveInfo) {
                String a = @"D:\";
                String b = @"E:\";
                String c = @"F:\"; 
                if ((d.Name.Equals(a))|| (d.Name.Equals(b)) || (d.Name.Equals(c))){

                    caminho = d.Name;
                    Console.WriteLine(d.Name);

                }

            }
            return caminho;

        }


        void VerifyusbName()
        {



            String[] arquivo;
            arquivo = Directory.GetFiles(result, "*.*", SearchOption.AllDirectories).ToArray();//caminho do pendrive

            String[] hash;
            hash = System.IO.File.ReadAllLines("C:\\PsPen\\database\\hashDatabase.txt").ToArray();//caminho da base de hashes

            foreach (String item in arquivo)
            {//para cada arquivo encontrado sera feita a checagem

                String assinatura = GetMD5FromFile(item);
                Console.WriteLine(assinatura);
                foreach (String line in hash)
                {

                    if (assinatura == line)
                    {

                        Form2.caminhoArquivo = assinatura;
                        Form2.chamaSistema = true;
                        Form2.caminhoArquivo = item;
                        Form2.verificarMalware = true;
                        this.BeginInvoke((Action)delegate(){
                            verificar();    
                        });
                        //DelegateMethodVerificar obj = new DelegateMethodVerificar(verificar) ;
                        //obj.Invoke();
                    }

                }
            }




        }
      //  public delegate void DelegateMethodVerificar();




       public void verificar()
        {
            if (verificarMalware)
            {
                lblTitulo.Text = "Arquivo malicioso encontrado";
                lblNomeArquivo.Text = caminhoArquivo;

            }

        }


        public Form2()
        {
             
            InitializeComponent();
        }
       
        protected override void WndProc(ref Message m)
        {
            //const int WM_DEVICEARRIVAL = 0X8000;
            //const int WM_DEVICECHANGE = 0X219;
            //lblTitulo.Text = "aaa";

            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {

                        case WM_DEVICEARRIVAL:
                            DetectUsbdive();
                            Form2.usbid = result;
                            
                            

                            break;
                    }

                    break;

            }


        }

        private void pcbIgnorar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja ignorar esse arquivo? ", "Ignorar arquivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            lblTitulo.Text = "Arquivo malicioso não encontrado";
            lblNomeArquivo.Text = "...";
            if (resultado == DialogResult.No)
                MessageBox.Show("Sugiro que exclua esse arquivo! ");
        }

        private void pcbExcluir_Click(object sender, EventArgs e)
        {
            File.Delete(caminhoArquivo);
            MessageBox.Show("Arquivo excluido com sucesso! ");
            lblTitulo.Text = "Arquivo malicioso não encontrado";
            lblNomeArquivo.Text = "...";
        }

        public string GetMD5FromFile(string filenPath) {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }

        }

        private void pcbAtualizarBilioteca_Click(object sender, EventArgs e)
        {
            string md5="";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Textfiles | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                md5 = GetMD5FromFile(ofd.FileName);
            }
            StreamWriter sw = new StreamWriter("C:\\PsPen\\database\\hashDatabase.txt", true);
            sw.WriteLine(md5);
            
            sw.Close();
            MessageBox.Show("Atualizado com sucesso! ");
        }
    }
    }
    

  
    

