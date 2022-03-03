namespace DIO.rpgPOO.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string name){
            this.name = name;
            this.weapon = "Katana";
            WeaponForce(17);
            Armor(80);

        }
        protected override double Dodge(){
            return Bonus(20, 80);
        }
        public override string ReceiveAtack(double atack){
            return TakeDamage(atack * Dodge());
        }

        public override string ToString()
        {
            return "Nome: " + this.name + "\nTipo: Ninja" + "\nSaude: " + this.health + "\nArma: " + this.weapon + " | Poder ataque: " + this.atackForce;
        }
    }
}