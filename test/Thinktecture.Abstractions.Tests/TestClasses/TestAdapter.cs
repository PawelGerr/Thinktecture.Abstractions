using System;

namespace Thinktecture.Abstractions.Tests.TestClasses
{
   public class TestAdapter : ITestAbstraction
   {
      TestImplementation IAbstraction<TestImplementation>.UnsafeConvert()
      {
         throw new NotSupportedException();
      }

      public object UnsafeConvert()
      {
         throw new NotSupportedException();
      }
   }
}
