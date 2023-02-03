using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public float rendimento { get; set; }

        public bool ValidarDataNascimento(DateTime dataNasc){
            
           //tipo nomedavariavel = (esta recebendo) biblioteca.função
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18){
                return true;
            }else {
                return false;
            }

    }

     public override double PagarImposto(float rendimento){
            if(rendimento <= 1500){
                return 0;
            } else if (rendimento > 1500 && rendimento <= 5000){
                return rendimento * .03;
            }else{
                return (rendimento/100) *5;
            }

        }
    }
}

    

    
