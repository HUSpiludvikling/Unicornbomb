using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Blank Item", menuName = "Items")]
public class Items : ScriptableObject
{
    public Color itemColor = Color.red;
        public string itemName = "Blank";
    public Sprite image;
}