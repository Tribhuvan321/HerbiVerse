using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New card", menuName ="Card")]
public class Card : ScriptableObject
{
    public string item_name;
    public string type;
    public string region;
    public string use;

    public Sprite item_img;
}
