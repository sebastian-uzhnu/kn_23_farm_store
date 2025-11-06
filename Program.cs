using System.Reflection.Metadata.Ecma335;

namespace _2025_KN_23_Lab3;

class Program
{
    public static void Main(string[] args)
    {
        RenderIntro();
        ShowMainMenu();
    }

    public static void RenderIntro()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("===========================================");
        Console.WriteLine("====== Ласкаво просимо до Farm Store ======");
        Console.WriteLine("===========================================");
        Console.ResetColor();
    }

    public static double GetUserInput(string prompt = "Введіть число:")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(prompt + " ");

        bool isNumber = Double.TryParse(Console.ReadLine(), out double choice);

        if (!isNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ви ввели не число!");
            Console.ResetColor();
            GetUserInput();
        }

        Console.ResetColor();

        return choice;
    }
    

    public static void ShowMainMenu()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Головне меню:");
        Console.WriteLine("1. Товари");
        Console.WriteLine("2. Клієнти");
        Console.WriteLine("3. Замовлення");
        Console.WriteLine("4. Пошук");
        Console.WriteLine("5. Статистика");
        Console.WriteLine("6. Вихід");
        Console.ResetColor();

        double choice = GetUserInput("Виберіть пункт меню:");

        switch (choice)
        {
            case 1:
                ShowProductMenu();
                break;
            case 2:
                ShowClientsMenu();
                break;
            case 3:
                ShowOrderMenu();
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                Console.WriteLine("Бувай!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Неправильний вибір");
                Console.WriteLine("==================");
                Console.WriteLine("Спробуйте ще раз");
                ShowMainMenu();
                break;
        }
    }

    private static void ShowOrderMenu()
    {
        // Ціни товарів
        double priceGrain = 25;
        double priceVegetables = 40;
        double priceMeat = 120;
        double priceMilk = 30;
        double priceEggs = 60;
        
        Console.WriteLine("Наші товари:");
        Console.WriteLine($"1. Зерно ({priceGrain} грн)");
        Console.WriteLine($"2. Овочі ({priceVegetables} грн)");
        Console.WriteLine($"3. Мясо ({priceMeat} грн)");
        Console.WriteLine($"4. Молоко ({priceMilk} грн)");
        Console.WriteLine($"5. Яйця ({priceEggs} грн)");

        // Ввід товарів з клавіатури
        double grain = GetUserInput("Введіть кількість зерна (кг):");
        double vegetables = GetUserInput("Введіть кількість овочів (кг): ");
        double meat = GetUserInput("Введіть кількість мяса (кг): ");
        double milk = GetUserInput("Введіть кількість молока (л): ");
        double eggs = GetUserInput("Введіть кількість яєць (шт): ");
        
       
        
        // Обрахунок вартості товару
        double totalGrain = grain * priceGrain;
        double totalVegetables = vegetables * priceVegetables;
        double totalMeat = meat * priceMeat;
        double totalMilk = milk * priceMilk;
        double totalEggs = eggs * priceEggs;
        
        double totalPrice = totalGrain
                            + totalVegetables
                            + totalMeat
                            + totalMilk
                            + totalEggs;


        double discount = 5;
        if (totalPrice > 1000 && totalPrice < 5000)
        {
            discount = 15;
        } else if (totalPrice > 10_000)
        {
            discount = 50;
        }
        
        double discountTotal = Math.Round(totalPrice * (discount / 100));
        
        // Вивід підсумків
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        
        System.Console.WriteLine();
        Console.WriteLine("=== Підсумок покупки ===");
        Console.WriteLine($"Зерно: {grain} кг, вартість за кг ({priceGrain}) вартість: {totalGrain} грн.");
        Console.WriteLine($"Овочі: {vegetables} кг, вартість: {totalVegetables} грн.");
        Console.WriteLine($"Мясо: {meat} кг, вартість: {totalMeat} грн.");
        Console.WriteLine($"Молоко: {milk} л, вартість: {totalMilk} грн.");
        Console.WriteLine($"Яйця: {eggs} шт., вартість: {totalEggs} грн.");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Загальна вартість: {totalPrice} грн.");
        Console.WriteLine($"Знижка: {discount}%");
        Console.WriteLine($"Вартість після знижки: {totalPrice - discountTotal} грн.");
        Console.ResetColor();
        
        System.Console.WriteLine("Дякуємо за вашу покупку!");
        Console.WriteLine("для продовження роботи натисніть будь яку клавішу");
        Console.ReadKey();
        ShowMainMenu();
    }

    private static void ShowClientsMenu()
    {
        Console.WriteLine("Функція в розробці");
    }

    private static void ShowProductMenu()
    {
        Console.WriteLine("========= МЕНЮ ТОВАРІВ =========");
        Console.WriteLine("1. Додати новий товар");
        Console.WriteLine("2. Переглянути всі товари");
        Console.WriteLine("3. Редагувати товар");
        Console.WriteLine("4. Видалити товар");
        Console.WriteLine("5. Пошук товару за назвою");
        Console.WriteLine("6. Сортувати за ціною / кількістю");
        Console.WriteLine("7. Повернутись у головне меню");
        Console.WriteLine("--------------------------------");

        double choice = GetUserInput("Виберіть дію:");

        if (choice > 0 && choice < 8)
        {
            Console.WriteLine("Фунція в розробці");
            return;
        }

        Console.WriteLine("Неправильний пункт меню");
        ShowProductMenu();
    }
}