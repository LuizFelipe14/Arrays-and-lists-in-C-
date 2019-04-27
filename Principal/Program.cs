using System;
using System.Globalization;

using Class.Produto;

namespace Principal {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                //Dando valor as propriedades da classe direto na na estanciação 
                vect[i] = new Produto { Name = name, Price = price };

            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                // Pegando a soma de todos os preços, com base no número digitado pelo usuário 
                sum += vect[n].Price;
            }

            // Calculando a média
            double avg = sum / n;
            Console.WriteLine("Preço médio: " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
