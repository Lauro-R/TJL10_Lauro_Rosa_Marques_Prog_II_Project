using UnityEngine;

[CreateAssetMenu(fileName = "ColetavelData", menuName = "Assets Lauro/Coletavel")]//cria uma opção dentro da unity dentro do botão direito do Create que cria um Scriptable Object.
public class SO_Coletavel : ScriptableObject //a classe não utliza MonoBehavior, utiliza ScriptableObject
{
    public string nome;
    public int valor;
    public Color cor;
}
