namespace Dictionary
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public String Nome { get; set; }
        String Sobrenome { get; set; }
        int Telefone { get; set; }
        public Aluno(String nome, String sobrenome, int telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
    public static class Escola
    {
        static public int numAlunos = 0;
        static public Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public static void CadastrarAluno(String nome, String sobrenome, int telefone)
        {
            Aluno aluno = new Aluno(nome, sobrenome, telefone);
            aluno.Matricula = Matriculados.Count + 1;
            Matriculados.TryAdd(aluno.Matricula, aluno);
            Console.WriteLine("Aluno cadastrado" + Environment.NewLine);
        }

        public static void RemoverAluno(int matricula)
        {
            if (Matriculados.ContainsKey(matricula))
            {
                Matriculados.Remove(matricula);
                Console.WriteLine($"Aluno de matrícula {matricula}removido");

            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void ListarAlunos()
        {
            Console.WriteLine("Alunos matriculádos: ");
            foreach(var item in Matriculados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }

    public class Inicializar
    {
        public int Menu()
        {
            Console.WriteLine(
                " Qual função você deseja realizar? \n" +
                "1 - Cadastrar aluno\n" +
                "2 - Remover aluno\n" +
                "3 - Listar todas as mátriculas com nomes de alunos\n" +
                "4 - Sair"
                );
            return int.Parse(Console.ReadLine());
            
        }
        public void Inicializacao()
        {
            int funcao = Menu();
            while(funcao != 4)
            {
                switch (funcao)
                {
                    case 1: Cadastrar();
                        break;
                    case 2: Remover();
                        break;
                    case 3: Listar();
                        break;
                    default: Console.WriteLine("Digite uma opção válida");
                        break;
                }
                funcao = Menu();   
            }
        }

        public void Listar()
        {
            Escola.ListarAlunos();
        }
        public void Remover()
        {
            Console.WriteLine("Digite o número da matrícula do aluno que você deseja remover");
            Escola.RemoverAluno(int.Parse(Console.ReadLine()));
        }
        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome do Aluno");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do Aluno");
            String sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do Aluno");
            int telefone = int.Parse(Console.ReadLine());
            Escola.CadastrarAluno(nome,sobrenome,telefone);
        }
    }

    public class program
    {

        static void Main(String[] args)
        {
            Inicializar inicializar = new Inicializar();
            inicializar.Inicializacao();
        }


        

    }
    
}
