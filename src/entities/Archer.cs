using static System.Console;
namespace DIO.rpgPOO.src.entities
{
    public class Archer : Hero
    {
        public Archer(string name){
            this.name = name;
            this.weapon = "Crossbow";
            WeaponForce(5);
            Armor(100);

        }
        public override double Atack(){
            int arrowQuantity = (int)(Bonus(1, 4) * 100);
            this.atackForce *= arrowQuantity;
            WriteLine($"{this.name} disparou {arrowQuantity} flechas!!");
            return ( this.atackForce + BonusAtack() ); 
        }
        protected override double Dodge(){
            return Bonus(20, 80);
        }
        public override string ReceiveAtack(double atack){
            return TakeDamage(atack * Dodge());
        }

        public override string ToString()
        {
            return "Nome: " + this.name + "\nTipo: Feiticeiro" + "\nSaude: " + this.health + "\nArma: " + this.weapon + " | Poder ataque: " + this.atackForce;
        }
    }
}