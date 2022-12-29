using System;
using System.Threading;

namespace GeneratorAudio
{
    internal class Menu
    {
        public double Gain;
        public double Freq;
        public double Duration;
        public string TypeAudio;

        public void Warning() {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Warning!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  ----------------------------------------------------------");
            Console.WriteLine("  Do not set a high volume value, I advise no more than 0.3!");
            Console.WriteLine("  ----------------------------------------------------------");
            Thread.Sleep(4000);
            Console.ResetColor();
        }
        public void LoadLogo() {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(100);
            Console.WriteLine("   /$$                                               /$$                              ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  | $$                                              | $$                              ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  | $$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$   /$$$$$$$ /$$$$$$    /$$$$$$   /$$$$$$       ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  | $$ /$$__  $$| $$_  $$_  $$ |____  $$ /$$_____/|_  $$_/   /$$__  $$ /$$__  $$      ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  | $$| $$  \\ $$| $$ \\ $$ \\ $$  /$$$$$$$|  $$$$$$   | $$    | $$$$$$$$| $$  \\__/      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  | $$| $$  | $$| $$ | $$ | $$ /$$__  $$ \\____  $$  | $$ /$$| $$_____/| $$            ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  | $$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$$| $$            ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  |__/ \\______/ |__/ |__/ |__/ \\_______/|_______/    \\___/   \\_______/|__/            ");
            Thread.Sleep(200);
            Console.ResetColor();
            Console.Clear();
        }
        public void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("   /$$                                               /$$                              ");
            Console.WriteLine("  | $$                                              | $$                              ");
            Console.WriteLine("  | $$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$   /$$$$$$$ /$$$$$$    /$$$$$$   /$$$$$$       ");
            Console.WriteLine("  | $$ /$$__  $$| $$_  $$_  $$ |____  $$ /$$_____/|_  $$_/   /$$__  $$ /$$__  $$      ");
            Console.WriteLine("  | $$| $$  \\ $$| $$ \\ $$ \\ $$  /$$$$$$$|  $$$$$$   | $$    | $$$$$$$$| $$  \\__/      ");
            Console.WriteLine("  | $$| $$  | $$| $$ | $$ | $$ /$$__  $$ \\____  $$  | $$ /$$| $$_____/| $$            ");
            Console.WriteLine("  | $$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$$| $$            ");
            Console.WriteLine("  |__/ \\______/ |__/ |__/ |__/ \\_______/|_______/    \\___/   \\_______/|__/            ");
            Console.ResetColor();
        }
        public void MainMenu() {
            Logo();
            Generator g = new Generator();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  Enter gain: ");
            double gain = Convert.ToDouble(Console.ReadLine());
            Console.Write("  Enter frequency: ");
            double freq = Convert.ToDouble(Console.ReadLine());
            Console.Write("  Enter duration (sec): ");
            double duration = Convert.ToDouble(Console.ReadLine());
            Gain = gain;
            Freq = freq;
            Duration = duration;
            TypeMenu();
            
        }
        public void TypeMenu() {
            Generator g = new Generator();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [1] - Sin\n  [2] - Triangle\n  [3] - Square\n  [4] - SawTooth");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  Type: ");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    TypeAudio = "Sin";
                    PrintLog();
                    g.GenerateAudioSin(Gain, Freq, Duration);
                    Console.Clear();
                    MainMenu();
                    break;
                case "2":
                    TypeAudio = "Triangle";
                    PrintLog();
                    g.GenerateAudioTriangle(Gain, Freq, Duration);
                    Console.Clear();
                    MainMenu();
                    break;
                case "3":
                    TypeAudio = "Square";
                    PrintLog();
                    g.GenerateAudioSquare(Gain, Freq, Duration);
                    Console.Clear();
                    MainMenu();
                    break;
                case "4":
                    TypeAudio = "SawTooth";
                    PrintLog();
                    g.GenerateAudioSawTooth(Gain, Freq, Duration);
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("  Type not found!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    LoadLogo();
                    Logo();
                    TypeMenu();
                    break;
            }
        }
        public void PrintLog() {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  Audio start!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  Gain - " + Gain);
            Console.WriteLine("  Type - " + TypeAudio);
            Console.WriteLine("  Frequency - " + Freq + "hz");
            Console.WriteLine("  Duration - " + Duration + "sес");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ----------------------------------------------------------");
        }
        
    }
}
