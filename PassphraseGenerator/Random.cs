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
