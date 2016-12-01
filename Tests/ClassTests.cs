using Xunit;

namespace FindReplace.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplace_SingleWordReplace_Goodbye()
    {
      //UserInput newInput = new UserInput();
      Assert.Equal("Goodbye", UserInput.FindAndReplace("Hello", "Hello", "Goodbye"));
    }
    [Fact]
    public void FindAndReplace_IgnoreCase_Goodbye()
    {
      //UserInput newInput = new UserInput();
      Assert.Equal("Goodbye", UserInput.FindAndReplace("Hello", "hello", "Goodbye"));
    }
    [Fact]
    public void FindAndReplace_MultipleWordInput_GoodbyeWorld()
    {
      //UserInput newInput = new UserInput();
      Assert.Equal("Goodbye world", UserInput.FindAndReplace("Hello world", "hello", "Goodbye"));
    }
    [Fact]
    public void FindAndReplace_PartialWordReplace_BadbyeWorld()
    {
      //UserInput newInput = new UserInput();
      Assert.Equal("badbye bad world", UserInput.FindAndReplace("Goodbye good world", "good", "bad"));
    }
  }
}
