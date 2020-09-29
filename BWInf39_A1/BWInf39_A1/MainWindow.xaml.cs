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
using System.Windows.Forms;

namespace BWInf39_A1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String EingabeLuecken, EingabeWoerter;
        String[] Luecken, Woerter;
        char[][] CharLuecken, CharWoerter;
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Solution_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                EingabeLuecken = RätselLuecken.Text;
                EingabeWoerter = RätselWoerter.Text;
                
                    if (!RaetselValid())
                    {
                    System.Windows.MessageBox.Show("Bitte ein gültiges Rätsel eingeben!");
                        RätselLuecken.Clear();
                        RätselWoerter.Clear();
                }
                
                BelegeArrays();
            }
            catch
            {

                System.Windows.MessageBox.Show("Bitte ein gültiges Rätsel eingeben!");
                RätselLuecken.Clear();
                RätselWoerter.Clear();
            }
            
            
        }
        bool RaetselValid()
        {
            if(RätselLuecken.Text == "" || RätselWoerter.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void BelegeArrays()
        {
            Luecken = EingabeLuecken.Split();
            Woerter = EingabeWoerter.Split();
            CharLuecken = new char[EingabeLuecken.Split().Length][];
            for (int i=0; i < EingabeLuecken.Split().Length; i++)
            {
                
                CharLuecken[i] = new char[Luecken[i].ToCharArray().Length];
                CharLuecken[i] = Luecken[i].ToCharArray();
            }
            CharWoerter = new char[EingabeWoerter.Split().Length][];
            for (int i = 0; i < EingabeWoerter.Split().Length; i++)
            {

                CharWoerter[i] = new char[Woerter[i].ToCharArray().Length];
                CharWoerter[i] = Woerter[i].ToCharArray();
            }
            void CleanArray()
            {
                for (int i=0; i < EingabeLuecken.Split().Length; i++){
                    for (int n=0; n < Luecken[i].ToCharArray().Length; n++){
                        if (CharLuecken[i][n].Equals(",") || CharLuecken[i][n].Equals("!") || CharLuecken[i][n].Equals(".") || CharLuecken[i][n].Equals("?"))
                        {
                           // CharLuecken[i][n].cut
                        }
                    }
                }
            }
        }
        
        
    }
}
