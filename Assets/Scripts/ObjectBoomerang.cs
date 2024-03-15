using System;
using System.Collections;
using UnityEngine;

public class ObjectBoomerang : MonoBehaviour
{
    private Action _senderAction;
    private Action _receiverAction;

    public void Init(Action receiverAction)
    {
        _senderAction = receiverAction;
        _senderAction += _receiverAction;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger != true)
        {
            _senderAction.Invoke();
           
        }
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.ReduceEnemyLife(10);
        }
        if (other.TryGetComponent(out Boss boss))
        {
            boss.ReduceEnemyLife(10);
        }
    }
    
    public void UnsubscribeAction()
    {
        _senderAction -= _receiverAction;
    }
    
}
