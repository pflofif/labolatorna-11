using System;
using System.Collections.Generic;
using labolatorna_11.Observer_Pattern;

namespace labolatorna_11.Artisans
{
    class Baker : Artistant, IObserverLaba
    {
        private Dictionary<int, string> actionDictionary = new()
        {
            {4, "Розпалити пiч"}, {5 , "Замiсити тiсто" },{6, "Поставити тiсто випiкатись"}, 
            {7 , "Витягти випiчку з печi" },{8, "вiдкрити пекарню"}, {16 , "Зачинити пекарню" },
        };
        public void DoAction(int actionNum)
        {
            if (actionDictionary.ContainsKey(actionNum)) Console.WriteLine($"Пекар робить : {actionDictionary[actionNum]}");
        }
        public void Update(int time)
        {
            DoAction(time);
        }
    }
}