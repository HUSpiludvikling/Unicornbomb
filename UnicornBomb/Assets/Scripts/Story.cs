using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Blank Story", menuName = "Story")]
public class Story : ScriptableObject
{
    public List<string> Linjer_af_tekst;
    public List<Sprite> Billeder;


}