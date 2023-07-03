using System;
using System.Collections.Generic;

using System.Windows;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCustomTextBoxNumeric
{
    public class MainWindowViewModel : BaseViewModel

    {

        public Action<string, bool> OnkeyUP { get; set; }

        public string Numeric { get; set; }
        public MainWindowViewModel()
        {

            OnkeyUP = OnkeyUPAction;


        }
        private void OnkeyUPAction(string s, bool b)
        {

            if (b)
            {
                if (Numeric != null)
                {
                    Numeric += s;
                }
                else
                {
                    Numeric = s;

                }
            }
            else
            {
                if (Numeric != null)
                {
                    Numeric.Remove(Numeric.Length - 1);
                }
            }
            OnPropertyChanged(nameof(Numeric));
            //            MessageBox.Show("Valid Data");

        }

    }
}
