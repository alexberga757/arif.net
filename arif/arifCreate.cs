using System;
using System.Text;
using System.IO;

namespace arif
{
    public class arifCreate
    {
        private string text = "";

        public arifCreate(string content)
        {
            this.text = content;
        }
        public void CreateString(string content)
        {
            this.text = content;
        }
        public string ReadString(string content)
        {

            string token = "";
            string[] line = this.text.Split('\n');
            for (int n = 0; n < line.Length; n++)
            {
                string[] Poperties = line[n].Split(':');
                for (int i = 0; i < Poperties.Length; i++)
                {
                    if (Poperties[0] == content)
                    {

                        if (i == 0)
                        {

                        }
                        else
                        {
                            
                            token += ":" + Poperties[i];
                        }
                    }
                    else
                    {

                    }
                }
            }
          if (token.Length != 0) {
              return token.Remove(0,1);
          }
          else {
            return "";
          }
          return null;

        }
      public int GetInt(string name) {
        return int.Parse(this.ReadString(name));
      }
      public bool GetBool(string name) {
        return bool.Parse(this.ReadString(name));
      }
      public string ReadStringWithEscChar(string name) {
        
        string token = "";
        int state = 0;
        char[] charsarr = this.ReadString(name).ToCharArray();
        for (int i = 0; i < charsarr.Length; i++)
        {
            string a = charsarr[i].ToString();
            if (a == "\\")
            {
                if (state == 0)
                {
                    state = 1;
                }
                else if (state == 1)
                {
                    token += "\\";
                    state = 0;
                }

            }
            else if (a == "n")
            {
                if (state == 1)
                {
                    token += "\n";
                    state = 0;
                }
                else
                {
                    token += a;
                }
            }
            else if (a == "t")
            {
                if (state == 1)
                {
                    token += "\t";
                    state = 0;
                }
                else
                {
                    token += a;
                }
            }
            else if (a == "b")
            {
                if (state == 1)
                {
                    token += "\b";
                    state = 0;
                }
                else
                {
                    token += a;
                }
            }
            else if (a == "r")
            {
                if (state == 1)
                {
                    token += "\r";
                    state = 0;
                }
                else
                {
                    token += a;
                }
            }
            else
            {
                token += a;
            }
        }
        return token;
    
      }
    }
   
}
