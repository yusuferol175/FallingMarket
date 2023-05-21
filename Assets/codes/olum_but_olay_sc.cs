using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class olum_but_olay_sc : MonoBehaviour
{
    public Text skor;
    public void res()
    {
        SceneManager.LoadScene("oyun");
    }
    public void ev()
    {
        SceneManager.LoadScene("menu");
    }

     void Start()
    {
        skor.text = PlayerPrefs.GetInt("skor").ToString();
    }
}
