using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace POC.Modal
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.TitleModal = "My modal";
            this.ContentModal = "Hello modal!";
        }

        public static readonly BindableProperty TitleModalProperty = BindableProperty.Create<Page1, string>(x => x.TitleModal, default(string));

        public string TitleModal
        {
            get { return (string)base.GetValue(TitleModalProperty); }
            set { base.SetValue(TitleModalProperty, value); }
        }


        public static readonly BindableProperty ContentModalProperty = BindableProperty.Create<Page1, string>(x => x.ContentModal, default(string));

        public string ContentModal
        {
            get { return (string)base.GetValue(ContentModalProperty); }
            set { base.SetValue(ContentModalProperty, value); }
        }    
    
    
    }
}
