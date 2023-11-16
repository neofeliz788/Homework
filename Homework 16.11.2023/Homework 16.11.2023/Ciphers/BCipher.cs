public class BCipher : ICipher
{
    public string Encode(string input)
    {
        char[] result = input.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                char originalChar = char.ToLower(result[i]);
                char encryptedChar = (char)('я' - (originalChar - 'а'));
                result[i] = char.IsUpper(result[i]) ? char.ToUpper(encryptedChar) : encryptedChar;
            }
        }

        return new string(result);
    }

    public string Decode(string input)
    {
        // Декодирование BCipher идентично кодированию, так как оба процесса используют тот же принцип
        return Encode(input);
    }
}