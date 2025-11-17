using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ControllerIO : MonoBehaviour
{

    [SerializeField]
    Text textoOutput;

    [SerializeField]
    PlayerInfo player;

    string caminho;

    
    string nomeArquivo = "arquivoLegal";

    
    string extensaoArquivo = ".txt";

    string caminhoArquivo;
    string separador = "||";

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
            File.AppendAllText(caminhoArquivo, "\n*- Opa-lala");
        }
        else
        {
            File.WriteAllText(caminhoArquivo, "Aula mó legal\n\n");//escreve dentro do txt esta string
        }
            
    }
    public void SalvarInfoPLayer()
    {
        //string data = player.nome + separador + player.vida + separador + player.level;

        //File.WriteAllText(caminhoArquivo, data);
    }

    public void LerArquivo()
    {
        textoOutput.text = File.ReadAllText(caminhoArquivo); //aplica o texto do txt no text do serializefield acima
    }

    public void LerPlayerData()
    {//faz um array para acessar corretamente as informações do TXT
        string[] data =  File.ReadAllText(caminhoArquivo).Split(separador);

        textoOutput.text = "Player Name: " + data[0] +
                           "\nLife: " + data[1] +
                           "\nLevel: " + data[2];
    }

    public void SalvarJson()
    {
        string json = JsonUtility.ToJson(player.data, true);
        File.WriteAllText(caminhoArquivo, json);
    }

    public void LerJson()
    {
        if (File.Exists(caminhoArquivo))
        {
            string json = File.ReadAllText(caminhoArquivo);

            PlayerData dataOutput = JsonUtility.FromJson<PlayerData>(json);

            textoOutput.text = $"Nome: {dataOutput.nome}" +
                               $"\nVida{dataOutput.vida}" +
                               $"\nLevel: {dataOutput.level}";

            player.transform.position = dataOutput.playerPos;
        }
    }


}
