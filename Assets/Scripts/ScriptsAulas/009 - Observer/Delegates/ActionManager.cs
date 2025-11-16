using UnityEngine;
using System;// necessário para utilizar o Action

public class ActionManager : MonoBehaviour
{
    public static event Action Falar;
    public static event Action<int, int> Gritar;
    //public static event Action <GameObject, Rigidbody, Color, Renderer, Vector3>  ele pode receber varias informações


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
