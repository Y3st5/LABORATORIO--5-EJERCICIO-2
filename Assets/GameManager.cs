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
            // Da�o b�sico
            GetDamage(15);
            print("Da�o b�sico: " + DamageBase);

            // Da�o con cr�tico
            GetDamage(15, 50); 
            print("Da�o con cr�tico: " + DamageBase);

            // Da�o con cr�tico y knockback
            GetDamage(15, 50, true);
            print("Da�o con cr�tico y knockback: " + DamageBase);
        }
    }
}


