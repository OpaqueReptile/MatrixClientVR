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
    private static string user, password, login_type;
    private static string user_id, access_token, home_server;

    //functions for getting static values
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
}

interface MatrixJSON
{

}

interface MatrixResponse
{
     void Save();
}

public class LoginInfo : MatrixJSON
{
    public string type = MatrixSessionInfo.LoginType;
    public string user = MatrixSessionInfo.Username;
    public string password = MatrixSessionInfo.Password;
}

public class LoginResponse : MatrixResponse
{
    public string user_id;
    public string access_token;
    public string home_server;

    public void Save()
    {
        MatrixSessionInfo.UserId = user_id;
        MatrixSessionInfo.AccessToken = access_token;
        MatrixSessionInfo.HomeServer = home_server;
    }
}

