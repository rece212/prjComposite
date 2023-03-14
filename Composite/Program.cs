namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponent wheat = new Leaf("Wheat");
            IComponent sesame = new Leaf("sesame");

            IComponent soy = new Leaf("soy");
            IComponent herbs = new Leaf("herbs");

            Composite bun = new Composite("bun");

            bun.addComponent(wheat);
            bun.addComponent(sesame);

            Composite patty = new Composite("Patty");
            patty.addComponent(soy);
            patty.addComponent(herbs);

            Composite burger = new Composite("Burger");
            burger.addComponent(bun);
            burger.addComponent(patty);

            burger.getPart();
        }
    }
}