using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPattern<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance = null;

    protected virtual void Awake()
    {
        Instance = FindObjectOfType(typeof(T)) as T;
    }
}
