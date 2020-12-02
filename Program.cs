using System;

namespace AtividadeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {// obs: por fins didaticos, o codigo e feito como se o usuario digitasse tudo corretamente de primeira
            Alunos aluno1 = new Alunos();

            Console.WriteLine("Digite o nome do aluno");
            aluno1.name = Console.ReadLine();
            Console.WriteLine("Digite o nome do curso");
            aluno1.course = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno");
            aluno1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero do RG do aluno");
            aluno1.RG = Console.ReadLine();
            Console.WriteLine("O aluno é bolsista?");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S") {
                aluno1.bolsa = true;
            } else if (resposta == "F") {
                aluno1.bolsa = false;
            }
            Console.WriteLine("Digite a media do aluno");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da mensalidade do aluno");
            aluno1.valorMensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno1.name);
            Console.WriteLine(aluno1.course);
            Console.WriteLine(aluno1.age);
            Console.WriteLine(aluno1.RG);
            Console.WriteLine(aluno1.bolsa);

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsa, aluno1.valorMensalidade);
        }
    }
}
