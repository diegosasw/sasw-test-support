# sasw-test-support
Given-Then-When abstract classes to make more readable tests

## How To Use
When creating unit or integration tests, extend the class `Given_When_Then_Test` or `Given_WhenAsync_Then_Test` in order to achieve more readable tests.
The Given should contain all the arranges for the scenario.
The When should contain the execution to trigger the scenario to be tested.
The Then are the facts that are asserted.

Example:

```
public class Given_Valid_Dependencies_When_Constructing_Instance
    : Given_When_Then_Test
{
    private Sample _sut;
    private Guid _id;

    protected override void Given()
    {
        _id = Guid.NewGuid();
    }

    protected override void When()
    {
        _sut = new Sample(_id);
    }

    [Fact]
    public void Then_It_Should_Have_Created_A_Valid_Instance()
    {
        _sut.Should().NotBeNull();
    }

    [Fact]
    public void Then_It_Should_Have_The_Expected_Id()
    {
        _sut.Id.Should().Be(_id);
    }
}
```