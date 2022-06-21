namespace Dictionary
{
    public class Aluno
    {
        int Matricula { get; set; }
        string Nome { get; set; }
        string Sobrenome { get; set; }
        int Telefone { get; set; }  

        
    }

    public class Escola
    {
        Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

////        
        public static void CadastrarAluno()
          {
            Escola.Add(matricula, nome);
            }

    }

    //Funcionalidades 
       //Cadastrar aluno
       //remover aluno
       //listar matrículas


    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

/*
 * // 2. Dictionary
            // 2.1. Declarar
            Dictionary<string, string> UF = new Dictionary<string, string>();

            // 2.1. Adicionar chave/valor
            UF.Add("RJ", "Rio de Janeiro");
            UF.Add("SP", "São Paulo");
            UF.Add("MG", "Minas Gerais");

            // 2.2. Remover chave/valor
            UF.Remove("MG");

            // 2.3. Acessar valor.
            // string Estado = UF["RJ"];
            bool validar = UF.TryGetValue("RJ", out string Estado);

            if(validar)
            {
                Console.WriteLine(Estado);
            }

            // 2.4. Verificar se a Key existe.
            bool ValidarTemUF = UF.ContainsKey("RJ"); // true

            Console.WriteLine(ValidarTemUF);

            // 2.5. Verificar se a Value existe.
            bool ValidarTemValor = UF.ContainsValue("Carioca"); // true

            Console.WriteLine(ValidarTemValor);

            // 2.6. Validar se existe, se não existir adicionar a coleção.
            UF.TryAdd("MG", "Mineiro");

            // 2.7. Iterar
            foreach (KeyValuePair<string, string> local in UF)
            {
                Console.WriteLine($"{local.Key} {local.Value}");
            }
 */