//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Licencias = new HashSet<Licencias>();
            this.Nomina = new HashSet<Nomina>();
            this.Permiso = new HashSet<Permiso>();
            this.Salida = new HashSet<Salida>();
            this.Vacaciones = new HashSet<Vacaciones>();
        }
    
        public int ID { get; set; }

        [Display(Name = "Código:")]
        public Nullable<int> Codigo_Empleado { get; set; }

        [Display(Name = "Nombre:")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido:")]
        public string Apellido { get; set; }

        [Display(Name = "Departamento:")]
        public Nullable<int> Departamento { get; set; }

        [Display(Name = "Cargo:")]
        public Nullable<int> Cargo { get; set; }

        [Display(Name = "Salario:")]
        public Nullable<decimal> Salario { get; set; }

        [Display(Name = "Fecha de ingreso:")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Fecha_De_Ingreso { get; set; }

        [Display(Name = "Teléfono:")]
        public string Telefono { get; set; }

        [Display(Name = "Estatus:")]
        public string Estatus { get; set; }
    
        public virtual cargo cargo1 { get; set; }
        public virtual Departamento Departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencias> Licencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina> Nomina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permiso> Permiso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida> Salida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
    }
   
}