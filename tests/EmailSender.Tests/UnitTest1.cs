using EmailSender.API.DTO_s;
using EmailSender.API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailSender.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var config = new EmailCodeConfigDto() { NumberDigits = 6 };

            var codeGeneratorServiceInstance = new CodeGeneratorService();
            var code = codeGeneratorServiceInstance.GenerateEmailCode(config);
        }
    }
}