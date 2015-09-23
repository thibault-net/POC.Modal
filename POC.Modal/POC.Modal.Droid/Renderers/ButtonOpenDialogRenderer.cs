using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using POC.Modal.Droid.Renderers;
using POC.Modal;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(ButtonOpenDialog), typeof(ButtonOpenDialogRenderer))]
namespace POC.Modal.Droid.Renderers
{
    public class ButtonOpenDialogRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
                e.NewElement.Clicked += NewElement_Clicked;
        }

        void NewElement_Clicked(object sender, EventArgs e)
        {
            var d = new Dialog(Xamarin.Forms.Forms.Context);
            d.SetTitle((this.Element as ButtonOpenDialog).TitleModal);
            var renderer = RendererFactory.GetRenderer((this.Element as ButtonOpenDialog).ContentModal);
            // TODO : à ajuster
            Android.Widget.LinearLayout.LayoutParams params1 = new Android.Widget.LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            params1.Height = 300;
            d.AddContentView(renderer.ViewGroup, params1);
            d.Show();

            this.UpdateLayout();
        }
    }
}