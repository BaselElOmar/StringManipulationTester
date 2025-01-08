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
        }

        public string ToLower(string originString)
        {
            originString = originString.ToLower();
            return originString;
        }
    }
}