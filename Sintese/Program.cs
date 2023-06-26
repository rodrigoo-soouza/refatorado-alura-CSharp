using System;
class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Digite a idade de João: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite True para acompanhado e False para desacompanhado: ");
        bool acompanhado = Convert.ToBoolean(Console.ReadLine());
        

        if (idade >= 18)

            Console.WriteLine("João pode entrar");

        else if (idade <= 18 && acompanhado == true)

            Console.WriteLine("João é menor de idade mas está acompanhado, pode entrar.");

        else

            Console.WriteLine("João é menor de idade e está desacompanhado não pode entrar");
        Console.ReadKey();
    }
    
}  