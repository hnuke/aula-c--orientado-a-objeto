
namespace construtor{
    public class Produto{
        
        private string nome;
        private int codigo;
        private double valor;

        // construtores
        public Produto(string nome, int codigo, double valor){
            this.nome = nome;
            this.codigo = codigo;
            this.valor = valor;
        }

        public Produto(string nome, int codigo){
            this.nome = nome;
            this.codigo = codigo;
        }
        public Produto(){}

        // propriedades
        public string Nome{

            get{
                return nome;
            }
            set{
                nome = value;
            }
        }

        public int Codigo{
            get{
                return codigo;
            }
            set{
                codigo = value;
            }
        }

        public double Valor{
            get{
                return valor;
            }
            set{
                valor = value;
            }
        }
    }
}