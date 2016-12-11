using UnityEngine;
using System.Collections;

public class EscortController : BaseLevelController
{

	// Use this for initialization
	void Start () {
        GameObject cruiser = UnitSpawner.SpawnUnit(UnitReferences.AlliedCruiserHeavy1, Vector3.zero);
        UnitSpawner.SpawnUnitsInArea(UnitReferences.EnemyCruiserLight1, 1, enemySpawns[0]);
        cruiser.GetComponent<CruiserAIController>().goToPoints = this.goToPoints;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
