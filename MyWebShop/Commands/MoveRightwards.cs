namespace MyWebShop.Commands;

public class MoveRightwards : ICommand
{
    private IKeyboard keyBoard;


    public MoveRightwards(IKeyboard keyBoard) {
        this.keyBoard = keyBoard;
    }

    public void execute() {
        keyBoard.Right();
    }
}