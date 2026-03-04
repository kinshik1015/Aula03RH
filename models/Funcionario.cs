using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2vscodeterca.models.Enuns;

namespace aula2vscodeterca.models
{}
    public class Funcionario
    {

    public int id { get; set; } 

    public string nome { get; set; } = "";

    public string Cpf { get; set; } = string.Empty;


     public  DateTime DataAdimissao { get; set; }

    public  decimal Salario { get; set; }

    public  TipoFuncionarioEnum TipoFuncionario { get; set; }

    public void ReajustarSalario ()
           {
            
         Salario = Salario + (Salario * 10 / 100);


           }


          public string ExibirPeriodoExperiencia()
           {
          string periodoExperiencia =
          string.Format("Períodos de Experiência: {0} até {1}", DataAdimissao, DataAdimissao.AddMonths(3));
         return periodoExperiencia;
           }

        public decimal CalcularDescontoVT (decimal percentual)
           {
        decimal desconto = this. Salario * percentual/100;
           return desconto;

        }


    }