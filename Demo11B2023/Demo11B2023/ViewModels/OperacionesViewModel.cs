using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11B2023.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {

        int b;
        public int Base
        {
            get { return b; }
            set
            {
                if (b != value)
                {
                    b = value;
                    OnPropertyChanged();
                }
            }
        }



        int h;
        public int Altura
        {
            get { return h; }
            set
            {
                if (h != value)
                {
                    h = value;
                    OnPropertyChanged();
                }
            }
        }


        int area;
        public int Area
        {
            get { return area; }
            set
            {
                if (area != value)
                {
                    area = value;
                    OnPropertyChanged();
                }
            }
        }

        int perimetro;
        public int Perimetro
        {
            get { return perimetro; }
            set
            {
                if (perimetro != value)
                {
                    perimetro = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand CalcularArea { get; set; }
        public ICommand CalcularPerimetro { get; set; }


        public OperacionesViewModel()
        {
            CalcularArea = new Command(() =>
            {
                Area = b * h;
            });

            CalcularPerimetro = new Command(() =>
            {
                Perimetro = (b+h)*2;
            });
        }

    }
}
