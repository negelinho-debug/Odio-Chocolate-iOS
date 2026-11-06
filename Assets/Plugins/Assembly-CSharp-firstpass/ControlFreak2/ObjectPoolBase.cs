using System.Collections.Generic;

namespace ControlFreak2
{
	public abstract class ObjectPoolBase<T>
	{
		protected List<T> usedList;

		protected List<T> unusedList;

		public ObjectPoolBase()
		{
		}

		protected abstract T CreateInternalObject();

		protected virtual void OnDestroyObject(T obj)
		{
		}

		protected virtual void OnUseObject(T obj)
		{
		}

		protected virtual void OnUnuseObeject(T obj)
		{
		}

		public int GetAllocatedCount()
		{
			return 0;
		}

		public int GetUsedCount()
		{
			return 0;
		}

		public int GetUnusedCount()
		{
			return 0;
		}

		public List<T> GetList()
		{
			return null;
		}

		public T GetNewObject(int insertPos = -1)
		{
			return default;
		}

		public void UnuseObject(T obj)
		{
		}

		public void Clear()
		{
		}

		public void Trim(int maxCount, bool trimAtEnd = true)
		{
		}

		public void EnsureCapacity(int count)
		{
		}

		public void Allocate(int count)
		{
		}

		public void DestroyAll()
		{
		}
	}
}
