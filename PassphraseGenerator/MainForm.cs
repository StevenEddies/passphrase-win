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

using PassphraseGenerator.Domain;
using System;
using System.Windows.Forms;

namespace PassphraseGenerator.UI
{
    /// <summary>
    /// Main form for the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Reference to controller class.
        /// </summary>
        private Generator Controller;

        /// <summary>
        /// The help display.
        /// </summary>
        private HelpForm _HelpForm;

        /// <summary>
        /// Constructs a new MainForm using the given controller reference.
        /// </summary>
        internal MainForm(Generator aController)
        {
            Controller = aController;
            Controller.StatusUpdated += Controller_StatusUpdated;

            InitializeComponent();
            DictionaryTrackBar.Value = Controller.DictionaryIndex;
            LengthTrackBar.Value = Controller.LengthIndex;
            Disposed += MainForm_Disposed;

            ParametersUpdated();
        }

        private void ParametersUpdated()
        {
            ClearCurrentPhrase();
            StatusLabel.Text = Controller.StatusLabel;
        }

        private void ClearCurrentPhrase()
        {
            PhraseTextBox.Text = "";
            GC.Collect();
        }

        private void GeneratePhrase()
        {
            // Note not using SecureString as it is displayed in a TextBox anyway.
            // Instead, garbage is collected after clearing the phrase - not perfect,
            // but better than nothing.
            ClearCurrentPhrase();
            PhraseTextBox.Text = Controller.Generate();
        }

        private void ShowHelp()
        {
            // Create new form if it doesn't already exist or if it has been disposed
            if (_HelpForm == null || _HelpForm.IsDisposed)
                _HelpForm = new HelpForm();

            // Show if necessary and then activate it
            if (!_HelpForm.Visible)
                _HelpForm.Show();
            _HelpForm.Activate();
        }

        private void Controller_StatusUpdated()
        {
            ParametersUpdated();
        }

        private void DictionaryTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Controller.DictionaryIndex = DictionaryTrackBar.Value;
        }

        private void LengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Controller.LengthIndex = LengthTrackBar.Value;
        }

        private void ClearToolbarButton_Click(object sender, EventArgs e)
        {
            ClearCurrentPhrase();
        }

        private void GenerateToolbarButton_Click(object sender, EventArgs e)
        {
            GeneratePhrase();
        }

        private void HelpToolbarButton_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        void MainForm_Disposed(object sender, EventArgs e)
        {
            if (_HelpForm != null && !_HelpForm.IsDisposed)
                _HelpForm.Dispose();
        }
    }
}
