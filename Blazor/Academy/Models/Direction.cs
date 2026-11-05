using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Direction
	{
		//Scalar properties:
		//Скалярные свойства описывают поля в таблице Базы Данных, например _____id, name, и т.д.
		[Key]
		[Column("direction_id", TypeName = "TINYINT")]
		public int direction_id { get; set; }
		public string direction_name { get; set; }

		//Navigation properties:
		public ICollection<Group> Groups { get; set; }
	}
}
