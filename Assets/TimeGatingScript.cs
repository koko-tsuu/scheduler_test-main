using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class TimeGatingScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int year;
    [SerializeField] private int month;
    [SerializeField] private int day;
    [SerializeField] private int hour;
    [SerializeField] private int minute;
    [SerializeField] private int second;

    DateTime timeGate;

    void Start()
    {
        timeGate = new DateTime(year, month, day, hour, minute, second);
    }

    void Update()
    {
        // constantly check if the player can access it
        CheckIfPlayerCanAccess();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DateTime now = DateTime.UtcNow.ToLocalTime();
        if (now < timeGate)
        {
            // you can display your error message
        }
    }

    void CheckIfPlayerCanAccess()
    {

        DateTime now = DateTime.UtcNow.ToLocalTime();
        print(now);
        print(timeGate);

        // not allowed
        if (now < timeGate)
        {
           // put your script here to not allow players to access something

        }
        // allowed to access
        else
        {
            // 
        }

    }

}
