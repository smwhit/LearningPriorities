using System;
using System.Collections.Generic;

namespace LearningPriorities
{
	public class FakeLearningItemRepository : ILearningItemRepository
	{
		public IEnumerable<LearningItem> GetAll ()
		{
			return new List<LearningItem> {
				new LearningItem { Label = "Decide on storage for ToDo App", 
									Notes = "Redis or RavenDb?", 
									Dependents = new [] {
						new LearningItem { Label = "Something else"}
					}	
				}};
		}

		public void Create (LearningItem item)
		{
			throw new NotImplementedException ();
		}

		public void Update (LearningItem item)
		{
			throw new NotImplementedException ();
		}
	}
}

