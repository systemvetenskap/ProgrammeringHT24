namespace FarmingGame
{
    public static class StringHelper
    {
        public static string Reverse(string message)
        {
            string reversedString = string.Empty;
            for (int i = message.Length - 1; i >= 0; i--)
            {
                reversedString += message[i];
            }
            return reversedString;
        }

        // lägg till tre tecken
        // ta bort tre tecken
        // eller kan vi slå ihop den och istället styra
        // "riktningen" med parameter
    }
}
