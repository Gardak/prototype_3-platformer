using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_player : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        player.transform.position = new Vector3(-108, 18, 50);
    }
}
