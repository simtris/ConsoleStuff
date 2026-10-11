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
    /// This menu's name.
    /// </summary>
    protected string name;

    public Menu(string name) {
        this.name = name;
        this.menuItems = new Dictionary<int, Command>() {
            {0, new ExitMenuCommand(this)},
        };
    }

    /// <summary>
    /// Open the menu.
    /// </summary>
    public void Open() {
        while (!this.exit) {
            Console.Clear();
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
        string output = $"\n{this.name}\n";
        foreach (var menuItem in this.menuItems) {
            output += $"{menuItem.Key} - {menuItem.Value.Name}\n";
        }

        return output;
    }
}
