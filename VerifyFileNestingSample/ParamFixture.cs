namespace VerifyFileNestingSample;

[TestFixture(FixtureOption.Option1)]
[TestFixture(FixtureOption.Option2)]
public class ParamFixture
{
    private readonly FixtureOption _option;

    public ParamFixture(FixtureOption option)
    {
        _option = option;
    }

    [Test]
    public Task VerifyNestedOption()
    {
        return Verify(_option);
    }
}

public enum FixtureOption
{
    Option1,
    Option2,
}
