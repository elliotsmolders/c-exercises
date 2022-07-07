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
        WindowsMediaPlayer _player;
        Frontend _frontend;
        public Backend(WindowsMediaPlayer player, Frontend frontend)
        {
            _player = player;
            _frontend = frontend;   
        }
        public bool HandleChoice(int userChoice)
        {
            bool exitApplication = false;
            switch (userChoice)
            {
                case (int)UserChoice.TogglePlayPause: { if ((int)_player.playState == 3) { PauseSong(); } else { PlaySong(); }; break; }
                case (int)UserChoice.ChangeVolume: { ChangeVolume(); break; }
                case (int)UserChoice.ToggleMute: { ToggleMute(); break; }
                case (int)UserChoice.SpeedUpSong: { FastForward(); break; }
                case (int)UserChoice.SlowDownSong: { FastReverse(); break; }
                case (int)UserChoice.PlayNewSong: { _player.URL = _frontend.GetUserFile(); break; }
                case (int)UserChoice.StopPlayingCurrentSong: { StopSong(); break; }
                case (int)UserChoice.StopApplication: { exitApplication=true; break; }
            }
            return exitApplication;
        }
        private void PauseSong()
        {
            _player.controls.pause();
        }
        private void PlaySong()
        {
            _player.controls.play();
        }
        private void StopSong()
        {
            _player.controls.stop();
        }
        private void ChangeVolume()
        {
            Console.WriteLine("Give new volume level: ");
            int volume;
            bool validInput = Int32.TryParse(Console.ReadLine(), out volume);
            if (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Input was not a number, please give a number between 0-100");
                Console.ResetColor();
                ChangeVolume();
     
                return;
            }
            if(volume <0 || volume > 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Input was not between 0-100, please give a number between 0-100");
                Console.ResetColor();
                ChangeVolume();
                
                return;
            }
            _player.settings.volume = volume;
        }
        private void ToggleMute()
        {
            _player.settings.mute ^= true;
        }
        private void FastForward()
        {
            _player.settings.rate += 0.25;
        }
        private void FastReverse()
        {
            if(_player.settings.rate > 0.25)
            {
                _player.settings.rate -= 0.25;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Can't slow down more");
                Console.ResetColor();
            }
            
        }

    }
}
