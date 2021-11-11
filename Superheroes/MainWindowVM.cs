using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        //prop propfull
        private Superheroe superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return superheroeActual; }
            set
            {
                superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");
            }
        }

        private int contadorActual;

        public int ContadorActual
        {
            get { return contadorActual; }
            set
            {
                contadorActual = value;
                NotifyPropertyChanged("ContadorActual");
            }
        }

        private int totalHeroes;

        public int TotalHeroes
        {
            get { return totalHeroes; }
            set
            {
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }

        private readonly List<Superheroe> lista = Superheroe.GetSamples();
        public MainWindowVM()
        {
            SuperheroeActual = lista.FirstOrDefault();
            ContadorActual = 1;
            TotalHeroes = lista.Count;
        }

        public void Avanzar()
        {
            if (ContadorActual < TotalHeroes)
            {
                ContadorActual++;
                SuperheroeActual = lista[ContadorActual - 1];
            }

        }
        public void Retroceder()
        {
            if (ContadorActual > 1)
            {
                ContadorActual--;
                SuperheroeActual = lista[ContadorActual - 1];
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
