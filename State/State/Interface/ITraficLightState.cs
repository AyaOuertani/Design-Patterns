using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Context;

namespace State.Interface
{
    public interface ITraficLightState
    {
        public void Handle(TraficLightContext traficLightContext);
    }
}
