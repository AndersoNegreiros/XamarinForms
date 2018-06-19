using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
 
		}

        private void BuscarCEP (object sender, EventArgs args)
        {
            //Logica do programa

            string cep = CEP.Text.Trim();

            if (isValedCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if( end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {2} , {3} {0} , {1} ", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + cep, "OK");
                    }

                    
                }
                catch(Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
                    
            }
            else
            {
                // Se n passar. 
            }

            
        }

        private bool isValedCEP(string cep)
        {
            int novoCep = 0;
            bool valido = true;


            // verificando se o CEP contem o oito digitos.
            if(cep.Length != 8)
            {
                // Passando menssagem de alerta por um display de alerta.
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");

                valido = false;
            }

            // verificando se não consegue converter para numeros inteiros.
            if(!int.TryParse(cep, out novoCep))
            {
                // Passando menssagem de alerta por um display de alerta.
                DisplayAlert("ERRO", "CEP inválido, CEP deve ser composto apenas por números.", "OK");

                valido = false;
            }


            return valido;
        }

	}
}
