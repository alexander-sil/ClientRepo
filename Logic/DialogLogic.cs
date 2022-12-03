using System;
using Terminal.Gui;

namespace Client.Logic
{
    public class DialogLogic
    {
        #region Dialogs

        private static Window _CreationDialog = new Window(new Rect(7, 7, 70, 16), "Создать запись о мелком предмете");

        private static Window _NewBorrowerBindDialog = new Window(new Rect(7, 7, 70, 16), "Создать запись об учащемся, взявшем мелкий предмет");

        private static Window _BorrowerNameUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить имя учащегося, взявшего мелкий предмет");

        private static Window _BorrowerClassUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить класс учащегося, взявшего мелкий предмет");

        private static Window _BorrowerBuildingUpdateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить здание учащегося, взявшего мелкий предмет");

        private static Window _BorrowerDeletionDialog = new Window(new Rect(7, 7, 70, 16), "Удалить запись об учащемся, взявшем мелкий предмет");

        private static Window _GetByIdDialog = new Window(new Rect(7, 7, 70, 16), "Получить запись о мелком предмете по магическому числу");

        private static Window _GetAllDialog = new Window(new Rect(7, 7, 70, 16), "Получить все записи (таблица мелких предметов)");

        private static Window _SearchDialog = new Window(new Rect(7, 7, 70, 16), "Поиск в таблице мелких предметов по названию");

        private static Window _UpdateStateDialog = new Window(new Rect(7, 7, 70, 16), "Изменить состояние мелкого предмета");

        private static Window _UpdateNameDialog = new Window(new Rect(7, 7, 70, 16), "Изменить название мелкого предмета");

        private static Window _UpdateQuantityDialog = new Window(new Rect(7, 7, 70, 16), "Изменить количество мелкого предмета");

        private static Window _UpdateUnitDialog = new Window(new Rect(7, 7, 70, 16), "Изменить единицу измерения мелкого предмета");

        private static Window _UpdateDescriptionDialog = new Window(new Rect(7, 7, 70, 16), "Изменить описание мелкого предмета");

        private static Window _UpdateOwnerDialog = new Window(new Rect(7, 7, 70, 16), "Изменить владельца мелкого предмета");

        private static Window _DeleteDialog = new Window(new Rect(7, 7, 70, 16), "Удалить запись о мелком предмете по магическому числу");

        #endregion

        #region CreationDialogCtrls

        private static TextField _CreationDialogStateField = new TextField("Состояние");

        private static TextField _CreationDialogNameField = new TextField("Навзание");

        private static TextField _CreationDialogQuantityField = new TextField("Количество");

        private static TextField _CreationDialogUnitField = new TextField("Единица измерения");

        private static TextField _CreationDialogDescField = new TextField("Описание");

        private static TextField _CreationDialogOwnerField = new TextField("Имя владельца");

        private static Button _CreationDialogYesButton = new Button("Отправить");

        private static Button _CreationDialogNoButton = new Button("Отменить");

        #endregion

        #region NewBorrowerBindCtrls

        private static TextField _NewBorrowerBindDialogNameField = new TextField("Имя учащегося");

        private static TextField _NewBorrowerBindDialogClassField = new TextField("Параллель/класс");

        private static TextField _NewBorrowerBindDialogBuildingField = new TextField("Здание");

        private static Button _NewBorrowerBindDialogYesButton = new Button("Отправить");

        private static Button _NewBorrowerBindDialogNoButton = new Button("Отменить");

        #endregion


        #region BorrowerNameUpdateCtrls



        private static TextField _BorrowerNameUpdateDialogClassField = new TextField();

        private static TextField _BorrowerNameUpdateDialogBuildingField = new TextField();

        private static Button _BorrowerNameUpdateDialogYesButton = new Button("Отправить");

        private static Button _NewBorrowerBindDialogNoButton = new Button("Отменить");

        #endregion

    }
}


