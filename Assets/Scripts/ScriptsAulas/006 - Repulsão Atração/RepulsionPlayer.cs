using UnityEngine;

public class RepulsionPlayer : MonoBehaviour
{
    Rigidbody myRb;
    public float raioExplosao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");

        myRb.angularVelocity = new Vector3(dirX, 0, dirZ) * 10f;
    }
    void UsarForca()
    {
        Collider[] hitColliders;
        hitColliders = Physics.OverlapSphere(this.transform.position, raioExplosao);
    }
}
