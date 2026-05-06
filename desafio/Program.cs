using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Luigi";
            string personagem = "Dante";
            string origem = "DMC3";
            string experiencia = "8/10";
            int maxlife = 300;
            int defesa = 999;
            int rebelion = 100;
            int bonus = 12;
            string historia = "filho de anjo e demonio caçador de demonio";
            string habilidade = "regeneração+força+velocidade absurdas";
            int força = 100;
            int agilidade = 100;
            int inteligencia = 10;

            string name2 = "Murilo";
            string personagem2 = "Leon S.";
            string origem2 = "RESIDENT EVIL 9";
            string experiencia2 = "9/10";
            int maxlife2 = 300;
            int defesa2 = 500;
            int requiem = 100;
            int bonus2 = 12;
            string historia2 = "Agente da DSO preparado para ameaças biologicas em escala global";
            string habilidade2 = "Perry+Precisão+Agilidade";
            int força2 = 80;
            int agilidade2 = 150;
            int inteligencia2 = 100;
            Console.WriteLine("Personagem de Luigi: " + personagem);
            Console.WriteLine("Personagem de Murilo: " + personagem2);

            Console.WriteLine(personagem + " VS " +personagem2);
            
            Console.WriteLine("qual regra queres?");
            int regra = int.Parse(Console.ReadLine());

            switch (regra)
            {
                case 1:
                if(força + agilidade > força2 + agilidade2)
                {
                    Console.WriteLine("O personagem " + personagem + " é mais forte que " + personagem2);
                }
                else if (força + agilidade  < força2 + agilidade2)
                {
                    Console.WriteLine("O personagem " + personagem2 + " é mais forte que " + personagem);
                }
                else
                {
                    Console.WriteLine("Os personagens " + personagem + " e " + personagem2 + " tem a mesma força");
                }
                break;
                case 2:
                if (inteligencia > inteligencia2)
                {
                    Console.WriteLine("O personagem " + personagem + " é mais inteligente que " + personagem2);
                }
                else if (inteligencia < inteligencia2)
                {
                    Console.WriteLine("O personagem " + personagem2 + " é mais inteligente que " + personagem);
                }
                else
                {
                    Console.WriteLine("Os personagens " + personagem + " e " + personagem2 + " tem a mesma inteligência");
                } 
                break;
                case 3:
                 if (maxlife + agilidade > maxlife2 + agilidade2)
                    {
                        Console.WriteLine("O personagem " + personagem + " é mais resistente que " + personagem2);
                    }
                    else if (maxlife + agilidade < maxlife2 + agilidade2)
                    {
                        Console.WriteLine("O personagem " + personagem2 + " é mais resistente que " + personagem);
                    }
                    else
                    {
                        Console.WriteLine("Os personagens " + personagem + " e " + personagem2 + " tem a mesma resistência");
                    }
                    break;
                    default:
                    Console.WriteLine("Regra inválida. Por favor, escolha uma regra entre 1 e 3.");
                    break;


            }


        }
    }
}
