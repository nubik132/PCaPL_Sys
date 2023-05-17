namespace Лаб15_DLL
{
    public class Услуга
    {
        public int price;
        public int amount;
        public int duration;
        public Услуга(int price, int amount, int duration)
        {
            this.price = price;
            this.amount = amount;
            this.duration = duration;  
        }
        public void Print()
        {
            Console.WriteLine("Цена: " + price + "\n" + "Количество: " + amount + "\n" + "Длительность: " + duration);
        }
    }

}