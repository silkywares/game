using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour

{
    //P.I.S.C.A.C 1-10 point buy 30 total
    //level cap 30
    //in game ability to increase each stat by one point
    //ability to grind skills under 4 up to 4 through quests
    int stamina;
    int strength; 
    int agility;
    int intellect;
    int perception;//pet
   

    //attack skills give xp when leveled up
    int 1hand;
    int 2hand;
    int ranged;
    int wands;
    int spells;
   
    int herbalism;
    int mining;
    int fishing;
    int medicine;
    int speech;
    int cooking;//quests to cook rare food with monetary reward
    
//perks
//core perks: 3, 5, 7, 9

//strength
   void strengthPerkOne(){
    //physical damage increased by 10%
    //weapon attack speed increased by 7%
   }
   void strengthPerkTwo(){
    //x attack power after a crit
   }
   void strengthPerkThree(){
    //attacks have 5% chance of stunning enemy
   } 
   void strengthPerkFour(){
    //auto attacks have 7% chance to strike twice
    //
   }

        //6strength-6stamina
        void heroicPosture(){
            //above 70% health do 15% more damage
        }
        //4strength-3agility
        void one(){
            //3% chance to parry
        }
        //5strength-5perception
        void exploitWeakSpot(){
            //chance to stun by 2%
            //chance to crit by 2%
        }
        //3strength-4intellect
        void one(){
            //staff damage increased by 25%
            //staff attack speed increased by 7%
        }


//stamina
   void staminaPerkOne(){
    //increase health by 10%
   }
   void staminaPerkOne(){
    //armor contributions increased by 10%
   }
   void staminaPerkOne(){
    //reduce damage taken by 10%
   } 
   void burstOfLife(){
    //if taken below 10% health instantly heal for 60% health once every 10 minutes
   }

            //3stamina-5strength
        void heroicPosture(){
              //increased blocking damage reduction by 15% 
            }
            //6stamina-5agility
        void heroicPosture(){
               //take 15% less damage after a dodge for 7 seconds
            }
            //4stamina-7intellect
        void heroicPosture(){
               //if you drop below 30% health spend mana to cast absorb shield on player
            }
            //stamina-perception
        void heroicPosture(){
             //
            }


//agility
   void agilityPerkOne(){
    //chance to dodge increased by 12%
    //raned weapon range increaed by 20%
   }
   void agilityPerkOne(){
    //dodging increase next dodge chance by 20%
    //ranged weapon speed increaed by 15%
   }
   void agilityPerkOne(){
    //increase dodge chance by 5%
    //increase crit chance by 5%
    //increase weapon attack speed 5%
   } 
   void agilityPerkOne(){
    //successful dodge gives next hit 100% chance to crit
   }

        //6agility-4strength
        void agilityPerkTwo(){
            //dual weild 1h weapons
        }
        //agility-stamina
        void agilityPerkTwo(){
            //
        }
        //5agility-6intellect
        void agilityPerkTwo(){
            //casting a spell increases movement speed by 25%
        }
        //agility-perception
        void agilityPerkTwo(){
            //5% chance to cause bleed effect
        }


//intellect
   void intellectPerkOne(){
    //wand speed increased 30%
    //spell cast speed by 15%
   }
   void intellectPerkOne(){
    //increase mana by 30%
   }
   void intellectPerkOne(){
    //killing enemies returns mana(7% for equally leveled mob)
   } 
   void intellectPerkOne(){
    //spell crits increase cast speed by 25% for 6 seconds
    //spell crit increased by 15%
   }

        //intellect-strength
        void intellectPerkTwo(){
            //
        }
        //intellect-agility
        void intellectPerkTwo(){
            //
        }
        //intellect-stamina
        void intellectPerkTwo(){
            //
        }
        //intellect-perception
        void intellectPerkTwo(){
            //
        }


//perception
   void perceptionPerkOne(){
    //reduce chance to miss by 5%
   }
   void perceptionPerkOne(){
    //reduce enemy detection radius
   }
   void perceptionPerkOne(){
    //increase range of ranged wands and spells by 25%
   } 
   void perceptionPerkOne(){
    //crit chance on enemies below 30% health increased by 20%
    //chance to hit enemies below 30% health increased by 10%
   }

 
}