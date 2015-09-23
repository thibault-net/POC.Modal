using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POC.Modal
{
    public class ButtonOpenDialog : Button
    {
        public static readonly BindableProperty ContentModalProperty = BindableProperty.Create<ButtonOpenDialog, View>(x => x.ContentModal, null);

        public View ContentModal
        {
            get { return (View)base.GetValue(ContentModalProperty); }
            set { base.SetValue(ContentModalProperty, value); }
        }

        public static readonly BindableProperty TitleModalProperty = BindableProperty.Create<ButtonOpenDialog, string>(x => x.TitleModal, default(string));

        public string TitleModal
        {
            get { return (string)base.GetValue(TitleModalProperty); }
            set { base.SetValue(TitleModalProperty, value); }
        }

    }
}
