using Client.Helpers;
using Client.Models;
using System.Text;
using Terminal.Gui;

namespace Client.Logic
{
    public class DialogLogic
    {
        #region Dialogs

        public static Window _ConnectionDialog = new Window(new Rect(7, 7, 70, 16), "Подключение к серверу");

        public static Window _CreationDialog = new Window(new Rect(7, 7, 70, 19), "Создать запись о мелком предмете");

        public static Window _NewBorrowerBindDialog = new Window(new Rect(7, 7, 70, 16), "Создать запись об учащемся, взявшем мелкий предмет");

        public static Window _BorrowerNameUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить имя учащегося, взявшего мелкий предмет");

        public static Window _BorrowerClassUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить класс учащегося, взявшего мелкий предмет");

        public static Window _BorrowerBuildingUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить здание учащегося, взявшего мелкий предмет");

        public static Window _BorrowerDeletionDialog = new Window(new Rect(7, 7, 70, 16), "Удалить запись об учащемся, взявшем мелкий предмет");

        public static Window _GetByIdDialog = new Window(new Rect(7, 7, 70, 16), "Получить запись о мелком предмете по магическому числу");

        public static Window _GetAllDialog = new Window(new Rect(7, 7, 70, 16), "Получить все записи (таблица мелких предметов)");

        public static Window _SearchDialog = new Window(new Rect(7, 7, 70, 16), "Поиск в таблице мелких предметов по названию");

        public static Window _UpdateStateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить состояние мелкого предмета");

        public static Window _UpdateNameDialog = new Window(new Rect(7, 7, 70, 16), "Изменить название мелкого предмета");

        public static Window _UpdateQuantityDialog = new Window(new Rect(7, 7, 70, 16), "Изменить количество мелкого предмета");

        public static Window _UpdateUnitDialog = new Window(new Rect(7, 7, 70, 16), "Изменить единицу измерения мелкого предмета");

        public static Window _UpdateDescriptionDialog = new Window(new Rect(7, 7, 70, 16), "Изменить описание мелкого предмета");

        public static Window _UpdateOwnerDialog = new Window(new Rect(7, 7, 70, 16), "Изменить владельца мелкого предмета");

        public static Window _DeleteDialog = new Window(new Rect(7, 7, 70, 16), "Удалить запись о мелком предмете по магическому числу");

        #endregion

        #region DeleteDialogCtrls

        public static TextField _DeleteDialogIdField = new TextField(2, 2, 35, "Магическое число записи");

        public static Button _DeleteDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _DeleteDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region ConnectionDialogCtrls

        public static TextField _ConnectionDialogIPField = new TextField(2, 2, 25, "IP-адрес REST-сервера");

        public static TextField _ConnectionDialogPortField = new TextField(2, 4, 25, "Порт REST-сервера");

        public static Button _ConnectionDialogYesButton = new Button(2, 12, "Подключение");

        public static Button _ConnectionDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region CreationDialogCtrls

        public static TextField _CreationDialogStateField = new TextField(2, 2, 25, "Состояние");

        public static TextField _CreationDialogNameField = new TextField(2, 4, 25, "Навзание");

        public static TextField _CreationDialogQuantityField = new TextField(2, 6, 25, "Количество");

        public static TextField _CreationDialogUnitField = new TextField(2, 8, 25, "Единица измерения");

        public static TextField _CreationDialogDescField = new TextField(2, 10, 25, "Описание");

        public static TextField _CreationDialogOwnerField = new TextField(2, 12, 25, "Имя владельца");

        public static Button _CreationDialogYesButton = new Button(2, 14, "Отправить");

        public static Button _CreationDialogNoButton = new Button(2, 15, "Отменить");

        #endregion

        #region NewBorrowerBindCtrls

        public static TextField _NewBorrowerBindDialogEntryIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _NewBorrowerBindDialogNameField = new TextField(2, 4, 25, "Имя учащегося");

        public static TextField _NewBorrowerBindDialogClassField = new TextField(2, 6, 25, "Параллель/класс");

        public static TextField _NewBorrowerBindDialogBuildingField = new TextField(2, 8, 25, "Здание");

        public static Button _NewBorrowerBindDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _NewBorrowerBindDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region BorrowerNameUpdateCtrls

        public static TextField _BorrowerNameUpdateDialogIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _BorrowerNameUpdateDialogExpressionField = new TextField(2, 4, 25, "Выражение");

        public static TextField _BorrowerNameUpdateDialogNameField = new TextField(2, 6, 25, "Новое имя");

        public static Button _BorrowerNameUpdateDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _BorrowerNameUpdateDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region BorrowerClassUpdateCtrls

        public static TextField _BorrowerClassUpdateDialogIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _BorrowerClassUpdateDialogExpressionField = new TextField(2, 4, 35, "Выражение");

        public static TextField _BorrowerClassUpdateDialogClassField = new TextField(2, 6, 35, "Новое значение поля класса");

        public static Button _BorrowerClassUpdateDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _BorrowerClassUpdateDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region BorrowerBuildingUpdateCtrls

        public static TextField _BorrowerBuildingUpdateDialogIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _BorrowerBuildingUpdateDialogExpressionField = new TextField(2, 4, 35, "Выражение");

        public static TextField _BorrowerBuildingUpdateDialogBuildingField = new TextField(2, 6, 35, "Новое значение поля здания");

        public static Button _BorrowerBuildingUpdateDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _BorrowerBuildingUpdateDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region BorrowerDeleteCtrls

        public static TextField _BorrowerDeleteDialogIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _BorrowerDeleteDialogExpressionField = new TextField(2, 4, 35, "Выражение");

        public static Button _BorrowerDeleteDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _BorrowerDeleteDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region GetByIdControls

        public static TextField _GetByIdDialogIdField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static Button _GetByIdDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _GetByIdDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region GetAllControls

        public static Label _GetAllDialogServiceLabel = new Label(2, 2, "Отправить запрос на получение всех записей?");

        public static Button _GetAllDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _GetAllDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region SearchControls

        public static TextField _SearchDialogTermTextField = new TextField(2, 2, 25, "Поисковый запрос");

        public static Button _SearchDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _SearchDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateStateControls

        public static TextField _UpdateStateDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateStateDialogStateTextField = new TextField(2, 4, 35, "Новое значение поля состояния");

        public static Button _UpdateStateDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateStateDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateNameControls

        public static TextField _UpdateNameDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateNameDialogNameTextField = new TextField(2, 4, 35, "Новое значение поля названия");

        public static Button _UpdateNameDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateNameDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateQuantityControls

        public static TextField _UpdateQuantityDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateQuantityDialogQuantityTextField = new TextField(2, 4, 35, "Новое значение поля количества");

        public static Button _UpdateQuantityDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateQuantityDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateUnitControls

        public static TextField _UpdateUnitDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateUnitDialogUnitTextField = new TextField(2, 4, 8, "Единица");

        public static Button _UpdateUnitDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateUnitDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateDescriptionControls

        public static TextField _UpdateDescriptionDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateDescriptionDialogDescriptionTextField = new TextField(2, 4, 35, "Новое значение поля описания");

        public static Button _UpdateDescDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateDescDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region UpdateOwnerControls

        public static TextField _UpdateOwnerDialogIdTextField = new TextField(2, 2, 35, "Магическое число мелкого предмета");

        public static TextField _UpdateOwnerDialogOwnerTextField = new TextField(2, 4, 35, "Новое значение поля владельца");

        public static Button _UpdateOwnerDialogYesButton = new Button(2, 12, "Отправить");

        public static Button _UpdateOwnerDialogNoButton = new Button(2, 13, "Отменить");

        #endregion

        #region Methods

        public static void ShowAboutDialog()
        {
            MessageBox.Query("О программе", "Информационная система\nКлиент\nВерсия 1.0-test\n(C) Александр Силицкий и Павел Шмачилин\n2022 г.", "OK");
        }

        public static void ShowConnectionDialog()
        {
            _ConnectionDialog.Add(_ConnectionDialogIPField);
            _ConnectionDialog.Add(_ConnectionDialogPortField);

            _ConnectionDialog.Add(_ConnectionDialogYesButton);
            _ConnectionDialog.Add(_ConnectionDialogNoButton);

            WindowLogic.window.Add(_ConnectionDialog);

            _ConnectionDialogYesButton.Clicked += ShowConnectionDialogYes;
            _ConnectionDialogNoButton.Clicked += ShowConnectionDialogNo;

            _ConnectionDialog.SetFocus();
        }

        private static void ShowConnectionDialogNo()
        {
            _ConnectionDialog.RemoveAll();

            WindowLogic.window.Remove(_ConnectionDialog);

            _ConnectionDialogYesButton.Clicked -= ShowConnectionDialogYes;
            _ConnectionDialogNoButton.Clicked -= ShowConnectionDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowConnectionDialogYes()
        {
            string ip = (string)_ConnectionDialogIPField.Text;
            string port = (string)_ConnectionDialogPortField.Text;

            _ConnectionDialogYesButton.Clicked -= ShowConnectionDialogYes;
            _ConnectionDialogNoButton.Clicked -= ShowConnectionDialogNo;

            _ConnectionDialog.RemoveAll();

            WindowLogic.window.Remove(_ConnectionDialog);

            if (ushort.TryParse(port, out ushort check))
            {
                HTTPLogic.IP = ip;
                HTTPLogic.Port = check;
            } else
            {
                MessageBox.Query("Ошибка", "Неправильный формат числа порта", "OK");
            }
        }

        public static void ShowDeleteDialog()
        {
            _DeleteDialog.Add(_DeleteDialogIdField);

            _DeleteDialog.Add(_DeleteDialogYesButton);
            _DeleteDialog.Add(_DeleteDialogNoButton);

            WindowLogic.window.Add(_DeleteDialog);

            _DeleteDialogYesButton.Clicked += ShowDeleteDialogYes;
            _DeleteDialogNoButton.Clicked += ShowDeleteDialogNo;

            _DeleteDialog.SetFocus();
        }

        private static void ShowDeleteDialogNo()
        {
            _DeleteDialog.RemoveAll();

            WindowLogic.window.Remove(_DeleteDialog);

            _DeleteDialogYesButton.Clicked -= ShowDeleteDialogYes;
            _DeleteDialogNoButton.Clicked -= ShowDeleteDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowDeleteDialogYes()
        {
            string id = (string)_DeleteDialogIdField.Text;

            _DeleteDialogYesButton.Clicked -= ShowDeleteDialogYes;
            _DeleteDialogNoButton.Clicked -= ShowDeleteDialogNo;

            _DeleteDialog.RemoveAll();

            WindowLogic.window.Remove(_DeleteDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.Delete(check);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", $"Учащийся успешно удален", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка удаления записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Удаление мелкого предмета возможно исключительно в случае отсутствия указывающих на него объектов учащихся", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowNewBorrowerBindDialog()
        {
            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogEntryIdField);
            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogNameField);
            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogClassField);
            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogBuildingField);

            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogYesButton);
            _NewBorrowerBindDialog.Add(_NewBorrowerBindDialogNoButton);

            WindowLogic.window.Add(_NewBorrowerBindDialog);

            _NewBorrowerBindDialogYesButton.Clicked += ShowNewBorrowerBindDialogYes;
            _NewBorrowerBindDialogNoButton.Clicked += ShowNewBorrowerBindDialogNo;

            _NewBorrowerBindDialog.SetFocus();
        }

        private static void ShowNewBorrowerBindDialogNo()
        {
            _NewBorrowerBindDialog.RemoveAll();

            WindowLogic.window.Remove(_NewBorrowerBindDialog);

            _NewBorrowerBindDialogYesButton.Clicked -= ShowNewBorrowerBindDialogYes;
            _NewBorrowerBindDialogNoButton.Clicked -= ShowNewBorrowerBindDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowNewBorrowerBindDialogYes()
        {
            string entryId = (string)_NewBorrowerBindDialogEntryIdField.Text;
            string name = (string)_NewBorrowerBindDialogNameField.Text;
            string _class = (string)_NewBorrowerBindDialogClassField.Text;
            string building = (string)_NewBorrowerBindDialogBuildingField.Text;

            _NewBorrowerBindDialogYesButton.Clicked -= ShowNewBorrowerBindDialogYes;
            _NewBorrowerBindDialogNoButton.Clicked -= ShowNewBorrowerBindDialogNo;

            _NewBorrowerBindDialog.RemoveAll();

            WindowLogic.window.Remove(_NewBorrowerBindDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(entryId, out int check))
            {
                status = HTTPLogic.BindNewBorrower(check, new PersonInModel()
                {
                    Name = name,
                    Class = _class,
                    Building = building
                });

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", $"Учащийся успешно добавлен", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка добавления записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }


        public static void ShowBorrowerNameUpdateDialog()
        {
            _BorrowerNameUpdateDialog.Add(_BorrowerNameUpdateDialogIdField);
            _BorrowerNameUpdateDialog.Add(_BorrowerNameUpdateDialogExpressionField);
            _NewBorrowerBindDialog.Add(_BorrowerNameUpdateDialogNameField);

            _BorrowerNameUpdateDialog.Add(_BorrowerNameUpdateDialogYesButton);
            _BorrowerNameUpdateDialog.Add(_BorrowerNameUpdateDialogNoButton);

            WindowLogic.window.Add(_BorrowerNameUpdateDialog);

            _BorrowerNameUpdateDialogYesButton.Clicked += ShowBorrowerNameUpdateDialogYes;
            _BorrowerNameUpdateDialogNoButton.Clicked += ShowBorrowerNameUpdateDialogNo;

            _BorrowerNameUpdateDialog.SetFocus();
        }

        private static void ShowBorrowerNameUpdateDialogYes()
        {
            _BorrowerNameUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerNameUpdateDialog);

            string id = (string)_BorrowerNameUpdateDialogIdField.Text;
            string expr = (string)_BorrowerNameUpdateDialogExpressionField.Text;
            string name = (string)_BorrowerNameUpdateDialogNameField.Text;

            _BorrowerNameUpdateDialogYesButton.Clicked -= ShowBorrowerNameUpdateDialogYes;
            _BorrowerNameUpdateDialogNoButton.Clicked -= ShowBorrowerNameUpdateDialogNo;

            _BorrowerNameUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerNameUpdateDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateBorrowerName(check, expr, name);

                if (status.SuccessRet && status.SuccessDb)
                {
                    
                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");

                   
                }
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        private static void ShowBorrowerNameUpdateDialogNo()
        {
            _BorrowerNameUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerNameUpdateDialog);

            _BorrowerNameUpdateDialogYesButton.Clicked -= ShowBorrowerNameUpdateDialogYes;
            _BorrowerNameUpdateDialogNoButton.Clicked -= ShowBorrowerNameUpdateDialogNo;

            WindowLogic.window.SetFocus();
        }

        public static void ShowBorrowerClassUpdateDialog()
        {
            _BorrowerClassUpdateDialog.Add(_BorrowerClassUpdateDialogIdField);
            _BorrowerClassUpdateDialog.Add(_BorrowerClassUpdateDialogExpressionField);
            _BorrowerClassUpdateDialog.Add(_BorrowerClassUpdateDialogClassField);

            _BorrowerClassUpdateDialog.Add(_BorrowerClassUpdateDialogYesButton);
            _BorrowerClassUpdateDialog.Add(_BorrowerClassUpdateDialogNoButton);

            WindowLogic.window.Add(_BorrowerClassUpdateDialog);

            _BorrowerClassUpdateDialogYesButton.Clicked += ShowBorrowerClassUpdateDialogYes;
            _BorrowerClassUpdateDialogNoButton.Clicked += ShowBorrowerClassUpdateDialogNo;

            _BorrowerClassUpdateDialog.SetFocus();
        }

        private static void ShowBorrowerClassUpdateDialogNo()
        {
            _BorrowerClassUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerClassUpdateDialog);

            _BorrowerClassUpdateDialogYesButton.Clicked -= ShowBorrowerClassUpdateDialogYes;
            _BorrowerClassUpdateDialogNoButton.Clicked -= ShowBorrowerClassUpdateDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowBorrowerClassUpdateDialogYes()
        {
            _BorrowerClassUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerClassUpdateDialog);

            string id = (string)_BorrowerClassUpdateDialogIdField.Text;
            string expr = (string)_BorrowerClassUpdateDialogExpressionField.Text;
            string _class = (string)_BorrowerClassUpdateDialogClassField.Text;

            _BorrowerClassUpdateDialogYesButton.Clicked -= ShowBorrowerClassUpdateDialogYes;
            _BorrowerClassUpdateDialogNoButton.Clicked -= ShowBorrowerClassUpdateDialogNo;

            _BorrowerClassUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerClassUpdateDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateBorrowerClass(check, expr, _class);

                if (status.SuccessRet && status.SuccessDb)
                {
                    
                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");

                   
                }
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowBorrowerBuildingUpdateDialog()
        {
            _BorrowerBuildingUpdateDialog.Add(_BorrowerBuildingUpdateDialogIdField);
            _BorrowerBuildingUpdateDialog.Add(_BorrowerBuildingUpdateDialogExpressionField);
            _BorrowerBuildingUpdateDialog.Add(_BorrowerBuildingUpdateDialogBuildingField);

            _BorrowerBuildingUpdateDialog.Add(_BorrowerBuildingUpdateDialogYesButton);
            _BorrowerBuildingUpdateDialog.Add(_BorrowerBuildingUpdateDialogNoButton);

            WindowLogic.window.Add(_BorrowerBuildingUpdateDialog);

            _BorrowerBuildingUpdateDialogYesButton.Clicked += ShowBorrowerBuildingUpdateDialogYes;
            _BorrowerBuildingUpdateDialogNoButton.Clicked += ShowBorrowerBuildingUpdateDialogNo;

            _BorrowerBuildingUpdateDialog.SetFocus();
        }

        private static void ShowBorrowerBuildingUpdateDialogNo()
        {
            _BorrowerBuildingUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerBuildingUpdateDialog);

            _BorrowerBuildingUpdateDialogYesButton.Clicked -= ShowBorrowerBuildingUpdateDialogYes;
            _BorrowerBuildingUpdateDialogNoButton.Clicked -= ShowBorrowerBuildingUpdateDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowBorrowerBuildingUpdateDialogYes()
        {
            _BorrowerBuildingUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerBuildingUpdateDialog);

            string id = (string)_BorrowerBuildingUpdateDialogIdField.Text;
            string expr = (string)_BorrowerBuildingUpdateDialogExpressionField.Text;
            string build = (string)_BorrowerBuildingUpdateDialogBuildingField.Text;

            _BorrowerBuildingUpdateDialogYesButton.Clicked -= ShowBorrowerBuildingUpdateDialogYes;
            _BorrowerBuildingUpdateDialogNoButton.Clicked -= ShowBorrowerBuildingUpdateDialogNo;

            _BorrowerBuildingUpdateDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerBuildingUpdateDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateBorrowerBuilding(check, expr, build);

                if (status.SuccessRet && status.SuccessDb)
                {
                    
                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");

                  
                }
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowBorrowerDeleteDialog()
        {
            _BorrowerDeletionDialog.Add(_BorrowerDeleteDialogIdField);
            _BorrowerDeletionDialog.Add(_BorrowerDeleteDialogExpressionField);

            _BorrowerDeletionDialog.Add(_BorrowerDeleteDialogYesButton);
            _BorrowerDeletionDialog.Add(_BorrowerDeleteDialogNoButton);

            WindowLogic.window.Add(_BorrowerDeletionDialog);

            _BorrowerDeleteDialogYesButton.Clicked += ShowBorrowerDeleteDialogYes;
            _BorrowerDeleteDialogNoButton.Clicked += ShowBorrowerDeleteDialogNo;

            _BorrowerDeletionDialog.SetFocus();
        }

        private static void ShowBorrowerDeleteDialogNo()
        {
            _BorrowerDeletionDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerDeletionDialog);

            _BorrowerDeleteDialogYesButton.Clicked -= ShowBorrowerDeleteDialogYes;
            _BorrowerDeleteDialogNoButton.Clicked -= ShowBorrowerDeleteDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowBorrowerDeleteDialogYes()
        {
            _BorrowerDeletionDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerDeletionDialog);

            string id = (string)_BorrowerDeleteDialogIdField.Text;
            string expr = (string)_BorrowerDeleteDialogExpressionField.Text;

            _BorrowerDeleteDialogYesButton.Clicked -= ShowBorrowerDeleteDialogYes;
            _BorrowerDeleteDialogNoButton.Clicked -= ShowBorrowerDeleteDialogNo;

            _BorrowerDeletionDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerDeletionDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UnbindBorrower(check, expr);

                if (status.SuccessRet && status.SuccessDb)
                {
                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");

                   
                }
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowGetByIdDialog()
        {
            _GetByIdDialog.Add(_GetByIdDialogIdField);

            _GetByIdDialog.Add(_GetByIdDialogYesButton);
            _GetByIdDialog.Add(_GetByIdDialogNoButton);

            WindowLogic.window.Add(_GetByIdDialog);

            _GetByIdDialogYesButton.Clicked += ShowGetByIdDialogYes;
            _GetByIdDialogNoButton.Clicked += ShowGetByIdDialogNo;

            _GetByIdDialog.SetFocus();
        }

        private static void ShowGetByIdDialogNo()
        {
            _GetByIdDialog.RemoveAll();

            WindowLogic.window.Remove(_GetByIdDialog);

            _GetByIdDialogYesButton.Clicked -= ShowGetByIdDialogYes;
            _GetByIdDialogNoButton.Clicked -= ShowGetByIdDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowGetByIdDialogYes()
        {
            _GetByIdDialog.RemoveAll();

            WindowLogic.window.Remove(_GetByIdDialog);

            string id = (string)_GetByIdDialogIdField.Text;

            _GetByIdDialogYesButton.Clicked -= ShowGetByIdDialogYes;
            _GetByIdDialogNoButton.Clicked -= ShowGetByIdDialogNo;

            _GetByIdDialog.RemoveAll();

            WindowLogic.window.Remove(_GetByIdDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                (EntryOutModel model, status) = HTTPLogic.GetById(check);

                if (status.SuccessRet && status.SuccessDb)
                {
                    

                    int result = MessageBox.Query("Результаты поиска",
                        $"Магическое число: {model.Id}\n" +
                        $"Название: {model.Name}\n" +
                        $"Описание: {model.Description}\n" +
                        $"Состояние: {model.State}\n" +
                        $"Количество: {model.Quantity} {model.Unit}\n" +
                        $"Владелец: {model.Owner}", "OK", "Кто взял?");

                    if (result == 1)
                    {
                        StringBuilder sb = new StringBuilder();

                        if (model.BorrowingPeople.Count > 0)
                        {
                            foreach (var item in model.BorrowingPeople)
                            {
                                sb.AppendLine(item.ToString());
                            }

                            MessageBox.Query("", sb.ToString(), "OK");
                        }
                        else
                        {
                            MessageBox.Query("", "Пусто", "OK");
                        }
                    }
                }
                else
                {
                    int result = MessageBox.Query("Ошибка получения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                            "2) Запись, соответствующая указанному поисковому запросу может не существовать в БД", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowGetAllDialog()
        {
            _GetAllDialog.Add(_GetAllDialogYesButton);
            _GetAllDialog.Add(_GetAllDialogNoButton);

            WindowLogic.window.Add(_GetAllDialog);

            _GetAllDialogYesButton.Clicked += ShowGetAllDialogYes;
            _GetAllDialogNoButton.Clicked += ShowGetAllDialogNo;

            _GetAllDialog.SetFocus();
        }

        private static void ShowGetAllDialogNo()
        {
            _GetAllDialog.RemoveAll();

            WindowLogic.window.Remove(_GetAllDialog);

            _GetAllDialogYesButton.Clicked -= ShowGetAllDialogYes;
            _GetAllDialogNoButton.Clicked -= ShowGetAllDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowGetAllDialogYes()
        {
            _GetAllDialog.RemoveAll();

            WindowLogic.window.Remove(_GetAllDialog);

            _GetAllDialogYesButton.Clicked -= ShowGetAllDialogYes;
            _GetAllDialogNoButton.Clicked -= ShowGetAllDialogNo;

            _GetAllDialog.RemoveAll();

            WindowLogic.window.Remove(_GetAllDialog);

            GetUpdateDeleteStatus status;

            (List<EntryOutModel> models, status) = HTTPLogic.GetAll();

            if (status.SuccessRet && status.SuccessDb)
            {


                StringBuilder sb = new StringBuilder();

                foreach (var item in models)
                {
                    sb.AppendLine(item.ToString());
                }

                int result = MessageBox.Query("", sb.ToString(), "OK", "Справка");

                if (result == 1)
                {
                    MessageBox.Query("Справка", "МЧ -> Магическое число\n" +
                                                             "Назв -> Название\n" +
                                                             "Числ.вз -> Число взявших\n" +
                                                             "Им -> Имя\n" +
                                                            "Кл -> Класс\n" +
                                                            "Зд -> Здание\n", "OK");
                }
            }
            else
            {
                int result = MessageBox.Query("Ошибка получения записей", "ОК", "Справка");

                if (result == 1)
                {
                    MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                        "2) Записи могут не существовать в БД", "OK");
                }
            }
        }

        public static void ShowSearchDialog()
        {
            _SearchDialog.Add(_SearchDialogTermTextField);

            _SearchDialog.Add(_SearchDialogYesButton);
            _SearchDialog.Add(_SearchDialogNoButton);

            WindowLogic.window.Add(_SearchDialog);

            _SearchDialogYesButton.Clicked += ShowSearchDialogYes;
            _SearchDialogNoButton.Clicked += ShowSearchDialogNo;

            _SearchDialog.SetFocus();
        }

        private static void ShowSearchDialogNo()
        {
            _SearchDialog.RemoveAll();

            WindowLogic.window.Remove(_SearchDialog);

            _SearchDialogYesButton.Clicked -= ShowSearchDialogYes;
            _SearchDialogNoButton.Clicked -= ShowSearchDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowSearchDialogYes()
        {
            _SearchDialog.RemoveAll();

            WindowLogic.window.Remove(_SearchDialog);

            string term = (string)_SearchDialogTermTextField.Text;

            _SearchDialogYesButton.Clicked -= ShowSearchDialogYes;
            _SearchDialogNoButton.Clicked -= ShowSearchDialogNo;

            _SearchDialog.RemoveAll();

            WindowLogic.window.Remove(_SearchDialog);

            GetUpdateDeleteStatus status;

            (List<EntryOutModel> models, status) = HTTPLogic.Search(term);

            if (status.SuccessRet && status.SuccessDb)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var item in models)
                {
                    sb.AppendLine(item.ToString());
                }

                int result = MessageBox.Query("", sb.ToString(), "OK", "Справка");

                if (result == 1) MessageBox.Query("Справка", "МЧ -> Магическое число\n" +
                                                             "Назв -> Название\n" +
                                                             "Числ.вз -> Число взявших\n" +
                                                             "Им -> Имя\n" +
                                                            "Кл -> Класс\n" +
                                                            "Зд -> Здание\n", "OK");
            }
            else
            {
                int result = MessageBox.Query("Ошибка получения записи", "ОК", "Справка");

                if (result == 1)
                {
                    MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата.\n" +
                        "2) Запись, соответствующая указанному поисковому запросу может не существовать в БД", "OK");
                }
            }
        }

        public static void ShowUpdateStateDialog()
        {
            _UpdateStateDialog.Add(_UpdateStateDialogIdTextField);
            _UpdateStateDialog.Add(_UpdateStateDialogStateTextField);

            _UpdateStateDialog.Add(_UpdateStateDialogYesButton);
            _UpdateStateDialog.Add(_UpdateStateDialogNoButton);

            WindowLogic.window.Add(_UpdateStateDialog);

            _UpdateStateDialogYesButton.Clicked += ShowUpdateStateDialogYes;
            _UpdateStateDialogNoButton.Clicked += ShowUpdateStateDialogNo;

            _UpdateStateDialog.SetFocus();
        }

        private static void ShowUpdateStateDialogNo()
        {
            _UpdateStateDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateStateDialog);

            _UpdateStateDialogYesButton.Clicked -= ShowUpdateStateDialogYes;
            _UpdateStateDialogNoButton.Clicked -= ShowUpdateStateDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowUpdateStateDialogYes()
        {
            _UpdateStateDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateStateDialog);

            string id = (string)_UpdateStateDialogIdTextField.Text;
            string state = (string)_UpdateStateDialogStateTextField.Text;

            _UpdateStateDialogYesButton.Clicked -= ShowUpdateStateDialogYes;
            _UpdateStateDialogNoButton.Clicked -= ShowUpdateStateDialogNo;

            _UpdateStateDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateStateDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateState(check, state);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowUpdateNameDialog()
        {
            _UpdateNameDialog.Add(_UpdateNameDialogIdTextField);
            _UpdateNameDialog.Add(_UpdateNameDialogNameTextField);

            _UpdateNameDialog.Add(_UpdateNameDialogYesButton);
            _UpdateNameDialog.Add(_UpdateNameDialogNoButton);

            WindowLogic.window.Add(_UpdateNameDialog);

            _UpdateNameDialogYesButton.Clicked += ShowUpdateNameDialogYes;
            _UpdateNameDialogNoButton.Clicked += ShowUpdateNameDialogNo;

            _UpdateNameDialog.SetFocus();
        }

        private static void ShowUpdateNameDialogNo()
        {
            _UpdateNameDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateNameDialog);

            _UpdateNameDialogYesButton.Clicked -= ShowUpdateNameDialogYes;
            _UpdateNameDialogNoButton.Clicked -= ShowUpdateNameDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowUpdateNameDialogYes()
        {

            _UpdateNameDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateNameDialog);

            string id = (string)_UpdateNameDialogIdTextField.Text;
            string name = (string)_UpdateNameDialogNameTextField.Text;

            _UpdateNameDialogYesButton.Clicked -= ShowUpdateNameDialogYes;
            _UpdateNameDialogNoButton.Clicked -= ShowUpdateNameDialogNo;

            _UpdateNameDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateNameDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateName(check, name);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }

        }

        public static void ShowUpdateQuantityDialog()
        {
            _UpdateQuantityDialog.Add(_UpdateQuantityDialogIdTextField);
            _UpdateQuantityDialog.Add(_UpdateQuantityDialogQuantityTextField);

            _UpdateQuantityDialog.Add(_UpdateQuantityDialogYesButton);
            _UpdateQuantityDialog.Add(_UpdateQuantityDialogNoButton);

            WindowLogic.window.Add(_UpdateQuantityDialog);

            _UpdateQuantityDialogYesButton.Clicked += ShowUpdateQuantityDialogYes;
            _UpdateQuantityDialogNoButton.Clicked += ShowUpdateQuantityDialogNo;

            _UpdateQuantityDialog.SetFocus();
        }

        private static void ShowUpdateQuantityDialogNo()
        {
            _UpdateQuantityDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateQuantityDialog);

            _UpdateQuantityDialogYesButton.Clicked -= ShowUpdateQuantityDialogYes;
            _UpdateQuantityDialogNoButton.Clicked -= ShowUpdateQuantityDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowUpdateQuantityDialogYes()
        {
            _UpdateQuantityDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateQuantityDialog);

            string id = (string)_UpdateQuantityDialogIdTextField.Text;
            string quantity = (string)_UpdateQuantityDialogQuantityTextField.Text;

            _UpdateQuantityDialogYesButton.Clicked -= ShowUpdateQuantityDialogYes;
            _UpdateQuantityDialogNoButton.Clicked -= ShowUpdateQuantityDialogNo;

            _UpdateQuantityDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateQuantityDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check) && uint.TryParse(quantity, out uint qcheck))
            {
                status = HTTPLogic.UpdateQuantity(check, qcheck);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowUpdateUnitDialog()
        {
            _UpdateUnitDialog.Add(_UpdateUnitDialogIdTextField);
            _UpdateUnitDialog.Add(_UpdateUnitDialogUnitTextField);

            _UpdateUnitDialog.Add(_UpdateUnitDialogYesButton);
            _UpdateUnitDialog.Add(_UpdateUnitDialogNoButton);

            WindowLogic.window.Add(_UpdateUnitDialog);

            _UpdateUnitDialogYesButton.Clicked += ShowUpdateUnitDialogYes;
            _UpdateUnitDialogNoButton.Clicked += ShowUpdateUnitDialogNo;

            _UpdateUnitDialog.SetFocus();
        }

        private static void ShowUpdateUnitDialogNo()
        {
            _UpdateUnitDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateUnitDialog);

            _UpdateUnitDialogYesButton.Clicked -= ShowUpdateUnitDialogYes;
            _UpdateUnitDialogNoButton.Clicked -= ShowUpdateUnitDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowUpdateUnitDialogYes()
        {
            _UpdateUnitDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateUnitDialog);

            string id = (string)_UpdateUnitDialogIdTextField.Text;
            string unit = (string)_UpdateUnitDialogUnitTextField.Text;

            _UpdateUnitDialogYesButton.Clicked -= ShowUpdateUnitDialogYes;
            _UpdateUnitDialogNoButton.Clicked -= ShowUpdateUnitDialogNo;

            _UpdateUnitDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateUnitDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateUnit(check, unit);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowUpdateDescDialog()
        {
            _UpdateDescriptionDialog.Add(_UpdateDescriptionDialogIdTextField);
            _UpdateDescriptionDialog.Add(_UpdateDescriptionDialogDescriptionTextField);

            _UpdateDescriptionDialog.Add(_UpdateDescDialogYesButton);
            _UpdateDescriptionDialog.Add(_UpdateDescDialogNoButton);

            WindowLogic.window.Add(_UpdateDescriptionDialog);

            _UpdateDescDialogYesButton.Clicked += ShowUpdateDescDialogYes;
            _UpdateDescDialogNoButton.Clicked += ShowUpdateDescDialogNo;

            _UpdateDescriptionDialog.SetFocus();
        }

        private static void ShowUpdateDescDialogYes()
        {
            _UpdateDescriptionDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateDescriptionDialog);

            string id = (string)_UpdateDescriptionDialogIdTextField.Text;
            string desc = (string)_UpdateDescriptionDialogDescriptionTextField.Text;

            _UpdateDescDialogYesButton.Clicked -= ShowUpdateDescDialogYes;
            _UpdateDescDialogNoButton.Clicked -= ShowUpdateDescDialogNo;

            _UpdateDescriptionDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateDescriptionDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateDescription(check, desc);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        private static void ShowUpdateDescDialogNo()
        {
            _UpdateDescriptionDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateDescriptionDialog);

            _UpdateDescDialogYesButton.Clicked -= ShowUpdateDescDialogYes;
            _UpdateDescDialogNoButton.Clicked -= ShowUpdateDescDialogNo;

            WindowLogic.window.SetFocus();
        }

        public static void ShowUpdateOwnerDialog()
        {
            _UpdateOwnerDialog.Add(_UpdateOwnerDialogIdTextField);
            _UpdateOwnerDialog.Add(_UpdateOwnerDialogOwnerTextField);

            _UpdateOwnerDialog.Add(_UpdateOwnerDialogYesButton);
            _UpdateOwnerDialog.Add(_UpdateOwnerDialogNoButton);

            WindowLogic.window.Add(_UpdateOwnerDialog);

            _UpdateOwnerDialogYesButton.Clicked += ShowUpdateOwnerDialogYes;
            _UpdateOwnerDialogNoButton.Clicked += ShowUpdateOwnerDialogNo;

            _UpdateOwnerDialog.SetFocus();
        }

        private static void ShowUpdateOwnerDialogNo()
        {
            _UpdateOwnerDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateOwnerDialog);

            _UpdateOwnerDialogYesButton.Clicked -= ShowUpdateOwnerDialogYes;
            _UpdateOwnerDialogNoButton.Clicked -= ShowUpdateOwnerDialogNo;

            WindowLogic.window.SetFocus();
        }

        private static void ShowUpdateOwnerDialogYes()
        {
            _UpdateOwnerDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateOwnerDialog);

            string id = (string)_UpdateOwnerDialogIdTextField.Text;
            string owner = (string)_UpdateOwnerDialogOwnerTextField.Text;

            _UpdateOwnerDialogYesButton.Clicked -= ShowUpdateOwnerDialogYes;
            _UpdateOwnerDialogNoButton.Clicked -= ShowUpdateOwnerDialogNo;

            _UpdateOwnerDialog.RemoveAll();

            WindowLogic.window.Remove(_UpdateOwnerDialog);

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateOwner(check, owner);

                if (status.SuccessRet && status.SuccessDb) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка изменения записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowCreationDialog()
        {
            _CreationDialog.Add(_CreationDialogStateField);
            _CreationDialog.Add(_CreationDialogNameField);
            _CreationDialog.Add(_CreationDialogQuantityField);
            _CreationDialog.Add(_CreationDialogUnitField);
            _CreationDialog.Add(_CreationDialogDescField);
            _CreationDialog.Add(_CreationDialogOwnerField);

            _CreationDialog.Add(_CreationDialogYesButton);
            _CreationDialog.Add(_CreationDialogNoButton);

            WindowLogic.window.Add(_CreationDialog);

            _CreationDialogYesButton.Clicked += ShowCreationDialogYes;
            _CreationDialogNoButton.Clicked += ShowCreationDialogNo;

            _CreationDialog.SetFocus();
        }

        public static void ShowCreationDialogYes()
        {

            string state = (string)_CreationDialogStateField.Text;
            string name = (string)_CreationDialogNameField.Text;
            string quantity = (string)_CreationDialogQuantityField.Text;
            string unit = (string)_CreationDialogUnitField.Text;
            string desc = (string)_CreationDialogDescField.Text;
            string owner = (string)_CreationDialogOwnerField.Text;

            _CreationDialogYesButton.Clicked -= ShowCreationDialogYes;
            _CreationDialogNoButton.Clicked -= ShowCreationDialogNo;

            _CreationDialog.RemoveAll();

            WindowLogic.window.Remove(_CreationDialog);

            CreateStatus status;

            if (uint.TryParse(quantity, out uint check))
            {
                status = HTTPLogic.Create(new EntryInModel()
                {
                    State = state,
                    Name = name,
                    Quantity = check,
                    Unit = unit,
                    Description = desc,
                    Owner = owner

                });

                if (status.SuccessRet) MessageBox.Query("Сообщение", $"Запись добавлена в БД\nМагическое число: {status.Id}", "OK");
                else
                {
                    int result = MessageBox.Query("Ошибка добавления записи", "ОК", "Справка");

                    if (result == 1)
                    {
                        MessageBox.Query("Справка", "1) Пожалуйста, удостоверьтесь в том, что клиент подключен к узлу информационной системы правильного формата (не БД).\n" +
                            "2) Запись с идентичными значениями может уже быть записана на стороне сервера", "OK");
                    }
                }
            }
            else
            {
                MessageBox.Query("Ошибка", "Неверный формат модели", "OK");
            }
        }

        public static void ShowCreationDialogNo()
        {
            _CreationDialog.RemoveAll();

            WindowLogic.window.Remove(_CreationDialog);

            _CreationDialogYesButton.Clicked -= ShowCreationDialogYes;
            _CreationDialogNoButton.Clicked -= ShowCreationDialogNo;

            WindowLogic.window.SetFocus();
        }

        #endregion
    }
}


