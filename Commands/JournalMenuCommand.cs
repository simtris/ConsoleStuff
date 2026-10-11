namespace ConsoleStuff;

/// <summary>
/// Command to show the journal menu
/// </summary>
public class JournalMenuCommand : Command {

    private JournalMenu journalMenu;

    /// <summary>
    /// Constructor.
    /// </summary>
    public JournalMenuCommand(Menu menu) {
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
        this.journalMenu = new();
        this.journalMenu.Open();
    }
}
