namespace AutomatedTests.Tests
{
    public static class DuolingoMap
    {
        public static string Url => "https://www.duolingo.com/";
        public static string BotaoJaTenhoUmaConta => "/html/body/div[1]/div/div/span[1]/div/div[1]/div[2]/div[2]/a";
        public static string BotaoEntrar => "/html/body/div[2]/div[5]/div/div/form/div[1]/button";
        public static string CampoUsuario => "/html/body/div[2]/div[5]/div/div/form/div[1]/div[1]/div[1]/label/div[1]/input";
        public static string CampoSenha => "/html/body/div[2]/div[5]/div/div/form/div[1]/div[1]/div[2]/label/div[1]/input";
        public static string BotaoEntrarComGoogle => "/html/body/div[2]/div[5]/div/div/form/div[1]/p/button[2]";
        public static string UrlLogarComGoogle => "https://accounts.google.com/o/oauth2/auth/identifier?redirect_uri=storagerelay%3A%2F%2Fhttps%2Fwww.duolingo.com%3Fid%3Dauth386472&response_type=permission%20id_token&scope=email%20profile%20openid&openid.realm&prompt=select_account%20consent&client_id=450298686065.apps.googleusercontent.com&ss_domain=https%3A%2F%2Fwww.duolingo.com&fetch_basic_profile=true&gsiwebsdk=2&flowName=GeneralOAuthFlow";
        public static string CampoUsuarioGoogle => "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input";
        public static string BotaoProximaGoogle => "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button";
        public static string CampoSenhaGoogle => "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input";
        public static string LabelSenhaErrada => "/html/body/div[2]/div[5]/div/div[2]/form/div[1]/div[2]/div";

    }
}
