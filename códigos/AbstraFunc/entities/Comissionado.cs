

namespace AbstraFunc.entities{
    public class Comissionado : Funcionario{
        public double Porcentagem {get;set;}

        public Comissionado(int codigo, string nome, Endereco endereco, double salario, double porcentagem): base(codigo, nome, endereco, salario){
            Porcentagem = porcentagem;
        }

        public override double CalcularSalario(int diasUteis){
            return (Salario / 30 * diasUteis) * Porcentagem + Salario;
        }

    }
}