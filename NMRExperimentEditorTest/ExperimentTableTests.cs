using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditorTest
{
    [TestClass]
    public class ExperimentTableTests
    {
        [TestMethod]
        public void ExperimentTableRelayCodeTest()
        {
            // Arrange

            var status = RelayStatus.Relay1 | RelayStatus.Relay3 | RelayStatus.Relay6;
           

            byte expected = Convert.ToByte("00100101", 2);

            // Apply
            var actual = Helpers.RelayStatusToByte(status);

            // Assertion
            Assert.AreEqual(expected, actual);
        }
    }
}
