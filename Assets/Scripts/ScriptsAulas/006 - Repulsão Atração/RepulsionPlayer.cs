using UnityEngine;

public class RepulsionPlayer : MonoBehaviour
{
    Rigidbody myRb;
    public float raioExplosao;
    public float raioAtracao;
    public float forca;
    public float velAtraction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKey(KeyCode.Space))
        {
            UsarForca();
            
        }
        Atracao();
    }
    void Movement()
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");

        myRb.linearVelocity = new Vector3(dirX, 0, dirZ) * 10f;
    }
    void UsarForca()
    {
        Collider[] hitColliders;
        hitColliders = Physics.OverlapSphere(this.transform.position, raioExplosao);

        
        foreach (Collider itemProximo in hitColliders)
        {
            Debug.Log(itemProximo.gameObject.name);
            if (itemProximo.gameObject.GetComponent<IExpulsar>() != null)
            {
                itemProximo.gameObject.GetComponent<IExpulsar>().Afastar(forca, this.transform.position);
            }
        }
    }

    void Atracao()
    {
        Collider[] hitColliders;
        hitColliders = Physics.OverlapSphere(this.transform.position, raioAtracao);
        foreach (Collider itemAtraido in hitColliders)
        {
            if (itemAtraido.gameObject.tag != "Item")
            {
                continue;//se não for igual a item ele não faz a atração
            }

            Vector3 direcaoAtracao = transform.position - itemAtraido.transform.position;
            direcaoAtracao.Normalize();
            itemAtraido.transform.Translate(direcaoAtracao * velAtraction * Time.deltaTime);
            
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;//desenha um gizmo vde uma cor especifica no formato do codigo abaixo(DrawWireSphere) na posição do player pra saber a distancia do raio para o raio de cada um
        Gizmos.DrawWireSphere(this.transform.position, raioExplosao);
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(this.transform.position, raioAtracao);
    }
}
