using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_12
{
    public class House
    {
        private int Id { get; set; } = 1;
        private static int Idk = 0;
        private double height;
        private int floor;
        private int flat;
        private int poarch;

        public House(double height,int floor, int flat,int poarch)
        {
            Idk++;
            Id = Idk;
            this.height = height;
            this.floor = floor;
            this.flat = flat;
            this.poarch = poarch;
        }

        public double Height { get { return height; } set { height = value; } }
        public int Floor { get { return floor; } set { floor = value; } }
        public int Flat { get { return flat; } set { flat = value; } }
        public int Poarch { get { return poarch; } set { poarch= value; } }

        public void heightfloor()
        {
            Console.WriteLine($"Высота этажа {height / floor} метров");
        }
        private int flatinporch()
        {
            return flat / poarch;
        }
        private int flatinfloor()
        {
            return flatinporch() / floor;
        }
        public void flatinf()
        {
            Console.WriteLine($"В подъезде: {flatinporch()} квартир, а на этаже {flatinfloor()} квартиры");
        }

        public void Print()
        {
            Console.WriteLine($"Номер: {Id}, Высота: {height}, Этажность: {floor},Количество квартир: {flat}, Количество подъездов: {poarch} ");

        }
    }
}
