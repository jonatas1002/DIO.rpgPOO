namespace DIO.rpgPOO.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name){
            this.name = name;
            this.weapon = "Magia";
            WeaponForce(20);
            Armor(60);

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