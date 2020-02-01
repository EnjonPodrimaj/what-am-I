using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConsoleController : MonoBehaviour {
    [SerializeField] private GameObject _debugPanel;

    public DebugController debugController;

    public GameObject currentlyClicked; 

    public void OpenDebugOptions() {       
        string clickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        currentlyClicked = EventSystem.current.currentSelectedGameObject;
        if (clickedButtonName == "Down") {
            debugController.ShowLeftButton();
            debugController.ShowRighttButton();
            debugController.ShowUpButton();
        }
        else if (clickedButtonName == "Left") {
            debugController.ShowDownButton();
            debugController.ShowRighttButton();
            debugController.ShowUpButton();
        }
        else if (clickedButtonName == "Right") {
            debugController.ShowDownButton();
            debugController.ShowLeftButton();
            debugController.ShowUpButton();
        }
        else if (clickedButtonName == "Up") {
            debugController.ShowDownButton();
            debugController.ShowRighttButton();
            debugController.ShowLeftButton();
        }
    }


}

