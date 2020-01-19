using System;

namespace SelectionSort
{
    class Program
    {
        //SelectionSort na Unha
        static void Main(string[] args)
        {
            Carro[] carros =
            {
                new Carro("Ferrari", 500_000),
                new Carro("Hilux", 150_000),
                new Carro("Gol", 40_000),
                new Carro("Onix", 40_000),
                new Carro("Mobi", 30_000)
            };

            ImprimeCarros(carros, "Carros");

            Ordena(carros, carros.Length);

            ImprimeCarros(carros, "Carros - Ordenados por Preço");

            Console.ReadLine();
        }

        private static void Ordena(Carro[] carros, int qtdElementos)
        {
            for (int atual = 0; atual < qtdElementos - 1; atual++)
            {
                int menor = BuscaMenor(carros, atual, qtdElementos);

                Troca(carros, atual, menor);
            }
        }

        private static int BuscaMenor(Carro[] carros, int inicio, int termino)
        {
            int maisBarato = inicio;

            for (int atual = inicio; atual < termino; atual++)
            {
                if(carros[atual].Preco < carros[maisBarato].Preco)
                {
                    maisBarato = atual;
                }
            }

            return maisBarato;
        }

        private static void Troca(Carro[] carros, int atual, int menor)
        {
            Carro carroAtual = carros[atual];
            Carro carroMenor = carros[menor];
            carros[atual] = carroMenor;
            carros[menor] = carroAtual;
        }

        private static void ImprimeCarros(Carro[] carros, string titulo)
        {
            Console.WriteLine(titulo);
            foreach (var carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
            Console.WriteLine();
        }
    }
}
