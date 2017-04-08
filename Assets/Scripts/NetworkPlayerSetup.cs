using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class NetworkPlayerSetup : MonoBehaviour {
	// Use this for initialization
	void Start () {
        VRTK_SDKManager vrtk_sdk = GameObject.Find("Manager").GetComponent<VRTK_SDKManager>();
        var player_cam = transform.Find("Camera (eye)");
        var player_right = transform.Find("Controller (right)");
        var player_left = transform.Find("Controller (left)");
        vrtk_sdk.actualBoundaries = gameObject;
        vrtk_sdk.actualHeadset = player_cam.gameObject;
        vrtk_sdk.actualLeftController = player_left.gameObject;
        vrtk_sdk.actualRightController = player_right.gameObject;
        vrtk_sdk.modelAliasLeftController = player_left.Find("Hand").gameObject;
        vrtk_sdk.modelAliasRightController = player_right.Find("Hand").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
