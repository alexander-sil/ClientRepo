﻿using Client.Logic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WindowLogic.Execute();
            }
            catch (Exception ex)
            {
                int x = MessageBox.Query("Ошибка", $"Пожалуйста, обратитесь к системному администратору.\nСообщение для отладки: {ex.Message}", "OK");
            }

        }
    }
}


