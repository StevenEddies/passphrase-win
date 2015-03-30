using PassphraseGenerator.Domain;
using PassphraseGenerator.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassphraseGenerator.Run
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            IRandom random = new PassphraseGenerator.Domain.Random();
            IDictionary[] dictionaries = DictionaryFactory.loadDictionaries();
            Generator generator = new Generator(random, dictionaries);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(generator));
        }
    }
}
