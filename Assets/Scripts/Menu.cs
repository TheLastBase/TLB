﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void ChangeScene (string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
