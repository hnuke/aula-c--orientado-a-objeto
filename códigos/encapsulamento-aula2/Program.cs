using encapsulamento_aula2.Entities;

namespace Program{
    class Program{
        static void Main(string[] args){
            Produto p1 = new Produto();
            p1.Codigo = 10;
            p1.Nome = "Organela";
            p1.Preco = 100.25;

            Console.WriteLine($"\tNome: {p1.Nome} \tPreço: {p1.Preco:c} \tCódigo: {p1.Codigo}\t");
        }
    }
}