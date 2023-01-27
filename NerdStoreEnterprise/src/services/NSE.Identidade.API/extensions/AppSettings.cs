namespace NSE.Identidade.API.extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public int ExpiracaoHoras { get; set; }

        public string Emissor { get; set; }

        public string ValidoEm { get; set; }

    }
}
