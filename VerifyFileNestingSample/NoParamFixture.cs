namespace VerifyFileNestingSample;

public class NoParamFixture
{
    [Test]
    public Task VerifyNestedOption1()
    {
        return Verify(FixtureOption.Option1);
    }

    [Test]
    public Task VerifyNestedOption2()
    {
        return Verify(FixtureOption.Option2);
    }
}
