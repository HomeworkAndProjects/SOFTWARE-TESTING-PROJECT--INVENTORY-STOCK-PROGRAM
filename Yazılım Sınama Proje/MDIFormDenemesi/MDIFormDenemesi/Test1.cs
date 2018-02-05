namespace MDIFormDenemesi
{
    public class Test1
    {
        public int FiyatDogruMu(string fiyat)
        {
            int i = 0;
            if (Isnumber(fiyat))
            {
                i = 1;
            }
            else if(fiyat == " ")
            {
                i = 0;
            }
            else
            {
                i = 2;
            }

            return i;
            
        }
        bool Isnumber(string text)
        {
            foreach (char chr in text)
            {
                if (!char.IsDigit(chr))
                {
                    return false;
                }
            }
            return true;
        }


        public Test1()
        {
            
        }
    }
}