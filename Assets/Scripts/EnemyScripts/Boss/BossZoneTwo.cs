﻿using UnityEngine;
using UnityEngine.Events;

public class BossZoneTwo : MonoBehaviour
{
    [SerializeField] private UnityEvent _unityEvent;

    public bool _isOnTrigger;

    public bool IsOnTrigger
    {
       set { _isOnTrigger = value; }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!_isOnTrigger)
            {
                _isOnTrigger = true;
                _unityEvent.Invoke();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isOnTrigger = false;
    }
}