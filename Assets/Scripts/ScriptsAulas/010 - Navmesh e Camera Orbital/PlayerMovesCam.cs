using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovesCam : MonoBehaviour
{
    [SerializeField]
    float speed = 8f;
    [SerializeField]
    float speedRotation = 10f;

    [SerializeField]
    Transform cameraPlayer;

    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    /*void MovimentoBase()
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().linearVelocity = new Vector3(dirX, 0, dirZ) * 10f;
    }*/

    void MovePlayer()
    {
        float moveHorizontal, moveVertical;
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3 dirInputs = new Vector3(moveHorizontal, 0, moveVertical);

        if (dirInputs.magnitude >= 0.1f)
        {
            Vector3 vectorFrente = cameraPlayer.forward;
            Vector3 vectorLado = cameraPlayer.right;

            vectorFrente.y = 0;
            vectorLado.y = 0;

            vectorFrente.Normalize();
            vectorLado.Normalize();

            Vector3 dirFinal = vectorFrente * moveVertical + vectorLado * moveHorizontal;
            dirFinal.Normalize();

            Vector3 movementacaoFinal = dirFinal * speed;
            movementacaoFinal.y = 0;
            myRigidbody.linearVelocity = movementacaoFinal;

            Quaternion dirDestinoRotation = Quaternion.LookRotation(dirFinal);
            transform.rotation = Quaternion.Slerp(transform.rotation, dirDestinoRotation, speedRotation * Time.deltaTime);
        }
        else
        {
            myRigidbody.linearVelocity = Vector3.zero;
        }

        //myRigidbody.angularVelocity = new Vector3(moveHorizontal, 0, moveVertical) * speed;
    }
}
