using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Models
{
    public class Section
    {
        public int SectionId { get; set; } //Идентификатор раздела

        public int? ParentId { get; set; } //Идентификатор родительского раздела

        
        [Remote("CheckTitle", "Sections", ErrorMessage = "Такая секция уже существует")] // Валидация на уникальность заголовка
        [StringLength(80, ErrorMessage = "Количество символов не должно превышать 80 символов")]
        public string Title { get; set; } //Заголовок раздела

        [StringLength(2000, ErrorMessage = "Количество символов не должно превышать 2000")]
        public string Description { get; set; } //Описание раздела

        public bool IsDeleted { get; set; } //Флаг удаления
    }
}

/* ЧекТитле - должен быть в контроллере!!
public JsonResult CheckTitle(string Title)
        {
            if(db.Messages.Any(m => m.Title == Title))
                return Json(false, JsonRequestBehavior.AllowGet);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
*/