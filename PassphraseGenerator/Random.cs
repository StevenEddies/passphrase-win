using System;
using System.Security.Cryptography;

namespace PassphraseGenerator.Domain
{
    /// <summary>
    /// An object capable of generating secure random numbers.
    /// </summary>
    internal interface IRandom
    {
        /// <summary>
        /// Generates and returns a secure random number between 0 (inclusive) and exMax (exclusive).
        /// </summary>
        uint Generate(uint exMax);
    }

    /// <summary>
    /// An object capable of generating secure random numbers.
    /// </summary>
    internal class Random : IRandom
    {
        private RandomNumberGenerator rand;

        public Random()
        {
            rand = RandomNumberGenerator.Create();
        }

        public uint Generate(uint exMax)
        {
            if (exMax == 0)
                return 0;

            uint bitsRequired = (uint)Math.Ceiling(Math.Log(exMax, 2));
            uint bytesRequired = (uint)Math.Ceiling(bitsRequired / 8.0);
            int spareBits = (int)((bytesRequired * 8) - bitsRequired);
            byte[] rawRandom = new byte[bytesRequired];
            uint generatedNumber;

            do
            {
                // Get random bytes
                rand.GetBytes(rawRandom);

                // Expand to uint
                generatedNumber = rawRandom[0];
                for (uint i = 1; i < bytesRequired; i++)
                {
                    generatedNumber *= 256;
                    generatedNumber += rawRandom[i];
                }

                // Remove spare bits
                generatedNumber >>= spareBits;
            }
            // If more than the maximum, try again
            while (generatedNumber >= exMax);

            return generatedNumber;
        }
    }
}
