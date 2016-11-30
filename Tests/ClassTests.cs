using Xunit;

namespace FindReplace.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplace_SingleWordReplace_Goodbye()
    {
      UserInput newInput = new UserInput();
      Assert.Equal("Goodbye", newInput.FindAndReplace("Hello", "Hello", "Goodbye"));
    }
    [Fact]
    public void FindAndReplace_IgnoreCase_Goodbye()
    {
      UserInput newInput = new UserInput();
      Assert.Equal("Goodbye", newInput.FindAndReplace("Hello", "hello", "Goodbye"));
    }
  }
}
