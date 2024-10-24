using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExemplos
{
    public class Professor : PessoaAbstrata
    {
        private string _disciplina;
        public string Disciplina
        {
            get { return _disciplina; }
            set { _disciplina = value; }
        }

        public Professor(string nome, int idade, string disciplina) : base(nome, idade)
        {
            _disciplina = disciplina;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }
}

