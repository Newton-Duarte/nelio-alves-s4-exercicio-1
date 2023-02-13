using System.Globalization;

namespace Exercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      Person pessoa1 = new Person();
      Person pessoa2 = new Person();

      System.Console.WriteLine("Informe os dados da primeira pessoa");
      System.Console.Write("Nome: ");
      pessoa1.name = Console.ReadLine();
      System.Console.Write("Idade: ");
      pessoa1.age = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Informe os dados da segunda pessoa");
      System.Console.Write("Nome: ");
      pessoa2.name = Console.ReadLine();
      System.Console.Write("Idade: ");
      pessoa2.age = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Dados da primeira pessoa:");
      System.Console.WriteLine("Nome: " + pessoa1.name);
      System.Console.WriteLine("Idade: " + pessoa1.age);

      System.Console.WriteLine("Dados da segunda pessoa:");
      System.Console.WriteLine("Nome: " + pessoa2.name);
      System.Console.WriteLine("Idade: " + pessoa2.age);

      System.Console.WriteLine($"Pessoa mais velha: {(pessoa1.age > pessoa2.age ? pessoa1.name : pessoa2.name)}");

      Staff funcionario1 = new Staff();
      Staff funcionario2 = new Staff();

      System.Console.WriteLine("Informe os dados do primeiro funcionário");
      System.Console.Write("Nome: ");
      funcionario1.name = Console.ReadLine();
      System.Console.Write("Salário: ");
      funcionario1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      System.Console.WriteLine("Informe os dados do segundo funcionário");
      System.Console.Write("Nome: ");
      funcionario2.name = Console.ReadLine();
      System.Console.Write("Salário: ");
      funcionario2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      System.Console.WriteLine("Dados do primeiro funcionário:");
      System.Console.WriteLine("Nome: " + funcionario1.name);
      System.Console.WriteLine("Salário: " + funcionario1.salary.ToString("F2", CultureInfo.InvariantCulture));

      System.Console.WriteLine("Dados da segunda funcionário:");
      System.Console.WriteLine("Nome: " + funcionario2.name);
      System.Console.WriteLine("Salário: " + funcionario2.salary.ToString("F2", CultureInfo.InvariantCulture));

      System.Console.WriteLine($"Salário médio = {((funcionario1.salary + funcionario2.salary) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}