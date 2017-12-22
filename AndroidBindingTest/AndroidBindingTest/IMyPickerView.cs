using System;
using System.Collections.Generic;

namespace AndroidBindingTest
{
    public interface IMyPickerView
    {
        void OpenDateTimePick(bool showDate = true, bool showTime = true, Action<DateTime> OnSelectedAction = null);
        void OpenOptionsPick(List<string> options1, List<List<string>> options2 = null, List<List<List<string>>> options3 = null, Action<int, int, int> OnSelectedAction = null);
    }
}