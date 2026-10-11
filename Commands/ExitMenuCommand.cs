namespace ConsoleStuff;

/// <summary>
/// Command to exit a menu
/// </summary>
public class ExitMenuCommand : Command {

    /// <summary>
    /// Constructor.
    /// </summary>
    public ExitMenuCommand(Menu menu) {
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
