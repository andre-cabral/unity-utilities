using UnityEngine;
using System.Collections;

public class PlayerPrefsScript : MonoBehaviour {

	void Awake () {

		//Playerprefs should only be used for preferences, because it creates a plain text file with the prefs, and it is not secure

		//How to save
		PlayerPrefs.SetInt("MouseSensibility",100);
		PlayerPrefs.Save();

		//How to load
		int mouseSensibility = PlayerPrefs.GetInt("MouseSensibility");
	}
}
