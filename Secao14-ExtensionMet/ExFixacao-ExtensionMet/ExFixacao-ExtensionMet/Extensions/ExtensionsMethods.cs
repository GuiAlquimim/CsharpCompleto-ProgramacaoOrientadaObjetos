namespace System
{
    internal static class ExtensionsMethods
    {
        //Converte uma string toda em minúsculo (ou misturada) para o formato de título (primeira letra de cada palavra em maiúsculo).
        public static string ToTitleCase(this string thisObj)
        {
            string[] phrase = thisObj.Split(' ');

            for (int i = 0; i < phrase.Length; i++)
            {
                string word = phrase[i].ToLower();
                if (word.Length > 0)
                {
                    phrase[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            return string.Join(" ", phrase);
        }

        //Compara a data do objeto com o DateTime.Now e retorna uma string legível.
        public static string ToRelativeTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;
            if (duration.TotalSeconds < 60)
                return $"Just now";
            else if (duration.TotalMinutes < 60)
                return $"{(int)duration.TotalMinutes} minutes ago";
            else if (duration.TotalHours < 24)
                return $"{(int)duration.TotalHours} hours ago";
            else if (duration.TotalHours < 48)
                return $"Yesterday";
            else return $"{(int)duration.TotalDays} days ago";
        }
    }
}