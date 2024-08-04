namespace Command.Receiver
{
    public class TV
    {
        private int _CurrentChannel;
        public void TurnOn() => Console.WriteLine("TV is ON.");
        public void TurnOff() => Console.WriteLine("TV is OFF.");

        public void ChangeChannel(int channel)
        {
            _CurrentChannel = channel;
            Console.WriteLine($"TV channel changed to {_CurrentChannel}.");
        }

        public int GetCurrentChannel()
        {
            return _CurrentChannel;
        }
    }
}
