using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Models
{

    // Класс Статья, должна содержать текст+, название +, дата публикации+, дата редактирования /должна меняться при редактировании
    public class Article
    {
        public int ArticleId { get; set; } // Идентификатор статьи
        public int SectionId { get; set; } // Идентификатор Раздела, к которому принадлежит статья

        [Remote("CheckTitle", "Articles", ErrorMessage = "Статья с таким названием уже есть")] // Валидация на уникальность заголовка
        [StringLength(80, ErrorMessage = "Количество символов не должно превышать 80 символов")]
        public string Title { get; set; } // Название статьи
        public string Content { get; set; } // Содержание статьи
        public DateTime PublishDate { get; set; } // Дата публикации
        public DateTime EditDate { get; set; } // Дата редактирования
               
    }
}