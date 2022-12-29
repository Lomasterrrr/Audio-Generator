using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Linq;
using System.Threading;

namespace GeneratorAudio
{
    internal class Generator
    {
        public void GenerateAudioSin(double gain, double frequency, double duration) {
            var sine20Seconds = new SignalGenerator()
            {
                Gain = gain,
                Frequency = frequency,
                
                Type = SignalGeneratorType.Sin
            }
    .Take(TimeSpan.FromSeconds(duration));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }
        }
        public void GenerateAudioTriangle(double gain, double frequency, double duration)
        {
            var sine20Seconds = new SignalGenerator()
            {
                Gain = gain,
                Frequency = frequency,

                Type = SignalGeneratorType.Triangle
            }
    .Take(TimeSpan.FromSeconds(duration));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }
        }
        public void GenerateAudioSquare(double gain, double frequency, double duration)
        {
            var sine20Seconds = new SignalGenerator()
            {
                Gain = gain,
                Frequency = frequency,

                Type = SignalGeneratorType.Square
            }
    .Take(TimeSpan.FromSeconds(duration));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }
        }
        public void GenerateAudioSawTooth(double gain, double frequency, double duration)
        {
            var sine20Seconds = new SignalGenerator()
            {
                Gain = gain,
                Frequency = frequency,

                Type = SignalGeneratorType.SawTooth
            }
    .Take(TimeSpan.FromSeconds(duration));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }
        }

    }
}
