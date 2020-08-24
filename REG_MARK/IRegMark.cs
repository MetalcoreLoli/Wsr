using System;

namespace REG_MARK
{
    public interface IRegMark
    {
        Boolean CheckMark(String mark);
        String GetNextMarkAfter(String mark);
        String GetNextMarkAfterInRange(String prevMark, String rangeStart, String rangeEnd);
        Int32 GetCombinationsCountInRange(String mark1, String mark2);
    }
}
