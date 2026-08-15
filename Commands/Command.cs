namespace ConsoleStuff;

/// <summary>
/// Base class for a command the user may enter in the console.
/// </summary>
public abstract class Command {
    /// <summary>
    /// The menu this command belongs to.
    /// </summary>
    protected Menu menu;

    /// <summary>
    /// This command's name 
    /// </summary>
    public abstract string Name { get; }

    /// <summary>
    /// Execute the command.
    /// </summary>
    public abstract void Execute();
}
