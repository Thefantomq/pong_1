using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolAtma : MonoBehaviour
{
    public Text skorYazisi;
    private int skor;

    public void Awake()
    {
        skor = 0;
        skorYazisi.text = skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TopTag")
        {
            skor += 1;
            skorYazisi.text = skor.ToString();
        }
    }

   void Update()
   {
        if(skor == 3)
        {
            SceneManager.LoadScene("SampleScene");
        }
   }
}