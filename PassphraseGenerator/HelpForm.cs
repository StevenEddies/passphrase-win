/*
 * 
 * Copyright 2015 Steven Eddies
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

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
