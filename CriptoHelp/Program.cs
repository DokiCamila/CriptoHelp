using System;

namespace CriptoHelp
{
    class MainClass
    {


        public static string AlfaNumerico(string x)
        {
            int y;
            x = x.ToUpper();

            y = -1;

            switch (x)
            {
                case "A":
                    y = 0;
                    break;
                case "B":
                    y = 1;
                    break;
                case "C":
                    y = 2;
                    break;
                case "D":
                    y = 3;
                    break;
                case "E":
                    y = 4;
                    break;
                case "F":
                    y = 5;
                    break;
                case "G":
                    y = 6;
                    break;
                case "H":
                    y = 7;
                    break;
                case "I":
                    y = 8;
                    break;
                case "J":
                    y = 9;
                    break;
                case "K":
                    y = 10;
                    break;
                case "L":
                    y = 11;
                    break;
                case "M":
                    y = 12;
                    break;
                case "N":
                    y = 13;
                    break;
                case "O":
                    y = 14;
                    break;
                case "P":
                    y = 15;
                    break;

                case "Q":
                    y = 16;
                    break;

                case "R":
                    y = 17;
                    break;
                case "S":
                    y = 18;
                    break;
                case "T":
                    y = 19;
                    break;

                case "U":
                    y = 20;
                    break;

                case "V":
                    y = 21;
                    break;

                case "W":
                    y = 22;
                    break;

                case "X":
                    y = 23;
                    break;
                case "Y":
                    y = 24;
                    break;

                case "Z":
                    y = 25;
                    break;

                default:
                    Console.WriteLine("Caractere Inválido!!");
                    break;
            }
            return y.ToString();
        }
            public static int ParOuImpar(int x)
             {
                 int resultado;

                 resultado = x % 2;
           
            if (resultado == 1)
            {
                return 1; 
            }
                return 0;

                     
             }
        public static void Main(string[] args)
        {

            int[,] chave = new int[2, 2];

            int option, tamanho, y;
            int i, j;
            string text;
            Console.WriteLine("Hello From CriptoHelp!!\n HOW CAN I HELP YOU ?? (1 - encryption/ 2 - decryption)");
                option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                Console.WriteLine("Type your phrase: ");
                text = Console.ReadLine();
                for (i = 0; i < 2; i++){
                    for (j = 0; j < 2;j++){
                        Console.WriteLine("Type your key[{0},{1}]: ", i + 1, j + 1);
                        chave[i,j] = int.Parse(Console.ReadLine());
                    }
                }

                text = text.Replace(" ", string.Empty); // substitui os espaços 
                tamanho = ParOuImpar(text.Length);
           
                if (tamanho == 1){
                    text = text + "H";
                }

                y = text.Length / 2;


                string[,] matriz = new string[2,y];
                int l;
                l = 0;
                for (i = 0; i < 2; i++){

                    for ( j = 0;j < y ; j++)  {
                      
                        matriz[i,j] = AlfaNumerico(text[l].ToString());
                        l++;
                        Console.WriteLine("matriz [{0},{1}] : {2}",i +1, j+1, matriz[i,j]);

                    }

                    Console.WriteLine("\n");
                }






            }
            else if (option == 2)
            {
                //Começo dos calculos de chave 
                int[,] chaveInversa = new int[2, 2];
                int  det, a, b, c, d;

                Console.WriteLine("Type your phrase: ");
                text = Console.ReadLine();
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Type your key[{0},{1}]: ", i + 1, j + 1);
                        chave[i, j] = int.Parse(Console.ReadLine());
                    }
                }


                det = 0;
                det = (chave[0, 0] * chave[1, 1]) - (chave[0, 1] * chave[1, 0]);
                Console.WriteLine("Seu determinante é de :" + det);

                if (det == 1)
                {
                    det = 1;
                }
                else if (det == 3)
                {
                    det = 9;
                }
                else if (det == 5)
                {
                    det = 21;
                }
                else if (det == 7)
                {
                    det = 15;
                }
                else if (det == 9)
                {
                    det = 3;
                }
                else if (det == 11)
                {
                    det = 19;
                }
                else if (det == 15)
                {
                    det = 7;
                }
                else if (det == 17)
                {
                    det = 23;
                }
                else if (det == 19)
                {
                    det = 11;
                }
                else if (det == 21)
                {
                    det = 5;
                }
                else if (det == 23)
                {
                    det = 17;
                }
                else if (det == 25)
                {
                    det = 25;
                }
                else
                {
                    Console.WriteLine("Error...");
                }

                a = chave[0, 0];
                b = chave[0, 1];
                c = chave[1, 0];
                d = chave[1, 1];

                chaveInversa[0, 0] = d;
                chaveInversa[0, 1] = b;
                chaveInversa[1, 0] = c;
                chaveInversa[1, 1] = a;


                Console.WriteLine("\nSeu det é de: " + det);


                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("chaveInversa[{0},{1}]: {2}", i + 1, j + 1, chaveInversa[i, j]);
                        chaveInversa[i, j] = (det * chaveInversa[i, j]) % 26;


                    }
                }

                Console.WriteLine("\n");

                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("chaveInversa[{0},{1}]: {2}", i + 1, j + 1, chaveInversa[i, j]);



                    }
                }


            }else {
                Console.WriteLine("Invalid operation... you have to choose between 1 or 2 ");
            }

        }

    }
}
