namespace ConsoleStuff;

/// <summary>
/// Command to exit a menu
/// </summary>
public class ExitMenuCommand : Command {

    /// <summary>
    /// Whether this command belong to the main menu
    /// </summary>
    private bool belongToMainMenu;

    /// <summary>
    /// Constructor.
    /// </summary>
    public ExitMenuCommand(Menu menu, bool belongToMainMenu) {
        this.menu = menu;
        this.belongToMainMenu = belongToMainMenu;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => belongToMainMenu ? "Exit" : "Back";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        this.menu.Exit();
    }
}
