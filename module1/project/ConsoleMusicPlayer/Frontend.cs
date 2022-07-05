using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ConsoleMusicPlayer
{
    public class Frontend
    {
        public string GetUserFile()
        {
            Console.WriteLine("Geef bestand om af te spelen:");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine("Het ingegeven bestand bestaat niet.");
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
                Console.WriteLine("Input was not a number, please enter a number between 1-6");
                return GetUserChoice();
            }
            if (userChoice < 1 || userChoice > 6)
            {
                Console.WriteLine("Input was not between 1-6, please enter a number between 1-6");
                return GetUserChoice();
            }
            return userChoice;

        }
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Play/Pause");
            Console.WriteLine("2. Change Volume");
            Console.WriteLine("3. Mute/Unmute");
            Console.WriteLine("4. Play new song");
            Console.WriteLine("5. Stop");
            Console.WriteLine("6. Quit");
        }
        public void PrintVolumeState(WindowsMediaPlayer player)
        {
            int volumeState = player.settings.volume;
            Console.WriteLine($"Volume = {volumeState} %");
        }
        public void PrintVolumeBar(WindowsMediaPlayer player)
        {
            int volume = player.settings.volume;
            string volumebar="[" + new string('*',volume/5) + new string(' ',20-volume/5) + "]";
            Console.WriteLine(volumebar);
        }
        public void PrintPlayerState(WindowsMediaPlayer player)
        {
            string[] statesArray = { "Undefined", "Stopped", "Paused", "Playing", "	ScanForward", "ScanReverse", "Buffering", "Waiting", "MediaEnded", "Transitioning", "Ready", "Reconnecting" };
            Console.WriteLine($"State: {statesArray[(int)player.playState]}");
        }
        public void PrintDuration(WindowsMediaPlayer player)
        {
            double seconds = player.currentMedia.duration;
            Console.WriteLine($"song length: {TimeSpan.FromSeconds(seconds).ToString(@"m\:ss")}");
        }
        public void PrintSongName(WindowsMediaPlayer player)
        {
            Console.WriteLine($"song name: {player.currentMedia.name}");
        }
    }
}


