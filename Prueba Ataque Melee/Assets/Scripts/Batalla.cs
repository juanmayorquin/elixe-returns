using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batalla : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] private GameObject player1, player2, player3, player4, enemigo;
    

    // Start is called before the first frame update
    void Start()
    {
        enemigo = GameManager.enemyForBattle;
        CargarBatalla(enemigo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarBatalla(GameObject enemigo)
    {

    }
}
