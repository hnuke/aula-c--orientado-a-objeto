

namespace AbstraFunc.entities{
    public class Dependente{
        public int Codigo {get;set;}
        public string? Nome {get;set;}
        public int Idade {get;set;}

        public Dependente(int c, string n, int i){
            Codigo = c;
            Nome = n;
            Idade = i;
        }

        public bool VerificarMaiorIdade(){
            return this.Idade >= 18;
        }
    }
}