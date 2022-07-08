using WMPLib;

namespace ConsoleMusicPlayer
{
    public class Frontend
    {
        private WindowsMediaPlayer _player;

        public Frontend(WindowsMediaPlayer player)
        {
            _player = player;
        }

        public void PrintFrontend()
        {
            PrintMenu();
            Thread.Sleep(100);
            /* app breaks without this, Unhandled exception. System.Runtime.InteropServices.COMException (0x8001010A)
            : The message filter indicated that the application is busy.*/
            PrintPlayerState();
            PrintVolumeState();
            PrintVolumeBar();
            PrintSongName();
            PrintPlaySpeed();
            PrintDuration();
        }

        public string GetUserFile()
        {
            Console.WriteLine("Geef bestand om af te spelen:");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Het ingegeven bestand bestaat niet.");
                Console.ResetColor();
                return GetUserFile();
            }
            return filename;
        }

        public int GetUserChoice()
        {
            Console.WriteLine("Choose an option:");
            int userChoice;
            bool validChoice = Int32.TryParse(Console.ReadLine(), out userChoice);
            if (!validChoice)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Input was not a number, please enter a number between 1-8");
                Console.ResetColor();
                return GetUserChoice();
            }
            if (userChoice < 1 || userChoice > 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Input was not between 1-8, please enter a number between 1-8");
                Console.ResetColor();
                return GetUserChoice();
            }
            return userChoice;
        }

        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Play/Pause");
            Console.WriteLine("2. Change Volume");
            Console.WriteLine("3. Mute/Unmute");
            Console.WriteLine("4. Speed up song");
            Console.WriteLine("5. Slow down song");
            Console.WriteLine("6. Play new song");
            Console.WriteLine("7. Stop");
            Console.WriteLine("8. Quit");
        }

        private void PrintVolumeState()
        {
            int volumeState = _player.settings.volume;
            if (_player.settings.mute)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("muted");
                Console.ResetColor();
            }
            Console.WriteLine($"Volume = {volumeState} %");
        }

        private void PrintVolumeBar()
        {
            int volume = _player.settings.volume;
            string volumebar = $"[{new string('*', volume / 5)}{new string(' ', 20 - volume / 5)}]";
            Console.WriteLine(volumebar);
        }

        private void PrintPlayerState()
        {
            string[] statesArray = { "Undefined", "Stopped", "Paused", "Playing", "	ScanForward", "ScanReverse", "Buffering", "Waiting", "MediaEnded", "Transitioning", "Ready", "Reconnecting" };
            Console.WriteLine($"State: {statesArray[(int)_player.playState]}");
        }

        private void PrintPlaySpeed()
        {
            Console.Write($"playback speed = ");
            if (_player.settings.rate > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (_player.settings.rate < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{_player.settings.rate}x");
            Console.ResetColor();
        }

        private void PrintDuration()
        {
            double seconds = _player.currentMedia.duration;
            Console.WriteLine($"song length: {TimeSpan.FromSeconds(seconds).ToString(@"m\:ss")}");
        }

        private void PrintSongName()
        {
            Console.WriteLine($"song name: {_player.currentMedia.name}");
        }
    }
}