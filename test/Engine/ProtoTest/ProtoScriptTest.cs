using NUnit.Framework;
namespace ProtoTest
{
    [TestFixture]
    class ProtoScriptTest : ProtoTestBase
    {
        [Test]
        public void BasicInfrastructureTest()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
@"
        }
    }

    [TestFixture]
    class MultiLangNegitiveTests : ProtoTestBase
    {
        //Negitive Tests with distortions of the Language def block
        [Test]
        public void ParserFailTest1()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            //@TODO: What exception should this throw
            Assert.Throws(typeof(ProtoCore.Exceptions.CompileErrorsOccured), () =>
            {
                fsr.Execute(
    @"
            });
        }
        [Test]
        public void ParserFailTest2()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            //@TODO: What exception should this throw
            Assert.Throws(typeof(ProtoCore.Exceptions.CompileErrorsOccured), () =>
            {
                fsr.Execute(
    @"
            });
        }
        [Test]
        public void ParserFailTest3()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            //@TODO: What exception should this throw
            Assert.Throws(typeof(ProtoCore.Exceptions.CompileErrorsOccured), () =>
            {
                fsr.Execute(
    @"
            });
        }
    }
}