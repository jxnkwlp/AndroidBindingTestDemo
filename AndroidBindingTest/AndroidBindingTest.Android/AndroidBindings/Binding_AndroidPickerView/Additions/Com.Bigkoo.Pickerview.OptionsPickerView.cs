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

namespace Com.Bigkoo.Pickerview
{
    public partial class OptionsPickerView : global::Com.Bigkoo.Pickerview.View.BasePickerView, global::Android.Views.View.IOnClickListener
    {
        static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.bigkoo.pickerview']/class[@name='OptionsPickerView']/method[@name='setPicker' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;T&gt;&gt;']]"
        [Register("setPicker", "(Ljava/util/List;Ljava/util/List;)V", "GetSetPicker_Ljava_util_List_Ljava_util_List_Handler")]
        public virtual unsafe void SetPicker(global::System.Collections.IList options1Items, global::System.Collections.Generic.IList<IList> options2Items)
        {
            if (options2Items == null || options2Items.Count == 0)
            {
                SetPicker(options1Items);
                return;
            }

            List<Java.Util.IList> options2ItemsCast = new List<Java.Util.IList>(options2Items.Count);
            foreach (System.Collections.IList item in options2Items)
            {
                options2ItemsCast.Add(new Java.Util.ArrayList(item));
            }

            if (id_setPicker_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
                id_setPicker_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "setPicker", "(Ljava/util/List;Ljava/util/List;)V");
            IntPtr native_options1Items = global::Android.Runtime.JavaList.ToLocalJniHandle(options1Items);
            IntPtr native_options2Items = global::Android.Runtime.JavaList<Java.Util.IList>.ToLocalJniHandle(options2ItemsCast);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_options1Items);
                __args[1] = new JValue(native_options2Items);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setPicker_Ljava_util_List_Ljava_util_List_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setPicker", "(Ljava/util/List;Ljava/util/List;)V"), __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_options1Items);
                JNIEnv.DeleteLocalRef(native_options2Items);
            }
        }


        List<Java.Util.IList> Convent(global::System.Collections.Generic.IList<IList> list)
        {
            List<Java.Util.IList> itemsCast = new List<Java.Util.IList>(list.Count);
            foreach (System.Collections.IList item in list)
            {
                itemsCast.Add(new Java.Util.ArrayList(item));
            }
            return itemsCast;
        }

        static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.bigkoo.pickerview']/class[@name='OptionsPickerView']/method[@name='setPicker' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;T&gt;&gt;'] and parameter[3][@type='java.util.List&lt;java.util.List&lt;java.util.List&lt;T&gt;&gt;&gt;']]"
        [Register("setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetSetPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
        public virtual unsafe void SetPicker(global::System.Collections.IList options1Items, global::System.Collections.Generic.IList<global::System.Collections.IList> options2Items, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.IList>> options3Items)
        {
            if (options2Items == null || options2Items.Count == 0)
            {
                SetPicker(options1Items);
                return;
            }
            if (options3Items == null || options3Items.Count == 0)
            {
                SetPicker(options1Items, options2Items);
                return;
            }
            //List<Java.Util.IList> options2ItemsCast = new List<Java.Util.IList>(options2Items.Count);
            //foreach (System.Collections.IList item in options2Items)
            //{
            //    options2ItemsCast.Add(new Java.Util.ArrayList(item));
            //}

            List<Java.Util.IList> options2ItemsCast = Convent(options2Items);


            List<global::Android.Runtime.JavaList<Java.Util.IList>> option3ItemsCast = new List<global::Android.Runtime.JavaList<Java.Util.IList>>();
            if (options3Items != null)
            {
                option3ItemsCast = new List<global::Android.Runtime.JavaList<Java.Util.IList>>(options3Items.Count);

                // 1rd 
                foreach (IList<IList> item1 in options3Items)
                {
                    List<Java.Util.IList> items2Cast = new List<Java.Util.IList>(item1.Count);
                    // 2rd 
                    foreach (System.Collections.IList item2 in item1)
                    {
                        items2Cast.Add(new Java.Util.ArrayList(item2));
                    }

                    option3ItemsCast.Add(new JavaList<Java.Util.IList>(items2Cast));
                }

            }


            if (id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
                id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V");
            IntPtr native_options1Items = global::Android.Runtime.JavaList.ToLocalJniHandle(options1Items);
            IntPtr native_options2Items = global::Android.Runtime.JavaList<Java.Util.IList>.ToLocalJniHandle(options2ItemsCast);
            IntPtr native_options3Items = global::Android.Runtime.JavaList<global::Android.Runtime.JavaList<Java.Util.IList>>.ToLocalJniHandle(option3ItemsCast);
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(native_options1Items);
                __args[1] = new JValue(native_options2Items);
                __args[2] = new JValue(native_options3Items);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"), __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_options1Items);
                JNIEnv.DeleteLocalRef(native_options2Items);
                JNIEnv.DeleteLocalRef(native_options3Items);
            }
        }
    }
}