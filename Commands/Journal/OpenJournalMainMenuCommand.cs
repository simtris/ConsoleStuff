using ConsoleStuff.Menus.Journal;

namespace ConsoleStuff.Commands.Journal;

/// <summary>
/// Command to open the journal main menu
/// </summary>
public class OpenJournalMainMenuCommand : Command
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public OpenJournalMainMenuCommand(Menu menu)
    {
        this.menu = menu;
    }

    /// <summary>
    /// The command's name
    /// </summary>
    public override string Name => "Journal";

    /// <summary>
    /// Execute the command.
    /// </summary>
    public override void Execute()
    {
        var journalMainMenu = new JournalMainMenu();
        journalMainMenu.Open();
    }
}
