﻿using UnityEngine;

namespace Hot2
{
	public static class Game
	{
		private static EventSystem eventSystem;

		public static EventSystem EventSystem
		{
			get
			{
				return eventSystem ?? (eventSystem = new EventSystem());
			}
		}
		
		private static Scene scene;

		public static Scene Scene
		{
			get
			{
				if (scene != null)
				{
					return scene;
				}
				scene = new Scene() { Name = "ClientH2" };
				return scene;
			}
		}

		private static ObjectPool objectPool;

		public static ObjectPool ObjectPool
		{
			get
			{
				if (objectPool != null)
				{
					return objectPool;
				}
				objectPool = new ObjectPool() { Name = "ClientH2" };
				return objectPool;
			}
		}

		public static void Close()
		{
			scene?.Dispose();
			scene = null;
			
			objectPool?.Dispose();
			objectPool = null;
			
			eventSystem = null;
		}
	}
}