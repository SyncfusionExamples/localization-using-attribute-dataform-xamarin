using DataformXamarin.Rex;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataformXamarin
{
    public class DataformBehavior : Behavior<SfDataForm>
    {
        public DataformBehavior()
        {

        }
        SfDataForm dataForm;
        protected override void OnAttachedTo(SfDataForm bindable)
        {
            dataForm = bindable;

            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            {
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                Localization.Culture = ci;
                DependencyService.Get<ILocalize>().SetLocale(CultureInfo.CurrentCulture);
            }
            dataForm.DataObject = new ContactInfo();
            base.OnAttachedTo(bindable);
        }
    }
}
