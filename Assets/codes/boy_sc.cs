using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boy_sc : MonoBehaviour
{
    public Text skor;
    public Image yesil_bar;
    public static int can;
    public GameObject can_olay;
    public AudioSource sescik;
    public AudioClip nom;
    public AudioClip dmg;
    private void skor_yaz()
    {
        if (PlayerPrefs.GetInt("skor") > 0)
        {
            skor.text = PlayerPrefs.GetInt("skor").ToString();
        }
        else if (PlayerPrefs.GetInt("skor") < 0)
        {
            PlayerPrefs.SetInt("skor", 0);
            skor.text = PlayerPrefs.GetInt("skor").ToString();
        }
        else if (PlayerPrefs.GetInt("skor") == 0)
        {
            skor.text = PlayerPrefs.GetInt("skor").ToString();
        }
        
    }
    private void sisko()
    {
        yesil_bar.fillAmount = yesil_bar.fillAmount-0.1f;
    }
    private void zayif()
    {
        yesil_bar.fillAmount = yesil_bar.fillAmount + 0.1f;
    }
    private void ye()
    {
        sescik.PlayOneShot(nom);
    }
    private void dmgye()
    {
        sescik.PlayOneShot(dmg);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="pattes")
        {
            Destroy(collision.gameObject);
            if (PlayerPrefs.GetInt("skor")>0)
            {
                PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("skor") - 20);
            }
            skor_yaz();
            sisko();
            ye();
        }
        if (collision.gameObject.tag=="kola")
        {
            Destroy(collision.gameObject);
            if (PlayerPrefs.GetInt("skor")>0)
            {
                PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("skor") - 10);
            }
            sisko();
            skor_yaz();
            ye();
        }
        if (collision.gameObject.tag == "karpuz")
        {
            Destroy(collision.gameObject);
           
                PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("skor") + 10);
            
            skor_yaz();
            zayif();
            ye();
        }
        if (collision.gameObject.tag == "brokoli")
        {
            Destroy(collision.gameObject);

            PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("skor") + 20);

            skor_yaz();
            zayif();
            ye();
        }
        if (collision.gameObject.tag == "sise")
        {
            Destroy(collision.gameObject);
            can--;
            can_olay.GetComponent<can_sc>().can_durum();
            dmgye();
        }
        if (collision.gameObject.tag == "kilcik")
        {
            Destroy(collision.gameObject);
            can--;
            can_olay.GetComponent<can_sc>().can_durum();
            dmgye();
        }
        if (collision.gameObject.tag == "biftek")
        {
            Destroy(collision.gameObject);
            can++;
            can_olay.GetComponent<can_sc>().kalp_durum();
            PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("skor") + 30);

            skor_yaz();
            ye();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        skor_yaz();
        yesil_bar.fillAmount = 0.5f;
        can = 3;
        PlayerPrefs.SetInt("skor", 0);
        skor_yaz();
    }

    // Update is called once per frame
    void Update()
    {
        if (can==0)
        {
            SceneManager.LoadScene("olum");
        }
    }
}
