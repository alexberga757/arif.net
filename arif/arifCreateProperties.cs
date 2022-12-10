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
      txt += String.Format("{0}:{1}\n",name,value_);
    }
    public void CreateValue(string name,int value_) {
       txt += String.Format("{0}:{1}\n",name,value_.ToString());
    }
     public void CreateValue(string name,bool value_) {
              txt += String.Format("{0}:{1}\n",name,value_.ToString());

    }
    public string GetData() {
      return this.txt;
    }
  }
}