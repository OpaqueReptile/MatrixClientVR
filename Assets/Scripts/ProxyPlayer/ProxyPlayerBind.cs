using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ProxyPlayerBind : NetworkBehaviour {

    private GameObject l_hand;
    private GameObject r_hand;
    private GameObject body;
	// Use this for initialization
	void Start () {
        body = GameObject.Find("Avatar");
        l_hand = GameObject.Find("LeftHand");
        r_hand = GameObject.Find("RightHand");
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        foreach (Transform t in GetComponentsInChildren<Transform>())
        {
            if (body != null && t.name == "ProxyAvatar")
            {
                t.position = body.transform.position;
                t.eulerAngles = body.transform.eulerAngles;
            }
            if (l_hand != null && t.name == "ProxyLeftHand")
            {
                t.position = l_hand.transform.position;
                t.eulerAngles = l_hand.transform.eulerAngles;
            }
            if (r_hand != null && t.name == "ProxyRightHand")
            {
                t.position = r_hand.transform.position;
                t.eulerAngles = r_hand.transform.eulerAngles;
            }
        }
	}
}
