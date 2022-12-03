using Client.Helpers;
using Client.Models;
using Terminal.Gui;

namespace Client.Logic
{
    public class DialogLogic
    {
        #region Dialogs

        public static Window _ConnectionDialog = new Window(new Rect(7, 7, 70, 16), "Подключение к серверу");

        public static Window _CreationDialog = new Window(new Rect(7, 7, 70, 16), "Создать запись о мелком предмете");

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

        public static Window _ShowPeopleDialog = new Window(new Rect(7, 7, 70, 16), "Учащиеся, взявшие данный мелкий предмет");

        #endregion

        #region ConnectionDialogCtrls

        public static TextField _ConnectionDialogIPField = new TextField("IP-адрес REST-сервера");

        public static TextField _ConnectionDialogPortField = new TextField("Порт REST-сервера");

        public static Button _ConnectionDialogYesButton = new Button("Подключение");

        public static Button _ConnectionDialogNoButton = new Button("Отменить");

        #endregion

        #region CreationDialogCtrls

        public static TextField _CreationDialogStateField = new TextField("Состояние");

        public static TextField _CreationDialogNameField = new TextField("Навзание");

        public static TextField _CreationDialogQuantityField = new TextField("Количество");

        public static TextField _CreationDialogUnitField = new TextField("Единица измерения");

        public static TextField _CreationDialogDescField = new TextField("Описание");

        public static TextField _CreationDialogOwnerField = new TextField("Имя владельца");

        public static Button _CreationDialogYesButton = new Button("Отправить");

        public static Button _CreationDialogNoButton = new Button("Отменить");

        #endregion

        #region NewBorrowerBindCtrls

        public static TextField _NewBorrowerBindDialogEntryIdField = new TextField("Магическое число мелкого предмета");

        public static TextField _NewBorrowerBindDialogNameField = new TextField("Имя учащегося");

        public static TextField _NewBorrowerBindDialogClassField = new TextField("Параллель/класс");

        public static TextField _NewBorrowerBindDialogBuildingField = new TextField("Здание");

        public static Button _NewBorrowerBindDialogYesButton = new Button("Отправить");

        public static Button _NewBorrowerBindDialogNoButton = new Button("Отменить");

        #endregion

        #region BorrowerNameUpdateCtrls

        public static TextField _BorrowerNameUpdateDialogIdField = new TextField("Магическое число мелкого предмета");

        public static TextField _BorrowerNameUpdateDialogExpressionField = new TextField("Выражение");

        public static TextField _BorrowerNameUpdateDialogNameField = new TextField("Новое имя");

        public static Button _BorrowerNameUpdateDialogYesButton = new Button("Отправить");

        public static Button _BorrowerNameUpdateDialogNoButton = new Button("Отменить");

        #endregion

        #region BorrowerClassUpdateCtrls

        public static TextField _BorrowerClassUpdateDialogIdField = new TextField("Магическое число мелкого предмета");

        public static TextField _BorrowerClassUpdateDialogExpressionField = new TextField("Выражение");

        public static TextField _BorrowerClassUpdateDialogClassField = new TextField("Новое значение поля класса");

        public static Button _BorrowerClassUpdateDialogYesButton = new Button("Отправить");

        public static Button _BorrowerClassUpdateDialogNoButton = new Button("Отменить");

        #endregion

        #region BorrowerBuildingUpdateCtrls

        public static TextField _BorrowerBuildingUpdateDialogIdField = new TextField("Магическое число мелкого предмета");

        public static TextField _BorrowerBuildingUpdateDialogExpressionField = new TextField("Выражение");

        public static TextField _BorrowerBuildingUpdateDialogBuildingField = new TextField("Новое значение поля здания");

        public static Button _BorrowerBuildingUpdateDialogYesButton = new Button("Отправить");

        public static Button _BorrowerBuildingUpdateDialogNoButton = new Button("Отменить");

        #endregion

        #region BorrowerDeleteCtrls

        public static TextField _BorrowerDeleteDialogIdField = new TextField("Магическое число мелкого предмета");

        public static TextField _BorrowerDeleteDialogExpressionField = new TextField("Выражение");

        public static Button _BorrowerDeleteDialogYesButton = new Button("Отправить");

        public static Button _BorrowerDeleteDialogNoButton = new Button("Отменить");

        #endregion

        #region GetByIdControls

        public static TextField _GetByIdDialogIdField = new TextField("Магическое число мелкого предмета");

        public static Button _GetByIdDialogYesButton = new Button("Отправить");

        public static Button _GetByIdDialogNoButton = new Button("Отменить");

        #endregion

        #region GetAllControls

        public static Label _GetAllDialogServiceLabel = new Label("Отправить запрос на получение всех записей?");

        public static Button _GetAllDialogYesButton = new Button("Отправить");

        public static Button _GetAllDialogNoButton = new Button("Отменить");

        #endregion

        #region SearchControls

        public static TextField _SearchDialogTermTextField = new TextField("Поисковый запрос");

        public static Button _SearchDialogYesButton = new Button("Отправить");

        public static Button _SearchDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateStateControls

        public static TextField _UpdateStateDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateStateDialogStateTextField = new TextField("Новое значение поля состояния");

        public static Button _UpdateStateDialogYesButton = new Button("Отправить");

        public static Button _UpdateStateDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateNameControls

        public static TextField _UpdateNameDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateNameDialogNameTextField = new TextField("Новое значение поля названия");

        public static Button _UpdateNameDialogYesButton = new Button("Отправить");

        public static Button _UpdateNameDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateQuantityControls

        public static TextField _UpdateQuantityDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateQuantityDialogQuantityTextField = new TextField("Новое значение поля количества");

        public static Button _UpdateQuantityDialogYesButton = new Button("Отправить");

        public static Button _UpdateQuantityDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateUnitControls

        public static TextField _UpdateUnitDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateUnitDialogUnitTextField = new TextField("Новое значение поля единицы измерения");

        public static Button _UpdateUnitDialogYesButton = new Button("Отправить");

        public static Button _UpdateUnitDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateDescriptionControls

        public static TextField _UpdateDescriptionDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateDescriptionDialogDescriptionTextField = new TextField("Новое значение поля описания");

        public static Button _UpdateDescDialogYesButton = new Button("Отправить");

        public static Button _UpdateDescDialogNoButton = new Button("Отменить");

        #endregion

        #region UpdateOwnerControls

        public static TextField _UpdateOwnerDialogIdTextField = new TextField("Магическое число мелкого предмета");

        public static TextField _UpdateOwnerDialogOwnerTextField = new TextField("Новое значение поля владельца");

        public static Button _UpdateOwnerDialogYesButton = new Button("Отправить");

        public static Button _UpdateOwnerDialogNoButton = new Button("Отменить");

        #endregion

        #region ShowPeopleCtrls

        public static ListView _ShowPeopleBorrowerList = new ListView(new List<PersonOutModel>());

        public static Button _ShowPeopleDialogExitButton = new Button("Возврат");

        #endregion

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
            throw new NotImplementedException();
        }

        private static void ShowNewBorrowerBindDialogYes()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static void ShowBorrowerNameUpdateDialogNo()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static void ShowBorrowerClassUpdateDialogYes()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static void ShowBorrowerBuildingUpdateDialogYes()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static void ShowBorrowerDeleteDialogYes()
        {
            _BorrowerDeletionDialog.RemoveAll();

            WindowLogic.window.Remove(_BorrowerDeletionDialog);

            string id = (string)_BorrowerDeleteDialogIdField.Text;

            _BorrowerDeleteDialogYesButton.Clicked -= ShowBorrowerDeleteDialogYes;
            _BorrowerDeleteDialogNoButton.Clicked -= ShowBorrowerDeleteDialogNo;

            _BorrowerDeletionDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                (EntryOutModel model, status) = HTTPLogic.GetById(check);

                if (status.SuccessRet)
                {
                    MainLogic.EntryView.Clear();

                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                    MainLogic.EntryView.Add(model);

                    WindowLogic.UpdateView();
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
            throw new NotImplementedException();
        }

        private static void ShowGetByIdDialogYes()
        {
            _GetByIdDialog.RemoveAll();

            WindowLogic.window.Remove(_GetByIdDialog);

            string id = (string)_GetByIdDialogIdField.Text;

            _GetByIdDialogYesButton.Clicked -= ShowGetByIdDialogYes;
            _GetByIdDialogNoButton.Clicked -= ShowGetByIdDialogNo;

            _GetByIdDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                (EntryOutModel model, status) = HTTPLogic.GetById(check);

                if (status.SuccessRet)
                {
                    MainLogic.EntryView.Clear();

                    MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
                    MainLogic.EntryView.Add(model);

                    WindowLogic.UpdateView();
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
            throw new NotImplementedException();
        }

        private static void ShowGetAllDialogYes()
        {
            _GetAllDialog.RemoveAll();

            WindowLogic.window.Remove(_GetAllDialog);

            _GetAllDialogYesButton.Clicked -= ShowGetAllDialogYes;
            _GetAllDialogNoButton.Clicked -= ShowGetAllDialogNo;

            _GetAllDialog.SetFocus();

            GetUpdateDeleteStatus status;

            (List<EntryOutModel> models, status) = HTTPLogic.GetAll();

            if (status.SuccessRet)
            {
                MainLogic.EntryView.Clear();

                MessageBox.Query("Сообщение", "Запись успешно получена", "OK");
                MainLogic.EntryView.AddRange(models);

                WindowLogic.UpdateView();
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

            _SearchDialog.SetFocus();

            GetUpdateDeleteStatus status;

            (List<EntryOutModel> models, status) = HTTPLogic.Search(term);

            if (status.SuccessRet)
            {
                MainLogic.EntryView.Clear();

                MessageBox.Query("Сообщение", "Запись успешно получена", "OK");
                MainLogic.EntryView.AddRange(models);

                WindowLogic.UpdateView();
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

            _UpdateStateDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateState(check, state);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _UpdateUnitDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateName(check, name);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _UpdateUnitDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check) && uint.TryParse(quantity, out uint qcheck))
            {
                status = HTTPLogic.UpdateQuantity(check, qcheck);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _UpdateUnitDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateUnit(check, unit);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _UpdateDescriptionDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateDescription(check, desc);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _UpdateOwnerDialog.SetFocus();

            GetUpdateDeleteStatus status;

            if (int.TryParse(id, out int check))
            {
                status = HTTPLogic.UpdateOwner(check, owner);

                if (status.SuccessRet) MessageBox.Query("Сообщение", "Запись успешно изменена", "OK");
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

            _CreationDialog.SetFocus();

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
    }
}


