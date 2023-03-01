namespace ConsoleApp4
{
    internal class KlasaGeneryczna<T> where T: Osoba
    {
        public T Osoba { get; set; }

        public KlasaGeneryczna(T osoba)
        {
            Osoba = osoba;
        }

        public void GenerycznaMetoda()
        {
            Console.WriteLine($"Miasto: {Osoba._miasto}, Numer domu {Osoba._numerDomu}, Numer mieszkania: {Osoba._numerMieszkania}, Kod pocztowy: {Osoba._kodPocztowy}");
        }
    }
}
