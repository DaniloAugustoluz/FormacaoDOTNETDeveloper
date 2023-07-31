using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }

        public void ApresetarPessoa(){
            System.Console.WriteLine($"Nome do usuário: {Nome} \nIdade do usuário: {Idade}");
        }
    }
}