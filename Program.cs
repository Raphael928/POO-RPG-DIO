// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using game_rpg_dio.src.Entities;

//CRIANDO VARIÁVEIS
/*string Nome = "Arus";
int Level = 12;
string TipoHeroi = "Guerreiro";*/

//INSTANCIANDO NOVO OBJETO
/*Arus Hero = new Arus();
Hero.Name = "Arus";
Hero.Level = 12;
Hero.HeroType = "Guerreiro";*/

//CONSTRUTOR 
Knight lKnight = new Knight("Arus", 30, "Knight");
Wizard lWizard = new Wizard("Jennica", 25, "White Wizard");

Console.WriteLine(lKnight.Attak());
Console.WriteLine(lWizard.Attak(8));
