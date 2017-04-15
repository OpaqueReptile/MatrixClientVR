using UnityEngine;
using UnityEngine.Networking;
using System.Text;
using System.IO;
using System;

/**
 *  To Run as a headless server - 
 *  1) Disable the VR CameraRig object
 *  2) Check "Is Server" on this script 
 * 
 * 
 * 
 * 
 * 
 * 
 **/

public class NetworkSetup : MonoBehaviour {
    public bool isServer = true;
	// Use this for initialization
	void Start () {

        //get Network Manager
        NetworkManager man = GetComponent<NetworkManager>();
        if (isServer)
        {
            //try to read a local file to get port
            string pwd = Application.dataPath;
            string port = Load(Path.Combine(pwd, "port.ini"));
            string name = Load(Path.Combine(pwd, "name.ini"));
            print(pwd);
            print(port);
            print(name);
            man.networkPort = Int32.Parse(port);
            man.serverBindToIP = true;
            //man.serverBindAddress = name;
            man.StopServer();
            NetworkServer.Reset();
            man.StartServer();
        }
       else {
            //get server from matrix service
            //man.networkAddress = MatrixSessionInfo.VRRoomURL;
            //man.networkPort = MatrixSessionInfo.VRRoomPort;
            man.networkAddress = "inferiorlattice.com";
            man.networkPort = 4515;
            man.StartClient();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
     private string Load(string fileName) {
        // Handle any problems that might arise when reading the text
        try
        {
            string line;
            // Create a new StreamReader, tell it which file to read and what encoding the file
            // was saved as
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            // Immediately clean up the reader after this block of code is done.
            // You generally use the "using" statement for potentially memory-intensive objects
            // instead of relying on garbage collection.
            // (Do not confuse this with the using directive for namespace at the 
            // beginning of a class!)
            using (theReader)
            {
                // While there's lines left in the text file, do this:
                string t = "";
                do
                {
                    line = theReader.ReadLine();

                    if (line != null)
                    {
                        t = t + line + " ";
                    }
                }
                while (line != null);
                // Done reading, close the reader and return true to broadcast success    
                theReader.Close();
                return t;
            }
        }
        catch
        {
            return "";
        }
    }
}
