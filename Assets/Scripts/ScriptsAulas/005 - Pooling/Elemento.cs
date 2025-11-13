using UnityEngine;
using System.Collections;

public class Elemento : MonoBehaviour
{
    GameObject elemento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("Morrer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Morrer()//boa pratica, fazer o proprio objeto se desativar sozinho
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}
