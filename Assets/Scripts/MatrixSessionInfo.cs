using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using UnityEngine;
using System.Collections;

public static class MatrixSessionInfo
{
    //Matrix API values
    //login
    private static string user = "", password = "", login_type = "";
    private static string user_id = "", access_token = "", home_server = "";
    //publicRooms
    private static int total_room_count_estimate;
    private static string next_batch = "";
    private static RoomChunk[] chunk;
    //send event
    public static string roomId = "";
    public static string eventType = "";
    public static string txnId = "0";
    public static string eventId = "";
    //join room
    private static string roomIdOrAlias = "";
    //API Error Status
    //login
    private static bool login_error = false; 

    //functions for getting and setting static values
    //login
    public static string Username
    {
        get
        {
            return user;
        }
        set
        {
            user = value;
        }
    }
    public static string Password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }
    public static string LoginType
    {
        get
        {
            return login_type;
        }
        set
        {
            login_type = value;
        }
    }
    public static string UserId
    {
        get
        {
            return user_id;
        }
        set
        {
            user_id = value;
        }
    }
    public static string AccessToken
    {
        get
        {
            return access_token;
        }
        set
        {
            access_token = value;
        }
    }
    public static string HomeServer
    {
        get
        {
            return home_server;
        }
        set
        {
            home_server = value;
        }
    }
    //publicRooms
    public static int TotalRoomCountEstimate
    {
        get
        {
            return total_room_count_estimate;
        }
        set
        {
            total_room_count_estimate = value;
        }
    }
    public static string NextBatch
    {
        get
        {
            return next_batch;
        }
        set
        {
            next_batch = value;
        }
    }
    public static RoomChunk[] Chunk
    {
        get
        {
            return chunk;
        }
        set
        {
            chunk = value;
        }
    }
    //sending events
    public static string RoomId
    {
        get
        {
            return roomId;
        }
        set
        {
            roomId = value;
        }
    }
    public static string EventType
    {
        get
        {
            return eventType;
        }
        set
        {
            eventType = value;
        }
    }
    public static string TxnId
    {
        get
        {
            return txnId;
        }
        set
        {
            txnId = value;
        }
    }
    public static string EventId
    {
        get
        {
            return eventId;
        }
        set
        {
            eventId = value;
        }
    }
    //joining rooms
    public static string RoomIdOrAlias
    {
        get
        {
            return roomIdOrAlias;
        }
        set
        {
            eventId = roomIdOrAlias;
        }
    }
    //error values
    public static bool LoginError
    {
        get
        {
            return login_error;
        }
        set
        {
            login_error = value;
        }
    }


    //non-MatrixAPI, VR specific
    //privates
    private static string vr_room_url;
    private static int vr_room_port;
    //public get/set
    public static string VRRoomURL
    {
        get
        {
            return vr_room_url;
        }
        set
        {
            vr_room_url = value;
        }
    }
    public static int VRRoomPort
    {
        get
        {
            return vr_room_port;
        }
        set
        {
            vr_room_port = value;
        }
    }
}

//interfaces for endpoints
interface MatrixJSON
{

}
interface MatrixResponse
{
    void Save();
    void Error();
}

//login endpoint
[System.Serializable]
public class LoginInfo : MatrixJSON
{
    public string type = MatrixSessionInfo.LoginType;
    public string user = MatrixSessionInfo.Username;
    public string password = MatrixSessionInfo.Password;
}
[System.Serializable]
public class LoginResponse : MatrixResponse
{
    public string user_id;
    public string access_token;
    public string home_server;

    public void Save()
    {
        MatrixSessionInfo.UserId = user_id;
        MatrixSessionInfo.AccessToken = access_token;
        //MatrixSessionInfo.HomeServer = home_server;
        MatrixSessionInfo.LoginError = false;
    }
    public void Error()
    {
        MatrixSessionInfo.LoginError = true;
    }
}

//Directory of Public Rooms endpoint
[System.Serializable]
public class DirectoryResponse : MatrixResponse{
    public int total_room_count_estimate;
    public string next_batch;
    public RoomChunk[] chunk;

    public void Save() {
        MatrixSessionInfo.TotalRoomCountEstimate = total_room_count_estimate;
        MatrixSessionInfo.NextBatch = next_batch;
        MatrixSessionInfo.Chunk = chunk;
    }
    public void Error() {

    }
}
[System.Serializable]
public class RoomChunk{
    public bool world_readable;
    public string topic;
    public int num_joined_members;
    public string avatar_url;
    public string room_id;
    public bool guest_can_join;
    public string[] aliases;
    public string name;

}

//send event endpoint
[System.Serializable]
public class SendEvent : MatrixJSON{
    public string roomId;
    public string eventType;
    public string txnId;
    public EventBody body;
}
[System.Serializable]
public class EventBody : MatrixJSON {
    public string msgtype;
    public string body;
}
[System.Serializable]
public class SendEventResponse : MatrixResponse {
    public string event_id;
    public void Save() { }
    public void Error() { }
}

//join room endpoint
public class JoinRoom : MatrixJSON {
    public string roomId;
}
