using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemigos = new List<GameObject>();
    public GameObject players;
    public GameObject triggeredEnemy;
    public static GameObject enemyForBattle;

    // Start is called before the first frame update
    void Start()
    {
        triggeredEnemy = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(triggeredEnemy != null)
        {
            //Si se entra en contacto con un enemigo, este se guarda en memoria y se entra en batalla con él
            enemyForBattle = triggeredEnemy;
            SceneManager.LoadScene("Batalla");
        }
    }
}
