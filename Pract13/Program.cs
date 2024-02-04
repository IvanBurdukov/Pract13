using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract13
{
    // Базовый класс Building
    class Building
    {
        // Поля класса Building
        private string address;
        private double length;
        private double width;
        private double height;

        // Конструктор с 4 параметрами
        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        // Свойства get/set для доступа к полям класса
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Метод для вывода информации о здании
        public void Print()
        {
            Console.WriteLine("Адрес: {0}", address);
            Console.WriteLine("Длина: {0}", length);
            Console.WriteLine("Ширина: {0}", width);
            Console.WriteLine("Высота: {0}", height);
        }
    }

    // Класс MultiBuilding, наследующий Building
    sealed class MultiBuilding : Building
    {
        // Поле класса MultiBuilding
        private int floors;

        // Конструктор с 5 параметрами
        public MultiBuilding(string address, double length, double width, double height, int floors) : base(address, length, width, height)
        {
            this.floors = floors;
        }

        // Свойство get/set для доступа к внутреннему полю класса
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        // Переопределенный метод Print() для вывода информации о многоэтажном здании
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0}", floors);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Улица Пушкина, дом Колотушкина", 10.5, 7.8, 25.3);
            Console.WriteLine("Информация о здании:");
            building.Print();

            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding("Улица Лермонтова, дом Калашникова", 20.2, 15.7, 35.8, 5);
            Console.WriteLine("Информация о многоэтажном здании:");
            multiBuilding.Print();
        }
    }
}