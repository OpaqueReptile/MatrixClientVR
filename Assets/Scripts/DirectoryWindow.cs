using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectoryWindow : MonoBehaviour {

    private float y_start = 110.0f;
    private float y_offset = 0.0f;
    public bool button_refresh = true;
    public bool title_refresh = true;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        
        if (MatrixSessionInfo.HomeServer.Length > 0 && title_refresh && MatrixSessionInfo.Chunk != null && MatrixSessionInfo.UserId.Length > 0)
        {
            SetTitle(MatrixSessionInfo.HomeServer);
            title_refresh = false;
        }

        if (MatrixSessionInfo.Chunk != null && button_refresh && MatrixSessionInfo.UserId.Length > 0)
        {
            //need to clear buttons
            //ClearButtons()
            foreach (var item in MatrixSessionInfo.Chunk)
            {
                AddButton(item.name, item.aliases[0], item.room_id);
            }
            button_refresh = false;
        }
    }

    //create a new button underneath the last one, starting from y_start
    void AddButton(string name, string alias, string id) {
        var button = Instantiate(transform.FindChild("DefaultButton").gameObject);
        //print(button);
        var rectTransform = button.GetComponent<RectTransform>();
        float x = rectTransform.localPosition.x;
        //print(x);
        float y = y_start - y_offset;
        float z = rectTransform.localPosition.z;
        rectTransform.SetParent(transform);
        rectTransform.localPosition = new Vector3(x,y,z);
        rectTransform.localScale = new Vector3(1, 1, 1);
        rectTransform.localEulerAngles = new Vector3(0, 0, 0);
        y_offset += 40;
        var ButtonScript = button.GetComponent<RoomButton>();
        ButtonScript.alias = alias;
        ButtonScript.id = id;
        Text text = button.GetComponentInChildren<Text>();
        text.text = name + " - " + alias;
        button.SetActive(true);
    }

    void SetTitle(string name){
        var Title = transform.Find("Title");
        Title.gameObject.SetActive(true);
        Text text = Title.GetComponent<Text>();
        text.text = "Directory:\n" + name;
    }

}
