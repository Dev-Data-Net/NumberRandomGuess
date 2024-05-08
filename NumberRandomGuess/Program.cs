var random = new Random();
var randomNumber = random.Next(0, 100);
Console.WriteLine("WITAJ W GRZE!");
Console.WriteLine("Wylosowano 1 LICZBĘ od 0 do 100. Zgadnij co to za liczba.");
var numberOfTries = 0;


while (true)
{
    numberOfTries++;
    Console.WriteLine("\nPodaj Twoją liczbę: ");

    var testNumber = AddNumber();

    if (testNumber > randomNumber)
    {
        Console.WriteLine("Twoja typowana liczba jest WIĘKSZA od wylosowanej. Próbuj dalej zgadnąć.");
        continue;
    }
    if (testNumber < randomNumber)
    {
        Console.WriteLine("Twoja typowana liczba jest MNIEJSZA od wylosowanej. Próbuj dalej zgadnąć.");
        continue;
    }
    Console.WriteLine($"Brawo udało się wytypować właściwą liczbę w {numberOfTries} próbach" + $"\nWylosowana liczba to: {randomNumber}");
    break;

}

static int AddNumber()
{
    while (true)
    {
        if (!int.TryParse(Console.ReadLine(), out int number) || number > 100 || number < 0)
        {
            Console.WriteLine("Podałeś nieprawidłową wartość. Spróbuj ponownie podając liczbę z zakresu 0-100");
            continue;

        }
        return number;
    }
}