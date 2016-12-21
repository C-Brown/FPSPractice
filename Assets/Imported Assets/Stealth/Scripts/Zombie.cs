using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

    public string Name;
    public int brainsEaten;
    public int hitPoints;
    GameObject ZombieMesh;

    public Zombie(string Name, int hitPoints)
    {
        this.Name = Name;
        brainsEaten = 0;
        this.hitPoints = hitPoints;
        ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Vector3 pos = new Vector3(
            Random.Range(-10, 10), 1f,
            Random.Range(-10, 10));
        ZombieMesh.transform.position = pos;
    }
}
