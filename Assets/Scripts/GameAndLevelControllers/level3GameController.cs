using UnityEngine;
using System.Collections;

public class level3GameController : BaseLevelController
{
    // Use this for initialization
    void Start()
    {
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyFighter1, 20, enemySpawns[0]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyFighter1, 20, enemySpawns[1]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyFighter1, 20, enemySpawns[2]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyCruiser1, 1, enemySpawns[0]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyCruiser1, 1, enemySpawns[1]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.AlliedFighter1, 15, allySpawns[0]);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.AlliedFighter1, 15, allySpawns[1]);

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void PlayerEnteredBoundary(GameObject boundary)
    {
        
    }


    protected override void PlayerLeftBoundary(GameObject boundary)
    {

    }
}

