using System;

namespace UserStrory.Models
{
    /// <summary>
    /// Сущность студента
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Средняя оценка
        /// </summary>
        public decimal AvgRate { get; set; }
        /// <summary>
        /// Отчислен
        /// </summary>
        public bool Deduct { get; set; }
        /// <summary>
        /// Задолженность
        /// </summary>
        public bool Debtor { get; set; }
    }
}
