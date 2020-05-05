using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "電影名稱")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "類型")]
        public byte? GenreId { get; set; }

        [Display(Name = "上映日期")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "庫存")]
        [Range(1, 200)]
        //[Required]
        public byte? NumberInStock { get; set; }

        [Display(Name = "庫存")]
        [Range(1, 200)]
        [Required]
        public byte? NumberAvailable { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberAvailable;
            GenreId = movie.GenreId;
            NumberAvailable = movie.NumberAvailable;
        }
    }
}