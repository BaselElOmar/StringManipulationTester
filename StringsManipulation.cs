using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace CiCdgrupp
{

    public class StringsManipulation
    {

        public string ToUpper(string input)
        {

            return input.ToUpper();
       // tester
        }

        public string ToLower(string input)
        {
            return input.ToLower();
        }
    }
}