using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject contentHolder;
    public GameObject[] Element;
    public GameObject searchBar;
    public int totalElements;
    void Start()
    {
        totalElements = contentHolder.transform.childCount;
        Element = new GameObject[totalElements];
        for(int i =0; i<totalElements; i++)
        {
            Element[i] = contentHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    public void Search()
    {
        string searchText = searchBar.GetComponent<TMP_InputField>().text;
        int searchTextLength = searchText.Length;
        int searchedElements = 0;

        foreach(GameObject ele in Element)
        {
            searchedElements += 1;
            Debug.Log(ele.transform.name);
            if(searchText.ToLower() == ele.transform.name.Substring(0, searchTextLength).ToLower())
            {
                ele.SetActive(true);
            }
            else
            {
                ele.SetActive(false);
            }
        }
    }
}
