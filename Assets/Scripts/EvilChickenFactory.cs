using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilChickenFactory : ChickenFactory
{
    public EvilChicken EvilChicken;
    
    
    public override IChicken CreateChicken()
    {
        EvilChicken = GameObject.Instantiate(EvilChicken);
        
        return EvilChicken;
    }
}
