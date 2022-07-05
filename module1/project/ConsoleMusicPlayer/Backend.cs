using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ConsoleMusicPlayer
{
    internal class Backend
    {
        private void PauseSong(WindowsMediaPlayer player)
        {
            player.controls.pause();
        }
        private void PlaySong(WindowsMediaPlayer player)
        {
            player.controls.play();
        }
        private void StopSong(WindowsMediaPlayer player)
        {
            player.controls.stop();
        }
        private void ChangeVolume(WindowsMediaPlayer player)
        {
            Console.WriteLine("Give new volume level: ");
            int volume;
            bool validInput = Int32.TryParse(Console.ReadLine(), out volume);
            if (!validInput)
            {
                Console.WriteLine("Input was not a number, please give a number between 0-100");
                ChangeVolume(player);
                return;
            }
            if(volume <0 || volume > 100)
            {
                Console.WriteLine("Input was not between 0-100, please give a number between 0-100");
                ChangeVolume(player);
                return;
            }
            player.settings.volume = volume;
        }
        private void ToggleMute(WindowsMediaPlayer player)
        {
            player.settings.mute ^= true;
        }
        public bool HandleChoice(WindowsMediaPlayer player, int userChoice,Frontend frontend)
        {
            switch (userChoice)
            {
                case 1: { if ((int)player.playState == 3) { PauseSong(player); } else { PlaySong(player); };break; }
                case 2: { ChangeVolume(player); break; }
                case 3: { ToggleMute(player); break; }
                case 4: { player.URL = frontend.GetUserFile(); break; }
                case 5: { StopSong(player); break; }
                case 6: { return true; }
            }
            return false;
        }
    }
}
