using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    //Rigidbody myRb;
    Animator myAnim;
    float velX, velY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxis("Horizontal"); //controlador basico para testar um jogo rapidamente
        velY = Input.GetAxis("Vertical");

        

        myAnim.SetFloat("X", velX);
        myAnim.SetFloat("Y", velY);

        transform.Translate(new Vector3(velX, 0, velY) * Time.deltaTime);// o Y desse transform está posicionado no Z do Vector3 que moverá o player pra frente,
                                                                         // pra movimentar o player para frente o axis x e y pega a informação no wasd
                                                                         // e no analogico dos controles com a funçao acima de input.getaxis

        if (Input.GetKey(KeyCode.X))
        {
            Destroy(this);
            myAnim.SetBool("isDead", true);// liga a animação de morte no Animator do personagem

        }
        else
        {
            myAnim.SetBool("isDead", false);

        }

    }
}
