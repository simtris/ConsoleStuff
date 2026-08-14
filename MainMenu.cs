namespace ConsoleStuff;

/// <summary>
/// Handles the main menu.
/// </summary>
public class MainMenu {
    /// <summary>
    /// Maps main menu items's input value to their output text.
    /// </summary>
    private readonly Dictionary<int, string> mainMenuItems;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainMenu() {
        this.mainMenuItems = new Dictionary<int, string>() {
            { 0, "Something cool" },
            { 1, "Exit" }
        };
    }

    /// <summary>
    /// Gets the main menu's output.
    /// </summary>
    public string GetMainMenu() {
        string output = "";
        foreach (var menuItem in this.mainMenuItems) {
            output += $"{menuItem.Key} - {menuItem.Value}\n";
        }

        return output;
    }
}
