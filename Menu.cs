using System;
using System.Buffers;

namespace EditorHtml {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DropScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }
        public static void DropScreen() {

            CreateRowTopAndBottom("-", "+", "\n");
            CreateLines("|", "\n");
            CreateRowTopAndBottom("-", "+", "\n");
        }
        public static void WriteOptions() {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("================================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option){
            switch(option){
                case 0 : {
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                }
                case 1 : Editor.Show(); break;
                // case 2 : Viewer.Show(); break;
                default: Show(); break;
            }
        }
        static void CreateLines(string? column, string? stopRow){
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write(column);
                CreateBetweenMiddle(" ");
                Console.Write(column);
                Console.Write(stopRow);
            }
        }

        static void CreateBetweenMiddle(string? caracter){
            for (int i = 0; i <= 38; i++)
            {
                Console.Write(caracter);
            }
        }
        
        static void CreateRowTopAndBottom(string? caracter, string? separator, string? stopRow){
            Console.Write(separator);
            for (int i = 0; i <= 38; i++)
            {
                // Seta o carater para criação da linha no top ou bottom
                Console.Write(caracter);
            }
            Console.Write(separator);
            Console.Write(stopRow);
        }
    }
}