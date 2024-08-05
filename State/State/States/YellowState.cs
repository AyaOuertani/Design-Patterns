using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Context;

namespace State.States
{
    public class YellowState : ITraficLightState
    {
        public void Handle(TraficLightContext traficLightContext)
        {
            Console.WriteLine("Yellow is Up .Prepare to Stop (No cheating :) )!");
            traficLightContext.SetState(new RedState());
        }
    }
}
