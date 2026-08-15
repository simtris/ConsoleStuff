namespace ConsoleStuff;

/// <summary>
/// Handles the main menu.
/// </summary>
public class MainMenu : Menu {

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainMenu() {
        this.menuItems = new Dictionary<int, ICommand>() {
            { 0, new ExitCommand()}
        };
    }
}
