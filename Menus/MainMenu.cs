namespace ConsoleStuff;

/// <summary>
/// Handles the main menu.
/// </summary>
public class MainMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainMenu() {
        this.menuItems = new Dictionary<int, Command>() {
            {0, new JournalMainMenuCommand(this)},
            {1, new ExitCommand(this)}
        };
    }
}
