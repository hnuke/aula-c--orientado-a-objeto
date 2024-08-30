using encapsulamento_aula1.Entities;


namespace encapsulamento_aula1{
    class Program {
        static void Main(string[] args){
            Conta c1 = new Conta();

            // modelo Java ou PHP
            //c1.setNumero(10);
            //System.Console.WriteLine(c1.getNumero());


            // com a nova convenção é dessa forma
            c1.Numero = 1;
            Console.WriteLine(c1.Numero);
        }
    }
}