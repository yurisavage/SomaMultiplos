

using SomaMultiplos.Services;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("     Soma dos múltiplos de 3 ou 5");


            Console.WriteLine("   Digite um valor: ");
            var valorInserido = Console.ReadLine();
            int valor = Int32.Parse(valorInserido);
            Console.WriteLine();

            SomaMultiploService soma = new SomaMultiploService();
            string resultados = soma.ApresentarResultados(valor);


            Console.WriteLine("   " + resultados);
            Console.ReadLine();

            Console.ReadKey();
        }

        

    }
}