using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraOrbital : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    float distancia = 10f;

    [SerializeField]
    float sensibilidadeCam = 300f;

    [SerializeField]
    Transform objetoAlvo;

    float pitch, yaw;

    // Update is called once per frame
    void Update()
    {
        GetOrientations();
        Orbitate();
    }

    void GetOrientations()//Metodo que obtém os valores do mouse para movimentar o yaw e o pitch da camera
    {
        yaw += Input.GetAxis("Mouse X") * sensibilidadeCam * Time.deltaTime;
        pitch += Input.GetAxis("Mouse Y") * sensibilidadeCam * Time.deltaTime;
        //Mathf.Clamp limita o limite entre dois valores
        pitch = Mathf.Clamp(pitch, -30, 15);
    }

    void Orbitate()
    {
        Vector3 afastamento = new Vector3(0, 0, distancia);
        Quaternion rotacao = Quaternion.Euler(pitch, yaw, 0);

        this.transform.position = objetoAlvo.position + (rotacao * afastamento);
        this.transform.LookAt(objetoAlvo);
    }
}
