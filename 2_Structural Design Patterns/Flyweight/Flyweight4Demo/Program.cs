using Flyweight4Demo._6.Client;

var game = new Game();
// Simulate adding particles
game.AddParticle("red", "bullet.jpg", "10,20", "1,0", "fast");
game.AddParticle("blue", "shrapnel.jpg", "30,40", "0,1", "medium");
game.AddParticle("red", "bullet.jpg", "50,60", "-1,0", "fast");
game.AddParticle("red", "bullet.jpg", "10,20", "1,0", "fast");


game.Draw();