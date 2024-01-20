namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool entradaValida = false;
            double volumeValido = 0;
            do
            {
                Console.Write("Digite o Raio do circulo: ");
                string raio = Console.ReadLine();

                if (double.TryParse(raio, out double raioValido))
                {
                    volumeValido = ((4.0 / 3.0) * 3.14159) * Math.Pow(raioValido, 3);
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    Console.WriteLine();
                }


            }while (!entradaValida);

            Console.WriteLine($"O volume é: {volumeValido:F3}");
        }
    }
}
