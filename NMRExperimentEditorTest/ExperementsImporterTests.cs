using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMRExperimentEditor.Serializers;

namespace NMRExperimentEditorTest
{
    [TestClass]
    public class ExperementsImporterTests
    {
        [TestMethod]
        public void ExperementsImporterTest()
        {
            var stream = GenerateStream();

            var importer = new ExperementsImporter();

            var retRes = importer.Import(stream, out var experiments);
        }

        private Stream GenerateStream()
        {
            var exp0 = "0000 0001 9999 9a37 1412   0115        C30B      001d   2020    0010    0010     0505     0200  0800 00CF";
            var exp1 = "0001 0001 A073 9a05 64C8   0b64        8210      007d   001a    007d    0009     1401     0000  0800 001F";

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(exp0);
            writer.Write(Environment.NewLine);
            writer.Write(exp1);

            writer.Flush();
            stream.Position = 0;

            return stream;
        }
    }
}
