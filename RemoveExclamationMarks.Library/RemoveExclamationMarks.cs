using System;
using System.Linq;

namespace RemoveExclamationMarks.Library
{
    public class RemoveExclamationMarks
    {
        public static string RemoverMarks(string s)
        {
            //with linq
            /*return new String(s.ToCharArray()
                .Select(x=> x.Equals('!') ? char.MinValue  : x )
                .Where(x => x!= char.MinValue)
                .ToArray());*/


            return s.Replace("!", string.Empty);


           
        }
    }
}
