using UnityEngine;

public class CenterOfMass : MonoBehaviour
{

    public Vector3 myCenterOfMass;//deixa mover a posição do centro de massa

    private Rigidbody myRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRb.centerOfMass = myCenterOfMass;
        if(Input.GetKeyDown(KeyCode.Space))//com espaço adiciona força pro vetor Z do centro de massa do João Bobo
        {
            myRb.AddForce(new Vector3(0, 0, 10));
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;//desenha o gizmo para mostrar o center of mass
        Gizmos.DrawWireSphere(transform.position + transform.rotation * myCenterOfMass, 2f);
    }
}
