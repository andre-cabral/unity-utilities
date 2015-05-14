using UnityEngine;
using System.Collections;

public class Camera2dMoveX : MonoBehaviour {


	void Update () {
		float axis = Input.GetAxis("Horizontal");
		
		if(axis != 0){
			transform.Translate(Vector3.right * axis);
		}
	}
}
