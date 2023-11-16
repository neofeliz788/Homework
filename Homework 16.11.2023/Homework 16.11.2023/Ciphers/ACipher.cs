public class ACipher : ICipher
{
    public string Encode(string input)
    {
        char[] result = input.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                result[i] = (char)(result[i] + 1);
            }
        }

        return new string(result);
    }

    public string Decode(string input)
    {
        char[] result = input.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                result[i] = (char)(result[i] - 1);
            }
        }

        return new string(result);
    }
}
