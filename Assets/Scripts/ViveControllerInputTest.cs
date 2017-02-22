using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {

    /*Reference to object being tracked*/
    private SteamVR_TrackedObject trackedObj;

    /*Device property fo easy acces to contoller's input*/

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }

    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	// Update is called once per frame
	void Update () {

	}
}
