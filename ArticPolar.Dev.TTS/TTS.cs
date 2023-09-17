using System;
using System.Linq;
using System.Speech.Synthesis;

namespace ArticPolar.Dev.TTS
{
    public class TTS : IDisposable
    {
        private SpeechSynthesizer synthesizer;
        public TTS()
        {
            synthesizer = new SpeechSynthesizer();
        }
        public void Speak(string text)
        {
            synthesizer.Speak(text);
        }
        public void SetVoice(string voiceName)
        {
            var voices = synthesizer.GetInstalledVoices();
            var selectedVoice = voices.FirstOrDefault(v => v.VoiceInfo.Name == voiceName);
            if (selectedVoice != null)
            {
                synthesizer.SelectVoice(selectedVoice.VoiceInfo.Name);
            }
        }
        public void SetRate(int rate) 
        {
            synthesizer.Rate = rate;
        }
        public void SetVolume(int volume)
        {
            synthesizer.Volume = volume;
        }
        public void Pause()
        {
            synthesizer.Pause();
        }
        public void Resume()
        {
            synthesizer.Resume();
        }
        public void Stop()
        {
            synthesizer.SpeakAsyncCancelAll();
        }
        public void Dispose()
        {
            synthesizer.Dispose();
        }
    }
}
