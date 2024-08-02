using Command.Commands;
using Command.Interface;
using Command.Invoker;
using Command.Receiver;

public class TVRemoteControlTest
{
    public static void Main(string[] args)
    {
        TV tv = new TV();

        ITvCommand turnOnTV = new TurnOnTVCommand(tv);
        ITvCommand turnOffTV = new TurnOffTvCommand(tv);
        ITvCommand changeChannel = new ChangeChannelCommand(tv, 5);
        ITvCommand changeChannel1 = new ChangeChannelCommand(tv, 1);
        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOnTV);
        remote.PressButton();

        remote.SetCommand(changeChannel);
        remote.PressButton();

        remote.SetCommand(changeChannel1);
        remote.PressButton();

        remote.Undo();

        remote.SetCommand(turnOffTV);
        remote.PressButton();

    }
}
