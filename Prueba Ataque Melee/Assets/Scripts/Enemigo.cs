using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Al entrar en colisión con un jugador, se guarda el enemigo en el battle manager, y carga la escena de batalla
            BattleManager.Instance.EnemigoParaBatalla = gameObject;
            SceneManager.LoadScene("Batalla");
        }
    }
}
