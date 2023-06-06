using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cone : MonoBehaviour
{
    [SerializeField] NetworkManager networkManager;
    void Start()
    {
        networkManager.networkAddress = "192.168.178.25";
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {

            networkManager.StartServer();
        } else
        {
            networkManager.StartClient();
        }
            
    }
}
