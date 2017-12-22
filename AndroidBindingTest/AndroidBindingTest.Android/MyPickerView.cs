using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidBindingTest.Droid;
using Com.Bigkoo.Pickerview;

[assembly: Xamarin.Forms.Dependency(typeof(MyPickerView))]
namespace AndroidBindingTest.Droid
{
    public class MyPickerView : IMyPickerView
    {

        public void OpenDateTimePick(bool showDate = true, bool showTime = true, Action<DateTime> OnSelectedAction = null)
        {
            var activity = Xamarin.Forms.Forms.Context as Activity;

            var impl = new OnTimeSelectListenerImpl()
            {
                //  MyPicker = this,
                AAA = (dt) =>
                {
                    OnSelectedAction?.Invoke(dt);
                    // Toast.MakeText(((Activity)Xamarin.Forms.Forms.Context), dt.ToString(), ToastLength.Short).Show();
                }
            };

            TimePickerView timePicker = new TimePickerView.Builder(activity, impl)
                                            .SetType(new[] { showDate, showDate, showDate, showTime, showTime, showTime })
                                            .Build();

            timePicker.Show();
        }

        // public Action<int, int, int> OnOptionSelectedAction { get; set; }

        public void OpenOptionsPick(List<string> options1, List<List<string>> options2 = null, List<List<List<string>>> options3 = null, Action<int, int, int> OnSelectedAction = null)
        {
            var activity = Xamarin.Forms.Forms.Context as Activity;

            var impl = new OnOptionsSelectListenerImpl()
            {
                AAA = (o1, o2, o3) =>
                {
                    OnSelectedAction?.Invoke(01, 02, 03);
                }
            };

            var optionPick = new OptionsPickerView.Builder(activity, impl)
                .Build();

            List<string> list1 = new List<string>();
            List<IList> list2 = new List<IList>();
            List<IList<IList>> list3 = new List<IList<IList>>();

            if (options1 != null)
            {
                list1 = options1;
            }

            if (options2 != null)
            {
                foreach (var item in options2)
                {
                    list2.Add(item);
                }
            }

            if (options3 != null)
            {
                foreach (var item1 in options3)
                {
                    var tmp1 = new List<IList>();
                    foreach (var item2 in item1)
                    {
                        tmp1.Add(item2);
                    }

                    list3.Add(tmp1);
                }
            }

            #region demo data

            // demo 
            //var list1 = new List<string>();
            //var list2 = new List<IList>();
            //var list3 = new List<IList<IList>>();

            //for (int i = 1; i < 10; i++)
            //{
            //    list1.Add(i.ToString());

            //    var list2Tmp = new List<string>();
            //    var list3Tmp = new List<IList>();


            //    for (int j = 1; j < 10; j++)
            //    {
            //        list2Tmp.Add($"{i}{j}");

            //        var tmp3 = new List<string>();

            //        for (int k = 1; k < 10; k++)
            //        {
            //            tmp3.Add($"{i}{j}{k}");
            //        }

            //        list3Tmp.Add(tmp3);
            //    }


            //    list2.Add(list2Tmp);
            //    list3.Add(list3Tmp);
            //}

            #endregion

            if (list3.Count > 0)
                optionPick.SetPicker(list1, list2, list3);
            else if (list2.Count > 0)
                optionPick.SetPicker(list1, list2);
            else if (list1.Count > 0)
                optionPick.SetPicker(list1);

            optionPick.Show();
        }
    }

    public class OnTimeSelectListenerImpl : Java.Lang.Object, TimePickerView.IOnTimeSelectListener
    {
        public void OnTimeSelect(Java.Util.Date date, View p1)
        {
            var selected = date.ToDateTime();

            // Toast.MakeText(((Activity)Xamarin.Forms.Forms.Context), selected.ToString(), ToastLength.Short).Show();  

            AAA(selected);
        }

        public Action<DateTime> AAA { get; set; }

    }

    public class OnOptionsSelectListenerImpl : Java.Lang.Object, OptionsPickerView.IOnOptionsSelectListener
    {
        public void OnOptionsSelect(int p0, int p1, int p2, View p3)
        {
            AAA(p0, p1, p2);
        }

        public Action<int, int, int> AAA { get; set; }
    }

    static class Extensions
    {
        public static DateTime ToDateTime(this Java.Util.Date date)
        {
            Java.Text.SimpleDateFormat format = new Java.Text.SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
            return DateTime.Parse(format.Format(date));

            // return new DateTime(date.Year, date.Month, date.Day, date.Hours, date.Minutes, date.Seconds);
        }
    }
}