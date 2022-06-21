namespace ResolucaoEnum
{
    internal class Program
    {
        enum Erros
        {
            Ok = 200,
            RedirecionamentoPermanente = 301,
            RedirecionamentoTemporario = 302,
            NaoEncontrado = 404,
            NaoAutorizado = 405,
            ServidorIndisponivel = 503,
            TempoEsgotado = 504
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Erros.Ok);
        }

    }
}
