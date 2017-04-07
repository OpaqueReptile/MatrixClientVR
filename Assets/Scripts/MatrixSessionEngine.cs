using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Networking;

public class MatrixSessionEngine : MonoBehaviour {
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
    //send a text message to a room
    public void MatrixMessage(string roomid, string msgbody)
    {
        SendEvent msgevent = new SendEvent();
        msgevent.body = new EventBody();
        msgevent.roomId = roomid;
        msgevent.body.body = msgbody;
        msgevent.eventType = "m.room.message";
        msgevent.body.msgtype = "m.text";
        msgevent.txnId = MatrixSessionInfo.txnId;
        StartCoroutine(MatrixREST(string.Format("_matrix/client/r0/rooms/{0}/send/{1}/{2}?access_token={3}", msgevent.roomId.Replace(":", "%3A"), msgevent.eventType, msgevent.txnId, MatrixSessionInfo.AccessToken),
            "PUT", msgevent.body, new SendEventResponse()));
        MatrixSessionInfo.txnId = (Int32.Parse(MatrixSessionInfo.txnId) + 1).ToString();
    }
    public void MatrixJoinRoom(string roomIdOrAlias)
    {
        StartCoroutine(MatrixREST(string.Format("_matrix/client/r0/join/{0}?access_token={1}", WWW.EscapeURL(roomIdOrAlias), MatrixSessionInfo.AccessToken), "POST", null, null));
    }

    //generic handler for any REST endpoint
    IEnumerator MatrixREST(string URL, string method, MatrixJSON data, MatrixResponse response)
    {
        var dataToSend = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
        //var postHeader = new Dictionary<string, string>();
        Debug.Log("jsonString: " + JsonUtility.ToJson(data));
        Debug.Log("URL: " + MatrixSessionInfo.HomeServer + URL);
        //POST if you use a postHeader, GET without
        UnityWebRequest request = new UnityWebRequest(MatrixSessionInfo.HomeServer + URL, method); ;
        if (method == "POST" || method == "PUT") {
            if (data != null) {
                request.uploadHandler = (UploadHandler)new UploadHandlerRaw(dataToSend);
            }
            request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
        }
        else if (method == "GET"){
            request = UnityWebRequest.Get(MatrixSessionInfo.HomeServer + URL);
            request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        }
        yield return request.Send();
        if (request.error != null || request.responseCode == 404)
        {
            Debug.Log("request error: " + request.responseCode);
            if (response != null) {
                response.Error();
            }
        }
        else
        {
            Debug.Log("request success" + request.responseCode);
            Debug.Log("returned data" + request.downloadHandler.text);
            //write the endpoint response, if there is one, into the response object
            if (response != null)
            {
                JsonUtility.FromJsonOverwrite(request.downloadHandler.text, response);
                //The response object will then populate the MatrixSessionInfo static values
                response.Save();
            }
        }
    }
}