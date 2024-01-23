﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DesignOfLibrary
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string filePath = "auth.txt";
            String settings = "";

            try
            {
                settings = File.ReadAllText(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMainMenu(settings));
        }
    }
}
