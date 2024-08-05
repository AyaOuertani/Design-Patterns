using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Context;

namespace State.States
{
    public class RedState :  ITraficLightState
    {
        public void Handle (TraficLightContext traficLightContext)
        {
            Console.WriteLine("Red is Up . Stop !");
            traficLightContext.SetState(new GreenState());
        }
    }
}
