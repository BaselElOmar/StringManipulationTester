using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace CiCdgrupp

public class StringsManipulation
{

    string originString = "Hello World";


    public string TUpper(string origingstring)
    {
        origingstring = origingstring.ToUpper();
        return originString;
    }



}
