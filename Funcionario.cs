using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExemplos
{
    public class Funcionario : PessoaAbstrata
    {
        private string _cargo;
        private decimal _salario;

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public Funcionario(string nome, int idade, string cargo, decimal salario) : base(nome, idade)
        {
            _cargo = cargo;
            _salario = salario;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cargo: {Cargo}. Salario: {Salario:C}"); //:C => Formatacao de moeda
        }
    }
}
