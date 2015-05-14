using UnityEngine;
using System.Collections;

//To serialize needs these 3 libraries
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class PersistenceController : MonoBehaviour {

	//Static so you can access the instance in any other class calling PersistenceController.control
	//This is a singleton, so there is only one object of this class instanced.
	//It make sure there is only one on the Awake()
	public static PersistenceController control;

	public float health;
	public float experience;

	public string fileName = "persistentdata.dat";
	private string completeFilePath;

	void Awake() {
		//DontDestroyOnLoad make the object available even when you change the scene.
		//The problem is that you must enter a scene that have the object first
		//The solution is to have one copy of the object on each scene, but when you change scenes
		//the object from previous scene is there too. So you make sure you Destroy this if there is another 
		//object from the class instanced.
		//It can be verified because the variable "control" is static and is unique for every object on the class.
		//So you can verify if any object of the class is in the control static variable.
		if(control == null){
			DontDestroyOnLoad(gameObject);
			control = this;
		}else if(control != this){
			Destroy (gameObject);
		}

		completeFilePath = Application.persistentDataPath + "/"+fileName;
	}
	
	void OnGUI () {
		GUI.Label(new Rect(10,10,100,30), "Health: " + health);
		GUI.Label(new Rect(10,40,100,30), "Experience: " + experience);
	}

	//Application.persistentDataPath is an automatic path unity makes to store data.
	//It works even on mobile, it doesnt work only in webplayer (because webplayer dont have anywhere to srite files)
	public void Save(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(completeFilePath);

		PersistentData data = new PersistentData();
		data.health = health;
		data.experience = experience;

		bf.Serialize(file, data);
		file.Close();
	}

	public void Load(){
		if(File.Exists(completeFilePath)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(completeFilePath, FileMode.Open);

			PersistentData data = (PersistentData)bf.Deserialize(file);
			file.Close();

			health = data.health;
			experience = data.experience;
		}
	}
}

//To serialize we need a class with only the variables that we will serialize and with [Serializable] before the class name
//Serializing a class with methods can cause problems (something to do with monodevelop compiling or something like that)
[Serializable]
class PersistentData{
	public float health;
	public float experience;
}