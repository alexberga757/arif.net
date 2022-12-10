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
    }
   
}