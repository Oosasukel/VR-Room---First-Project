using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    [SerializeField]
    private Transform secondsTransform;
    [SerializeField]
    private Transform minutesTransform;
    [SerializeField]
    private Transform hoursTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var currentDate = DateTime.Now;

        secondsTransform.rotation = Quaternion.Euler((360 / 60f) * currentDate.Second, 0, 0);
        minutesTransform.rotation = Quaternion.Euler((360 / 60f) * currentDate.Minute, 0, 0);
        hoursTransform.rotation = Quaternion.Euler((360 / 12f) * currentDate.Hour, 0, 0);
    }
}
