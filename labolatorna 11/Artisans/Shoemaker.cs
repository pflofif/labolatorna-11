using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labolatorna_11.Observer_Pattern;

namespace labolatorna_11.Artisans
{
    class Shoemaker : Artistant, IObserverLaba
    {
        private Dictionary<int, string> actionDictionary = new()
        {
            {10, "Вiдкрити майстерню"}, {11 , "випиває гальбу пива" },{15, "починає спiвати пiсню"}, {18 , "зачиняє майстерню i йде до шинку" }
        };
        public void DoAction(int actionNum)
        {
            if (actionDictionary.ContainsKey(actionNum)) Console.WriteLine($"Чоботяр робить : {actionDictionary[actionNum]}");
        }
        public void Update(int time)
        {
            DoAction(time);
        }
    }
}
