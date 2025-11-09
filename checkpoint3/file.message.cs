namespace ChatApp
{
    public class FileMessage : MessageBase
    {
        public string Arquivo { get; private set; }
        public string Formato { get; private set; }

        public FileMessage(string conteudo, string arquivo, string formato)
            : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override string FormatMessage()
        {
            return $"[Arquivo] {Conteudo} - Arquivo: {Arquivo}.{Formato} (Enviado em {DataEnvio})";
        }
    }
}
