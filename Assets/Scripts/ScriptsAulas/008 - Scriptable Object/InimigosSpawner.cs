using UnityEngine;

public class InimigosSpawner : MonoBehaviour
{
    public InimigoSO[] tiposInimigo; //Array de varios inimigos que vai guardar as possibilidades dos prefabs
    public GameObject prefabInimigo;//acessa o prefab do inimigo

    public void SpawnarInimigo(int i)
    {
        GameObject inimigo = Instantiate(prefabInimigo, this.transform.position, this.transform.rotation);//instancia quem você quer dos game objects
        inimigo.GetComponent<InimigoCriado>().ConfigurarInimigo(tiposInimigo[i]);
        //configura a informação dele pelo componente puxado na função ConfigurarInimigo
        inimigo.GetComponent<InimigoCriado>().Defesa = 100;

        Debug.Log(inimigo.GetComponent<InimigoCriado>().Vida);
        Debug.Log(inimigo.GetComponent<InimigoCriado>().Atk);//retorna o valor da propriedade que é modificada no inimigoCriado já com um calculo feito checando o buff
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnarInimigo(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnarInimigo(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpawnarInimigo(2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnarInimigo(Random.Range(0,3));
        }
    }
}
