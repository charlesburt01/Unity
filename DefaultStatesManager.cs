using System;
using UnityEngine;

public class DefaultStatesManager : MonoBehaviour
{
    [SerializeField] private MyObjects[] _objs;
    void Start()
    {
        foreach (MyObjects obj in _objs) 
        {
            obj._obj.SetActive(obj._state);
        }
    }
    [Serializable]
    public class MyObjects
    {
        public GameObject _obj;
        public bool _state;
    }

}

