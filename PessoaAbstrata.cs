using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExemplos
{


    public abstract class PessoaAbstrata : IExibivel
    {
      
    //Propriedade privada
    private string _nome;
    private int _idade;

    //Propriedades publicas

    public string Nome
        {
            get { return _nome.ToUpper(); }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        //Construtor 
        public PessoaAbstrata (string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

         
        //Permite que possa ser reenscrito
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");
        }
    }
}
