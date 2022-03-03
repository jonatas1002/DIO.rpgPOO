using System;

namespace DIO.rpgPOO.src.entities
{
    public abstract class Hero
    {
        public string name { get; set; }
        private static double initialHealth = 100;
        protected double health = initialHealth;
        protected double atackForce = 10;
        protected string weapon;
        protected double weaponForce;
        private double armor;
        Random rdn = new Random();
        
        public Hero(){

        }
        
        public virtual double Atack(){
            return ( this.atackForce + BonusAtack() ); 
        }
        protected double BonusAtack(){
            return (this.atackForce * Bonus());
        }
        protected void WeaponForce(double weaponForce){
            this.atackForce += weaponForce;
        }
        protected void Armor(double armor){
            this.health += armor;
        }
        protected abstract double Dodge();
        public abstract string ReceiveAtack(double atack);

        protected string TakeDamage(double atackForce){
            this.health -= atackForce;
            return ($"{this.name} recebeu "+atackForce.ToString("0.00")+" de dano!!\nStatus após ataque:\n" + ReturnHeroLife());
        }
        protected double Bonus(){
            return ((double)this.rdn.Next(0, 40) / 100);
        }
        protected double Bonus(int num1, int num2){
            return ((double)rdn.Next(num1, num2) / 100);
        }
        private string ReturnHeroLife(){
            if(health <= initialHealth){
                return ($"Saude: {health} | Armadura: 0");
            }
            
            return ($"Saude: {initialHealth} | Armadura: {this.health - initialHealth}");
        }
        public double GetHealth(){
            return this.health;
        }
    }
}