namespace SomaMultiplos.Services
{
    public class SomaMultiploService
    {
        /// <summary>
        /// Apresentar uma descriçãoda soma dos múltiplos
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Apresenta um texto sobre os resultados das somas dos múltiplos</returns>
        public string ApresentarResultados(int valor)
        {
            int somaDe3 = SomarMultiploDe3(valor);
            int somaDe5 = SomarMultiploDe5(valor);

            string resultadoDe3;
            string resultadoDe5;

            int somaTotal = 0;
            if (somaDe3 > 0 || somaDe5 > 0)
            {
                somaTotal = somaDe3 + somaDe5;
            }

            return "   A soma dos múltiplos é: " + somaTotal.ToString();
        }

        /// <summary>
        /// Soma os múltiplos de 3
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna a soma dos múltiplos</returns>
        private int SomarMultiploDe3(int valor)
        {
            int inferior = valor - 1;
            List<int> lista = new List<int>();

            for (int i = inferior; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    lista.Add(i);
                }
            }

            int soma = 0;
            foreach (var item in lista)
            {
                soma = soma + item;
            }

            return soma;
        }


        /// <summary>
        /// Soma os múltiplos de 5
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna a soma dos múltiplos</returns>
        private int SomarMultiploDe5(int valor)
        {
            int inferior = valor - 1;
            List<int> lista = new List<int>();

            for (int i = inferior; i > 0; i--)
            {
                if (i % 5 == 0)
                {
                    lista.Add(i);
                }
            }

            int soma = 0;
            foreach (var item in lista)
            {
                soma = soma + item;
            }

            return soma;
        }
    }
}
