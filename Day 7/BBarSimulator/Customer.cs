using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBarSimulator
{
    class Customer
    {
        public string Name { get; private set; }

        private Bar bar;

        public Customer(string name, Bar bar)
        {
            Name = name;
            this.bar = bar;
        }

        enum PartyAction { Walk, VisitBar, GoHome };
        enum BarAction { Drink, Dance, Leave };

        static Random rand = new Random();

        private PartyAction GetRandomPartyAction()
        {
            return (PartyAction)rand.Next(3);
        }
        private BarAction GetRandomBarAction()
        {
            return (BarAction)rand.Next(3);
        }

        private bool inBar;

        public void PaintTheTownRed()
        {
            inBar = false;
            while (true)
            {
                if (inBar)
                {
                    var barAction = GetRandomBarAction();
                    switch (barAction)
                    {
                        case BarAction.Dance:
                            Console.WriteLine($"{Name} is dancing.");
                            break;
                        case BarAction.Drink:
                            Console.WriteLine($"{Name} is drinking.");
                            break;
                        case BarAction.Leave:
                            Console.WriteLine($"{Name} is leaving the bar.");
                            bar.Leave(this);
                            inBar = false;
                            break;
                        default:
                            throw new NotSupportedException("Unsupported bar action");
                    }
                }
                else
                {
                    var partyAction = GetRandomPartyAction();
                    switch (partyAction)
                    {
                        case PartyAction.VisitBar:
                            bar.Enter(this);
                            inBar = true;
                            Console.WriteLine($"{Name} entered the bar.");
                            break;
                        case PartyAction.GoHome:
                            Console.WriteLine($"{Name} is going home to sleep.");
                            return;
                        case PartyAction.Walk:
                            Console.WriteLine($"{Name} is roaming the streets");
                            break;
                        default:
                            throw new NotSupportedException("Party action not supported.");
                    }
                }
            }
        }
    }
}
