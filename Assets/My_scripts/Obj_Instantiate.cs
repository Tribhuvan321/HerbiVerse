using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj_Instantiate : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject placeAt;

    public void Ins_table()
    {
        Instantiate(obj[0],placeAt.transform);
    }
    public void Ins_sofa()
    {
        Instantiate(obj[1], placeAt.transform);
    }
    public void Ins_lamp()
    {
        Instantiate(obj[2], placeAt.transform);
    }
    public void Ins_Chandlier()
    {
        Instantiate(obj[3], placeAt.transform);
    }
    public void Ins_CupBoard()
    {
        Instantiate(obj[4], placeAt.transform);
    }
    public void DesstroyFurniture()
    {
        //for(int i =0; i< obj.Length; i++)
        //{
        //    obj[i].
        //}
        Debug.Log(this.GetComponentInParent<Transform>());
    }
}
