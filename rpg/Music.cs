using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
namespace rpg
{
    class Music
    {
        WaveOutEvent waveOut = new WaveOutEvent();
        public void StartMusic(string WaveMus)
        {
            var reader = new Mp3FileReader(WaveMus);
            
            waveOut.Init(reader);
            waveOut.Play();


        }
        public void StopMusic()
        {
            waveOut.Stop();
        }

    }
}
