using AbstraFunc.entities;

namespace AbstraFunc{
    class Program{
        public static void Main(string[] args){

            Departamento dp = new Departamento(100,"Empresa");
            Comissionado c = new Comissionado(100,"José",new Endereco(), 100, 25);
            dp.AdmitirFuncionario(c);
            dp.AdmitirFuncionario(new Assalariado(1, "Topzera", new Endereco(), 100));
            dp.ListarNomeFuncionarioESalarioFixo();
            dp.DemitirFuncionario(1);
            dp.ListarNomeFuncionarioESalarioFixo();

            c.AdicionarDependente(new Dependente(1,"FELIPE DEPENDENTE",17));
            c.AdicionarDependente(new Dependente(1,"JOSE DEPENDENTE", 19));

            c.ListarDependentes();

            c.RemoverDependentesMaioridade();
            
            c.ListarDependentes();

        }
    }
}