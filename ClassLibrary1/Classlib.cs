namespace ClassLibrary
{
    public static class Cumprimento
    {
        public static string ObterCumprimento(DateTime hora)
        {
            if (hora.Hour < 12)
                return "Bom dia, Rui";
            else if (hora.Hour < 19)
                return "Boa tarde, Rui";
            else
                return "Boa noite, Rui";
        }
    }
}