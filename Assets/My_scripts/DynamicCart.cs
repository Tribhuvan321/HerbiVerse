using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicCart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TemplateCardPrefab;
    public GameObject item;
    public Transform Container;
    [SerializeField]
    private GameObject[] activeObjList;
    public string[] objNames;
    public Dictionary<string, string> objPrice;
    public Dictionary<string, string> objImgPath;
    int done = 0;
    public int i = 0;
    //private string[] activeObjName;
    //int i;
    void Start()
    {
        //objPrice = new Dictionary<string, string>()
        //{
        //    {"table","1000"},
        //    {"chandlier","2000"}
        //};

        //objImgPath = new Dictionary<string, string>()
        //{
        //    {"table","/assets/img1" },
        //    {"chandlier", "/assets/img2" }
        //};
    }

    // Update is called once per frame
    void Update()
    {
        activeObjList = GameObject.FindGameObjectsWithTag("furniture");
        //activeObjName = activeObjList[].name;

        //objNames = new string[activeObjList.Length];
        //if (done == 0)
        //{
        objNames = new string[activeObjList.Length];
        tribhu();




        //item.GetComponent<Image>().sprite = Resources.Load<Sprite>("Chandlier");
        ////spriteRdr.sprite = Resources.Load<Sprite>("Chandlier");
        //Instantiate(TemplateCardPrefab,Container); //-------------> for instantiating the card
        
        //}
        //Debug.Log(done);
        //if (objPrice.ContainsKey(objNames[i]))
        //{
        //    //set the respective price value to the preset prefab;
        //}

    }
    public void tribhu()
    {
        while(i < objNames.Length)
        {
            objNames[i] = activeObjList[i].name;
            Debug.Log(objNames[i]);
            i++;
        }
        //done++;
    }

    public void addToCart ()
    {

    }
}
