using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyHuntStatee :MonoBehaviour, IState
{

    [SerializeField] private float _distanceToPlayer;
    [SerializeField] private Vector3 _inicialPosition;
    private Transform _playerTransform;
    void Awake()
    {
        _playerTransform = GetComponent<Transform>();
    }

     void Start()
    {
        
    }
    void Update()
    {
        
    }
    public bool DoState()
    {
            throw new System.NotImplementedException();
    }

     public void HuntPlayer()
    {

    }
}
