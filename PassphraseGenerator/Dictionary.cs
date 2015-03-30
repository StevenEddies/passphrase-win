using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using PassphraseGenerator.Properties;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PassphraseGenerator.Domain
{
    /// <summary>
    /// Represents a dictionary from which words can be chosen.
    /// </summary>
    internal interface IDictionary
    {
        uint Length
        {
            get;
        }

        string Label
        {
            get;
        }

        string FindWord(uint index);
    }

    /// <summary>
    /// Represents a dictionary from which words can be chosen.
    /// </summary>
    internal class Dictionary : IDictionary
    {
        private List<string> _words;
        private string _label;

        /// <summary>
        /// Constructs a new Dictionary with the given label and word list. The list must not be modified.
        /// </summary>
        internal Dictionary(string label, List<string> words)
        {
            _label = label;
            _words = words;
        }

        public uint Length
        {
            get
            {
                return (uint)_words.Count;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }
        }

        public string FindWord(uint index)
        {
            if (index >= Length)
                return null;

            return _words[(int)index];
        }
    }

    /// <summary>
    /// Factory class for loading dictionaries.
    /// </summary>
    internal static class DictionaryFactory
    {
        private static byte[][] dicResources = {
            Resources.dic_0,
            Resources.dic_1,
            Resources.dic_2,
            Resources.dic_3,
            Resources.dic_4,
            Resources.dic_5,
            Resources.dic_6
        };
        private static string[] dicLabels = {
            "Tiny",
            "Extra small",
            "Small",
            "Standard",
            "Large",
            "Extra large",
            "Extreme"
        };

        /// <summary>
        /// Loads all dictionaries and returns them as an array.
        /// </summary>
        internal static IDictionary[] loadDictionaries()
        {
            IDictionary[] dictionaries = new IDictionary[dicResources.Length];

            for (int i = 0; i < dicResources.Length; i++)
                dictionaries[i] = fromData(dicLabels[i], dicResources[i]);

            return dictionaries;
        }

        /// <summary>
        /// Creates a new IDictionary from the given resource data.
        /// </summary>
        private static IDictionary fromData(string label, byte[] data)
        {
            List<string> words = new List<string>();
            using (Stream baseStream = new MemoryStream(data))
            using (Stream inflatedStream = new InflaterInputStream(baseStream))
            using (StreamReader reader = new StreamReader(inflatedStream, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    words.Add(reader.ReadLine());
                }
            }
            return new Dictionary(label, words);
        }
    }
}
