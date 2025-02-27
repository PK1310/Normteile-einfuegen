using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Macro101_OpenM16
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Laenge_Click(object sender, RoutedEventArgs e)
        {
            ButtonFarbeZurück();
            string strEingabe;
            int intEingabe;
            bool boolCheckEingabe;
            strEingabe =txtBox_Laenge.Text;
            boolCheckEingabe = CheckEingabe(strEingabe);

            if (boolCheckEingabe == true)
            {
                intEingabe = Convert.ToInt32(strEingabe);
                ButtonFarbe(intEingabe);
            }
            else return;
            
            
        }
        private bool CheckEingabe(string strEingabe)
        {//prüfe ob eine Zahl ohne Komma eingegeben wurde
            int intEingabe;
            try
            {
                intEingabe = Convert.ToInt32(strEingabe);
            }
            catch
            {
                MessageBox.Show("Bitte eine Zahl eingeben (ohne Komma)");
                txtBox_Laenge.Text = "";
                txtBox_Laenge.Focus();
                return false;
            }
            return true;
        }
        private void ButtonFarbeZurück()
        {
            btn_M16x25.Background = Brushes.LightGray;
            btn_M16x30.Background = Brushes.LightGray;
            btn_M16x35.Background = Brushes.LightGray;
            btn_M16x40.Background = Brushes.LightGray;
            btn_M16x45.Background = Brushes.LightGray;
            btn_M16x50.Background = Brushes.LightGray;
            btn_M16x55.Background = Brushes.LightGray;
            btn_M16x60.Background = Brushes.LightGray;
            btn_M16x65.Background = Brushes.LightGray;
            btn_M16x70.Background = Brushes.LightGray;
            btn_M16x80.Background = Brushes.LightGray;
            btn_M16x90.Background = Brushes.LightGray;

        }
        private void ButtonFarbe(int Klemmung)
        {
            if (Klemmung < 5)
            {
                btn_M16x30.Background = Brushes.Yellow;
            }
            if (Klemmung > 4 && Klemmung < 11)
            {
                btn_M16x35.Background = Brushes.Yellow;
            }
            if (Klemmung > 10 && Klemmung < 16)
            {
                btn_M16x40.Background = Brushes.Yellow;
            }
            if (Klemmung > 15 && Klemmung < 21)
            {
                btn_M16x45.Background = Brushes.Yellow;
            }
            if (Klemmung > 20 && Klemmung < 26)
            {
                btn_M16x50.Background = Brushes.Yellow;
            }
            if (Klemmung > 25 && Klemmung < 31)
            {
                btn_M16x55.Background = Brushes.Yellow;
            }
            if (Klemmung > 30 && Klemmung < 36)
            {
                btn_M16x60.Background = Brushes.Yellow;
            }
            if (Klemmung > 35 && Klemmung < 46)
            {
                btn_M16x70.Background = Brushes.Yellow;
            }
            if (Klemmung > 45 && Klemmung < 56)
            {
                btn_M16x80.Background = Brushes.Yellow;
            }
            if (Klemmung > 55 && Klemmung < 66)
            {
                btn_M16x90.Background = Brushes.Yellow;
            }

        }
        private void btn_M16x25_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe=txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 25-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x30_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 30-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x35_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            CheckEingabe(Eingabe);
            Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
            Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 35-C.sldprt";
            SW_Schraube.OpenModel();
            SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            Environment.Exit(0);
        }
        private void btn_M16x40_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 40-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x45_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 45-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x50_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 50-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x55_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 50-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x60_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 60-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x65_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 65-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x70_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 70-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x80_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 80-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
        private void btn_M16x90_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe;
            int Klemmung;
            string Schraubenlaenge;
            Eingabe = txtBox_Laenge.Text;
            if (CheckEingabe(Eingabe) == true)
            {
                Klemmung = Convert.ToInt16(txtBox_Laenge.Text);
                Schraubenlaenge = "C:\\Kuhne Group\\Library\\DIN 933   SechskantschraubeISO 4017\\M16\\ISO 4017 - M16 x 90-C.sldprt";
                SW_Schraube.OpenModel();
                SW_Schraube.changeAndRebuild(Klemmung, Schraubenlaenge);
            }
            else return;

            Environment.Exit(0);

        }
    }
}
