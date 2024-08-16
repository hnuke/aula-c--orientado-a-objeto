using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeira_aula.Entities
{
    public class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public int codigo { get; set; }

        public Funcionario(string nome, double salario, int codigo){
            this.nome = nome;
            this.salario = salario;
            this.codigo = codigo;
        }


        // método para os dados
        public override string ToString(){
            return "Nome: " + nome + " , Salário: R$ " + salario + " , Código: " + codigo;
        }
    }
}