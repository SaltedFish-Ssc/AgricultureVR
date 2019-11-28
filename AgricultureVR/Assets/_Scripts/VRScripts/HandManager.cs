using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class HandManager : MonoBehaviour
{
    [SerializeField]
    private VRTK_ControllerEvents _events;

    /// <summary>
    /// 手抓握动画
    /// </summary>
    public Animator _GrabAnimation; 

    void Start()
    {
        _events.TriggerAxisChanged += _events_TriggerAxisChanged;
    }

    /// <summary>
    /// 抓取键按下的角度
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void _events_TriggerAxisChanged(object sender, ControllerInteractionEventArgs e)
    {
        _GrabAnimation.Play("Grab",0,e.buttonPressure);
        _GrabAnimation.speed = 0;
    }

    void Update()
    {
        
    }
}
