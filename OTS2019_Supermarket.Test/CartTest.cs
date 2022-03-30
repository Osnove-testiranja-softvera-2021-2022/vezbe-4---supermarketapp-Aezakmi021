using NUnit.Framework;
using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Test
{

    [TestFixture]
    public class CartTest
    {
        [Test]
        public void AddOneToCart_OKInput_Sucess()
        {
            Cart cart = new Cart();
            Keyboard keyboard = new Keyboard();

            cart.AddOneToCart(keyboard);

            Assert.AreEqual(1, cart.size);
        }

        [Test]
        public void AddOneToCart_SizeGreaterThan10_Sucess()
        {
            Cart cart = new Cart();
            Keyboard keyboard1 = new Keyboard();
            Keyboard keyboard2 = new Keyboard();
            Keyboard keyboard3 = new Keyboard();
            Keyboard keyboard4 = new Keyboard();
            Keyboard keyboard5 = new Keyboard();
            Keyboard keyboard6 = new Keyboard();
            Keyboard keyboard7 = new Keyboard();
            Keyboard keyboard8 = new Keyboard();
            Keyboard keyboard9 = new Keyboard();
            Keyboard keyboard10 = new Keyboard();

            cart.AddOneToCart(keyboard1);
            cart.AddOneToCart(keyboard2);
            cart.AddOneToCart(keyboard3);
            cart.AddOneToCart(keyboard4);
            cart.AddOneToCart(keyboard5);
            cart.AddOneToCart(keyboard6);
            cart.AddOneToCart(keyboard7);
            cart.AddOneToCart(keyboard8);
            cart.AddOneToCart(keyboard9);
            cart.AddOneToCart(keyboard10);

            Monitor monitor = new Monitor();


            Exception ex = Assert.Throws<Exception>(() => cart.AddOneToCart(monitor));
            Assert.That(ex.Message, Is.EqualTo("Broj ajtema ne moze biti veci od 10"));

        }

        //Vise ajtema

        [Test]
        public void AddMultipleToCart_InvalidValue()
        {
            Cart cart = new Cart();

            Keyboard keyboard1 = new Keyboard();

            cart.broj = 9999;

            for (int i = 1; i <= cart.broj; i++)
            {
                cart.AddOneToCart(keyboard1);
            }


            Exception ex = new Exception();
            Assert.That(ex.Message, Is.EqualTo("Broj ajtema ne moze biti veci od 10"));
        }

        [Test]
        public void AddMultipleToCart_SizeGreaterThan10_Sucess()
        {
            
            Cart cart = new Cart();
            Keyboard keyboard1 = new Keyboard();
            cart.broj = 10;
            
            for(int i=1; i<=cart.broj; i++)
            {
                cart.AddOneToCart(keyboard1);
            }
            

            Monitor monitor = new Monitor();


            Exception ex = Assert.Throws<Exception>(() => cart.AddOneToCart(monitor));
            Assert.That(ex.Message, Is.EqualTo("Broj ajtema ne moze biti veci od 10"));
        }

    }
}
