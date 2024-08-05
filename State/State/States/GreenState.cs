using State.Context;
using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace State.States
{
    public class GreenState : ITraficLightState
    {
        public void Handle (TraficLightContext traficLightContext)
        {
            Console.WriteLine("Green Is Up.Go!");
            traficLightContext.SetState(new YellowState());
        }
    }
}
