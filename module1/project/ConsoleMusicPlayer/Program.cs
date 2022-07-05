// See https://aka.ms/new-console-template for more information
using WMPLib;
using ConsoleMusicPlayer;

WindowsMediaPlayer player = new WindowsMediaPlayer();
Frontend frontend = new Frontend();
Backend backend = new Backend();

string filename = frontend.GetUserFile();
player.URL = filename;

bool exitProgram = false;

while (!exitProgram)
{
    Thread.Sleep(1000);
    // app breaks without this, Unhandled exception. System.Runtime.InteropServices.COMException (0x8001010A)
    // : The message filter indicated that the application is busy.
    frontend.PrintMenu();
    frontend.PrintPlayerState(player);
    frontend.PrintVolumeState(player);
    frontend.PrintVolumeBar(player);
    frontend.PrintSongName(player);
    frontend.PrintDuration(player);
    int userChoice = frontend.GetUserChoice();
    exitProgram = backend.HandleChoice(player, userChoice,frontend);
}
