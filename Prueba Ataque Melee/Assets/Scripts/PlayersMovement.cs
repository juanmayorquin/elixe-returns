using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject player1, player2, player3, player4;
    [SerializeField] private float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        moverse();
        rotar();
    }

    public void moverse()
    {
        //Se añade velocidad según la dirección que se presione
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0);

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            //Se invocan las animaciones de los personajes
            player1.GetComponent<Animator>().SetTrigger("run");
            player2.GetComponent<Animator>().SetTrigger("run");
            player3.GetComponent<Animator>().SetTrigger("run");
            player4.GetComponent<Animator>().SetTrigger("run");
        }
        else if(Input.GetAxisRaw("Horizontal") == 0)
        {
            //Se invocan las animaciones de los personajes
            player1.GetComponent<Animator>().SetTrigger("idle");
            player2.GetComponent<Animator>().SetTrigger("idle");
            player3.GetComponent<Animator>().SetTrigger("idle");
            player4.GetComponent<Animator>().SetTrigger("idle");
        }
    }

    public void rotar()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //Se establece la rotación por defecto si se está moviendo hacia la derecha
            player1.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            player2.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            player3.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            player4.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //Se invierte la imagen sobre el eje x si se está moviendo hacia la izquierda
            player1.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
            player2.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
            player3.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
            player4.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
    }
}
