using System;
using System.Collections.Generic;

namespace Thinktecture
{
	public class CustomMappings
	{
		private readonly Dictionary<Type, List<Type>> _types;

		public CustomMappings()
		{
			_types = new Dictionary<Type, List<Type>>();
		}

		public void Add(Type originalType, Type abstraction)
		{
			Add(originalType, new List<Type>() { abstraction });
		}

		public void Add(Type originalType, List<Type> abstractions)
		{
			_types.Add(originalType, abstractions);
		}

		public bool TryGet(Type originalType, out List<Type> abstractions)
		{
			return _types.TryGetValue(originalType, out abstractions);
		}
	}
}
