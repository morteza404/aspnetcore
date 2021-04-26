using System;

namespace EventsApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();

            var john = new Person("john", tower);

            var sally = new Person("sally", tower);

            tower.ChimeFivePM();
        }
    }

    public class Person
    {
        private string _name;

        private ClockTower _tower;

        public Person(string name, ClockTower tower)
        {
            _name = name;
            _tower = tower;

            _tower.Chime += () => Console.WriteLine("{0} heard the class chime.", _name);

        }

      
    }

    public delegate void ChimeEventHandler();
    public class ClockTower
    {
        public event ChimeEventHandler Chime;
        public void ChimeFivePM()
        {
            Chime();
        }
        public void ChimeSixAM()
        {
            Chime();
        }
    }
}
