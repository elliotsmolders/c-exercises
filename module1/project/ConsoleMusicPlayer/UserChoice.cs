using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMusicPlayer
{
    public enum UserChoice
    {
        TogglePlayPause = 1,
        ChangeVolume = 2,
        ToggleMute = 3,
        SpeedUpSong = 4,
        SlowDownSong = 5,
        PlayNewSong = 6,
        StopPlayingCurrentSong = 7,
        StopApplication = 8
    }
}
