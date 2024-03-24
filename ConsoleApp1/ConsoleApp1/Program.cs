using ConsoleApp1.Containers;
using ConsoleApp1.Ships;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja statku
            Ship ship = new Ship(25, 10, 5000, "CargoShip");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== Cargo Management System ===");
                Console.WriteLine("1. Dodaj kontener");
                Console.WriteLine("2. Usuń kontener");
                Console.WriteLine("3. Wyświetl informacje o statku");
                Console.WriteLine("4. Zakończ");

                Console.Write("Wybierz opcję: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddContainer(ship);
                        break;
                    case "2":
                        RemoveContainer(ship);
                        break;
                    case "3":
                        ShowShipInfo(ship);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddContainer(Ship ship)
        {
            Console.WriteLine("Podaj dane kontenera:");

            // Wprowadzanie danych kontenera
            Console.Write("Waga ładunku: ");
            double cargoWeight = double.Parse(Console.ReadLine());

            Console.Write("Wysokość: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Szerokość: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Głębokość: ");
            double depth = double.Parse(Console.ReadLine());

            Console.Write("Maksymalna waga ładunku: ");
            double maxCargo = double.Parse(Console.ReadLine());

            // Tworzenie kontenera i dodawanie go do statku
            Container container = new Container(cargoWeight, height, width, depth, maxCargo);
            ship.loadContaier(container);
            Console.WriteLine("Kontener został dodany do statku.");
        }

        static void RemoveContainer(Ship ship)
        {
            Console.WriteLine("Który kontener chcesz usunąć?");
            Console.Write("Podaj nazwę kontenera: ");
            string containerName = Console.ReadLine();

            // Usuwanie kontenera ze statku
            foreach (var container in ship.containersList)
            {
                if (container.Name == containerName)
                {
                    ship.unloadContaier(container);
                    Console.WriteLine("Kontener został usunięty ze statku.");
                    return;
                }
            }

            Console.WriteLine("Nie znaleziono kontenera o podanej nazwie.");
        }

        static void ShowShipInfo(Ship ship)
        {
            Console.WriteLine("Informacje o statku:");
            ship.ShowShipInfo();
        }
    }
}

