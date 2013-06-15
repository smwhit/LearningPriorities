using System;
using System.Collections.Generic;

namespace LearningPriorities
{
	public interface ILearningItemRepository
	{
		IEnumerable<LearningItem> GetAll();

		void Create(LearningItem item);

		void Update(LearningItem item);
	}
}

