using UnityEngine;

public class ItemAttract : MonoBehaviour, IExpulsar
{
    public void Afastar(float forca, Vector3 posOrigem)
    {
        Vector3 direcaoForca = posOrigem - this.transform.position;
        direcaoForca.Normalize();
        GetComponent<Rigidbody>().AddForce(-direcaoForca * forca);
    }
}
