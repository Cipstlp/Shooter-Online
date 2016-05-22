using UnityEngine;
using System.Collections;
//using UnityEngine.Networking;

public class EnemyMovement : MonoBehaviour {

	public GameObject player;
	NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (!GetComponent<EnemyHealth>().isDead)
        {
            if (player != null)
            {
                if (player.GetComponent<PlayerHealth>().isDead)
                {
                    GetComponent<EnemyHealth>().Death();
                    GetComponent<EnemyHealth>().isDead = true;
                    return;
                }
                else
                {
                    nav.SetDestination(player.transform.position);
                }
            }
        }
	}
}
