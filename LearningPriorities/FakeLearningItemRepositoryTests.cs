using System;
using NUnit.Framework;
using System.Linq;

namespace LearningPriorities
{
	[TestFixture]
	public class FakeLearningItemRepositoryTests
	{
		[Test]
		public void CanRetrieveFakeItems()
		{
			FakeLearningItemRepository repo = new FakeLearningItemRepository ();
			Assert.Greater (repo.GetAll ().Count(), 0);
		}
	}
}

