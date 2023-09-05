using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Player auto = new Player(25,"Chad", new DeerMount());
            auto.Move();
            auto.Movable = new EagleMount();
            auto.Move();

            Console.ReadLine();
        }
    }

    //IStrategy
    interface IMovable
    {
        void Move();
    }

    //concrete strategy 1
    class DeerMount : IMovable
    {
        private int _ridingSpeed = 50;
        public void Move()
        {
            Console.WriteLine($"Now you are riding with speed {_ridingSpeed}");
        }
    }

    //concrete strategy 2
    class EagleMount : IMovable
    {
        private int _flyingSpeed = 25;
        public void Move()
        {
            Console.WriteLine($"Now you are flying with speed {_flyingSpeed}");
        }
    }

    
    class Player
    {
        protected int _level; 
        protected string _name;

        public Player(int level, string name, IMovable movable)
        {
            this._level = level;
            this._name = name;
            Movable = movable;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Console.Write($"Player: {_name} | Level: {_level} | ");
            Movable.Move();
            Console.WriteLine();
        }
    }
}
