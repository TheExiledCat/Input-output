using System;

namespace ConsoleApp1
{
    public class Key
    {
        //Sprite fullsprite;
        public void Appear()
        {
            //key wordt zichtbaarder, de key is al zichtbaar maar doorzichtig, nu swapped the key naar de sprite waar hij helemaal zichtbaar is.
            //this.spriteofzo = fullsprite;
            //this.hitbox gaat aan;
        }
        void Pickup()//dit gebeurt wnr je de key die active is aanraakt
        {
            //player.keys++;
        }
    }
    public class Activator
    {
        public Key key;
        //functie on collision komt hier al bestaat dat in godot,
        void oncollisiontroep()
        {
            this.verdwijn();
            key.Appear();
            
        }
    }
    public class Door
    {
        virtual protected void Open()
        {
            //beweeg deur met  godot functie aan de kant zodat de hitbox ervan de player niet meer blocked.
            //dit kan met een physics functie die je vgm in godot met kinematicbody2d krijgt, dus mischien moet die geinherit worden.

        }
        virtual protected void Close()
        {
            //beweeg deur weer terug
        }
    }
    public class OneWayDoor : Door
    {
        

        // in de update functie van godot komt dit te staan:

        // {
        //    if(players position is behind door){
        //   base.Open();
        //    }
        //}else{
        //base.Close();
    //}

    //hierdoor kan je alleen de deur in van een kant. als je de andere kant probeert gaat ie dicht.
    //mischien een if statement die checked of ze wel dichtbij elkaar zijn zodat de deur niet gaat bewegen als je er niet bij bent.

        
    }
    public class KeyDoor : Door
    {
       // if(players.keys>0){
        //    base.Open();
        //    }
    }
    
}
