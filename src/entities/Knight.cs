using static System.Console;
namespace DIO.rpgPOO.src.entities
{
    public class Knight : Hero
    {
        public Knight(string name){
            this.name = name;
            this.weapon = "Espada";
            WeaponForce(15);
            Armor(110);

        }
        protected override double Dodge(){
            return Bonus( 40, 80 );
        }
        public override string ReceiveAtack(double atack){
            return TakeDamage( atack * Dodge() );
        }

        public override string ToString()
        {
            return "Nome: " + this.name + "\nTipo: Knight" + "\nSaude: " + this.health + "\nArma: " + this.weapon + " | Poder ataque: " + this.atackForce;
        }
    }
}