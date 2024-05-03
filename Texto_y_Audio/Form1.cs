using System.Runtime.InteropServices.ObjectiveC;
using System.Speech.Synthesis;
using NAudio.Mixer;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;


namespace Texto_y_Audio
{
    public partial class Texto_Audio : Form
    {
        public Texto_Audio()
        {
            InitializeComponent();
        }

        private void btnHablar_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(hablar));
            tarea.Start(rTexto.Text);
        }


        private void hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());

        }

        private void rTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado por el usuario
            string texto = rTexto.Text;

            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Por favor, ingresa un texto antes de convertirlo a audio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la ruta de salida para el archivo de audio MP3
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "pruebas", $"{texto}.mp3");

            // Convertir el texto a voz y guardar el audio en un archivo MP3
            try
            {
                ConvertirTextoAVoz(texto, outputPath);
                MessageBox.Show($"El audio se ha guardado exitosamente en: {outputPath}", "Conversión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al convertir el texto a voz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertirTextoAVoz(string texto, string outputPath)
        {
            // Crear un objeto SpeechSynthesizer
            using (SpeechSynthesizer voz = new SpeechSynthesizer())
            {
                // Establecer el idioma
                voz.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("es-ES"));

                // Convertir texto a voz y guardar el audio en un archivo MP3
                using (var ms = new MemoryStream())
                {
                    voz.SetOutputToWaveStream(ms);
                    voz.Speak(texto);
                    ms.Position = 0;

                    // Guardar la salida de audio en un archivo MP3 en la ruta especificada
                    using (var reader = new NAudio.Wave.WaveFileReader(ms))
                    {
                        NAudio.Wave.WaveFileWriter.CreateWaveFile(outputPath, reader);
                    }
                }
            }
        }

        private void btnReproducirMP3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Audio|*.mp3";
            openFileDialog.Title = "Seleccionar Archivo MP3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                ReproducirAudio(rutaArchivo);
            }
        }


        private void ReproducirAudio(string rutaArchivo)
        {
            using (var audioFile = new AudioFileReader(rutaArchivo))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
    }


}
