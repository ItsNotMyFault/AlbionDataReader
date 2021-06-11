using Albion.Network;
using System;
using System.Collections.Generic;

namespace albion_data_reader_new.handlers
{
    public class FameEvent : BaseEvent
    {
        public float BonusFactor;
        public byte GroupSize;
        public bool IsPremiumBonus;
        public int UsedItemType;
        public FameEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Console.WriteLine($"event fame update");
            Console.WriteLine(parameters.ToString());
            try
            {
                //Debug.Print($"----- UpdateFame (Events) -----");
                //foreach (var parameter in parameters)
                //{
                //    Debug.Print($"{parameter}");
                //}



                if (parameters.ContainsKey(3)) GroupSize = parameters[3] as byte? ?? 0;


                if (parameters.ContainsKey(5)) IsPremiumBonus = parameters[5] as bool? ?? false;

                if (parameters.ContainsKey(6)) BonusFactor = parameters[6] as float? ?? 0;


                if (parameters.ContainsKey(252)) {
                    UsedItemType = (int)parameters[252];
                }


                var gg = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine($"event fame update ERROR => {e.Message}");
            }
        }
    }
}
