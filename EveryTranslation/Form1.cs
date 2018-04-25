using Google.Apis.Auth.OAuth2;
using Google.Cloud.Speech.V1;
using Google.Cloud.Translation.V2;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveryTranslation
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationToken;
        private GoogleCredential credential = GoogleCredential.FromJson(File.ReadAllText("TranslationSample-cac6feffc38d.json"));
        private Channel channel;

        public Form1()
        {
            InitializeComponent();

            credential = credential.CreateScoped("https://www.googleapis.com/auth/cloud-platform");
            channel = new Channel("speech.googleapis.com:443", credential.ToChannelCredentials());

            ButtonStartRecognition.Enabled = true;
            ButtonStartTranslation.Enabled = false;
        }

        private void ButtonStartRecognition_Click(object sender, EventArgs e)
        {
            ButtonStartRecognition.Enabled = false;
            ButtonStartTranslation.Enabled = true;

            StartSpeechRecognition();
        }

        private void ButtonStartTranslation_Click(object sender, EventArgs e)
        {
            ButtonStartRecognition.Enabled = true;
            ButtonStartTranslation.Enabled = false;

            if(cancellationToken != null)
            {
                cancellationToken.Cancel();
            }

            StartTextTranslation();
        }

        private async void StartSpeechRecognition()
        {
            if(NAudio.Wave.WaveIn.DeviceCount < 1)
            {
                LabelTextRecognition.Text = "マイクが検出できませんでした";
                return;
            }

            cancellationToken = new CancellationTokenSource();
            SpeechClient speech = SpeechClient.Create(channel);
            SpeechClient.StreamingRecognizeStream streamingCall = speech.StreamingRecognize();

            await streamingCall.WriteAsync(new StreamingRecognizeRequest()
            {
                StreamingConfig = new StreamingRecognitionConfig()
                {
                    Config = new RecognitionConfig()
                    {
                        Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                        SampleRateHertz = 16000,
                        LanguageCode = "ja-JP",
                    },
                    InterimResults = true,
                }
            });

            Task printResponse = Task.Run(async () =>
            {
                while (await streamingCall.ResponseStream.MoveNext())
                {
                    foreach (var result in streamingCall.ResponseStream.Current.Results)
                    {
                        foreach (var alternative in result.Alternatives)
                        {
                            Invoke((Action)(() =>
                            {
                                LabelTextRecognition.Text = alternative.Transcript;
                            }));
                        }
                    }
                }
            });

            object writeLock = new object();
            bool writeMore = true;
            NAudio.Wave.WaveInEvent waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            waveIn.DataAvailable += (object sender, NAudio.Wave.WaveInEventArgs args) =>
            {
                lock (writeLock)
                {
                    if (!writeMore)
                    {
                        return;
                    }
                    streamingCall.WriteAsync(new StreamingRecognizeRequest()
                    {
                        AudioContent = Google.Protobuf.ByteString.CopyFrom(args.Buffer, 0, args.BytesRecorded)
                    }).Wait();
                }
            };

            waveIn.StartRecording();
            Console.WriteLine("Speak now");
            for (int i = 0; i < 50; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Cancel");
                    break;
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            Console.WriteLine("End Recognition");
            waveIn.StopRecording();
            lock (writeLock)
            {
                writeMore = false;
            }
            await streamingCall.WriteCompleteAsync();
            await printResponse;
            return;

        }

        private void StartTextTranslation()
        {
            TranslationClient client = TranslationClient.Create(credential);

            TranslationResult englishTranslation = client.TranslateText(LabelTextRecognition.Text, Google.Cloud.Translation.V2.LanguageCodes.English);
            LabelTextEnglish.Text = englishTranslation.TranslatedText;

            TranslationResult germanTranslation = client.TranslateText(LabelTextRecognition.Text, Google.Cloud.Translation.V2.LanguageCodes.German);
            LabelTextGerman.Text = germanTranslation.TranslatedText;

            TranslationResult spanishTranslation = client.TranslateText(LabelTextRecognition.Text, Google.Cloud.Translation.V2.LanguageCodes.Spanish);
            LabelTextSpanish.Text = spanishTranslation.TranslatedText;

            TranslationResult italianTranslation = client.TranslateText(LabelTextRecognition.Text, Google.Cloud.Translation.V2.LanguageCodes.Italian);
            LabelTextItalian.Text = italianTranslation.TranslatedText;
            
        }

    }
}
