namespace ConsoleStuff;

/// <summary>
/// Base class for a menu. A menu handles its own loop and output.
/// </summary>
public abstract class Menu {
    /// <summary>
    /// Maps menu items's input value to their output text.
    /// </summary>
    protected Dictionary<int, Command> menuItems;

    /// <summary>
    /// Whether this menu should exit its loop
    /// </summary>
    private bool exit;

    /// <summary>
    /// Open the menu.
    /// </summary>
    public void Open() {
        while (!this.exit) {
            Console.WriteLine(GetOutput());
            if(int.TryParse(Console.ReadLine(), out int input)) {
                if (this.menuItems.TryGetValue(input, out var value)) {
                    value.Execute();
                }
            }
        }
    }

    /// <summary>
    /// Exit this menu.
    /// </summary>
    public void Exit() {
        this.exit = true;
    }

    /// <summary>
    /// Gets the menu's output.
    /// </summary>
    private string GetOutput() {
        string output = "\n";
        foreach (var menuItem in this.menuItems) {
            output += $"{menuItem.Key} - {menuItem.Value.Name}\n";
        }

        return output;
    }
}
