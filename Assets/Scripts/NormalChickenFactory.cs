using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalChickenFactory : ChickenFactory
{
    public Chicken Chicken;
    
    
    public override IChicken CreateChicken()
    {
        Chicken = GameObject.Instantiate(Chicken);
        
        return Chicken;
    }
}
