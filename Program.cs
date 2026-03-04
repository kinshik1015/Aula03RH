using System;
using aula2vscodeterca.models;
namespace aula2vscodeterca
{
    public class Program
    {
        static void Main(string[] args)
        {
            
          Funcionario func = new Funcionario();
          func.id = 10;
        func.nome = "kinshik";
        func.Cpf = "12345678910";
        func.DataAdimissao = DateTime.Parse("01/01;2010");
        func.Salario = 1000.00m;
         func.TipoFuncionario = models.Enuns.TipoFuncionarioEnum.Aprendiz;
         string mensagem = func.ExibirPeriodoExperiencia();
         


        }
    }
}