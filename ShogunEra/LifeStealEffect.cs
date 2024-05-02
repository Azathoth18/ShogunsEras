using Jotunn.Entities;
using UnityEngine;
using System.Collections.Generic;

namespace ShogunEra.Effects
{
    // Clase para definir el efecto de robo de vida
    public class SE_LifeSteal : StatusEffect
    {
        public float m_chanceToStealLife;
        public float m_lifeStealMin;
        public float m_lifeStealMax;

        public void Awake()
        {
            m_name = "Life Steal";
            name = "LifeSteal";
            m_tooltip = "15% chance to steal 10-30% of enemy's life and add it to your next attack";
        }

        public override void ModifyAttack(Skills.SkillType skill, ref HitData hitData)
        {
            float originalDamage = hitData.GetTotalDamage();

            if (UnityEngine.Random.value < m_chanceToStealLife)
            {
                float lifeToSteal = UnityEngine.Random.Range(m_lifeStealMin, m_lifeStealMax) * originalDamage;
                float lifeStealPercentage = lifeToSteal / originalDamage * 100;

                List<string> validDamageTypes = new List<string>();
                if (hitData.m_damage.m_blunt >= 1) validDamageTypes.Add("blunt");
                if (hitData.m_damage.m_slash >= 1) validDamageTypes.Add("slash");
                if (hitData.m_damage.m_pierce >= 1) validDamageTypes.Add("pierce");

                string selectedDamageType = validDamageTypes[UnityEngine.Random.Range(0, validDamageTypes.Count)];

                switch (selectedDamageType)
                {
                    case "blunt":
                        hitData.m_damage.m_blunt += lifeToSteal;
                        break;
                    case "slash":
                        hitData.m_damage.m_slash += lifeToSteal;
                        break;
                    case "pierce":
                        hitData.m_damage.m_pierce += lifeToSteal;
                        break;
                }

                float totalDamageWithBuff = hitData.GetTotalDamage();

                Player.m_localPlayer.Message(MessageHud.MessageType.TopLeft, "Bendición de Tyr: Robaste " + lifeStealPercentage.ToString("0.00") + "% de vida");
                Player.m_localPlayer.Message(MessageHud.MessageType.TopLeft, "Daño con Bendición de Tyr: " + totalDamageWithBuff.ToString("0.00"));
            }
        }
    }
}