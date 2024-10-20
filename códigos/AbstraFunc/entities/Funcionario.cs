using System.Runtime.Intrinsics.Arm;
using AbstraFunc.entities;


namespace AbstraFunc.entities {
    public abstract class Funcionario{
        public int Codigo {get;set;}
        public string? Nome {get;set;}
        public Endereco Endereco {get;set;}
        public double Salario {get;set;}
        public List<Dependente> listaDependentes {get;set;}

        public Funcionario(int codigo, string nome, Endereco endereco, double salario){
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Salario = salario;
            listaDependentes = new List<Dependente>();
        }

        public virtual double CalcularSalario(int diasUteis){
            return Salario / 30 * diasUteis;
        }

        // methods dependentes
        public int CalcularTotalDependente(){
            return listaDependentes.Count();
        }

        public void AdicionarDependente(Dependente novoDep){
            listaDependentes.Add(novoDep);
        }
        
        public void RemoverDependentesMaioridade(){
            for(int i = listaDependentes.Count -1; i >= 0; i--){
                if (listaDependentes[i].VerificarMaiorIdade()){
                    listaDependentes.Remove(listaDependentes[i]);
                }
            }

        }

        public void ListarDependentes(){
            foreach(Dependente d in listaDependentes){
                Console.WriteLine($"Depentende {d.Nome}\n{d.Idade}\n");
            }
        }

    }
}