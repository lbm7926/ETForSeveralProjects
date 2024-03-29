﻿using UnityEngine;

namespace Hot2
{
	public interface IUIFactory
	{
		UI Create(Scene scene, string type, GameObject parent);
		void Remove(string type);
	}
}