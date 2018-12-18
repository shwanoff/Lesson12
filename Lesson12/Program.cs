using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашнее задание

            // В вашей предметной области определить базовый класс и несколько наследников
            // Создать класс, который будет принимать в качестве универсального типа базовый класс
            // Поэкспериментировать с универсальными типами

            var eating = new Eating<Banana>();

            var list = new List<int>();
            var map = new Dictionary<string, string>();
            map.Add("5", "Пять");
            map.Add("5", "Пять");
        }
    }
}
