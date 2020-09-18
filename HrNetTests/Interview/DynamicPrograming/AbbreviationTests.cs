using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.DynamicPrograming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.DynamicPrograming.Tests
{
    [TestClass()]
    public class AbbreviationTests
    {
        [TestMethod()]
        public void abbreviationTest1()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("AbcDE", "ABDE");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest2()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("AbcDE", "AFDE");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void abbreviationTestDD()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("ACDE", "ABCD");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void abbreviationTest3()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("daBcd", "ABC");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest4_2()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("beFgH", "EFG");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void abbreviationTest4_3()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("beFgH", "EFH");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest5_5()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("KXzQ", "K");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void abbreviationTest65()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("EOWZEOHWYOJTBNMcefdsp", "EOWZEOHWYOJTBNM");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest04_1()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("XXVVnDEFYgYeMXzWINQYHAQKKOZEYgSRCzLZAmUYGUGILjMDET", "XXVVDEFYYMXWINQYHAQKKOZEYSRCLZAUYGUGILMDETQVWU");
            Assert.IsTrue(res == "NO");

            //XXVVnDEFYgYeMXzWINQYHAQKKOZEYgSRCzLZAmUYGUGILjMDET
            //XXVVDEFYYMXWINQYHAQKKOZEYSRCLZAUYGUGILMDETQVWU
            //XVNEYYMZIQHQKZYSCLAUGGLDT
        }
        [TestMethod()]
        public void abbreviationTest04_10()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("EIZGAWWDCSJBBZPBYVNKRDEWVZnSSWZIw", "EIZGAWWDCSJBBZPBYVNKRDEWVZSSWZI");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest06_1()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("RDWPJPAMKGRIWAPBZSYWALDBLDOFLWIQPMPLEMCJXKAENTLVYMSJNRJAQQPWAGVcGOHEWQYZDJRAXZOYDMNZJVUSJGKKKSYNCSFWKVNHOGVYULALKEBUNZHERDDOFCYWBUCJGbvqlddfazmmohcewjg", "RDPJPAMKGRIWAPBZSYWALDBLOFWIQPMPLEMCJXKAENTLVYMJNRJAQQPWAGVGOHEWQYZDJRAXZOYDMNZJVUSJGKKKSYNCSFWKVNHOGVYULALKEBUNZHERDOFCYWBUCJG");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void abbreviationTest06_2()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("MBQEVZPBjcbswirgrmkkfvfvcpiukuxlnxkkenqp", "MBQEVZP");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void abbreviationTest06_3()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("DINVMKSOfsVQByBnCWNKPRFRKMhFRSkNQRBVNTIKNBXRSXdADOSeNDcLWFCERZOLQjEZCEPKXPCYKCVKALNxBADQBFDQUpdqunpelxauyyrwtjpkwoxlrrqbjtxlkvkcajhpqhqeitafcsjxwtttzyhzvh", "DINVMKSOVQBBCWNKPRFRKMFRSNQRBVNTIKNBXRSXADOSNDLWFCERZOLQEZCEPKXPCYKCVKALNBADQBFDQU");
            Assert.IsTrue(res == "YES");
        }


        [TestMethod()]
        public void abbreviationTest06_4()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("BFZZVHdQYHQEMNEFFRFJTQmNWHFVXRXlGTFNBqWQmyOWYWSTDSTMJRYHjBNTEWADLgHVgGIRGKFQSeCXNFNaIFAXOiQORUDROaNoJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMvSTGEQCYAJSFvbqivjuqvuzafvwwifnrlcxgbjmigkms", "BFZZVHQYHQEMNEFFRFJTQNWHFVXRXGTFNBWQOWYWSTDSTMJRYHBNTEWADLHVGIRGKFQSCXNFNIFAXOQORUDRONJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMSTGEQCYAJSF");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest06_4_2()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("DLgHVgGIR", "DLHVGIR");
            Assert.IsTrue(res == "YES");
        }



        [TestMethod()]
        public void abbreviationTest06_5()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("AQIUQVIPJDKYNEBPXFGVHCMFGvURORPRSTYQYJZCYJDNFRPRYTMZIsNDOJAOAGAEFRCDKUJBhdkedalbwoxxnoyowoxpdlelovibyiwat", "AQIUQVIPJDKYNEBPXFGVHCMFGURORPRSTYQYJZCYJDNFRPRYTMZINDOJAOAGAEFRCDKUJB");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest06_6()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("HCPXJZTDXLWHYKHPPDFYFDJWTAETQLJCIIPVHMZHHOQTKONUHGYVKLXTFTBEMYAWXTCSwNJYALIGMIBDOWKIVStFATDOZCYSUCaATUWORPMTFPKTNHDSFWKRKBrXNBYICOZYDWLLElKKWTFAUSTZKFDCBQNYVcWKDHDMXJGFORwURHISYLBIZSOJXVRVBNPQLRJKIN", "HCPXJZTDXLWHYKHPPDFYFDJWTAETQLJCIIPVHMZHHOQTKONUHGYVKLXTFTBEMYAWXTCSNJYALIGMIBDOWKIVSFATDOZCYSUCATUWORPMTFPKTNHDSFWKRKBXNBYICOZYDWLLEKKWTFAUSTZKFDCBQNYVWKDHDMXJGFORURHISYLBIZSOJXVRVBNPQLRJKINIIOYB");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void abbreviationTest06_7()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("IZLAKtDFAITDNWMVQPDShQQFGTRIXDLNBQPZRpuRJMLLPHBMOWrNagJDPPREZSYBHIWKDHLkjPSEUWIVQYUfPPJYKCbPEKCSKBRIAAJTMDPAOLNWSQESOTRQZOFTMTTGTDTrWLPENHXHLDWAFNDZMIFlogtcddtulusydquboxquwmgcji", "IZLAKDFAITDNWMVQPDSQQFGTRIXDLNBQPZRRJMLLPHBMOWNJDPPREZSYBHIWKDHLPSEUWIVQYUPPJYKCPEKCSKBRIAAJTMDPAOLNWSQESOTRQZOFTMTTGTDTWLPENHXHLDWAFNDZMIF");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest06_8()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("KRBPLVCTESRNPTCVNDMPTQYvFAWBGYPQHNXNAESRQMKFDZIEKVNZXSXKCFHQYCMMANPQFHWCEeNGOLWTUXZVMQNDZfRPLUFZcSTRLRYAZUKAZYXCVTNTNScSDFTBJSUKEQKZRDITZUCFVAPLCLTUWAXOnNHPYEOZDGWZPBJQBZEOFAeXTFJDWRHI", "KRBPVCTESRNPTCVNDMPTQYFWBGYPQHXNAESRQMFDZIEKVNZXSXKFHQYCMMANPQFHWCNGOLWTUXZVMQNDZRPLUFZSTRLRYAZUAZYXCVTNTNSSDTBJSUKEQKZRDITZUCFVAPCLTUWAXONHPYEOZDGWZPBJQBZEOAXTFJDWRHIPGQVCWODYNNV");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void abbreviationTest06_9()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("WOAECAAVWMSQMIMYMAPEVARGIZCTIVNLAgydhmrxwcjltpjdewxhxrtynyyuyhqwbpkwuqtpwmyhemjxvwoazumyfstoumreirdkwbmepwbrgmyhjgtqeltzxnwhbunvuoejnhfqcikggaqjgsoqhzrmu", "WOAECAAVWMSQMIMYMAPEVARGIZCTIVNLA");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void abbreviationTest06_10()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("RMPRWOBYTSjXGVJQPDQEHTWXMOGcHVWKATSWLBWPJBQTYKVHKMFKCYVVJXGLUEZTLSXChGBCAOAMiFEAPPAGWeMXXQAQTFCZGXKOGZLLUWTZDOYVWHIJZEIDOSHPwFWHYXCIZKTjKKVKQNDXMTCCBQMAGVCDPZOXHPSEQYthuqclzletakrqbzmaohadpog", "RMPRWOBYTSXGVJQPDQEHTWXMOGHVWKATSWLBWPJBQTYKVHKMFKCYVVJXGLUEZTLSXCGBCAOAMFEAPPAGWMXXQAQTFCZGXKOGZLLUWTZDOYVWHIJZEIDOSHPFWHYXCIZKTKKVKQNDXMTCCBQMAGVCDPZOXHPSEQY");
            Assert.IsTrue(res == "YES");
        }


        [TestMethod()]
        public void abbreviationTest12()
        {
            Abbreviation ab = new Abbreviation();

            string[] lines = File.ReadAllLines(@"./data/abbreviation/input12.txt");
            string[] answers = File.ReadAllLines(@"./data/abbreviation/output12.txt");
            int tests = Convert.ToInt32(lines[0]);
            int answerI = 0;
            for (int i = 1; i <= tests; i += 2)
            {
                string a = lines[i];
                string b = lines[i + 1];
                string answer = answers[answerI++];
                string res = ab.abbreviation(a, b);
                Assert.IsTrue(res == answer);
            }

        }


        [TestMethod()]
        public void abbreviationTest12_01()
        {
            Abbreviation ab = new Abbreviation();
            string res = ab.abbreviation("HACAAC", "AhahcCh");
            Assert.IsTrue(res == "NO");

        }

        //ccaaHacaac

    }
}

