using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInfo : MonoBehaviour
{
    public PlayerData data;

    private void Start()
    {
        data = new PlayerData();
        data.nome = "Hornet";
        data.level = 10;
        data.vida = 150;
        data.playerPos = transform.position;
    }
}
