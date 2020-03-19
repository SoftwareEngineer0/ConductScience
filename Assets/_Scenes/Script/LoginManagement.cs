﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManagement : MonoBehaviour
{
    public GameObject canvas;
    public GameObject parentPanel;

    [Header("Login")]
    public GameObject loginPanel;
    public InputField loginPanelEmail;
    public InputField loginPanelPassword;
    [Header("Error")]
    public GameObject errorParent;
    public Text errorText;
    //public Text loginPanelErrorText;

    private string databaseURL = "https://test1-be462.firebaseio.com/user/Users";
    private string AuthKey = "AIzaSyA79Y96XJYFzEhO_yxligbpqsZKi6-qyaY";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLogin()
    {
        if (loginPanelEmail.text == "")
        {
            loginPanelEmail.ActivateInputField();
            errorParent.SetActive(true);
            errorText.text = "Email is invalid.";
            //loginPanelErrorText.text = "Email is invalid.";
        }
        else if (loginPanelPassword.text == "")
        {
            loginPanelPassword.ActivateInputField();
            errorParent.SetActive(true);
            errorText.text = "Password is invalid.";
            //loginPanelErrorText.text = "Password is invalid.";
        }
        else
        {
            LoginRequest(loginPanelEmail.text, loginPanelPassword.text);
        }

    }
    public void LoginRequest(string email, string password)
    {

    }
    public void OnValueChange()
    {

    }
}
