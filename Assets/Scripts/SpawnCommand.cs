using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCommand : MonoBehaviour, ICommand
{
    
    public List<ChickenFactory> chickenFactories = new List<ChickenFactory>();
    private ChickenFactory _chickenFactory;
    public void Execute()
    {
        _chickenFactory = chickenFactories[Random.Range(0, chickenFactories.Count)];
        IChicken chicken = _chickenFactory.CreateChicken();
    }
}
