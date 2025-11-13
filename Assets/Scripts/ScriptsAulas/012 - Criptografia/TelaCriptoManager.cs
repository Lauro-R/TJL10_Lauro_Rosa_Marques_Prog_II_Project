using UnityEngine;
using UnityEngine.UI;

public class TelaCriptoManager : MonoBehaviour
{
    [SerializeField]
    InputField textEntrada, textCriptografado, textDescriptografado;

    public void Criptografar()
    {
        string textoFinal = "teste";

        //textoFinal = CriptoLibr.CriptografarComDuasChaves(textEntrada.text);  //Criptografia com Duas chaves que é puxada da library contida dentro do CriptoLibr.cs
        //textoFinal = CriptoLibr.CriptografarDeslocamento(textEntrada.text);  //Criptografia que move os caracteres em um valor especifico contido na library CriptoLibr.cs
        textoFinal = CriptoLibr.CriptografarDeslocamentoC(textEntrada.text);  //Criptografia mais complexa que utiliza o mesmo codigo do deslocamento acima mas com uma
                                                                             //complexidade maior que deixa o codigo mais seguro com mais um layer de deslocamento.

        textCriptografado.text = textoFinal;
    }

    public void Descriptografar()
    {
        //bool deslocateButton == true;
        string textoFinal = "teste";
        //textoFinal = CriptoLibr.DescriptografarComDuasChaves(textCriptografado.text); //Criptografia com Duas chaves que é puxada da library contida dentro do CriptoLibr.cs
        //textoFinal = CriptoLibr.DescriptografarDeslocamento(textCriptografado.text); //Criptografia que move os caracteres em um valor especifico contido na library CriptoLibr.cs
        textoFinal = CriptoLibr.DescriptografarDeslocamentoC(textCriptografado.text); //Criptografia mais complexa que utiliza o mesmo codigo do deslocamento acima mas com uma
                                                                                     //complexidade maior que deixa o codigo mais seguro com mais um layer de deslocamento.

        textDescriptografado.text = textoFinal;
        }
    }
