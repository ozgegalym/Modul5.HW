using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Попытка доступа к несуществующему веб-ресурсу
                throw new System.Net.WebException("Ошибка: не удалось получить доступ к веб-ресурсу.");
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

/*
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                    // Обращение к элементам массива за его пределами
                    for (int i = 0; i <= array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Выход за пределы массива. " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Обработка массива завершена.");
                }
*/
            }
        }
    }


