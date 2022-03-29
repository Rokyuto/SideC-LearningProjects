using System;
using System.IO;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        ExampleAsync();

    }

    // Метод за четене и записване на документи
    public static async Task ExampleAsync()
    {

        String line; // Променлива за текстов ред

        // Направи
        try
        {
            //Създаваме обект, който прочита файла от директорията: 
            StreamReader sr = new StreamReader("W:\\#Code_Projects\\C#\\ReadAndWriteTxtDocuments\\bin\\Debug\\net6.0\\ReadFile.txt");

            //Създаваме обект, който ще пренаписва файла от директорията:
            StreamWriter sw = new StreamWriter("W:\\#Code_Projects\\C#\\ReadAndWriteTxtDocuments\\bin\\Debug\\net6.0\\WriteFile.txt");

            // Прочитаме реда на първия текстов документ (Test1.txt)
            line = sr.ReadLine();

            //Цикъл който продължава докато документа има ред
            while (line != null)
            {
                //Презаписваме данните от реда на първия файл в съответния ред на втория файл
                sw.WriteLine(line);

                // Прочитаме следващия ред от първия файл
                line = sr.ReadLine();
            }

            // Когато всички редове са прочетени и записани, Затваря двата файла
            sw.Close();
            sr.Close();

        }
        // Дебъгер за грешки
        catch (Exception e)
        {
            // Изписва съответната грешка
            Console.WriteLine("Exception: " + e.Message);
        }
        // Когато всичко е изпълнено
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }

}