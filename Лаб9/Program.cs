namespace lab9
{
    class Prog
    {
        static void Main()
        {

            Avtobus a = new(50, 55, "Pryanik", 2);
            Avtobus b = new();
            Avtobus c = new() { Skorost = 40, Number = 3, Name = "Pecheniya", Vmestit = 55};
            a.Info();
            Console.WriteLine("--------------------------");
            b.Info();
            Console.WriteLine("--------------------------");
            c.Info();
        }
    }
    class Avtobus
    {
        int skorost, vmestit;
        string name;
        public int Skorost { get {return skorost; } set { skorost = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Vmestit { get { return vmestit; } set { vmestit = value; } }
        public int Number { get; set; }
        public void Info()
        {
            Console.WriteLine("Скорость " + Skorost);
            Console.WriteLine("Имя АВТОбуса " + Name);
            Console.WriteLine("Вместительность " + Vmestit);
            Console.WriteLine("Номер автобуса " + Number);
        }
        public Avtobus()
        {
            skorost = 40;
            name = "Пряник";
            vmestit = 55;
        }
        public Avtobus(int skorost, int vmestit, string name, int Number)
        {
            Skorost = skorost;
            Vmestit = vmestit;
            Name = name;
            this.Number = Number;
        }

    }

}
