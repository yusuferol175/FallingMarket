using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olusum_sc : MonoBehaviour
{
    System.Random random = new System.Random();
    private float sayac;
    public GameObject pattes;
    public GameObject kola;
    public GameObject karpuz;
    public GameObject brkl;
    public GameObject sise;
    public GameObject kilcik;
    public GameObject biftek;
    private void pattes_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(pattes, new Vector3(rndm_x, 6f, 0f), pattes.transform.rotation);
    }
    private void kola_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(kola, new Vector3(rndm_x, 6f, 0f), kola.transform.rotation);
    }
    private void karpuz_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(karpuz, new Vector3(rndm_x, 6f, 0f), karpuz.transform.rotation);
    }
    private void brkl_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(brkl, new Vector3(rndm_x, 6f, 0f), brkl.transform.rotation);
    }
    private void sise_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(sise, new Vector3(rndm_x, 6f, 0f), sise.transform.rotation);
    }
    private void kilcik_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(kilcik, new Vector3(rndm_x, 6f, 0f), kilcik.transform.rotation);
    }
    private void biftek_ol()
    {
        int rndm_x = random.Next(-8, 8);
        Instantiate(biftek, new Vector3(rndm_x, 6f, 0f), biftek.transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        sayac += Time.deltaTime * 1;
        if (sayac > 1)
        {



            int rast_nesne = random.Next(0, 7);
            rast_nesne = random.Next(0, 7);
            if (rast_nesne == 0)
            {
                pattes_ol();
            }
            else if (rast_nesne == 1)
            {
                kola_ol();
            }
            else if (rast_nesne == 2)
            {
                karpuz_ol();
            } 
            else if (rast_nesne == 3)
            {
                brkl_ol();
            }
            else if (rast_nesne == 4)
            {
                sise_ol();
            }
            else if (rast_nesne == 5)
            {
                kilcik_ol();
            }
            else if (rast_nesne == 6)
            {
                biftek_ol();
            }

            sayac = 0;
        }



    }
}
