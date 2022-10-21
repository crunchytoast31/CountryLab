namespace CountryLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController();

            countryController.WelcomeAction();
        }
    }
}