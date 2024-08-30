using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class PriceEstimation : MonoBehaviour
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
        walls = GameObject.FindGameObjectsWithTag("cube");
        for(int i=0; i<walls.Length; i++){
            wallLength =  walls[i].GetComponent<BoxCollider>().size.x;
            wallBreath =  walls[i].GetComponent<BoxCollider>().size.y;
            wallHeight =  walls[i].GetComponent<BoxCollider>().size.z;
            totalVolume += wallLength*wallBreath*wallHeight;
        }
        bricks = totalVolume/(float)brickVolumeWithMortar;
        bricks = (float)Math.Round(bricks);
        motorVolume = totalVolume - bricks*(float)brickVolume;
        ratio = motorVolume/17;
        cement = ratio*4;
        lime = ratio;
        sand = ratio*12;
        brickRate = bricks*10;
        cementRate = cement*(10080);
        limeRate = lime*(320000);
        sandRate = sand*(400000);
        basePrice = brickRate + cementRate + limeRate + sandRate;
        cementText.text = "Cement Rate: " + cementRate;
        limeText.text = "Lime Rate: " + limeRate;
        sandText.text = "Sand Rate: " + sandRate;
        brickText.text = "Brick Rate: " + brickRate;
        basePriceText.text = "Base Price: " + basePrice;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
