using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn_Button_test : MonoBehaviour {

    public MatrixSessionEngine Manager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void onClick() {
        var canv = transform.parent.gameObject;
        print(canv);
        foreach (Transform child in canv.transform)
        {
            if (child.name == "User")
            {
                MatrixSessionInfo.Username = child.GetComponent<InputField>().text;
            }
            if (child.name == "Pass")
            {
                MatrixSessionInfo.Password = child.GetComponent<InputField>().text;
            }
            if (child.name == "Home")
            {
                MatrixSessionInfo.HomeServer = child.GetComponent<InputField>().text;
            }
            if (child.name == "Identity")
            {
                //MatrixSessionInfo. = child.Find("Text").GetComponent<Text>().text;
            }
        }
        Manager.MatrixLogin();
    }
}
