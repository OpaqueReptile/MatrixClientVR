using UnityEngine;
using System.Collections;
using Valve.VR;
using System;
using UnityEngine.EventSystems;

public class SteamVR_Keyboard : MonoBehaviour, IPointerClickHandler
{
	public UnityEngine.UI.InputField textEntry;
	public bool minimalMode;
	static bool keyboardShowing;
	string text = "";
    string temp1 = "";
    string temp2 = "";
    string temp3 = "";
    static SteamVR_Keyboard activeKeyboard = null;

	// Use this for initialization
	void Start ()
	{
		
	}

	void OnEnable()
	{
		SteamVR_Events.SystemAction(EVREventType.VREvent_KeyboardCharInput, OnKeyboard).Enable(true);
		SteamVR_Events.SystemAction(EVREventType.VREvent_KeyboardClosed, OnKeyboardClosed).Enable(true);

	}


    private void OnKeyboard(VREvent_t ev)
	{
		if (activeKeyboard != this)
			return;
		VREvent_Keyboard_t keyboard = ev.data.keyboard;
		byte[] inputBytes = new byte[] { keyboard.cNewInput0, keyboard.cNewInput1, keyboard.cNewInput2, keyboard.cNewInput3, keyboard.cNewInput4, keyboard.cNewInput5, keyboard.cNewInput6, keyboard.cNewInput7 };
		int len = 0;
		for (; inputBytes[len] != 0 && len < 7; len++) ;
		string input = System.Text.Encoding.UTF8.GetString(inputBytes, 0, len);
        //the first part of the string: 0 to whichever anchor is first
        temp1 = textEntry.text.Substring(0, Math.Min(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition));
        //the selected part that we're taking out
        temp2 = textEntry.text.Substring(Math.Min(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition),
            (Math.Max(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition) - Math.Min(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition)));
        //last chunk to the end
        temp3 = textEntry.text.Substring(Math.Max(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition), 
            (textEntry.text.Length - Math.Max(textEntry.selectionAnchorPosition, textEntry.selectionFocusPosition)));
       // print(temp1);
       // print(temp2);
       // print(temp3);

        if (minimalMode)
		{
			if (input == "\b")
			{
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
                    textEntry.caretPosition += -1;
                }
			}
			else if (input == "\x1b")
			{
				// Close the keyboard
				var vr = SteamVR.instance;
				vr.overlay.HideKeyboard();
				keyboardShowing = false;
			}
			else
			{
				text += input;
			}
			textEntry.text = text;
            //textEntry.text = temp1 + text + temp2;
            textEntry.caretPosition += 1;
		}
		else
		{
			System.Text.StringBuilder textBuilder = new System.Text.StringBuilder(1024);
			uint size = SteamVR.instance.overlay.GetKeyboardText(textBuilder, 1024);
			text = textBuilder.ToString();
            textEntry.text = text;
            //textEntry.text = temp1 + text + temp2;
            textEntry.caretPosition += 1;
        }
    }

    private void OnKeyboardClosed(VREvent_t arg0)
    {
		if (activeKeyboard != this)
			return;
		keyboardShowing = false;
		activeKeyboard = null;
    }

//	private void KeyboardDemo_Clicked()
//	{
//		if(!keyboardShowing)
//		{
//			keyboardShowing = true;
//			activeKeyboard = this;
//			SteamVR.instance.overlay.ShowKeyboard(0, 0, "Description", 256, text, minimalMode, 0);
//		}
//	}

    public void OnPointerClick(PointerEventData eventData)
    {
        print("clicked!");
        if(!keyboardShowing)
        {
        	keyboardShowing = true;
        	activeKeyboard = this;
            textEntry.text = "";
            textEntry.caretPosition = 0;
            SteamVR.instance.overlay.ShowKeyboard(0, 0, "Description", 256, text, minimalMode, 0);
        }
    }

    // Update is called once per frame
    void Update ()
	{
		
	}
}