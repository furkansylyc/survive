using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puan;

    // Start metodu, ilk frame'den �nce �a�r�l�r
    void Start()
    {
        // Farenin g�r�n�r ve kilitsiz olmas�n� sa�la
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Zaman �l�e�ini 1 yaparak farenin d�zg�n �al��mas�n� sa�la
        Time.timeScale = 1;

        // Skor g�stergesini g�ncelle
        puan.text = "Puan�n�z: " + PlayerPrefs.GetInt("puan");
    }

    // Oyunu yeniden y�klemek i�in metod
    public void YenidenOyna()
    {
        SceneManager.LoadScene("oyun");
    }
}
