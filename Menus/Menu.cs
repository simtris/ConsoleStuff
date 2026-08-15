namespace ConsoleStuff;

/// <summary>
/// Base class for a menu. A menu handles its own loop and output.
/// </summary>
public abstract class Menu {
    /// <summary>
    /// Maps menu items's input value to their output text.
    /// </summary>
    protected Dictionary<int, ICommand> menuItems;

    /// <summary>
    /// Whether this menu should exit its loop
    /// </summary>
    private bool exit;

    /// <summary>
    /// Start the menu's loop.
    /// </summary>
    public void StartLoop() {
        while (!this.exit) {
            Console.WriteLine(GetOutput());
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Gets the menu's output.
    /// </summary>
    private string GetOutput() {
        string output = "";
        foreach (var menuItem in this.menuItems) {
            output += $"{menuItem.Key} - {menuItem.Value}\n";
        }

        return output;
    }
}
