using UnityEngine;

[CreateAssetMenu(fileName = "InimigoData", menuName = "Assets Lauro/Inimigo")]
public class InimigoSO : ScriptableObject
{
    public string nome;
    public int vida;
    public Material tipo;
    public int atk;
    public int level;
}
