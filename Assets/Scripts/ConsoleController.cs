using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleController : MonoBehaviour {
    //public static Action<bool> SendGameObject;
    //public static Action<bool> DisablePlayerControllersAction;

    [SerializeField] private GameObject _debugPanel;
    public GameObject _downButton;
    public GameObject _leftButton;

    public void OpenDebugOptions() {
        _debugPanel.SetActive(true);
        //_leftButton.transform.position = _downButton.transform.position;
        _downButton.SetActive(false);
        
    }
}
