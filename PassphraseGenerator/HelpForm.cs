using PassphraseGenerator.Properties;
using System.Diagnostics;
using System.Windows.Forms;

namespace PassphraseGenerator
{
    /// <summary>
    /// Form to display help and tips.
    /// </summary>
    public partial class HelpForm : Form
    {
        internal HelpForm()
        {
            InitializeComponent();

            helpBrowser.DocumentText = Resources.help;
        }

        private void helpBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.Scheme != "about")
            {
                // Prevent the browser control from navigating
                e.Cancel = true;

                // Open in external browser instead
                Process.Start(e.Url.AbsoluteUri);
            }
        }
    }
}
