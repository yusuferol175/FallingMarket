using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class can_sc : MonoBehaviour
{
    public Image can1;
    public Image can2;
    public Image can3;

    public Sprite biftek;
    public Sprite kemik;
    public void can_durum()
    {
        if (boy_sc.can == 0)
        {

            can1.gameObject.GetComponent<Image>().sprite = kemik;
        }
        if (boy_sc.can == 1)
        {

            can2.gameObject.GetComponent<Image>().sprite = kemik;
        }
        if (boy_sc.can == 2)
        {

            can3.gameObject.GetComponent<Image>().sprite = kemik;
        }

    }
    public void kalp_durum()
    {
        if (boy_sc.can == 1)
        {

            can1.gameObject.GetComponent<Image>().sprite = biftek;
        }
        if (boy_sc.can == 2)
        {

            can2.gameObject.GetComponent<Image>().sprite = biftek;
        }
        if (boy_sc.can == 3)
        {

            can3.gameObject.GetComponent<Image>().sprite = biftek;
        }
        if (boy_sc.can == 4)
        {
            boy_sc.can = 3;
        }

    }
}
