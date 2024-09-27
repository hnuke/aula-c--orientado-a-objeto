

namespace Heranca{
    public class Program{
        public static void Main(string[] args){

            Produto produto1 = new Produto("Cadeira", 25.44);
            produto1.MostrarAtributos();
            Produto produto2 = new Perecivel("Maça", 100.10, new DateTime(2010,10,21), new DateTime(2009,10,21));
            produto2.MostrarAtributos();
            


        }
    }
}