using System.IO;

String linijka = "";
int licznik = 0;
String sciezka = "C://test//";

Console.WriteLine("Podaj swoje imię i nazwisko rozdzielone znakiem spacji");
String ImieINazw = Console.ReadLine();
ImieINazw = ImieINazw.ToLower();
String Imie = ImieINazw.Substring(0,ImieINazw.IndexOf(' '));
String Nazwisko = ImieINazw.Substring(ImieINazw.IndexOf(' ')+1);
String NazwaPliku = "test_" + Imie + "_" + Nazwisko + ".txt";

if ( NazwaPliku.Length > 15 )
{
    NazwaPliku = "test_" + Imie.Substring(0,3) + "_" + Nazwisko.Substring(0,3) + ".txt";
}


try
{


    StreamReader czytacz = new StreamReader(sciezka+           NazwaPliku       );


    linijka = czytacz.ReadLine();

    while (linijka != null)
    {
        for (int i = 0; i < linijka.Length; i++)
        {
            if (linijka[i] == 'a')
                licznik++;
        }
        linijka = czytacz.ReadLine();
    }

    Console.WriteLine("Ilosc a w całym pliku " + licznik + " ");
    czytacz.Close();
}
catch
{
   Console.WriteLine("Błąd" );

}




