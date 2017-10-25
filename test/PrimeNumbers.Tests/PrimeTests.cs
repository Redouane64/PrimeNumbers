using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeNumbers.Tests
{
    public class PrimeTests
    {
        [Fact(DisplayName = "Generate four primes at least.")]
        public void ShouldGenerateAtLeastFourPrimes()
        {
            uint[] expected_primes = new uint[4] { 2, 3, 5, 7 };

            uint[] primes = Prime.GetPrimeNumbers(0);

            Assert.Equal(expected_primes.Length, primes.Length);
            Assert.Equal(expected_primes, primes);
        }

        [Fact(DisplayName = "Generate first ten primes.")]
        public void ShouldGenerateFirstTenPrimes()
        {
            const int N = 10;
            uint[] expected_primes = new uint[N] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            uint[] primes = Prime.GetPrimeNumbers(N);

            Assert.Equal(expected_primes.Length, primes.Length);
            Assert.Equal(expected_primes, primes);
        }
    }
}
