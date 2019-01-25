using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace debugws2
{
  class Program
  {
    public long sum()
    {
      string[] data = File.ReadAllLines("data");
      long total = 0;

      for (int x = 0; x < data.Length; x++)
      {
        total += cnv(data[x]);
      }

      return total;
    }

        public int cnv(string val)
        {

            val.Replace('G', 'F');

            char[] c = val.ToCharArray();
            if (val.Contains("G"))
            {
                c[4] = 'F';
            }


            string v = new string(c);
           Int32.TryParse(v, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value);

      return value;
    }

    static void Main(string[] args)
    {
      var p = new Program();
      Console.WriteLine("Total: {0}", p.sum());
    }
  }
}