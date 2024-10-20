
using AbstraFunc.entities;

namespace AbstraFunc.entities{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, Endereco endereco, double salario): base(codigo,nome,endereco,salario){
            
        }
    }
}