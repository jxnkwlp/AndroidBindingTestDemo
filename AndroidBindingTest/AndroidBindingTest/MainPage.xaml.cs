using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidBindingTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            UserDialogs.Instance.Toast($"这是提示~~~{DateTime.Now}");

        }


        private void Button1_Clicked(object sender, EventArgs e)
        {
            var pickView = DependencyService.Get<IMyPickerView>();

            pickView.OpenDateTimePick(OnSelectedAction: (dt) =>
            {
                UserDialogs.Instance.Toast(dt.ToString());
            });


        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
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



            var pickView = DependencyService.Get<IMyPickerView>();

            pickView.OpenOptionsPick(new List<string> { "广东", "上海", "北京" }, OnSelectedAction: (i1, i2, i3) =>
            {
                UserDialogs.Instance.Toast("{i1}-{i2}-{i3}");
            });

        }

    }
}
