using System;

namespace Libapp.Functions
{
    class CodeCreator
    {
        Random random = new Random();
        private String RandomNumber()
        {
            return random.Next(0, 10).ToString();
        }

        public String GetRandomCode()
        {
            string code = "";
            for (int a = 0; a < 6; a++)
            {
                code = code + RandomNumber();
            }
            return code;
        }
    }
}
