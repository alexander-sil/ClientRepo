using System;
using Terminal.Gui;

namespace Client.Logic
{
    public class WindowLogic
    {
        // Общедоступные компоненты

        public static ListView fileList = new ListView(new Rect(1, 2, Console.WindowWidth - 2, Console.WindowHeight - 3), MainLogic.View);

        public static Button goUpButton = new Button("Back");

        public static Window window = new Window("REST Client")
        {
            X = 0,
            Y = 1,

            Width = Dim.Fill(),
            Height = Dim.Fill()
        };


        // Стартовый метод

        public static void Execute()
        {

            Toplevel top = Application.Top;

            Console.Title = "Клиент информационной системы";

            Application.Init();

            top = Application.Top;


            MenuBarItem[] menu = new MenuBarItem[] { new MenuBarItem("Tools", new MenuItem[] {
                 new MenuItem("Подключиться к серверу", "", null, () => true),
                 new MenuItem("Добавить запись о товаре", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                 new MenuItem("Добавить запись о товаре", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                 new MenuItem("О программе", "", null, () => true)
            }) };


            top.Add(new MenuBar(menu));

            window.Add(fileList);

            window.Add(goUpButton);

            top.Add(window);

            Application.Run();

        }
    }
}

