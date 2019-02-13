using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Traning123
{
    public static class Kata
    {
        public static string addOrChangeUrlParameter(string url, string param)
        {
            string[] key = param.Split('=');
            if (url.IndexOf(key[0]) == -1)
            {
                if(url.IndexOf("key")==-1)return url + "?" + param;
                else return url + "&" + param;
            }
            else
            {
                int index = url.IndexOf(key[0]);
                int indexConcat = url.IndexOf('&');
                if (indexConcat == -1)
                {
                    string temp = url.Remove(index);
                    return temp + param;
                }
                else
                {
                    string temp = url.Remove(index, indexConcat);
                    temp = temp.Insert(index, param);
                    return temp;
                }
            }
        }

    }
}

