using FluentAssertions;
using System;
using Xunit;

namespace Sasw.TestSupport.UnitTests.GuidGeneratorTests
{
    public static class CreateTests
    {
        public class Given_An_Integer_When_Creating
            : Given_When_Then_Test
        {
            private Guid _result;
            private Guid _expectedGuid;

            protected override void Given()
            {
                _expectedGuid = Guid.Parse("00000001-0000-0000-0000-000000000000");
            }

            protected override void When()
            {
                _result = GuidGenerator.Create(1);
            }

            [Fact]
            public void Then_It_Should_Return_A_Valid_Guid()
            {
                _result.Should().NotBeEmpty();
            }

            [Fact]
            public void Then_It_Should_Have_The_Right_Guid()
            {
                _result.Should().Be(_expectedGuid);
            }
        }
    }
}