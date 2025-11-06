using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    void TakeDamage(float amount);
    void Recover(float amount);
}

public interface IStamina
{
    void Deplete(float amount);
    void Replenish(float amount);
}

public interface IMagic
{
    void ConsumeMana(float amount);
    void RestoreMana(float amount);
}
