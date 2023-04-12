namespace Gestion_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Mohammed", "Ali", "mohammed.ali@gmail.com", "1234-5678-9012-3456", 101);
            Client client2 = new Client("Mohammed", "Ali", "mohammed.ali@gmail.com", "1234-5678-9012-3456", 101);


            Hotel hotel1 = new Hotel();
            hotel1.AjouterClient(client1);
            hotel1.AjouterClient(client2);
            foreach (Client client in hotel1.Clients)
            {
                Console.Write("Client: ");
                Console.Write(client1.Nom);
                Console.Write(client1.Prenom);
                Console.Write(client1.Courriel);
                Console.Write(client1.CarteCredit);
                Console.Write(client1.NumeroChambre);
                Console.WriteLine("");
            }

        }
    }
}