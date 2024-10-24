using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExemplos
{
    public class Estudante : PessoaAbstrata
    {
        private string _matricula;
        public string Matricula 
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public Estudante(string nome, int idade, string matricula) : base(nome, idade)
        {
            _matricula = matricula;
        }

        public override void ExibirInformacoes()
        {
           // base => Referencia a algo que esta na classe pai
            base.ExibirInformacoes();
            Console.WriteLine($"Matricula: {Matricula}");
        }
    }
}
