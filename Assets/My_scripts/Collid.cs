using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Collid : MonoBehaviour
{
    private GameObject [] walls;
    private float wallLength;
    private float wallBreath;
    private float wallHeight; 
    private float totalVolume;
    private float basePrice;
    private double brickVolume = (0.19*0.09*0.09);
    private double brickVolumeWithMortar = (0.19+0.009525)*(0.09)*(0.09+0.009525);
    private float bricks;
    private float motorVolume;
    private float ratio;
    private float cement;
    private float lime;
    private float sand;
    private float cementRate;
    private float limeRate;
    private float sandRate;
    private float brickRate;
    public TextMeshProUGUI cementText;
    public TextMeshProUGUI limeText;
    public TextMeshProUGUI sandText;
    public TextMeshProUGUI brickText;
    public TextMeshProUGUI basePriceText;

    // private float pricePerCube = 1;
    // Start is called before the first frame update
    void Start()
    {
        walls = GameObject.FindGameObjectsWithTag("Wall");
        for(int i=0; i<walls.Length; i++){
            walls[i].AddComponent<BoxCollider>();
            wallLength =  walls[i].GetComponent<BoxCollider>().size.x;
            wallBreath =  walls[i].GetComponent<BoxCollider>().size.y;
            wallHeight =  walls[i].GetComponent<BoxCollider>().size.z;
            totalVolume += wallLength*wallBreath*wallHeight;
            Destroy(walls[i].GetComponent<BoxCollider>());
        }
        bricks = totalVolume/(float)brickVolumeWithMortar;
        bricks = (float)Math.Round(bricks);
        motorVolume = totalVolume - bricks*(float)brickVolume;
        ratio = motorVolume/17;
        cement = ratio*4;
        lime = ratio;
        sand = ratio*12;
        brickRate = bricks;
        cementRate = cement*(10080);
        limeRate = lime*(14100);
        sandRate = sand*(75000);
        basePrice = brickRate + cementRate + limeRate + sandRate;
        cementText.text = "Cement Rate: " + (int)cementRate;
        limeText.text = "Lime Rate: " + (int)limeRate;
        sandText.text = "Sand Rate: " + (int)sandRate;
        brickText.text = "Brick Rate: " + (int)brickRate;
        basePriceText.text = "Base Price: " + (int)basePrice;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}