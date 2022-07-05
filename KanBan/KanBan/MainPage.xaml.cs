using KanBan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KanBan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaCotacao1.ItemsSource = GetOportunidades1();
            ListaCotacao2.ItemsSource = GetOportunidades2();


        }

        public List<Oportunidade> GetOportunidades1()
        {
            return new List<Oportunidade>()
            {
                new Oportunidade(){Id = 1, Cliente = "CLIENTE 1", Situacao = "cotacao"},
                new Oportunidade(){Id = 2, Cliente = "CLIENTE 2", Situacao = "cotacao"},
                new Oportunidade(){Id = 3, Cliente = "CLIENTE 3", Situacao = "cotacao"},
                new Oportunidade(){Id = 4, Cliente = "CLIENTE 4", Situacao = "cotacao"},
            };
        }

        public List<Oportunidade> GetOportunidades2()
        {
            return new List<Oportunidade>()
            {
                new Oportunidade(){Id = 1, Cliente = "CLIENTE 5", Situacao = "cotacao"},
                new Oportunidade(){Id = 2, Cliente = "CLIENTE 6", Situacao = "cotacao"},
                new Oportunidade(){Id = 3, Cliente = "CLIENTE 7", Situacao = "cotacao"},
            };
        }       

        // Adiciona oportunidade na lista 01
        public List<Oportunidade> AddOportunidade1(int Id, string clienteSt, string situacaoSt)
        {
            List<Oportunidade> oportunidades1 = GetOportunidades1();
            
            oportunidades1.Add(new Oportunidade() { Id = 1, Cliente = clienteSt, Situacao = situacaoSt });

            return oportunidades1;

        }

        // Adiciona oportunidade na lista 02
        public List<Oportunidade> AddOportunidade2(int Id, string clienteSt, string situacaoSt)
        {
            List<Oportunidade> oportunidades2 = GetOportunidades2();

            oportunidades2.Add(new Oportunidade() { Id = 1, Cliente = clienteSt, Situacao = situacaoSt });

            return oportunidades2;

        }

        // Remove oportunidade da lista 01
        public List<Oportunidade> RemoveOportunidade1(int Id, string clienteSt, string situacaoSt)
        {
            List<Oportunidade> oportunidades1 = GetOportunidades1();

            oportunidades1.RemoveAll(item => item.Id == Id);

            return oportunidades1;
        }

        // Remove oportunidade da lista 02
        public List<Oportunidade> RemoveOportunidade2(int Id, string clienteSt, string situacaoSt)
        {
            List<Oportunidade> oportunidades2 = GetOportunidades1();

            oportunidades2.RemoveAll(item => item.Id == Id);

            return oportunidades2;
        }

        // Solta oportunidade na lista 01
        private void DropGestureRecognizer_Drop01(object sender, DropEventArgs e)
        {
            ListaCotacao2.ItemsSource = AddOportunidade1(4, "CLIENTE 4", "cotacao");
            ListaCotacao1.ItemsSource = RemoveOportunidade2(4, "CLIENTE 4", "cotacao");
        }

        // Solta oportunidade na lista 02
        private void DropGestureRecognizer_Drop02(object sender, DropEventArgs e)
        {
            ListaCotacao2.ItemsSource = AddOportunidade2(4, "CLIENTE 4", "cotacao");
            ListaCotacao1.ItemsSource = RemoveOportunidade1(4, "CLIENTE 4", "cotacao");
        }

        

        private void DragGestureRecognizer_DragStarting01(object sender, DragStartingEventArgs e)
        {

        }

        
        private void DragGestureRecognizer_DragStarting02(object sender, DragStartingEventArgs e)
        {

        }
    }
}
