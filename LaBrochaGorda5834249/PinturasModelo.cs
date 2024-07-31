using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrochaGorda5834249
{
    public partial class PinturasModelo : ObservableObject
    {
        [ObservableProperty]
        public string? precioMetro;

        [ObservableProperty]
        public string? metrosCuadrados;

        [ObservableProperty]
        public string? pago;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if(double.TryParse(PrecioMetro, out double precio) && double.TryParse(MetrosCuadrados, out double metros))
            {
                Pago = (precio * metros).ToString();
            }
            else
            {
                Pago = "Digite valores numericos";
            }
        }
    }
}
