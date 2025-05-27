using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class NotificationManager : MonoBehaviour
{

    [SerializeField] PushNotificationManager pushNotificationManager;

    private void Start()
    {
        pushNotificationManager.RequestAuthorization();
        pushNotificationManager.RegisterNotificationChannel();   
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            // AndroidNotificationCenter.CancelAllNotifications();
            pushNotificationManager.SendNotification("Hello World!", "this is a notification that should be scheduled from last opened + 8 seconds", System.DateTime.Now.AddSeconds(8));
        }
    }
}
