
namespace ConstrutorAluno{
    public class Aluno{
        private long matricula = 1570482311000;
        private string? nome;

        public static int cont = 0;

        public long Matricula{
            get{return matricula;}
        }

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }


        public Aluno(string nome){
            MatriculaConstrutor();
            this.nome = nome;
        }

        public Aluno(){
            MatriculaConstrutor();
        }

        // método privado
        private void MatriculaConstrutor(){ // evitar repetição de código nos dois construtores.
            matricula += cont;
            cont++;
        }

        // métodos públicos

        public void MostrarAluno(){
            Console.WriteLine("ID Matricula: " + matricula + "\tNome: " + nome);
        }
    }
}