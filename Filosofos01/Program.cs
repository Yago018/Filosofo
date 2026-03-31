using System;
class Program
{
    static void Main()
    {
        bool pegou01 = false, pegou02 = false;
        bool veriF01 = false, veriF02 = false;
        string Filosofo, Acao;
        while (true)
        {
            Console.WriteLine("Qual Filosofo vai comer: (F1 ou F2)");
            Filosofo = Console.ReadLine().ToUpper();
            if (Filosofo == "F1")
            {
                while (true)
                {

                    Console.WriteLine("Qual vai ser a ação do filosofo \nPegar a faca (A1) ou Pegar o garfo (B1)");
                    Acao = Console.ReadLine().ToUpper();
                    if (Acao == "A1")
                    {
                        if (pegou01 == true) Console.WriteLine("Não pode pegar a faca");
                        else if (pegou01 != true)
                        {
                            Console.WriteLine("O fisofo pegou a faca");
                            pegou01 = true;
                        }
                    }
                    if (Acao == "B1")
                    {
                        if (pegou02 == true) Console.WriteLine("Não pode pegar o garfo novamente");
                        else if (pegou02 != true)
                        {
                            Console.WriteLine("O filosofo pegou o garfo");
                            pegou02 = true;
                        }
                    }
                    if (Acao == "A2")
                    {
                        if (pegou01 == true) Console.WriteLine("Não pode pegar a faca novamente");
                        else if (pegou01 != true)
                        {
                            Console.WriteLine("O fisofo pegou a faca");
                            pegou01 = true;
                        }
                    }
                    if (Acao == "B2")
                    {
                        if (pegou02 == true) Console.WriteLine("Não pode pegar o garfo novamente");
                        else if (pegou02 != true)
                        {
                            Console.WriteLine("O filosofo pegou o garfo");
                            pegou02 = true;
                        }
                    }
                    if (pegou01 == true && pegou02 == true)
                    {
                        veriF01 = true;
                        break;
                    }
                }
            }
            pegou01 = false;
            pegou02 = false;
            if (Filosofo == "F2")
            {

                while (true)
                {
                    if (Filosofo == "F2")
                    {
                        Console.WriteLine("Qual vai ser a ação do filosofo \nPegar a faca (A2) ou Pegar o garfo (B2)");
                        Acao = Console.ReadLine().ToUpper();
                        if (Acao == "A2")
                        {
                            if (pegou01 == true) Console.WriteLine("Não pode pegar a faca novamente");
                            else if (pegou01 != true)
                            {
                                Console.WriteLine("O fisofo pegou a faca");
                                pegou01 = true;
                            }
                        }
                        if (Acao == "B2")
                        {
                            if (pegou02 == true) Console.WriteLine("Não pode pegar o garfo novamente");
                            else if (pegou02 != true)
                            {
                                Console.WriteLine("O filosofo pegou o garfo");
                                pegou02 = true;
                            }
                        }
                        if (Acao == "A1")
                        {
                            if (pegou01 == true) Console.WriteLine("Não pode pegar a faca");
                            else if (pegou01 != true)
                            {
                                Console.WriteLine("O fisofo pegou a faca");
                                pegou01 = true;
                            }
                        }
                        if (Acao == "B1")
                        {
                            if (pegou02 == true) Console.WriteLine("Não pode pegar o garfo novamente");
                            else if (pegou02 != true)
                            {
                                Console.WriteLine("O filosofo pegou o garfo");
                                pegou02 = true;
                            }
                        }
                        if (pegou01 == true && pegou02 == true)
                        {
                            veriF02 = true;
                            break;
                        }
                    }
                }
                if (veriF01 == true && veriF02 == true) break;
            }
        }
    }
}