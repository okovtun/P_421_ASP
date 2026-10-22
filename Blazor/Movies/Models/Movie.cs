using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
//	Movie - это модель
//	Модель - это класс, описывающий данные, хранящиеся в Базе данных.
//	Точнее, Модель описывает стуктуру записи определенной таблиы в Базе Данных,
//	а именно, каждое поле Модели соответствует определенному полю таблицы в Базе Данных.
	public class Movie
	{
		public int Id { get; set; }

//		[DataAnnotation]
//		DataAnnotations - пишуся в квадратных скобках перед Моделью и перед ее полями,
//		и предназначены для уточнения свойств Модели, либо ее полей.
		[Required(ErrorMessage = "Кино без названия, как Самурай без меча")]
		[StringLength(50, MinimumLength = 2)]
		public string Title { get; set; }

		[Range(typeof(DateOnly), "1888-10-14", "2029-12-31")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//НЕ работает в Blazor
		public DateOnly ReleaseDate { get; set; }
		public string URL { get; set; }
		public string Poster { get; set; }
	}
}
