
using OrientacaoObjetosExemplos;

//Instanciando objetos das classes derivadas com construtores
Estudante estudante1 = new Estudante("Carlos", 20, "123456");
Professor professor1 = new Professor("Diana", 30, "Ciencia da Computação");
Funcionario funcionario1 = new Funcionario("João", 28, "Analista de Sistemas", 5000);



List<IExibivel> objetosExibiveis = new List<IExibivel>();
objetosExibiveis.Add(estudante1);
objetosExibiveis.Add(professor1);
objetosExibiveis.Add(funcionario1);

/*IExibivel[] objetosExibiveis = new IExibivel[]
 {
  estudante1,
  professor1,
  funcionario1
};*/

 foreach( var objeto in objetosExibiveis)
{
    objeto.ExibirInformacoes();
    Console.WriteLine();
}

//Exibir Informacoes
Console.WriteLine("Estudante:");
estudante1.ExibirInformacoes();

Console.WriteLine("\nProfessor:");
professor1.ExibirInformacoes();

Console.WriteLine("\nFuncionário:");
funcionario1.ExibirInformacoes();







