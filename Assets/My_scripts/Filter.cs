using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> cardList;

    public void Skin()
    {
        foreach (var item in cardList)
        {
            if(item.tag == "Skin")
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }
    public void Immunity()
    {
        foreach (var item in cardList)
        {
            if (item.tag == "Immunity")
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }
    public void Digest()
    {
        foreach (var item in cardList)
        {
            if (item.tag == "Digest")
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }

    public void FilterOff()
    {
        foreach (var item in cardList)
        {
            item.SetActive(true);
        }
    }
}
