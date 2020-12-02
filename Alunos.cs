using System;

namespace AtividadeAlunos
{
    public class Alunos
    {
        public string name;
        public string course;
        public int age;
        public string RG;
        public bool bolsa;
        public float mediaFinal;
        public double valorMensalidade;

        public void VerMediaFinal(float media) {
        Console.WriteLine($"A média final é de {media}");
        }

        public void VerMensalidade (bool bolsa, double valor) {
            if (bolsa) {
                Console.WriteLine("Bolsa de 20%");
                valor = valor*0.8;
            }
                Console.WriteLine("Mensalidade de "+valor+" ");
        }
    }
}