using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int DamageBase = 10;

    public void GetDamage(int damage)
    {
        DamageBase = damage;
    }

    public void GetDamage(int damage, int ProbCrit)
    {
        if (Random.Range(0, 100) < ProbCrit)
        {
            DamageBase = damage * 2;
        }
        else
        {
            DamageBase = damage;
        }
    }
    public void GetDamage(int damage, int ProbCrit, bool knockback)
    {
        GetDamage(damage, ProbCrit);
        if (knockback)
        {
            print("Player Knockback");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Daño básico
            GetDamage(15);
            print("Daño básico: " + DamageBase);

            // Daño con crítico
            GetDamage(15, 50); 
            print("Daño con crítico: " + DamageBase);

            // Daño con crítico y knockback
            GetDamage(15, 50, true);
            print("Daño con crítico y knockback: " + DamageBase);
        }
    }
}


