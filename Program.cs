using System;
using static System.Console;
using DIO.rpgPOO.src.entities;
using System.Threading;

namespace DIO.rpgPOO
{
    class Program
    {
        static void Main(string[] args){
            string initialUserChoise;
            Hero firstHero, secondHero;
            
            Clear();
            WriteLine("<------> Bem vindo ao RPG DIO <------>");
            initialUserChoise = MenuInitial();
            
            while(initialUserChoise != "X"){
                switch(initialUserChoise){
                    case "1":
                        firstHero = CreateHero();
                        WriteLine("Proximo Heroi!");
                        secondHero = CreateHero();
                        Clear();
                        WriteLine("\n Pressione Enter para iniciar o combate:");
                        ReadLine();
                        Combat(firstHero, secondHero);
                        break;
                    default:
                        WriteLine("Selecione uma opção valida!");
                        break;
                }
                initialUserChoise = MenuInitial();
            }        
            

            WriteLine("\nPressione Enter para sair do jogo!!\n");
            ReadLine();
            Clear();
        }
        private static void Loading(){
            WriteLine("Criando o seu heroi:");
            for (int i = 0; i < 10; i++){
                Write(".");
                Thread.Sleep(400);
            }
            WriteLine("\n");
        }
        static void Combat(Hero firstHero, Hero secondHero){
            Random rdn = new Random();
            while ( firstHero.GetHealth() > 0 && secondHero.GetHealth() > 0 ){
                WriteLine($"{firstHero.name} irá atacar!");
                Thread.Sleep(rdn.Next(100, 400));
                WriteLine();
                WriteLine(HeroAtack(firstHero, secondHero));
                if( secondHero.GetHealth() <= 0 ){
                    WriteLine($"{secondHero.name} perdeu!");
                    continue;
                }
                WriteLine();
                WriteLine($"{secondHero.name} irá atacar!");
                Thread.Sleep(rdn.Next(100, 400));
                WriteLine();
                WriteLine(HeroAtack(secondHero, firstHero));
                if( firstHero.GetHealth() <= 0 ){
                    WriteLine($"{firstHero.name} perdeu!");
                    continue;
                }
                WriteLine();
                WriteLine("Pressione Enter para o proximo turno:");
                ReadLine();
            }
        }
        static string HeroAtack(Hero atackHero, Hero receiveAtackHero){
            return receiveAtackHero.ReceiveAtack(atackHero.Atack());            
        }
        static string MenuInitial(){
            WriteLine("1 - Para criar seus heróis e iniciar uma batalha:");
            WriteLine("X - Para sair:");
            return ReadLine().ToUpper();
        }
        static void ShowHeroData(Hero hero){
            WriteLine(hero.ToString() + "\n");
        }
        static Hero CreateHero(){
            WriteLine("Qual será o nome do heroi?");
            string nome = ReadLine();
            WriteLine("Que tipo de heroi deseja criar?");
            WriteLine("1 - Para Knight;");
            WriteLine("2 - Para Ninja;");
            WriteLine("3 - Para Wizard;");
            WriteLine("4 - Para Archer;");
            WriteLine("Em breve novos herois estarão disponiveis!!");
            string userChoise = ReadLine().ToUpper();
            //ref Hero hero;
            Loading();
            switch(userChoise){
                case "1":
                    return new Knight(nome);
                    
                case "2":
                    return new Ninja(nome);
                    
                case "3":
                    return new Wizard(nome);
                    
                case "4":
                    return new Archer(nome);
                    //return hero;
                
            }
            throw new ArgumentException();
        }
    }
}
