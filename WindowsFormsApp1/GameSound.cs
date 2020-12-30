using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WindowsFormsApp1
{
    class GameSound
    {
        SoundPlayer MenuSound;
        SoundPlayer GamePlaySound;

        public GameSound()
        {
            MenuSound = new SoundPlayer();
            GamePlaySound = new SoundPlayer();
            
            MenuSound.SoundLocation = @".\Intro_Screen.wav";
            GamePlaySound.SoundLocation = @".\Blazer_rail_2.wav";
        }

        public void PlayMenuSound()
        {
            MenuSound.PlayLooping();
        }

        public void PlayGameSound()
        {
            GamePlaySound.PlayLooping();
        }

        public void StopMenuSound()
        {
            MenuSound.Stop();
        }

        public void StopGamePlaySound()
        {
            GamePlaySound.Stop();
        }

        public void StopAll()
        {
            MenuSound.Stop();
            GamePlaySound.Stop();
        }
    }
}
