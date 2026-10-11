namespace ConsoleStuff;

/// <summary>
/// Command to exit the program
/// </summary>
public class ExitCommand : Command {

    /// <summary>
    /// Constructor.
    /// </summary>
    public ExitCommand(Menu menu) {
        this.menu = menu;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "Exit";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        this.menu.Exit();
    }
}
