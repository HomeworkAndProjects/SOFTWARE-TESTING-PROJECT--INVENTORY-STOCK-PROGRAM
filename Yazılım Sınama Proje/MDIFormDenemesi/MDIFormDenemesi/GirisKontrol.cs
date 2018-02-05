using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIFormDenemesi
{
    public class GirisKontrol
    {
        public string cikisMetni = "";
        public bool SadeceSayiAl(string girdi)
        {
            cikisMetni = "";
            int karakterAsciiDegeri;
            foreach (char item in girdi)
            {
                karakterAsciiDegeri = Convert.ToInt32(item);
                if (karakterAsciiDegeri >= 48 && karakterAsciiDegeri <= 57)
                {
                    cikisMetni += item;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public string bosluklariAt(string girdi)
        {
            string temp = "";
            foreach (char item in girdi)
            {
                if (item.ToString() == " ")
                {
                    continue;
                }
                else
                {
                    temp += item;
                }
            }
            return temp;
        }
        public bool SadeceMetinAl(string girdi)
        {
            cikisMetni = "";
            int karakterAsciiDegeri;
            foreach (char item in girdi)
            {
               // karakterAsciiDegeri = Convert.ToInt32(item);
                if ((item >= 65 && item <= 90) || (item >= 97 && item <= 122))
                {
                    cikisMetni += item.ToString();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool SayiveyaMetinAl(string girdi)
        {
            cikisMetni = "";
            int karakterAsciiDegeri;
            foreach (char item in girdi)
            {
                karakterAsciiDegeri = Convert.ToInt32(item);
                if ((karakterAsciiDegeri >= 48 && karakterAsciiDegeri <= 57) || (karakterAsciiDegeri >= 65 && karakterAsciiDegeri <= 90) || (karakterAsciiDegeri >= 97 && karakterAsciiDegeri <= 122))
                {
                    cikisMetni += item;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public decimal MetniDecimalYap(string str1,string str2)
        {
            decimal cikti;
            string temp = "";
            str1 = bosluklariAt(str1);
            str2 = bosluklariAt(str2);
            temp += str1 + "," + str2;
            cikti = Convert.ToDecimal(temp);
            return cikti;
        }


    }
}
