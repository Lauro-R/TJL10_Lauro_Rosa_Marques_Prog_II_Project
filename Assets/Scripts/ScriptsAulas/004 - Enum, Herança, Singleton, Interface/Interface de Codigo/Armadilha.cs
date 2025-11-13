using UnityEngine;

public class Armadilha : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Interface implementada nas outras classes permitem a armadilha checar direto se o objeto tem o método abaixo Destruir()
        if (collision.gameObject.GetComponent<IDestruir>() != null)
        {
            collision.gameObject.GetComponent<IDestruir>().Destruir();
        }
    }
}
