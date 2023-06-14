using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager EvAnahtarı = null;    // EvAnahtarı adında null bir değişken oluştur.
    public Button baslaDugme;
    public bool oyunbasladimi = false;

    void Awake()
    {
        if(EvAnahtarı == null)  // EvAnahtarı başka bir yerde oluşturulmamışsa 
        {
            EvAnahtarı = this;  // EvAnahtarı değişkenine bu GameManager nesnesini atar.
        }
        else
        {
            Destroy(gameObject);
        }

        // Diğer kodlar...
        // GameManager'ın diğer işlemleri burada devam eder.
    }
    
    // Diğer GameManager fonksiyonları ve işlemler...

    public void BaslatFonk()
    {
        oyunbasladimi = true;
        baslaDugme.gameObject.SetActive(false);
    }
}