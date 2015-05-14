using UnityEngine;
using System.Collections;

public class ChangeHealthAndExperience : MonoBehaviour {

	//Can easily access and change the control variable because control is static
	void OnGUI () {
		if(GUI.Button(new Rect(10,100,100,30),"Health up")){
			PersistenceController.control.health += 10;
		}
		if(GUI.Button(new Rect(10,140,100,30),"Health down")){
			PersistenceController.control.health -= 10;
		}
		if(GUI.Button(new Rect(10,180,100,30),"Experience up")){
			PersistenceController.control.experience += 10;
		}
		if(GUI.Button(new Rect(10,220,100,30),"Experience down")){
			PersistenceController.control.experience -= 10;
		}
		if(GUI.Button(new Rect(10,260,100,30),"Save")){
			PersistenceController.control.Save();
		}
		if(GUI.Button(new Rect(10,300,100,30),"Load")){
			PersistenceController.control.Load();
		}
	}
}
