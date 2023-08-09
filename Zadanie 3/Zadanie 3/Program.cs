

String[] imie = new string[] {"Ania", "Kasia", "Basia", "Zosia" };
String[] nazwisko = new string[] { "Kowalska", "Nowak"};

Random generator = new Random();

try
{
    String nazwa ="users_" + DateTime.Now.ToString("dd_MM_HH")+".csv";



    StreamWriter streamWriter = new StreamWriter("C://test//" + nazwa);

    streamWriter.WriteLine("LP,Imię,Nazwisko,Rok_urodzenia");


    for (int i  = 1; i <= 100; i++)
streamWriter.WriteLine(i + "," + imie[generator.Next(imie.Length)] + "," + nazwisko[generator.Next(nazwisko.Length )] + "," + generator.Next(1990,2001 ));
       
    
        

    streamWriter.Close();
    Console.WriteLine("Plik został zapisany na dysku c w katalogu test");
}
catch
{

}




