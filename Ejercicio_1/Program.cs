using System;

namespace Ejercicio_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            BubbleSortCollectionSorter bubbleSortCollectionSorter = new BubbleSortCollectionSorter();
            bubbleSortCollectionSorter.ejecutarProceso();
        }
    }


    interface ICollectionSorter
    {

        void mostrarVector(string[] vector);

        string[] SortAscending(int[] numbers);

        string[] SortDescending(int[] numbers);

    }

    public class BubbleSortCollectionSorter : ICollectionSorter
    {

        public void ejecutarProceso()
        {

            int cantidadNumeros = 0;
            int[] arrayNumbers;
            string[] arrayNumText;
            string[] arrayorganized;

            bool bitError = false;

            try
            {
                //Definicion cantidad de numeros del vector
                Console.WriteLine("Por favor digite el numero de enteros a ingresar : ");
                cantidadNumeros = int.Parse(Console.ReadLine());
                arrayNumbers = new int[0];
                arrayNumText = new string[cantidadNumeros];
                arrayorganized = new string[cantidadNumeros];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Por favor ingrese un numero entero");
            }

            //Armado del vector
            (arrayNumbers, bitError) = armarVector(cantidadNumeros);


            if (bitError == false)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("======Ordenamiento Ascendente===========");
                arrayorganized = SortAscending(arrayNumbers);
                arrayNumText = vectorToText(arrayorganized);
                Console.WriteLine("========================================");
                mostrarVector(arrayNumText);
            }


            if (bitError == false)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("======Ordenamiento Descendente==========");
                arrayorganized = SortDescending(arrayNumbers);
                arrayNumText = vectorToText(arrayorganized);
                Console.WriteLine("========================================");
                mostrarVector(arrayNumText);
            }

            Console.WriteLine("========================================");

            Console.ReadLine();

        }

        public (int[], bool) armarVector(int amountNumbers)
        {
            int[] arrayNumbers = new int[0];
            bool bitError = false;

            arrayNumbers = new int[amountNumbers];

            for (int contador = 0; contador < amountNumbers; contador++)
            {
                try
                {
                    Console.WriteLine("Por favor digite el numero de la posicion {0} :", contador);
                    arrayNumbers[contador] = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    bitError = true;
                    Console.WriteLine("Por favor ingrese un numero entero");
                    break;
                }
            }

            return (arrayNumbers, bitError);

        }

        public void mostrarVector(string[] vector)
        {
            
                string result = "";

                //Muestro el vector
                for (int i = 0; i < vector.Length; i++)
                {
                    if (i < vector.Length - 1)
                    {
                        result += vector[i] + ",";
                    }
                    else
                    {
                        result += vector[i];
                    }

                }

                Console.WriteLine(result);                   

        }

        public string[] SortAscending(int[] numbers)
        {

            string[] resultado = new string[numbers.Length];

            try
            {

                //Lleno el array resultado               
                for (int posicion = 0; posicion <= numbers.Length - 1; posicion++)
                {
                    resultado[posicion] = numbers[posicion].ToString();
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length - i - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            int numMayor = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = numMayor;

                            resultado[j] = numbers[j].ToString();
                            resultado[j + 1] = numbers[j + 1].ToString();
                        }
                    }

                    mostrarVector(resultado);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error : " + ex.Message);
            }

            return resultado;


        }

        public string[] SortDescending(int[] numbers)
        {
            string[] resultado = new string[numbers.Length];

            try
            {

                //Lleno el array resultado
                for (int posicion = 0; posicion <= numbers.Length - 1; posicion++)
                {
                    resultado[posicion] = numbers[posicion].ToString();
                }


                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {
                            int numMenor = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = numMenor;

                            resultado[j] = numbers[j].ToString();
                            resultado[j + 1] = numbers[j + 1].ToString();
                        }
                    }

                    mostrarVector(resultado);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error : " + ex.Message);
            }

            return resultado;
        }

        public string[] vectorToText(string[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case "0":
                        numbers[i] = "ZeRo";
                        break;
                    case "1":
                        numbers[i] = "one";
                        break;
                    case "2":
                        numbers[i] = "two";
                        break;
                    case "3":
                        numbers[i] = "three";
                        break;
                    case "4":
                        numbers[i] = "four";
                        break;
                    case "5":
                        numbers[i] = "five";
                        break;
                    case "6":
                        numbers[i] = "six";
                        break;
                    case "7":
                        numbers[i] = "seven";
                        break;
                    case "8":
                        numbers[i] = "eight";
                        break;
                    case "9":
                        numbers[i] = "nine";
                        break;
                }



                if ((i != 0) && ((i % 2) == 0))
                {
                    numbers[i] = numbers[i].ToLower();
                }
                else if ((i != 0) && ((i % 2) != 0))
                {
                    numbers[i] = numbers[i].ToUpper();
                }

            }

            return numbers;


        }


    }

}
