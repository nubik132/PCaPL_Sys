using Microsoft.EntityFrameworkCore;

namespace Лаб26Console
{
    [PrimaryKey(nameof(Id))]
    public class Bus
    {

        public int Id { get; set; }
        public int Number { get; set; }
        public string VodilaName { get; set; }
        public int Seats { get; set; }
    }

}
