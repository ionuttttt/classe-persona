using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classe_persona
{
    internal class Program
    {
        class persona
        {
            protected int codice;
            protected string nome;
            protected string cognome;
            protected bool registrato;
            public persona() 
            {
                codice = 104;
                nome = "Mirko";
                cognome = "Colombo";
                registrato = false;

            }
            public void registra()
            {
                registrato = true;

            }
            public void mostra()
            {
                    if (registrato == true)
                    {
                        Console.WriteLine("Registrazione avvenuta\n codice: " + codice + "\nnome: " + nome + "\ncognome: " + cognome);
                    }
                    if (registrato == false)
                    {
                        Console.WriteLine("Utente non registrato");
                    }

                
            }

        }
        static void Main(string[] args)
        {
            persona persona = new persona();
            persona.mostra();
            Console.WriteLine("Premi invio per registrare");
            Console.ReadLine();
            persona.registra();
            persona.mostra();
            Console.ReadLine();
        }
    }
}
