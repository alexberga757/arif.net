using System;
using System.Text;
using System.IO;

namespace arif
{
  public class arifCreateProperties {
    string txt = "";
    public arifCreateProperties() {
    
    }
    //create value
    public void CreateValue(string name,string value_) {
      txt += String.Format("{0}:{1}\n",npzero(name),value_);
    }
    public void CreateValue(string name,int value_) {
       txt += String.Format("{0}:{1}\n",npzero(name),value_.ToString());
    }
     public void CreateValue(string name,bool value_) {
              txt += String.Format("{0}:{1}\n",npzero(name),value_.ToString());

    }
    public string GetData() {
      return this.txt;
    }
    private static string npzero(string name) {
    char[] _name = name.ToCharArray();
    string token = "";
    int state = 0;
    for (int i = 0;i < _name.Length;i++) {
      string __name = _name[i].ToString();
      if (__name == " ") {
        
        if (state == 0) {
          state = 1;
        }
        else if (state == 2) {
          token += __name;
        }
        
      }
      else {
        state = 2;
        token += __name;
      }
    }
    return token;
  }
  }
}
