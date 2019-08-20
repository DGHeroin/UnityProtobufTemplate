using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Text resultText;

    void Start() {
        UserInfo user = new UserInfo() {
            Id = 1,
            Name = "MyName",
            Address = new AddressInfo() {
                Street = "MyStreet",
                ZIP = 123456
            }
        };
        try {
            byte[] bytes = Proto.Encode<UserInfo>(user);
            UserInfo newUser = Proto.Decode<UserInfo>(bytes);
            Debug.Log(newUser);

            resultText.text = string.Format("Success.\nResult:\n{0}", newUser);
        } catch (Exception e) {
            resultText.text = string.Format("Exception:\n{0}", e);
        }
    }
}
