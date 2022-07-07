// See https://aka.ms/new-console-template for more information
using WMPLib;
using ConsoleMusicPlayer;

WindowsMediaPlayer player = new WindowsMediaPlayer();
Frontend frontend = new Frontend(player);
Backend backend = new Backend(player,frontend);

string filename = frontend.GetUserFile();
player.URL = filename;

bool exitProgram = false;

while (!exitProgram)
{
    frontend.PrintFrontend();
    int userChoice = frontend.GetUserChoice();
    exitProgram = backend.HandleChoice(userChoice);
}
