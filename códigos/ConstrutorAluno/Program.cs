
namespace ConstrutorAluno{
    public class Program{
        public static void Main(string[] args){
            Aluno a1 = new Aluno("Jonathan");
            a1.MostrarAluno();

            Aluno a2 = new Aluno("Felps");
            a2.MostrarAluno();
 
            Aluno a3 = new Aluno("Giovani");
            a3.MostrarAluno();

            Aluno asemnome = new Aluno();

            asemnome.MostrarAluno();

            Console.WriteLine("Total de alunos cadastrados: " + Aluno.cont);

            
        }
    }
}