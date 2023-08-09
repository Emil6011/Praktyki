using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Text.RegularExpressions;

Console.WriteLine("Podaj lokalizacje pliku np C://test//plik.txt");
String lokalizacja = Console.ReadLine();


try
{
    string wczytany= File.ReadAllText(lokalizacja);


    int index = wczytany.IndexOf("praca");
    int licznik = 0;
    while (index != -1 && licznik < 5)
    {
        licznik++;
        index = wczytany.IndexOf("praca", index + 1);
    }
    
    if (licznik == 5)
    {

        string Zmodyfikowany = wczytany.Replace("praca", "job");
        File.WriteAllText(lokalizacja, Zmodyfikowany);
        String nazwa =  FileSystem.GetName(lokalizacja);
        index = nazwa.IndexOf(".txt");

        nazwa = nazwa.Substring(0, index) + "_changed - ";
        index = DateTime.Now.ToString("G").IndexOf(" ");
        String temp = DateTime.Now.ToString("G").Substring(0, index);
        nazwa = nazwa + temp + ".txt";
     

        FileSystem.RenameFile(lokalizacja, nazwa);       
        Console.WriteLine("Zamieniono 5 wystąpień 'praca' na 'job'.");
    }
    else
    {
        Console.WriteLine("Nie znaleziono 5 wystąpień slowa 'praca' w pliku.");
    }


}
catch
{

   Console.WriteLine("Błąd");
}




