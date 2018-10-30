using System;

namespace DiExmple.Domain
{
    public class Todo<T>
    {
		public bool IsDone { get; set; }

		public T Value { get; set; }

		public DateTime Created { get; set; }

		public DateTime Updated { get; set; }
    }
}
