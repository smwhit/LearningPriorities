using System;
using System.Collections.Generic;

namespace LearningPriorities
{
	public class LearningItem
	{
		public long Id { get ; set; }

		public string Label { get; set;}

		public int Priority { get; set; }

		public DateTime DateAdded { get; set; }

		public DateTime DateStarted { get; set; }

		public DateTime DateCompleted { get; set; }

		public string Notes { get; set; }

		public LearningItem[] Dependents { get; set; }
	}
}