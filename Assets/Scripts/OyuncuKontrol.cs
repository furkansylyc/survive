using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyuncuKontrol : MonoBehaviour
{
    public Transform mermiPos;
    public GameObject mermi;
    public GameObject silahpatlama;
    public Image canImajý;
    private float canDegeri = 100f;
    public OyunKontrol oKontrol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject go = Instantiate (mermi,mermiPos.position,mermiPos.rotation) as GameObject;
            GameObject gosilahpatlama = Instantiate(silahpatlama, mermiPos.position, mermiPos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = mermiPos.transform.forward * 10f;
            Destroy (go.gameObject,3f);
            Destroy(gosilahpatlama.gameObject, 2f);
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if(c.collider.gameObject.tag.Equals("zombi"))
        {
            canDegeri -= 15f;
            float x = canDegeri / 100f;
            canImajý.fillAmount = x;
            canImajý.color = Color.Lerp(Color.green, Color.red,x);

            if(canDegeri<=0)
            {
                oKontrol.oyunBitti();
            }
        }
    }
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag.Equals("kalp"))
        {
            if(canDegeri<100f)
            canDegeri += 5f;
            float x = canDegeri / 100f;
            canImajý.fillAmount = x;
            canImajý.color = Color.Lerp(Color.red, Color.green, x);          
        }
    }
}
