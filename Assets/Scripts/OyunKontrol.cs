using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject zombi;
    private float zamanSayaci;
    private float olusumSüreci = 8f;
    public Text puantext;
    private int puan;

    // Start is called before the first frame update
    void Start()
    {
        zamanSayaci = olusumSüreci;
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0)
        {
            Vector3 pos = new Vector3(Random.Range(450, 550), 43f, Random.Range(450, 600));
            Instantiate(zombi, pos, Quaternion.identity);
            zamanSayaci = olusumSüreci;
        }
    }
    public void puanArtir(int p)
    {
        puan += p;
        puantext.text = "" + puan;
    }
    public void oyunBitti()
    {
        PlayerPrefs.SetInt("puan", puan);
        SceneManager.LoadScene("oyunBitti");
    }
}
