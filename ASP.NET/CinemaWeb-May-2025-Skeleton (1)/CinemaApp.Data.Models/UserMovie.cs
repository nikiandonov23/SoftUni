using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CinemaApp.Data.Models
{
    public class UserMovie
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public virtual IdentityUser User { get; set; }=new IdentityUser();


        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }
        public virtual Movie Movie { get; set; } = new Movie();

    }
}
