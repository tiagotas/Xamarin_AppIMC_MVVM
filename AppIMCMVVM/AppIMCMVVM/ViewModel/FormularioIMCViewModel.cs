using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIMCMVVM.ViewModel
{
    public class FormularioIMCViewModel : INotifyPropertyChanged
    {
        private double peso, altura;
        private string resultado;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Resultado
        {
            get { return resultado; }
            set
            {
                resultado = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Resultado"));
            }                
        }

        public ICommand CalcularIMCCommand
        {
            get
            {
                return new Command(() =>
                {       
                    Resultado = Model.Imc.CalcularImc(peso, altura);
                    //Console.WriteLine("Resultado = " + Resultado);
                });
            }
        }        
    }
}
