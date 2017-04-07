using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOrbTable : MonoBehaviour {

    public Vector3 StartPos = new Vector3(0.0f, -0.75f, 0.75f);
    public Vector3 EndPos = new Vector3(0.0f, 0.25f, 0.75f);
    private Vector3 CurPos = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start () {
        transform.position = StartPos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        if (MatrixSessionInfo.UserId.Length > 0)
        {
            if (x > EndPos.x)
            {
                x = x - 0.01f;
            }
            if (y < EndPos.y)
            {
                y = y + 0.02f;
            }
            if (z > EndPos.z)
            {
                z = z - 0.005f;
            }
            transform.position = new Vector3(x, y, z);
        }
    }
}
