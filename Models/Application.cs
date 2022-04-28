using System.ComponentModel.DataAnnotations;

namespace AzlanioBaseWebApp.Models
{
    public class Application
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateHolder { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public decimal PriceHolder { get; set; }

        public Application()
        {

        }
    }
}
