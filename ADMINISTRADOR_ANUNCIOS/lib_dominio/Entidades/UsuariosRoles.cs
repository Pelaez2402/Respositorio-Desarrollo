using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class UsuariosRoles
    {
        public int UsuarioID {get; set;}
        public Usuarios Usuarios { get; set; } = null!;
        public int RolID  { get; set; }
        public Roles Roles { get; set; } = null!;
        public DateTime FechAsignacion { get; set; }
        public string? AsignadoPor { get; set; }
        public byte Activo { get; set; }
    }
}
