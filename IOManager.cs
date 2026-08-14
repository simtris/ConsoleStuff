namespace ConsoleStuff;

/// <summary>
/// Handles Input/Output
/// </summary>
public class IOManager {

    /// <summary>
    /// Start the program's main loop
    /// </summary>
    public static void StartMainLoop() {
        var mainMenu = new MainMenu();
        // Main loop
        while (true) {
            Console.WriteLine(mainMenu.GetMainMenu());
            Console.ReadLine();
        }
    }
}
