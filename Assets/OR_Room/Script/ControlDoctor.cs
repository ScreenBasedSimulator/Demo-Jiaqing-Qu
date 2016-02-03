using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControlDoctor : MonoBehaviour {
	GameObject rightArm;
	GameObject leftArm;
	//GameObject rightForeArm = GameObject.Find("RightForeArm");



	// Use this for initialization
	void Start () {
		rightArm = GameObject.Find("/Characters/Surgeon_A_Cloth/Reference/Hips/Spine/Spine1/Spine2/RightShoulder/RightArm");
		leftArm = GameObject.Find("/Characters/Surgeon_A_Cloth/Reference/Hips/Spine/Spine1/Spine2/LeftShoulder/LeftArm");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rightArm.transform.rotation =  Quaternion.Euler(30f, 176.6f, 44.7f);
			leftArm.transform.rotation =  Quaternion.Euler(312f, 1.2f, 224.7f);

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			rightArm.transform.rotation =  Quaternion.Euler(351f, 176.6f, 44.7f);
			leftArm.transform.rotation =  Quaternion.Euler(8.8f, 1.2f, 224.7f);
		}
	}
	

}
