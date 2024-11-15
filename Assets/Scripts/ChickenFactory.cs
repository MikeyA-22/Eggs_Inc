using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChickenFactory : MonoBehaviour
{
   public abstract IChicken CreateChicken();
   
}
