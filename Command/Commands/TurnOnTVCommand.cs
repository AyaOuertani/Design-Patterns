using Command.Interface;
using Command.Receiver;
namespace Command.Commands
{
    public class TurnOnTVCommand : ITvCommand
    {
        private readonly TV _TV;
        public TurnOnTVCommand(TV tv)
        {
            _TV = tv;
        }
        public void Execute()
        {
            _TV.TurnOn();
        }

        public void Undo()
        {
            _TV.TurnOff();
        }
    }
}
