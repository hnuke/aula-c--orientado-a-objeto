

namespace AbstraFunc.entities{
    public class Departamento{
        public int Codigo {get;set;}
        public string? Descricao {get;set;}
        public List<Funcionario> funcionarios {get;set;} = new List<Funcionario>();

        public Departamento(int codigo, string descricao){
            Codigo = codigo;
            Descricao = Descricao;
        }


        //methods
        public double CalcularFolhaPagamento(int diasUteis){
            double total = 0;
            foreach(Funcionario func in funcionarios){
                total+=func.CalcularSalario(diasUteis);
            }
            return total;
        }

        public void AdmitirFuncionario(Funcionario funcionario){
            funcionarios.Add(funcionario);
        }
        public void DemitirFuncionario(int codigo){
            // usando LINQ
            funcionarios.Remove(funcionarios.Single(f => f.Codigo == codigo));
        }

        public void ListarNomeFuncionarioESalarioFixo(){
            foreach(Funcionario func in funcionarios){
                Console.WriteLine($"{func.Nome}\n{func.Salario:c}");
            }
        }
        public void ListarNomeFuncionarioESalario(int diasUteis){
            foreach(Funcionario func in funcionarios){
                Console.WriteLine($"{func.Nome}\n{func.CalcularSalario(diasUteis):c}");
            }
        }


    }
}