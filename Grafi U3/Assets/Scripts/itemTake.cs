using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemTake : MonoBehaviour
{
    private GameObject player;
    private AlmasManager almas;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.instance.Player;
        almas = player.GetComponent<AlmasManager>();
        almas.SumarAlma();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject == player)
        {
            almas.RestarAlma();
            Destroy(gameObject);
        }
    }
}
