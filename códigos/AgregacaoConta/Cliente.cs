
namespace AgregacaoConta{
    public class Cliente{
        public string Nome {get;set;}
        public int Idade { get; set; }
        public int Telefone { get; set; }

        public Cliente(){}
        
        public Cliente(string nome, int idade, int telefone){
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }
        
    }
}