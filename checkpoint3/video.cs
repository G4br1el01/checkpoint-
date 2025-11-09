namespace ChatApp
{
    public class VideoMessage : MessageBase
    {
        public string Arquivo { get; private set; }
        public string Formato { get; private set; }
        public int DuracaoSegundos { get; private set; }

        public VideoMessage(string conteudo, string arquivo, string formato, int duracao)
            : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
            DuracaoSegundos = duracao;
        }

        public override string FormatMessage()
        {
            return $"[Vídeo] {Conteudo} - Arquivo: {Arquivo}.{Formato} - Duração: {DuracaoSegundos}s (Enviado em {DataEnvio})";
        }
    }
}
