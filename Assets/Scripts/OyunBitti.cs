using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puan;

    // Start metodu, ilk frame'den önce çaðrýlýr
    void Start()
    {
        // Farenin görünür ve kilitsiz olmasýný saðla
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Zaman ölçeðini 1 yaparak farenin düzgün çalýþmasýný saðla
        Time.timeScale = 1;

        // Skor göstergesini güncelle
        puan.text = "Puanýnýz: " + PlayerPrefs.GetInt("puan");
    }

    // Oyunu yeniden yüklemek için metod
    public void YenidenOyna()
    {
        SceneManager.LoadScene("oyun");
    }
}
