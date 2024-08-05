using State.Interface;
using State.States;

namespace State.Context
{
    public class TraficLightContext
    {
        private ITraficLightState _traficLightState;
        public TraficLightContext()
        {
            _traficLightState = new RedState();
        }
        public void SetState(ITraficLightState changetraficLightState)
        {
            _traficLightState = changetraficLightState;
        }
        public void Request()
        {
            _traficLightState.Handle(this);
        }
    }
}
