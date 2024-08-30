using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColliderDimensions : MonoBehaviour
{
    private GameObject [] walls;
    private float length;
    private float breath;
    private float height; 
    private float volume;
    private float basePrice;
    private float pricePerCube = 1;
    public TextMeshProUGUI basePriceText;
    public TextMeshProUGUI volumeText;
    // Start is called before the first frame update
    void Start()
    {
        walls = GameObject.FindGameObjectsWithTag("cube");
        for(int i=0; i<walls.Length; i++){
            length =  walls[i].GetComponent<BoxCollider>().size.x;
            breath =  walls[i].GetComponent<BoxCollider>().size.y;
            height =  walls[i].GetComponent<BoxCollider>().size.z;
            volume += length*breath*height;
        }
        basePrice = volume*pricePerCube;
        basePriceText.text = "Base Price: " + basePrice;
        volumeText.text = "Volume: " + volume;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 