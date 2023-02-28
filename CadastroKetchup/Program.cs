using CadastroKetchup;
using CadastroKetchup.Entities;

namespace CadastroKetchup
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            MarcaKetchup ketchup  = new MarcaKetchup();
            Console.WriteLine("Digite o nome da Marca: ");
            ketchup.marca = Console.ReadLine ();

            Console.WriteLine("Digite o Volume: ");
            ketchup.volume = Int32.Parse(Console.ReadLine()); ;

            Console.WriteLine("Digite o Preço: ");
            ketchup.preço = Double.Parse(Console.ReadLine());

            Distribuidora distribuidora = new Distribuidora();

            Console.WriteLine("Digite a Cidade da Distribuidora: ");
            distribuidora.cidade = Console.ReadLine();

            Console.WriteLine("Digite o Estado da Distribuidora: ");
            distribuidora.estado = Console.ReadLine();

            if (ketchup.volume > 300)
            {
                Calcular calcular = new Calcular();
                double preco = calcular.ContaCalcular();
                ketchup.preço += preco;
            }


            Console.WriteLine("Marca: " + ketchup.marca); 
            Console.WriteLine("Volume: " + ketchup.volume);
            Console.WriteLine("Preço: " + ketchup.preço);

            Console.WriteLine("Cidade da Distribuidora: " +distribuidora.cidade);
            Console.WriteLine("Estado da Distribuidora: " +distribuidora.estado);

            Console.WriteLine("Cadastro realizado com sucesso");

             }
    }
}