using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditorTest
{   
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        public void HelpersTestsGetFrequencyByFrequencyIndex()
        { 
            uint index1 = 0x01810625;
            double f1 = 470.0 / 1000; // (МГц)

            uint index2 = 0x033B645A;
            double f2 = 1010.0 / 1000; // (МГц)

            double sysClk = 80;

            var freq1 = Helpers.GetFrequencyByFrequencyIndex(index1, sysClk);
            var freq2 = Helpers.GetFrequencyByFrequencyIndex(index2, sysClk);

            Assert.AreEqual(f1, freq1, 1e-5);
            Assert.AreEqual(f2, freq2, 1e-5);
        }
    }
}
