using System;
using arif;
using System.IO;
class Program {
  public static void Main (string[] args) {
     arif.arifCreate a = new arif.arifCreate(File.ReadAllText("testRead.arif"));
            Console.WriteLine(a.ReadString("string"));
            Console.WriteLine(a.GetInt("int"));
            Console.WriteLine(a.GetBool("bool"));
      arif. arifCreateProperties c = new arif.arifCreateProperties();
            c.CreateValue("abc","000");
            Console.WriteLine(c.GetData());
            Console.ReadLine();
}
}     