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

		public override string ToString ()
		{
			return string.Format ("[LearningItem: Id={0}, Label={1}, Priority={2}, DateAdded={3}, DateStarted={4}, DateCompleted={5}, Notes={6}, Dependents={7}]", Id, Label, Priority, DateAdded, DateStarted, DateCompleted, Notes, Dependents);
		}
	}
}