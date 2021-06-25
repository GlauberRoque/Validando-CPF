using System;

namespace ValidandoCpf
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Digite o seu CPF: ");
                string CPF = Console.ReadLine();
            if (CPF.Length > 11 )
            {
                Console.WriteLine("Informe um cpf válido!");
            }else if(CPF.Length < 11){
                Console.WriteLine("Informe um cpf válido!");
            }else{
                CPF = CPF.Insert(9, "-");
                CPF = CPF.Insert(6, ".");
                CPF = CPF.Insert(3, ".");
               
                Console.WriteLine(CPF);
            }

        }
    }
}
