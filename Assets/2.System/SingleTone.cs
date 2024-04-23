using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance;
    public void Start()
    {
        Instance = this as T;
    }
}
