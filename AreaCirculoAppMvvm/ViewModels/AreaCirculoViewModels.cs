using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaCirculoViewModels:ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void calcular()
        {
            try
            {
                Resultado = Math.PI * Math.Pow(A, 2);
            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            Resultado = 0;
        }
    }
}
