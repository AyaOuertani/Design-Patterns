using Command.Interface;
using Command.Receiver;
namespace Command.Commands
{
    public class ChangeChannelCommand : ITvCommand
    {
        private TV _TV;
        private int _Channel;
        private int _PreviousChannel;
        public ChangeChannelCommand(TV tv, int channel)
        {
            _TV = tv;
            _Channel = channel;
        }
        public void Execute()
        {
            _PreviousChannel = _TV.GetCurrentChannel();
            _TV.ChangeChannel(_Channel);
        }
        public void Undo()
        {
            _TV.ChangeChannel(_PreviousChannel);
        }
    }
}
