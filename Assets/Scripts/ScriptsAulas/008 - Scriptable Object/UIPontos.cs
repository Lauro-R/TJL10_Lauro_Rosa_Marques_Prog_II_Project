using UnityEngine;
using UnityEngine.UI;

public class UIPontos : MonoBehaviour
{
    [SerializeField]
    Text textoPontos;
    [SerializeField]
    PlayerGetItens player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoPontos.text = "Score: " + player.Pontuacao + " Coletou: " + player.ItensColetados;
    }
}
