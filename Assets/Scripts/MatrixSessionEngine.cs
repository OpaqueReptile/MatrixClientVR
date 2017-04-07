using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;


public class MatrixSessionEngine : MonoBehaviour
{
    const int BUFFER_SIZE = 1024;

    // Use this for initialization
    void Start()
    {
    }

    //functions for getting REST state
    public void MatrixLogin()
    {
        MatrixSessionInfo.LoginType = "m.login.password";
        StartCoroutine(MatrixREST("_matrix/client/r0/login", "POST", new LoginInfo(), new LoginResponse()));
    }
    //get the server's room directory
    public void MatrixRooms() {
        StartCoroutine(MatrixREST("_matrix/client/r0/publicRooms", "GET", null, new DirectoryResponse()));
    }

    //generic handler for any REST endpoint
    IEnumerator MatrixREST(string URL, string method, MatrixJSON data, MatrixResponse response)
    {
        var dataToSend = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
        var postHeader = new Dictionary<string, string>();
        Debug.Log("jsonString: " + JsonUtility.ToJson(data));
        //POST if you use a postHeader, GET without
        WWW request;
        if (method == "POST") {
            request = new WWW(MatrixSessionInfo.HomeServer + URL, dataToSend, postHeader);
        }
        else{
            request = new WWW(MatrixSessionInfo.HomeServer + URL);
        }
        yield return request;
        if (request.error != null)
        {
            Debug.Log("request error: " + request.error);
            response.Error();
        }
        else
        {
            Debug.Log("request success");
            Debug.Log("returned data" + request.text);
            //write the endpoint response, if there is one, into the response object
            JsonUtility.FromJsonOverwrite(request.text, response);
            //The response object will then populate the MatrixSessionInfo static values
            response.Save();
        }
    }
}