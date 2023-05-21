using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay : MonoBehaviour
{
    public GameObject mc;
    bool hareket;
    public float MovementSpeed;
    public Image yesil_bar;
    Animator animcha;
    public AudioSource walk_ses;   
    public GameObject pause_panel;

    public void durdur()
    {
        Time.timeScale = 0f;
        pause_panel.SetActive(true);

    }
    public void baslat()
    {
        Time.timeScale = 1f;
        pause_panel.SetActive(false);
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void restart()
    {
        SceneManager.LoadScene("oyun");
    }
    public void move_start(bool sol_da_mý)
    {
        if (sol_da_mý)
        {
            if (mc.gameObject.transform.localScale.x > 0)
            {
                mc.gameObject.transform.localScale = new Vector3(mc.gameObject.transform.localScale.x * -1, mc.gameObject.transform.localScale.y, mc.gameObject.transform.localScale.x);
                MovementSpeed *= -1;
            }


        }
        else
        {
            if (mc.gameObject.transform.localScale.x < 0)
            {
                mc.gameObject.transform.localScale = new Vector3(mc.gameObject.transform.localScale.x * -1, mc.gameObject.transform.localScale.y, mc.gameObject.transform.localScale.x);
                MovementSpeed *= -1;
            }


        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;

    }

     void Start()
    {
        Time.timeScale = 1f;
        pause_panel.SetActive(false);
        animcha = mc.gameObject.GetComponent<Animator>();
    }
    private bool yks =true;
    private bool alck =false;
    private bool orta =true;
    // Update is called once per frame
    void Update()
    {
        if (yesil_bar.fillAmount>0.5f)
        {
            if (yks)
            {
                if (MovementSpeed>0)
                {
                    MovementSpeed = 2.5f;
                    yks = false;
                    orta = true;
                    alck = true;
                }
                else if (MovementSpeed < 0)
                {
                    MovementSpeed = -2.5f;
                    yks = false;
                    orta = true;
                    alck = true;
                }
               
                
            }
            
        }
        else if (yesil_bar.fillAmount < 0.5f)
        {
            if (alck)
            {
                if (MovementSpeed>0)
                {
                    MovementSpeed = 1f;
                    yks = true;
                    orta = true;
                    alck = false;
                }
                else if (MovementSpeed < 0)
                {
                    MovementSpeed = -1f;
                    yks = true;
                    orta = true;
                    alck = false;
                }
                
            }
        }
        else if (yesil_bar.fillAmount == 0.5f)
        {
            if (orta)
            {
                if (MovementSpeed > 0)
                {
                    MovementSpeed = 2f;
                    orta = false;
                    yks = true;
                    alck = true;
                }
                else if (MovementSpeed < 0)
                {
                    MovementSpeed = -2f;
                    orta = false;
                    yks = true;
                    alck = true;
                }
            }
        }
        if (hareket)
        {
            if (walk_ses.isPlaying==false)
            {
                walk_ses.Play();
            }
            
            if (mc.gameObject)
            {
                mc.gameObject.transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime * 5;
            }
            if (animcha)
            {
                animcha.SetBool("yurume", true);
            }

        }
        else
        {
            if (walk_ses.isPlaying == true)
            {
                walk_ses.Stop();
            }
            
            if (animcha)
            {
                animcha.SetBool("yurume", false);
            }
        }
    }
}
