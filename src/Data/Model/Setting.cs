using System.ComponentModel.DataAnnotations;

namespace DailyQuotes.Data.Model
{
    public class Setting
    {
        [Key]
        public int SettingKey { get; set; }
        public int LastPositionX { get; set; }
        public int LastPositionY { get; set; }
    }
}
