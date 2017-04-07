using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInWindow : MonoBehaviour {

    public Vector3 StartPos = new Vector3(0.0f,1.0f,1.0f);
    public Vector3 StartRot = new Vector3(0,0,0);
    public Vector3 EndPos = new Vector3(-1.5f,1.1f,0.0f);
    public Vector3 EndRot = new Vector3(0,-90,0);
    private Vector3 CurPos = new Vector3(0,0,0);

    // Use this for initialization
    void Start () {
        transform.position = StartPos;
    }
	
	
	void FixedUpdate () {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float ex = transform.eulerAngles.x;
        float ey = transform.eulerAngles.y;
        float ez = transform.eulerAngles.z;
        if (MatrixSessionInfo.UserId.Length > 0)
        {
            if (x > EndPos.x){
                x = x - 0.01f;
            }
            if (y < EndPos.y){
                y = y + 0.01f;
            }
            if (z > EndPos.z){ 
                z = z - 0.005f;
            }
            transform.position = new Vector3(x, y, z);
            if (ey > EndRot.y){
                ey = ey - 0.8f;
            }
            transform.eulerAngles = new Vector3(ex, ey, ez);
        }
    }
}
