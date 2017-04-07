using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn_Button : MonoBehaviour {

    public MatrixSessionEngine Manager;

	// Use this for initialization
	void Start () {
        onClick();
	}
	
	// Update is called once per frame
	void Update () {
        if (MatrixSessionInfo.UserId.Length > 0)
        {
            Button button = gameObject.GetComponent<Button>();
            ColorBlock cb = button.colors;
            cb.normalColor = Color.green;
            button.colors = cb;
        }
        else if(MatrixSessionInfo.LoginError == true)
        {
            Button button = gameObject.GetComponent<Button>();
            ColorBlock cb = button.colors;
            cb.normalColor = Color.red;
            button.colors = cb;
        }
        else
        {
            Button button = gameObject.GetComponent<Button>();
            ColorBlock cb = button.colors;
            cb.normalColor = Color.white;
            button.colors = cb;
        }
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
        Manager.MatrixRooms();
    }
}
