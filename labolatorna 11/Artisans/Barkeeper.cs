using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labolatorna_11.Observer_Pattern;

namespace labolatorna_11.Artisans
{
    class Barkeeper : Artistant, IObserverLaba
    {
        private Dictionary<int, string> actionDictionary = new()
        {
            {16, "починає варити пиво"}, {17 , " вiдчиняє шинок" },{23, "зачиняє шинок"}
        };
        public void DoAction(int actionNum)
        {
            if (actionDictionary.ContainsKey(actionNum)) Console.WriteLine($"Шинкар робить : {actionDictionary[actionNum]}");
        }
        public void Update(int time)
        {
            DoAction(time);
        }
    }
}
