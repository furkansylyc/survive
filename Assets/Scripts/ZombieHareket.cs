using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieHareket : MonoBehaviour
{
    public GameObject kalp;
    private GameObject oyuncu;
    private int zombiCan = 3;
    private float mesafe;
    private OyunKontrol oKontrol;
    private int zombidengelenPuan = 10;
    void Start()
    {
        oyuncu = GameObject.Find("Oyuncu");
        oKontrol = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination=oyuncu.transform.position;
        mesafe=Vector3.Distance(transform.position,oyuncu.transform.position);
        if(mesafe<5f)
        {
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if(c.collider.gameObject.tag.Equals("mermi"))
        {
            zombiCan--;
            if(zombiCan == 0) {
                oKontrol.puanArtir(zombidengelenPuan);
                Instantiate(kalp,transform.position, Quaternion.identity);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.667f);
               
            }
        }
    }
}
