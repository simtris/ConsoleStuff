namespace ConsoleStuff;

/// <summary>
/// Command to show the journal main menu
/// </summary>
public class JournalMainMenuCommand : Command {

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalMainMenuCommand(Menu menu) {
        this.menu = menu;
    }
    
    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "Journal";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute() {
        var journalMainMenu = new JournalMainMenu();
        journalMainMenu.Open();
    }
}
