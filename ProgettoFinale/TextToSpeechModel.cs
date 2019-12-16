using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ProgettoFinale
{
    public class TextToSpeechModel
    {
        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        public void ConvertToSpeech(KeyboardWriterModel kwm)
        {
            this.speechSynthesizer.Speak(kwm.Text);
        }
    }
}

