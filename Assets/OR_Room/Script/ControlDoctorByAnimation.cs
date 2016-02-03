using UnityEngine;
using System.Collections;

public class ControlDoctorByAnimation : MonoBehaviour {
	GameObject microscope;

	// Use this for initialization
	void Start () {
		microscope = GameObject.Find ("/Devices/Microscope");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GetComponent<Animation> ().PlayQueued("M_Sit_Microdown", QueueMode.PlayNow);
			microscope.GetComponent<Animation> ().Play ();
			GetComponent<Animation> ().PlayQueued("M_Sit_Idle", QueueMode.CompleteOthers);

		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
//			GetComponent<Animation> ().Play ("M_Sit_Idle_Headturn");
			GetComponent<Animation> ().PlayQueued("M_Sit_Idle_Headturn", QueueMode.PlayNow);
			GetComponent<Animation> ().PlayQueued("M_Sit_Idle", QueueMode.CompleteOthers);

		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
//			GetComponent<Animation> ().Play ("M_Sit_Anestesia");
			GetComponent<Animation> ().PlayQueued("M_Sit_Anestesia", QueueMode.PlayNow);
			GetComponent<Animation> ().PlayQueued("M_Sit_Idle", QueueMode.CompleteOthers);

		}


	
	}
}
