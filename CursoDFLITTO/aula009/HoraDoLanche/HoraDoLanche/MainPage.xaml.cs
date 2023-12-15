using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HoraDoLanche
{
    public partial class MainPage : ContentPage
    {
        private bool pc = false, mobile = false;
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                //Esta verificando e a plataforma do dispositivo que esta rodando é igaul á do android
                mobile = true;
                Imagem.Source = "Forma0";
            }
            else
            {
                pc = true;
                Imagem.Source = "imgs/Forma0.png";
            }
            
        }
        public void Troca(Object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Transforme-se")
            {
                if (pc == true) 
                    Imagem.Source = "imgs/Forma1.png";
                else
                    Imagem.Source = "Forma1";
                bt.Text = "Destransforme-se";
            }
            else
            {
                if (pc == true)
                    Imagem.Source = "imgs/Forma0.png";
                else
                    Imagem.Source = "Forma0";
                //no mobile ele procura a imagem sem a necessidade do caminho dela
                bt.Text = "Transforme-se";
            }
        }
    }
}
