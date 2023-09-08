namespace Exercio_01_OrienObjt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome, idade;

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Boa tarde, tudo bem? Gentileza informar seu nome e idade: ");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Nome :");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade :");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Informe outro nome e idade: ");
            Console.WriteLine("Nome :");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade :");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha é : " + p1.nome);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            else
            {
                Console.WriteLine("A pessoa mais velha é : " + p2.nome);
            }

        }
    }
}