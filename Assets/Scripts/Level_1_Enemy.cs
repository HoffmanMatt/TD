using UnityEngine;
using System.Collections;

public class Level_1_Enemy : MonoBehaviour {

    //float maxHitPoints = 50;
    public float hitPoints = 50;
    

    void Start()
    {      

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damage")
        {
            //var scriptName = "Tower_Rocket Projectile";
            //need to work for all types of projectiles. not sure how
            Tower_Rocket_Projectile_Yaxis theScript = (Tower_Rocket_Projectile_Yaxis) other.gameObject.GetComponent("Tower_Rocket_Projectile_Yaxis");
            //hitPoints = hitPoints - 16;
            hitPoints = hitPoints - theScript.damagePerAttack;
            Destroy(other.gameObject);
            if (hitPoints <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
