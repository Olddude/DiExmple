using System;

namespace DiExmple.Domain
{
    public class Todo
    {
		public int Id { get; set; }

		public bool IsDone { get; set; }

		public string Value { get; set; }

		public DateTime Created { get; set; }

		public DateTime Updated { get; set; }
	}
}
