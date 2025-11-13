using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriptoLibr : MonoBehaviour
{
    #region Duas Chaves
    static string chave1 = "toca"; //duas chaves que serão a criptografia do seu código, se um caractere é contido dentro da chave ele é trocado pela outra chave.
    static string chave2 = "punk";  //exemplo: Toca Raul viraria punk rkol

    public static string CriptografarComDuasChaves(string textoOriginal) //codigo que contem a criptografia com duas chaves
    {
        string textoCripto = "";
        char[] caracteres = textoOriginal.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.BuscarRefChar(caracteres[i]);
        }
        textoCripto = new string(caracteres);
        return textoCripto;
    }
    public static string DescriptografarComDuasChaves(string textoCriptografado) //codigo que contem a descriptografia com duas chaves, é similar ao codigo acima mas
                                                                                 //ele faz o oposto do código acima, voltando os valores ao normal utilizando o metodo abaixo
                                                                                 //BuscarRefChar que checa com as chaves especificadas acima utilizando um for loop que checa cada chave
                                                                                 //e modifica ela de volta se ela for similar a uma chave ou outra baseado na length do que está sendo convertido
    {
        string textoDescripto = "";
        char[] caracteres = textoCriptografado.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.BuscarRefChar(caracteres[i]);
        }
        textoDescripto = new string(caracteres);
        return textoDescripto;
    }

    static char caractereNovo;
    static char BuscarRefChar(char caractereOriginal)
    {
        char caractereNovo = caractereOriginal;
        for (int i = 0; i < chave1.Length; i++)
        {
            if(caractereOriginal == chave1[i])
            {
                caractereNovo = chave2[i];
            }
            if (caractereOriginal == chave2[i])
            {
                caractereNovo = chave1[i];
            }
        }
        

        return caractereNovo;
    }
    #endregion //

    #region Deslocamento

    static int deslocamento = 512;
    public static string CriptografarDeslocamento(string textoOriginal)
    {
        char[] caracteres = textoOriginal.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.Deslocar(caracteres[i], true);
        }

        string textoCriptografado = new string(caracteres);
        return textoCriptografado;
    }

    public static string DescriptografarDeslocamento(string textoCriptografado)
    {
        char[] caracteres = textoCriptografado.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.Deslocar(caracteres[i], false);
        }

        string textoDescriptografado = new string(caracteres);
        return textoDescriptografado;
    }

    static char Deslocar(char caractere, bool sentido)
    {
        int charDecimal = caractere;
        if (sentido == true)
        {
            charDecimal += deslocamento;
        }
        else
        {
            charDecimal -= deslocamento;
        }
        char charDeslocado = (char)charDecimal;
            Debug.Log(charDecimal);

        return charDeslocado;
    }

    #endregion

    #region Deslocamento Complexo

    static int deslocamentoC = 512;
    static int deslocamentoIndice = 3;
    public static string CriptografarDeslocamentoC(string textoOriginal)
    {
        char[] caracteres = textoOriginal.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.DeslocarC(caracteres[i], true, i);
        }

        string textoCriptografado = new string(caracteres);
        return textoCriptografado;
    }

    public static string DescriptografarDeslocamentoC(string textoCriptografado)
    {
        char[] caracteres = textoCriptografado.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLibr.DeslocarC(caracteres[i], false, i);
        }

        string textoDescriptografado = new string(caracteres);
        return textoDescriptografado;
    }

    static char DeslocarC(char caractere, bool sentido, int indiceComplexo)
    {
        int charDecimal = caractere;
        if (sentido == true)
        {
            charDecimal += deslocamentoC * (indiceComplexo+deslocamentoIndice);
        }
        else
        {
            charDecimal -= deslocamentoC * (indiceComplexo + deslocamentoIndice);
        }
        char charDeslocado = (char)charDecimal;
        Debug.Log(charDecimal);

        return charDeslocado;
    }


    #endregion
}
