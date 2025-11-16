using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ControllerIO : MonoBehaviour
{

    [SerializeField]
    Text textoOutput;

    string caminho;

    
    string nomeArquivo = "arquivoLegal";

    
    string extensaoArquivo = ".txt";

    string caminhoArquivo;

    private void Start()
    {
        caminho = Application.streamingAssetsPath + "/LauroSaves/"; //caminho dentro da pasta do jogo
        caminhoArquivo = caminho + nomeArquivo + extensaoArquivo;
    }




    public void CriarPasta()
    {
        Directory.CreateDirectory(caminho);
    }

    public void EscreverArquivo()
    {
        if (File.Exists(caminhoArquivo))
        {
            Debug.Log("já existe!");
        }
        else
        {
            File.WriteAllText(caminhoArquivo, "Aula mó legal");//escreve dentro do txt esta string
        }
            
    }

    public void LerArquivo()
    {
        textoOutput.text = File.ReadAllText(caminhoArquivo); //aplica o texto do txt no text do serializefield acima
    }
}
