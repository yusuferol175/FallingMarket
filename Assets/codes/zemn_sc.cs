using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemn_sc : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="pattes")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "kola")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "brokoli")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "karpuz")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "sise")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "kilcik")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "biftek")
        {
            Destroy(collision.gameObject);
        }
    }

}
