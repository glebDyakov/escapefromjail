﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSettings : MonoBehaviour {

	void OnMouseDown () {
		SceneManager.LoadScene ("Settings");
	}
}
