namespace MyWebShop.Commands;

public class KeyboardKeysReceiver
{
    private ICommand command;

    public KeyboardKeysReceiver(ICommand command) {
        this.command = command;
    }

    public void press() {
        command.execute();
    }
}