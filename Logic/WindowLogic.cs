using Terminal.Gui;

namespace Client.Logic
{
    public class WindowLogic
    {
        // Общедоступные компоненты

        public static ListView entryList = new ListView(new Rect(1, 2, Console.WindowWidth - 2, Console.WindowHeight - 3), new List<string>());

        public static Label getResults = new Label("Результаты запроса");

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

            #region УДАЛИТЬ ПРИ СБОРКЕ ПОД МАК!!!

            Console.SetWindowSize(400, 300);
            Console.SetBufferSize(400, 300);

            #endregion

            MenuBarItem[] menu = new MenuBarItem[] { new MenuBarItem("Tools", new MenuItem[] {
                new MenuItem("Подключиться к серверу", "", null, () => true),
                new MenuItem("Создать запись о мелком предмете", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Создать запись об учащемся, взявшем мелкий предмет", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить имя учащегося, взявшего мелкий предмет", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить класс учащегося, взявшего мелкий предмет", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить здание учащегося, взявшего мелкий предмет", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Удалить запись об учащемся, взявшем мелкий предмет", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Получить запись о мелком предмете по магическому числу", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Получить все записи (таблица мелких предметов)", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Поиск в таблице мелких предметов по названию", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить состояние мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить название мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить количество мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить единицу измерения мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                new MenuItem("Изменить описание мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                 new MenuItem("Изменить владельца мелкого предмета", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                 new MenuItem("Удалить запись о мелком предмете по магическому числу", "", null, () =>
                 (!((HTTPLogic.IP == null) || (HTTPLogic.IP == String.Empty)))),
                 new MenuItem("О программе", "", null, () => true)
            }) };


            top.Add(new MenuBar(menu));

            window.Add(getResults);

            window.Add(entryList);



            top.Add(window);

            Application.Run();

        }
    }
}

