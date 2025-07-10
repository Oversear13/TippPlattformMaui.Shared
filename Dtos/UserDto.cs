using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippPlattformMaui.Shared.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Neues Passwort (wenn leer oder null, wird im Backend ignoriert)
        /// </summary>
        public string? Password { get; set; }
    }
}