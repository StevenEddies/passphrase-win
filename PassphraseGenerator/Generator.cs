using System;
using System.Text;

namespace PassphraseGenerator.Domain
{
    /// <summary>
    /// Delegate to handle status updates.
    /// </summary>
    internal delegate void StatusUpdateHandler();

    /// <summary>
    /// Controller class for generating phrases.
    /// </summary>
    internal class Generator
    {
        private const int LENGTH_INDEX_MAXIMUM = 8;
        private const int LENGTH_OFFSET = 2;

        private const int LENGTH_INDEX_DEFAULT = 2;
        private const int DICTIONARY_INDEX_DEFAULT = 3;

        private IDictionary[] _Dictionaries;
        private IDictionary _CurrentDictionary;
        private int _CurrentLength;
        private IRandom _RandomGenerator;

        public event StatusUpdateHandler StatusUpdated;

        public int DictionaryIndex
        {
            get
            {
                return Array.FindIndex(_Dictionaries, d => d == _CurrentDictionary);
            }
            set
            {
                if (value < 0 || value >= _Dictionaries.Length)
                    throw new ArgumentOutOfRangeException();
                _CurrentDictionary = _Dictionaries[value];
                RaiseStatusUpdated();
            }
        }

        public int LengthIndex
        {
            get
            {
                return _CurrentLength - LENGTH_OFFSET;
            }
            set
            {
                if (value < 0 || value > LENGTH_INDEX_MAXIMUM)
                    throw new ArgumentOutOfRangeException();
                _CurrentLength = value + LENGTH_OFFSET;
                RaiseStatusUpdated();
            }
        }

        public string StatusLabel
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(_CurrentDictionary.Label);
                sb.Append(" dictionary, ");
                sb.Append(_CurrentLength);
                sb.Append(" words, ");
                sb.Append(GetEntropy().ToString("N0"));
                sb.Append(" bits of entropy");
                return sb.ToString();
            }
        }

        public Generator(IRandom aRandom, IDictionary[] aDictionaries)
        {
            _Dictionaries = aDictionaries;
            _RandomGenerator = aRandom;

            DictionaryIndex = DICTIONARY_INDEX_DEFAULT;
            LengthIndex = LENGTH_INDEX_DEFAULT;
        }

        private void RaiseStatusUpdated()
        {
            if (StatusUpdated != null)
                StatusUpdated();
        }

        private double GetEntropy()
        {
            double entropyPerWord = Math.Log(_CurrentDictionary.Length, 2);
            double totalEntropy = entropyPerWord * _CurrentLength;
            return totalEntropy;
        }

        public string Generate()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _CurrentLength; i++)
            {
                if (i > 0)
                    sb.Append(" ");
                sb.Append(_CurrentDictionary.FindWord(_RandomGenerator.Generate(_CurrentDictionary.Length)));
            }
            return sb.ToString();
        }
    }
}
