using UnityEngine;

public class Weapon : MonoBehaviour
{
    public virtual void Use(GameObject weapon)
    {

    }

    public virtual void SecondaryUse()
    {

    }

    public void DealDmg(IHittable hittable)
    {
        
    }
}