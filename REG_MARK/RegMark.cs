using REG_MARK;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REG_LIB_MARK
{
    public class RegMark : IRegMark
    {
        public bool CheckMark(string mark)
        {
            return Regex.IsMatch(mark, @"(^[a-z]+[0-9]{3}[a-z]{2}(([0-9]{2})|([0-9]{3})))");
        }

        public int GetCombinationsCountInRange(string mark1, string mark2)
        {
            throw new NotImplementedException();
        }

        public string GetNextMarkAfter(string mark)
        {
            throw new NotImplementedException();
        }

        public string GetNextMarkAfterInRange(string prevMark, string rangeStart, string rangeEnd)
        {
            throw new NotImplementedException();
        }
    }
}
