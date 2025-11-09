using System;

namespace ChatApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação dos canais
            var whatsapp = new WhatsApp("+55 11 99999-8888");
            var telegram = new Telegram("@usuario_teste");
            var facebook = new Facebook("usuario.fb");
            var instagram = new Instagram("usuario.insta");

            // Criação das mensagens
            var texto = new TextMessage("Olá, tudo bem?");
            var foto = new PhotoMessage("Confira esta foto!", "imagem_viagem", "jpg");
            var video = new VideoMessage("Veja o vídeo do produto", "video_demo", "mp4", 45);
            var arquivo = new FileMessage("Segue o relatório", "relatorio", "pdf");

            // Envio em todos os canais
            whatsapp.EnviarMensagem(texto);
            telegram.EnviarMensagem(foto);
            facebook.EnviarMensagem(video);
            instagram.EnviarMensagem(arquivo);

            Console.WriteLine("Mensagens enviadas com sucesso!");
        }
    }
}
