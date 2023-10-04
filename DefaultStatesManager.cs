/*
File for making sure gameobjects are correctly enabled or disabled at start of play mode, 
so you can disable them in editor while working on them, and not need to remember to turn 
them back on, as sometimes when making UI, you need to hide items to see others....

<edit> This isn't needed any more, unless in an older version of Unity, as Unity now 
has an "eye" button beside gameobjects to hide them while editing!

*/
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

