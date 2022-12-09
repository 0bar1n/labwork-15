using System;

namespace labwork_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Удалить часть строки (заключенную в скобки)"; //задние изначальной строки со скобками
            char[] text_ar = text.ToCharArray(); //создание массива
            bool flag = true; //задание логической переменной
            string res = string.Empty; //задание пустой строки

            for (int i = 0; i < text_ar.Length; i++) //цикл, пока верно условие
            {
                if (text_ar[i] == '(') flag = false; //задание логического значения, если на некотором индексе строки открывающая скобка
                else if (text_ar[i] == ')') flag = true; //задание логического значения, если на некотором индексе строки закрывающая скобка
                else if (flag) res += text_ar[i]; //замена содржимого скобок на пустую строку
            }

            Console.WriteLine(res); //вывод строки без скобок
            Console.ReadLine(); //программа ожидает нажатия клавиши для завершения работы
        }
    }
}
